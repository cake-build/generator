// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Cake.Generator;

public partial class CakeGenerator
{
    private static void GenerateXmlDocumentation(StringBuilder sb, IMethodSymbol method, string indent)
    {
        var xmlDoc = method.GetDocumentationCommentXml();
        if (xmlDoc is not { Length: > 0 } documentation)
        {
            return;
        }

        var lines = documentation.Split('\n');
        var minIndent = int.MaxValue;
        foreach (var line in lines)
        {
            var trimmedEnd = line.TrimEnd();
            if (trimmedEnd.Length == 0 || IsMemberWrapper(trimmedEnd))
            {
                continue;
            }

            var leading = GetLeadingWhitespaceLength(trimmedEnd);
            if (leading < minIndent)
            {
                minIndent = leading;
            }
        }

        if (minIndent == int.MaxValue)
        {
            minIndent = 0;
        }

        foreach (var line in lines)
        {
            var trimmedEnd = line.TrimEnd();
            if (trimmedEnd.Length == 0)
            {
                continue;
            }

            var dedented = IsMemberWrapper(trimmedEnd) || GetLeadingWhitespaceLength(trimmedEnd) < minIndent
                ? trimmedEnd.TrimStart()
                : trimmedEnd.Substring(minIndent);

            // Remove the first parameter (context) from documentation
            if (dedented.Contains("<param name=\"context\""))
            {
                continue;
            }

            sb.AppendLine($"{indent}/// {dedented}");
        }
    }

    private static bool IsMemberWrapper(string line)
    {
        var start = line.TrimStart();
        return start.StartsWith("<member", StringComparison.Ordinal)
            || start.StartsWith("</member>", StringComparison.Ordinal);
    }

    private static int GetLeadingWhitespaceLength(string line)
    {
        var i = 0;
        while (i < line.Length && char.IsWhiteSpace(line[i]))
        {
            i++;
        }

        return i;
    }
}
