namespace Cake.Generator;

public partial class CakeGenerator
{
    /// <summary>
    /// Scans a namespace and all its types for valid Cake method/property aliases.
    /// OCE: Entry point for recursive symbol scanning in referenced assemblies.
    /// </summary>
    internal static ImmutableArray<MethodInfo> ScanTypeMembers(
        INamespaceSymbol namespaceSymbol,
        INamedTypeSymbol? cakeMethodAliasAttributeSymbol,
        INamedTypeSymbol? cakePropertyAliasAttributeSymbol,
        INamedTypeSymbol? cakeNamespaceImportAttributeSymbol,
        INamedTypeSymbol iCakeContextSymbol,
        INamespaceSymbol? compilationGlobalNamespace = null,
        List<Diagnostic>? diagnostics = null)
    {
        var validMethods = new List<MethodInfo>();
        var scanContext = new ScanContext(compilationGlobalNamespace, diagnostics);
        ScanNamespaceMembers(namespaceSymbol, cakeMethodAliasAttributeSymbol, cakePropertyAliasAttributeSymbol, cakeNamespaceImportAttributeSymbol, iCakeContextSymbol, validMethods, scanContext);
        return validMethods.Count == 0 ? [] : [.. validMethods];
    }

    /// <summary>
    /// Recursively scans all members of a namespace for types and nested namespaces.
    /// OCE: Drives recursive type/member scanning for Cake alias discovery.
    /// </summary>
    private static void ScanNamespaceMembers(
        INamespaceSymbol namespaceSymbol,
        INamedTypeSymbol? cakeMethodAliasAttributeSymbol,
        INamedTypeSymbol? cakePropertyAliasAttributeSymbol,
        INamedTypeSymbol? cakeNamespaceImportAttributeSymbol,
        INamedTypeSymbol iCakeContextSymbol,
        List<MethodInfo> validMethods,
        ScanContext scanContext)
    {
        foreach (var member in namespaceSymbol.GetMembers())
        {
            if (member is INamedTypeSymbol typeSymbol)
            {
                ScanTypeMembers(typeSymbol, cakeMethodAliasAttributeSymbol,
                              cakePropertyAliasAttributeSymbol, cakeNamespaceImportAttributeSymbol, iCakeContextSymbol, validMethods, scanContext);
            }
            else if (member is INamespaceSymbol nestedNamespace)
            {
                ScanNamespaceMembers(nestedNamespace, cakeMethodAliasAttributeSymbol,
                                   cakePropertyAliasAttributeSymbol, cakeNamespaceImportAttributeSymbol, iCakeContextSymbol, validMethods, scanContext);
            }
        }
    }

    /// <summary>
    /// Scans a type for static methods that are valid Cake method/property aliases.
    /// OCE: Checks for Cake attributes and ICakeContext parameter.
    /// </summary>
    private static void ScanTypeMembers(
        INamedTypeSymbol typeSymbol,
        INamedTypeSymbol? cakeMethodAliasAttributeSymbol,
        INamedTypeSymbol? cakePropertyAliasAttributeSymbol,
        INamedTypeSymbol? cakeNamespaceImportAttributeSymbol,
        INamedTypeSymbol iCakeContextSymbol,
        List<MethodInfo> validMethods,
        ScanContext scanContext)
    {
        foreach (var member in typeSymbol.GetMembers())
        {
            if (member is IMethodSymbol methodSymbol
                && methodSymbol.IsStatic
                && methodSymbol.MethodKind == MethodKind.Ordinary)
            {
                var methodInfo = GetValidCakeMethod(methodSymbol, cakeMethodAliasAttributeSymbol, cakePropertyAliasAttributeSymbol, cakeNamespaceImportAttributeSymbol, iCakeContextSymbol, scanContext);
                if (methodInfo != null)
                {
                    validMethods.Add(methodInfo);
                }
            }
        }

        foreach (var nestedType in typeSymbol.GetTypeMembers())
        {
            ScanTypeMembers(nestedType, cakeMethodAliasAttributeSymbol, cakePropertyAliasAttributeSymbol, cakeNamespaceImportAttributeSymbol, iCakeContextSymbol, validMethods, scanContext);
        }
    }

