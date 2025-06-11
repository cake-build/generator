// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Cake.Generator;

public partial class CakeGenerator
{
    private static Dictionary<string, List<MethodInfo>> GroupMethodsByAssemblyName(List<MethodInfo> methods)
    {
        return methods
            .GroupBy(method => method.Symbol.ContainingAssembly.Name)
            .ToDictionary(group => group.Key.Replace(".", "_"), group => group.ToList());
    }
}