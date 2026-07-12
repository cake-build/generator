// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Cake.Generator;

public partial class CakeGenerator
{
    /// <summary>
    /// A fully qualified type display format that includes nullable reference type modifiers.
    /// </summary>
    private static readonly SymbolDisplayFormat FullyQualifiedFormatWithNullableReferenceTypes =
        SymbolDisplayFormat.FullyQualifiedFormat
            .AddMiscellaneousOptions(SymbolDisplayMiscellaneousOptions.IncludeNullableReferenceTypeModifier);

    /// <summary>
    /// Formats a method return type including nullable reference type annotations from metadata.
    /// </summary>
    /// <param name="method">The method symbol.</param>
    /// <returns>The formatted return type.</returns>
    private static string FormatReturnType(IMethodSymbol method)
        => SymbolDisplay.ToDisplayString(
            method.ReturnType,
            method.ReturnNullableAnnotation,
            FullyQualifiedFormatWithNullableReferenceTypes);

    /// <summary>
    /// Formats a parameter type including nullable reference type annotations from metadata.
    /// </summary>
    /// <param name="parameter">The parameter symbol.</param>
    /// <returns>The formatted parameter type.</returns>
    private static string FormatParameterType(IParameterSymbol parameter)
        => SymbolDisplay.ToDisplayString(
            parameter.Type,
            parameter.NullableAnnotation,
            FullyQualifiedFormatWithNullableReferenceTypes);

    /// <summary>
    /// Formats a cached property backing field type, ensuring it is nullable without double-applying modifiers.
    /// </summary>
    /// <param name="method">The property alias method symbol.</param>
    /// <returns>The formatted backing field type.</returns>
    private static string FormatCachedBackingFieldType(IMethodSymbol method)
    {
        var returnType = FormatReturnType(method);
        return returnType.EndsWith("?", StringComparison.Ordinal) ? returnType : $"{returnType}?";
    }
}
