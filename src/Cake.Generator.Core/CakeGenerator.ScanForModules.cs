namespace Cake.Generator;

public partial class CakeGenerator
{
    private static List<ModuleInfo> ScanForModules(
        IAssemblySymbol assemblySymbol,
        INamedTypeSymbol cakeModuleAttributeSymbol,
        INamedTypeSymbol iCakeModuleSymbol,
        INamedTypeSymbol? obsoleteAttributeSymbol)
    {
        var modules = new List<ModuleInfo>();

        // Check if the assembly has the CakeModule attribute
        var hasModuleAttribute = assemblySymbol.GetAttributes()
            .Any(attr => SymbolEqualityComparer.Default.Equals(attr.AttributeClass, cakeModuleAttributeSymbol));

        if (!hasModuleAttribute)
        {
            return modules;
        }

        // Scan all types in the assembly for ICakeModule implementations
        ScanForModulesInNamespace(assemblySymbol.GlobalNamespace, iCakeModuleSymbol, obsoleteAttributeSymbol, modules);

        return modules;
    }

    private static void ScanForModulesInNamespace(
        INamespaceSymbol namespaceSymbol,
        INamedTypeSymbol iCakeModuleSymbol,
        INamedTypeSymbol? obsoleteAttributeSymbol,
        List<ModuleInfo> modules)
    {
        foreach (var member in namespaceSymbol.GetMembers())
        {
            if (member is INamedTypeSymbol typeSymbol)
            {
                // Check if the type implements ICakeModule and is not obsolete
                if (typeSymbol.TypeKind == TypeKind.Class &&
                    !typeSymbol.IsAbstract &&
                    typeSymbol.AllInterfaces.Any(i => SymbolEqualityComparer.Default.Equals(i, iCakeModuleSymbol)) &&
                    !IsObsolete(typeSymbol, obsoleteAttributeSymbol))
                {
                    modules.Add(new ModuleInfo(typeSymbol));
                }

                // Scan nested types
                foreach (var nestedType in typeSymbol.GetTypeMembers())
                {
                    if (nestedType.TypeKind == TypeKind.Class &&
                        !nestedType.IsAbstract &&
                        nestedType.AllInterfaces.Any(i => SymbolEqualityComparer.Default.Equals(i, iCakeModuleSymbol)) &&
                        !IsObsolete(nestedType, obsoleteAttributeSymbol))
                    {
                        modules.Add(new ModuleInfo(nestedType));
                    }
                }
            }
            else if (member is INamespaceSymbol nestedNamespace)
            {
                ScanForModulesInNamespace(nestedNamespace, iCakeModuleSymbol, obsoleteAttributeSymbol, modules);
            }
        }
    }

    private static bool IsObsolete(INamedTypeSymbol typeSymbol, INamedTypeSymbol? obsoleteAttributeSymbol)
    {
        if (obsoleteAttributeSymbol == null)
        {
            return false;
        }

        return typeSymbol.GetAttributes()
            .Any(attr => SymbolEqualityComparer.Default.Equals(attr.AttributeClass, obsoleteAttributeSymbol));
    }
}