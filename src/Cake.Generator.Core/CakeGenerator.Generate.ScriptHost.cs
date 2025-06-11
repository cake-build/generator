// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Cake.Generator;

public partial class CakeGenerator
{
    private static string GenerateScriptHost(Compilation compilation)
    {
        var scriptHostInterface = compilation.GetTypeByMetadataName("Cake.Core.Scripting.IScriptHost");

        if (scriptHostInterface == null)
        {
          return string.Empty;
        }

        var stringBuilder = new StringBuilder();
        stringBuilder.AppendLine(
            """
            /// <summary>
            /// Static proxy methods and properties for IScriptHost.
            /// </summary>"
            public static partial class Program
            {
                /// <summary>
                /// Gets the Cake script host instance from the service provider.
                /// </summary>
                public static IScriptHost ScriptHost { get; } = ServiceProvider.GetRequiredService<IScriptHost>();

                private class GeneratorScriptHost(ICakeEngine engine, ICakeContext context, IExecutionStrategy strategy, ICakeReportPrinter reporter)
                    : ScriptHost(engine, context)
                {

                    public override async Task<CakeReport> RunTargetAsync(string target)
                    {
                        Settings.SetTarget(target);
                        var report = await Engine.RunTargetAsync(Context, strategy, Settings);
                        reporter.Write(report);
                        return report;
                    }

                    public override async Task<CakeReport> RunTargetsAsync(IEnumerable<string> targets)
                    {
                        Settings.SetTargets(targets);
                        var report = await Engine.RunTargetAsync(Context, strategy, Settings);
                        reporter.Write(report);
                        return report;
                    }
                }
            """);

        stringBuilder.AppendLine();

        // Generate proxy methods and properties dynamically
        foreach (var member in scriptHostInterface.GetMembers())
        {
            if (member is IMethodSymbol method && method.MethodKind == MethodKind.Ordinary)
            {
                GenerateProxyMethod(stringBuilder, method);
            }
            else if (member is IPropertySymbol property)
            {
                GenerateProxyProperty(stringBuilder, property);
            }
        }

        stringBuilder.AppendLine("}");
        return stringBuilder.ToString();
    }

    private static void GenerateProxyMethod(StringBuilder sb, IMethodSymbol method)
    {
        // Generate XML documentation from the actual method
        GenerateXmlDocumentation(sb, method, "    ");

        // Generate method signature
        var returnType = method.ReturnType.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat);
        var methodName = method.Name;

        // Handle generic methods
        var typeParameters = method.TypeParameters.Length > 0
            ? $"<{string.Join(", ", method.TypeParameters.Select(tp => tp.Name))}>"
            : string.Empty;

        // Generate parameters
        var parameters = string.Join(
            ", ",
            method.Parameters.Select(p =>
                $"{p.Type.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)} {p.Name}"));

        // Generate generic constraints separately
        var constraints = new StringBuilder();
        if (method.TypeParameters.Length > 0)
        {
            foreach (var tp in method.TypeParameters)
            {
                var typeConstraints = GetGenericConstraints(tp);
                if (!string.IsNullOrEmpty(typeConstraints))
                {
                    if (constraints.Length == 0)
                    {
                        constraints.Append(" ");
                    }
                    constraints.Append($"where {tp.Name} : {typeConstraints} ");
                }
            }
            // If constraints were added, the preceding loop ensures a trailing space. Remove it for cleaner output.
            if (constraints.Length > 0)
            {
                constraints.Length--;
            }
        }

        // For the method call, include type parameters if the method is generic
        var methodCall = method.TypeParameters.Length > 0
                            ? $"ScriptHost.{methodName}<{string.Join(", ", method.TypeParameters.Select(tp => tp.Name))}>"
                            : $"ScriptHost.{methodName}";

        // Append the main part of the method signature
        sb.Append($"    public static {returnType} {methodName}{typeParameters}({parameters})");

        // Append constraints on a new line if they exist
        if (constraints.Length > 0)
        {
            sb.AppendLine();
            sb.Append($"        {constraints.ToString().TrimStart()}");
        }

        // Append the method body on a new line
        sb.AppendLine();
        sb.AppendLine($"        => {methodCall}({string.Join(",", method.Parameters.Select(p => p.Name))});");

        // Add a blank line after the method definition (this was the original behavior)
        sb.AppendLine();
    }

    private static void GenerateProxyProperty(StringBuilder sb, IPropertySymbol property)
    {
        // Generate XML documentation from the actual property
        GenerateXmlDocumentation(sb, property);

        var propertyType = property.Type.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat);
        var propertyName = property.Name;

        sb.AppendLine($"    public static {propertyType} {propertyName}");
        sb.AppendLine($"        => ScriptHost.{property.Name};");
        sb.AppendLine();
    }

    private static void GenerateXmlDocumentation(StringBuilder sb, ISymbol symbol)
    {
        var xmlDoc = symbol.GetDocumentationCommentXml();

        if (!string.IsNullOrEmpty(xmlDoc))
        {
            // Parse and extract the summary
            var summary = ExtractSummaryFromXml(xmlDoc!);
            if (!string.IsNullOrEmpty(summary))
            {
                sb.AppendLine("    /// <summary>");

                // Split summary into lines if it's multiline and properly indent
                var summaryLines = summary.Split(['\n', '\r'], StringSplitOptions.RemoveEmptyEntries);
                foreach (var line in summaryLines)
                {
                    sb.AppendLine($"    /// {line.Trim()}");
                }

                sb.AppendLine("    /// </summary>");
                return;
            }
        }
    }

    private static string ExtractSummaryFromXml(string xmlDoc)
    {
        try
        {
            // Simple extraction of summary content
            // This could be made more robust with proper XML parsing
            const string startTag = "<summary>";
            const string endTag = "</summary>";

            var startIndex = xmlDoc.IndexOf(startTag);
            if (startIndex == -1)
            {
                return string.Empty;
            }

            startIndex += startTag.Length;
            var endIndex = xmlDoc.IndexOf(endTag, startIndex);
            if (endIndex == -1)
            {
                return string.Empty;
            }

            var summary = xmlDoc.Substring(startIndex, endIndex - startIndex);

            // Clean up the summary text
            summary = summary.Trim();

            // Remove extra whitespace and normalize line endings
            summary = Regex.Replace(summary, @"\s+", " ");

            return summary;
        }
        catch
        {
            return string.Empty;
        }
    }

    private static string GetGenericConstraints(ITypeParameterSymbol typeParameter)
    {
        var constraints = new List<string>();

        if (typeParameter.HasReferenceTypeConstraint)
        {
            constraints.Add("class");
        }

        if (typeParameter.HasValueTypeConstraint)
        {
            constraints.Add("struct");
        }

        constraints.AddRange(typeParameter.ConstraintTypes.Select(ct => ct.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)));

        if (typeParameter.HasConstructorConstraint)
        {
            constraints.Add("new()");
        }

        return string.Join(", ", constraints);
    }
}