    /// <summary>
    /// Checks if a method is a valid Cake method/property alias and extracts metadata.
    /// OCE: Attribute and parameter checks for Cake alias discovery.
    /// </summary>
    private static MethodInfo? GetValidCakeMethod(IMethodSymbol methodSymbol,
        INamedTypeSymbol? cakeMethodAliasAttributeSymbol,
        INamedTypeSymbol? cakePropertyAliasAttributeSymbol,
        INamedTypeSymbol? cakeNamespaceImportAttributeSymbol,
        INamedTypeSymbol iCakeContextSymbol,
        ScanContext scanContext)
    {
        // Only call GetAttributes() once and reuse the result
        var attributes = methodSymbol.GetAttributes();
        if (attributes.Length == 0)
        {
            return null;
        }

        AttributeData? cakeMethodAttribute = null;
        AttributeData? cakePropertyAttribute = null;
        for (int i = 0; i < attributes.Length; i++)
        {
            var attr = attributes[i];
            if (cakeMethodAliasAttributeSymbol != null &&
                SymbolEqualityComparer.Default.Equals(attr.AttributeClass, cakeMethodAliasAttributeSymbol))
            {
                cakeMethodAttribute = attr;
            }
            else if (cakePropertyAliasAttributeSymbol != null &&
                     SymbolEqualityComparer.Default.Equals(attr.AttributeClass, cakePropertyAliasAttributeSymbol))
            {
                cakePropertyAttribute = attr;
            }
        }

        if (cakeMethodAttribute == null && cakePropertyAttribute == null)
        {
            return null;
        }

        // Check if first parameter is ICakeContext
        if (methodSymbol.Parameters.Length == 0)
        {
            return null;
        }

        var firstParam = methodSymbol.Parameters[0];
        if (!SymbolEqualityComparer.Default.Equals(firstParam.Type, iCakeContextSymbol))
        {
            return null;
        }

        // Skip aliases referencing types from assemblies that are not referenced, i.e. an addin missing a dependency
        if (FindUnresolvedType(methodSymbol) is { } unresolvedType)
        {
            scanContext.Diagnostics?.Add(Diagnostic.Create(
                UnresolvedAliasTypeDescriptor,
                Location.None,
                methodSymbol.ToDisplayString(),
                unresolvedType.ToDisplayString(),
                methodSymbol.ContainingAssembly.Name));
            return null;
        }

        // Determine if this is a property alias and if it's cached
        bool isPropertyAlias = cakePropertyAttribute != null;
        bool isCached = false;

        if (isPropertyAlias && cakePropertyAttribute != null)
        {
            foreach (var arg in cakePropertyAttribute.NamedArguments)
            {
                if (arg.Key == "Cache" && arg.Value.Value is bool cacheValue)
                {
                    isCached = cacheValue;
                    break;
                }
            }
        }

        // Extract namespace imports from CakeNamespaceImportAttribute on the method, its type and its assembly
        var namespaceImports = ImmutableArray<string>.Empty;
        if (cakeNamespaceImportAttributeSymbol != null)
        {
            namespaceImports =
            [
                .. GetNamespaceImports(attributes, methodSymbol.ContainingAssembly, cakeNamespaceImportAttributeSymbol, scanContext),
                .. GetCachedNamespaceImports(methodSymbol.ContainingType, methodSymbol.ContainingAssembly, cakeNamespaceImportAttributeSymbol, scanContext),
                .. GetCachedNamespaceImports(methodSymbol.ContainingAssembly, methodSymbol.ContainingAssembly, cakeNamespaceImportAttributeSymbol, scanContext)
            ];
        }

        return new MethodInfo(methodSymbol, isPropertyAlias, isCached, namespaceImports);
    }

    /// <summary>
    /// Gets the namespace imports declared on a type or assembly, reading and validating them once per scan.
    /// </summary>
    private static ImmutableArray<string> GetCachedNamespaceImports(
        ISymbol symbol,
        IAssemblySymbol assembly,
        INamedTypeSymbol cakeNamespaceImportAttributeSymbol,
        ScanContext scanContext)
    {
        if (!scanContext.NamespaceImportCache.TryGetValue(symbol, out var imports))
        {
            imports = GetNamespaceImports(symbol.GetAttributes(), assembly, cakeNamespaceImportAttributeSymbol, scanContext);
            scanContext.NamespaceImportCache[symbol] = imports;
        }

        return imports;
    }

