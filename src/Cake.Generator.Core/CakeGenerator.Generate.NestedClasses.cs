// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Cake.Generator;

public partial class CakeGenerator
{
    private static void GenerateNestedClasses(StringBuilder sb, Dictionary<string, List<MethodInfo>> assemblyGroups, int indentLevel, bool isProperty)
    {
        var indent = new string(' ', indentLevel * 4);

        foreach (var assemblyGroup in assemblyGroups)
        {
            var className = assemblyGroup.Key;
            var methods = assemblyGroup.Value;

            // Generate flat class with underscore-separated name
            sb.AppendLine($"{indent}public static partial class {className}");
            sb.AppendLine($"{indent}{{");

            // Generate backing fields for cached properties first
            if (isProperty)
            {
                var cachedProps = methods.Where(m => m.IsCached).ToList();
                if (cachedProps.Count > 0)
                {
                    sb.AppendLine($"{indent}    // Backing fields for cached properties");
                    foreach (var prop in cachedProps)
                    {
                        var method = prop.Symbol;
                        var fieldName = $"_{method.Name}";
                        var returnType = method.ReturnType.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat);
                        sb.AppendLine($"{indent}    private static {returnType}? {fieldName};");
                    }

                    sb.AppendLine();
                }
            }

            // Generate methods/properties
            foreach (var method in methods)
            {
                if (isProperty)
                {
                    GenerateProperty(sb, method, indentLevel + 1);
                }
                else
                {
                    GenerateMethod(sb, method, indentLevel + 1);
                }
            }

            sb.AppendLine($"{indent}}}");
            sb.AppendLine();
        }
    }
}
