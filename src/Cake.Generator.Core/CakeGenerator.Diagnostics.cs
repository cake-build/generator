// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Cake.Generator;

public partial class CakeGenerator
{
    private const string DiagnosticCategory = "CakeGenerator";

    /// <summary>
    /// Reported when an alias is skipped because its signature references a type that cannot be resolved.
    /// </summary>
    private static readonly DiagnosticDescriptor UnresolvedAliasTypeDescriptor = new(
        id: "CAKEGEN001",
        title: "Cake alias skipped due to unresolved type",
        messageFormat: "Cake alias '{0}' was skipped because type '{1}' could not be resolved, the addin assembly '{2}' may be missing a package dependency",
        category: DiagnosticCategory,
        defaultSeverity: DiagnosticSeverity.Warning,
        isEnabledByDefault: true,
        description: "The alias signature references a type from an assembly that is not referenced by the script, so no alias is generated for it.");

    /// <summary>
    /// Reported when a <c>CakeNamespaceImport</c> value is not a namespace known to the compilation.
    /// </summary>
    private static readonly DiagnosticDescriptor UnresolvedNamespaceImportDescriptor = new(
        id: "CAKEGEN002",
        title: "Cake namespace import ignored",
        messageFormat: "Cake namespace import '{0}' from addin assembly '{1}' was ignored because it is not a namespace known to the compilation",
        category: DiagnosticCategory,
        defaultSeverity: DiagnosticSeverity.Warning,
        isEnabledByDefault: true,
        description: "The namespace import does not resolve to a namespace, it may name a type or a namespace from an assembly that is not referenced, so no global using is generated for it.");
}
