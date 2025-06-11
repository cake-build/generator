// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Cake.Generator;

public partial class CakeGenerator
{
    private static void GenerateXmlDocumentation(StringBuilder sb, IMethodSymbol method, string indent)
    {
        var xmlDoc = method.GetDocumentationCommentXml();
        if (!string.IsNullOrEmpty(xmlDoc))
        {
            var lines = xmlDoc?.Split('\n') ?? Array.Empty<string>();
            foreach (var line in lines)
            {
                var trimmedLine = line.Trim();
                if (!string.IsNullOrEmpty(trimmedLine))
                {
                    // Remove the first parameter (context) from documentation
                    if (trimmedLine.Contains("<param name=\"context\""))
                    {
                        continue; // Skip this line
                    }

                    sb.AppendLine($"{indent}/// {trimmedLine}");
                }
            }
        }
    }
}
