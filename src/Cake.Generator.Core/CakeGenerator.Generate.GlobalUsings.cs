// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Cake.Generator;

public partial class CakeGenerator
{
    private static string GenerateGlobalUsings(List<MethodInfo> methods)
    {
        var foundNamespaces = new HashSet<string>(StringComparer.Ordinal)
        {
            "System",
            "System.Collections.Generic",
            "System.Collections.Concurrent",
            "System.Linq",
            "System.Text",
            "System.Text.Json",
            "System.Threading.Tasks",
            "System.IO",
            "Microsoft.Extensions.DependencyInjection",
            "Cake.Core",
            "Cake.Core.Configuration",
            "Cake.Core.Diagnostics",
            "Cake.Core.IO",
            "Cake.Core.IO.NuGet",
            "Cake.Core.Reflection",
            "Cake.Core.Scripting",
            "Cake.Core.Tooling",
            "Cake.Cli",
            "Spectre.Console"
        };

        // Get unique assembly names from methods to generate static usings
        var assemblyNames = new HashSet<string>();
        foreach (var method in methods)
        {
            var assemblyName = method.Symbol.ContainingAssembly.Name;
            assemblyNames.Add(assemblyName);
            foundNamespaces.Add(method.Symbol.ContainingNamespace.ToDisplayString());

            // Add namespaces from CakeNamespaceImportAttribute
            foreach (var namespaceImport in method.NamespaceImports)
            {
                foundNamespaces.Add(namespaceImport);
            }
        }

        var sb = new StringBuilder();
        sb.AppendLine("// <auto-generated/>");
        sb.AppendLine("// Global usings for all Cake method aliases");
        sb.AppendLine();

        // Add regular global usings
        var globalUsings = string.Join(
                                "\n",
                                foundNamespaces
                                    .OrderBy(x => x)
                                    .Select(ns => $"global using global::{ns};"));
        sb.AppendLine(globalUsings);
        sb.AppendLine();

        // Add global static usings for generated flat classes
        sb.AppendLine("// Global static usings for generated Cake alias classes");
        foreach (var assemblyName in assemblyNames.OrderBy(x => x))
        {
            var flatClassName = assemblyName.Replace(".", "_");
            sb.AppendLine($"global using static global::Program.{flatClassName};");
        }

        return sb.ToString();
    }
}
