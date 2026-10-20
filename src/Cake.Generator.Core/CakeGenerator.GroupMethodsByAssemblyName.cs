// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Concurrent;

namespace Cake.Generator;

public partial class CakeGenerator
{
    private static IDictionary<string, List<MethodInfo>> GroupMethodsByAssemblyName(List<MethodInfo> methods)
    {
        var result = new ConcurrentDictionary<string, List<MethodInfo>>();

        foreach (var method in methods)
        {
            var key = GetAssemblyClassName(method.Symbol.ContainingAssembly.Name);

            result.AddOrUpdate(
                key,
                _ => [method],
                (_, existingList) =>
                {
                    existingList.Add(method);
                    return existingList;
                });
        }

        return result;
    }

    /// <summary>
    /// Gets the generated class name for an addin assembly, replacing characters that are not valid in a
    /// C# identifier, e.g. <c>Cake.Markdown-Pdf</c> becomes <c>Cake_Markdown_Pdf</c>.
    /// </summary>
    /// <param name="assemblyName">The assembly name.</param>
    /// <returns>A valid C# identifier.</returns>
    private static string GetAssemblyClassName(string assemblyName)
    {
        var builder = new StringBuilder(assemblyName.Length + 1);
        foreach (var c in assemblyName)
        {
            builder.Append(SyntaxFacts.IsIdentifierPartCharacter(c) ? c : '_');
        }

        if (builder.Length == 0 || !SyntaxFacts.IsIdentifierStartCharacter(builder[0]))
        {
            builder.Insert(0, '_');
        }

        return EscapeIdentifier(builder.ToString());
    }
}