    /// <summary>
    /// Gets the namespaces from <c>CakeNamespaceImport</c> attributes, skipping values that are not a namespace
    /// known to the compilation.
    /// </summary>
    private static ImmutableArray<string> GetNamespaceImports(
        ImmutableArray<AttributeData> attributes,
        IAssemblySymbol assembly,
        INamedTypeSymbol cakeNamespaceImportAttributeSymbol,
        ScanContext scanContext)
    {
        List<string>? imports = null;
        foreach (var attr in attributes)
        {
            if (!SymbolEqualityComparer.Default.Equals(attr.AttributeClass, cakeNamespaceImportAttributeSymbol)
                || attr.ConstructorArguments.Length == 0
                || attr.ConstructorArguments[0].Value is not string namespaceValue
                || string.IsNullOrWhiteSpace(namespaceValue))
            {
                continue;
            }

            if (scanContext.CompilationGlobalNamespace is { } globalNamespace
                && !NamespaceExists(globalNamespace, namespaceValue))
            {
                scanContext.Diagnostics?.Add(Diagnostic.Create(
                    UnresolvedNamespaceImportDescriptor,
                    Location.None,
                    namespaceValue,
                    assembly.Name));
                continue;
            }

            (imports ??= []).Add(namespaceValue);
        }

        return imports == null ? [] : [.. imports];
    }

    /// <summary>
    /// Finds the first type in a method signature that could not be resolved, e.g. because the assembly
    /// defining it is not referenced.
    /// </summary>
    private static ITypeSymbol? FindUnresolvedType(IMethodSymbol methodSymbol)
    {
        if (FindUnresolvedType(methodSymbol.ReturnType) is { } returnType)
        {
            return returnType;
        }

        foreach (var parameter in methodSymbol.Parameters)
        {
            if (FindUnresolvedType(parameter.Type) is { } parameterType)
            {
                return parameterType;
            }
        }

        foreach (var typeParameter in methodSymbol.TypeParameters)
        {
            foreach (var constraintType in typeParameter.ConstraintTypes)
            {
                if (FindUnresolvedType(constraintType) is { } unresolvedConstraintType)
                {
                    return unresolvedConstraintType;
                }
            }
        }

        return null;
    }

    private static ITypeSymbol? FindUnresolvedType(ITypeSymbol typeSymbol)
    {
        switch (typeSymbol)
        {
            case IErrorTypeSymbol:
                return typeSymbol;
            case IArrayTypeSymbol arrayType:
                return FindUnresolvedType(arrayType.ElementType);
            case IPointerTypeSymbol pointerType:
                return FindUnresolvedType(pointerType.PointedAtType);
            case INamedTypeSymbol namedType:
                foreach (var typeArgument in namedType.TypeArguments)
                {
                    if (FindUnresolvedType(typeArgument) is { } unresolvedTypeArgument)
                    {
                        return unresolvedTypeArgument;
                    }
                }

                return namedType.ContainingType is { } containingType ? FindUnresolvedType(containingType) : null;
            default:
                return null;
        }
    }

    /// <summary>
    /// Checks that a <c>CakeNamespaceImport</c> value is a namespace known to the compilation.
    /// </summary>
    private static bool NamespaceExists(INamespaceSymbol globalNamespace, string namespaceName)
    {
        var current = globalNamespace;
        foreach (var part in namespaceName.Split('.'))
        {
            current = current.GetNamespaceMembers().FirstOrDefault(ns => ns.Name == part.Trim());
            if (current == null)
            {
                return false;
            }
        }

        return true;
    }

    /// <summary>
    /// Shared state for a scan of referenced assemblies.
    /// </summary>
    /// <param name="compilationGlobalNamespace">The compilation's global namespace, used to validate namespace imports.</param>
    /// <param name="diagnostics">Collects diagnostics for skipped aliases and namespace imports.</param>
    private sealed class ScanContext(INamespaceSymbol? compilationGlobalNamespace, List<Diagnostic>? diagnostics)
    {
        public INamespaceSymbol? CompilationGlobalNamespace { get; } = compilationGlobalNamespace;

        public List<Diagnostic>? Diagnostics { get; } = diagnostics;

        public Dictionary<ISymbol, ImmutableArray<string>> NamespaceImportCache { get; } = new(SymbolEqualityComparer.Default);
    }
}
