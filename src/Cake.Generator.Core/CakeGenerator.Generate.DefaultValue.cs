// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Globalization;

namespace Cake.Generator;

public partial class CakeGenerator
{
    private static string FormatExplicitDefaultValue(object? value)
    {
        return value switch
        {
            null => "null",
            string str => FormatStringLiteral(str),
            bool b => b ? "true" : "false",
            char c => FormatCharLiteral(c),
            _ => Convert.ToString(value, CultureInfo.InvariantCulture) ?? "null"
        };
    }

    private static string FormatStringLiteral(string value)
    {
        var builder = new StringBuilder(value.Length + 2);
        builder.Append('"');
        AppendEscaped(builder, value, quote: '"');
        builder.Append('"');
        return builder.ToString();
    }

    private static string FormatCharLiteral(char value)
    {
        var builder = new StringBuilder(4);
        builder.Append('\'');
        AppendEscaped(builder, value, quote: '\'');
        builder.Append('\'');
        return builder.ToString();
    }

    private static void AppendEscaped(StringBuilder builder, string value, char quote)
    {
        foreach (var c in value)
        {
            AppendEscaped(builder, c, quote);
        }
    }

    private static void AppendEscaped(StringBuilder builder, char c, char quote)
    {
        switch (c)
        {
            case '\\':
                builder.Append("\\\\");
                break;
            case '"' when quote == '"':
                builder.Append("\\\"");
                break;
            case '\'' when quote == '\'':
                builder.Append("\\'");
                break;
            case '\0':
                builder.Append("\\0");
                break;
            case '\a':
                builder.Append("\\a");
                break;
            case '\b':
                builder.Append("\\b");
                break;
            case '\f':
                builder.Append("\\f");
                break;
            case '\n':
                builder.Append("\\n");
                break;
            case '\r':
                builder.Append("\\r");
                break;
            case '\t':
                builder.Append("\\t");
                break;
            case '\v':
                builder.Append("\\v");
                break;
            default:
                if (char.IsControl(c))
                {
                    builder.Append("\\u");
                    builder.Append(((int)c).ToString("x4", CultureInfo.InvariantCulture));
                }
                else
                {
                    builder.Append(c);
                }

                break;
        }
    }
}
