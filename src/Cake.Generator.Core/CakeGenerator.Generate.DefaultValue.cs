// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Globalization;

namespace Cake.Generator;

public partial class CakeGenerator
{
    private static string FormatExplicitDefaultValue(IParameterSymbol parameter)
    {
        var value = parameter.ExplicitDefaultValue;
        var isNullableValueType = parameter.Type is INamedTypeSymbol { OriginalDefinition.SpecialType: SpecialType.System_Nullable_T };
        var type = isNullableValueType ? ((INamedTypeSymbol)parameter.Type).TypeArguments[0] : parameter.Type;

        if (value == null)
        {
            // null is only valid for reference and nullable value types, value types and type parameters need default.
            return parameter.Type.IsReferenceType || isNullableValueType ? "null" : "default";
        }

        if (type is INamedTypeSymbol { TypeKind: TypeKind.Enum } enumType)
        {
            return FormatEnumDefaultValue(enumType, value);
        }

        return FormatExplicitDefaultValue(value);
    }

    /// <summary>
    /// Formats an enum default value as its member name, a combination of members for flags enums,
    /// or a cast when the value has no name.
    /// </summary>
    private static string FormatEnumDefaultValue(INamedTypeSymbol enumType, object value)
    {
        var bits = ToEnumBits(value);
        var members = enumType.GetMembers()
            .OfType<IFieldSymbol>()
            .Where(field => field.HasConstantValue && field.ConstantValue != null)
            .Select(field => (Field: field, Bits: ToEnumBits(field.ConstantValue!)))
            .ToList();

        // Exact match, first declared member wins when several share a value
        foreach (var member in members)
        {
            if (member.Bits == bits)
            {
                return FormatEnumMember(enumType, member.Field);
            }
        }

        // Combination of members for flags enums
        if (bits != 0 && enumType.GetAttributes().Any(attribute => attribute.AttributeClass?.ToDisplayString() == "System.FlagsAttribute"))
        {
            var covered = 0UL;
            var flags = new List<(IFieldSymbol Field, ulong Bits)>();
            foreach (var member in members.Where(member => member.Bits != 0).OrderByDescending(member => member.Bits))
            {
                if ((bits & member.Bits) == member.Bits && (covered | member.Bits) != covered)
                {
                    covered |= member.Bits;
                    flags.Add(member);
                }
            }

            if (covered == bits)
            {
                return string.Join(
                    " | ",
                    flags
                        .OrderBy(flag => flag.Bits)
                        .Select(flag => FormatEnumMember(enumType, flag.Field)));
            }
        }

        var enumValue = FormatExplicitDefaultValue(value);
        return $"({enumType.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)}){(enumValue.StartsWith("-", StringComparison.Ordinal) ? $"({enumValue})" : enumValue)}";
    }

    private static string FormatEnumMember(INamedTypeSymbol enumType, IFieldSymbol member)
        => $"{enumType.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)}.{EscapeIdentifier(member.Name)}";

    /// <summary>
    /// Converts an enum constant to its bit pattern, so signed and unsigned underlying types compare equally.
    /// </summary>
    private static ulong ToEnumBits(object value)
        => value switch
        {
            ulong u => u,
            uint u => u,
            ushort u => u,
            byte u => u,
            _ => unchecked((ulong)Convert.ToInt64(value, CultureInfo.InvariantCulture))
        };

    private static string FormatExplicitDefaultValue(object value)
    {
        return value switch
        {
            string str => FormatStringLiteral(str),
            bool b => b ? "true" : "false",
            char c => FormatCharLiteral(c),
            float f when float.IsNaN(f) => "float.NaN",
            float f when float.IsPositiveInfinity(f) => "float.PositiveInfinity",
            float f when float.IsNegativeInfinity(f) => "float.NegativeInfinity",
            float f => f.ToString("R", CultureInfo.InvariantCulture) + "f",
            double d when double.IsNaN(d) => "double.NaN",
            double d when double.IsPositiveInfinity(d) => "double.PositiveInfinity",
            double d when double.IsNegativeInfinity(d) => "double.NegativeInfinity",
            double d => d.ToString("R", CultureInfo.InvariantCulture) + "d",
            decimal m => m.ToString(CultureInfo.InvariantCulture) + "m",
            _ => Convert.ToString(value, CultureInfo.InvariantCulture) ?? "default"
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
