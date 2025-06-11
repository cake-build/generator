// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Cake.Generator;

public partial class CakeGenerator
{
    private class ModuleInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModuleInfo"/> class.
        /// </summary>
        /// <param name="symbol">The module type symbol.</param>
        public ModuleInfo(INamedTypeSymbol symbol)
        {
            Symbol = symbol;
        }

        /// <summary>
        /// Gets the module type symbol.
        /// </summary>
        public INamedTypeSymbol Symbol { get; }

        /// <summary>
        /// Gets the full name of the module type.
        /// </summary>
        public string FullName => Symbol.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat);

        /// <summary>
        /// Gets the simple name of the module type.
        /// </summary>
        public string Name => Symbol.Name;
    }
}
