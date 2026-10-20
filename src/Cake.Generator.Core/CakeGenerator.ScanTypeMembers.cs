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
        INamedTypeSymbol iCakeContextSymbol)
    {
        var validMethods = new List<MethodInfo>();
        ScanNamespaceMembers(namespaceSymbol, cakeMethodAliasAttributeSymbol, cakePropertyAliasAttributeSymbol, cakeNamespaceImportAttributeSymbol, iCakeContextSymbol, validMethods);
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
        List<MethodInfo> validMethods)
    {
        foreach (var member in namespaceSymbol.GetMembers())
        {
            if (member is INamedTypeSymbol typeSymbol)
            {
                ScanTypeMembers(typeSymbol, cakeMethodAliasAttributeSymbol,
                              cakePropertyAliasAttributeSymbol, cakeNamespaceImportAttributeSymbol, iCakeContextSymbol, validMethods);
            }
            else if (member is INamespaceSymbol nestedNamespace)
            {
                ScanNamespaceMembers(nestedNamespace, cakeMethodAliasAttributeSymbol,
                                   cakePropertyAliasAttributeSymbol, cakeNamespaceImportAttributeSymbol, iCakeContextSymbol, validMethods);
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
        List<MethodInfo> validMethods)
    {
        foreach (var member in typeSymbol.GetMembers())
        {
            if (member is IMethodSymbol methodSymbol
                && methodSymbol.IsStatic
                && methodSymbol.MethodKind == MethodKind.Ordinary)
            {
                var methodInfo = GetValidCakeMethod(methodSymbol, cakeMethodAliasAttributeSymbol, cakePropertyAliasAttributeSymbol, cakeNamespaceImportAttributeSymbol, iCakeContextSymbol);
                if (methodInfo != null)
                {
                    validMethods.Add(methodInfo);
                }
            }
        }

        foreach (var nestedType in typeSymbol.GetTypeMembers())
        {
            ScanTypeMembers(nestedType, cakeMethodAliasAttributeSymbol, cakePropertyAliasAttributeSymbol, cakeNamespaceImportAttributeSymbol, iCakeContextSymbol, validMethods);
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
        INamedTypeSymbol iCakeContextSymbol)
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

        // Extract namespace imports from CakeNamespaceImportAttribute
        ImmutableArray<string>? namespaceImports = null;
        if (cakeNamespaceImportAttributeSymbol != null)
        {
            List<string>? imports = null;
            for (int i = 0; i < attributes.Length; i++)
            {
                var attr = attributes[i];
                if (SymbolEqualityComparer.Default.Equals(attr.AttributeClass, cakeNamespaceImportAttributeSymbol))
                {
                    if (attr.ConstructorArguments.Length > 0 &&
                        attr.ConstructorArguments[0].Value is string namespaceValue &&
                        !string.IsNullOrWhiteSpace(namespaceValue))
                    {
                        (imports ??= []).Add(namespaceValue);
                    }
                }
            }
            if (imports != null)
            {
                namespaceImports = [.. imports];
            }
        }

        return new MethodInfo(methodSymbol, isPropertyAlias, isCached, namespaceImports ?? []);
    }
}