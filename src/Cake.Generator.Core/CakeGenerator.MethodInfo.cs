// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Cake.Generator;

public partial class CakeGenerator
{
    private class MethodInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MethodInfo"/> class.
        /// </summary>
        /// <param name="symbol">The method symbol.</param>
        /// <param name="isPropertyAlias">A value indicating whether the method is a property alias.</param>
        /// <param name="isCached">A value indicating whether the property alias is cached.</param>
        /// <param name="namespaceImports">The namespaces to import based on CakeNamespaceImportAttribute.</param>
        public MethodInfo(IMethodSymbol symbol, bool isPropertyAlias = false, bool isCached = false, params string[] namespaceImports)
        {
            this.Symbol = symbol;
            this.IsPropertyAlias = isPropertyAlias;
            this.IsCached = isCached;
            this.NamespaceImports = namespaceImports;
        }

        /// <summary>
        /// Gets the method symbol.
        /// </summary>
        public IMethodSymbol Symbol { get; }

        /// <summary>
        /// Gets a value indicating whether the method is a property alias.
        /// </summary>
        public bool IsPropertyAlias { get; }

        /// <summary>
        /// Gets a value indicating whether the property alias is cached.
        /// </summary>
        public bool IsCached { get; }

        /// <summary>
        /// Gets the namespaces to import based on CakeNamespaceImportAttribute.
        /// </summary>
        public string[] NamespaceImports { get; }
    }
}