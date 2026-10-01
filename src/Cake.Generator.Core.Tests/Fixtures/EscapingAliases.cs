// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Cake.Core;
using Cake.Core.Annotations;

namespace Cake.Generator.Core.Tests.Fixtures;

/// <summary>
/// Cake method aliases used to verify default-value escaping in generated proxies.
/// </summary>
public static class EscapingAliases
{
    /// <summary>
    /// Alias with string and char defaults that require escaping.
    /// </summary>
    /// <param name="context">The Cake context.</param>
    /// <param name="path">A Windows path default.</param>
    /// <param name="separator">A backslash default.</param>
    /// <param name="message">A quoted string with a newline.</param>
    [CakeMethodAlias]
    public static void InstallToolPath(
        ICakeContext context,
        string path = @"C:\tools",
        char separator = '\\',
        string message = "say \"hi\"\n")
    {
        _ = context;
    }
}
