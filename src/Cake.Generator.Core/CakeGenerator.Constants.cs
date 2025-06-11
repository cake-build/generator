// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Cake.Generator;

public partial class CakeGenerator
{
    /// <summary>
    /// The full name of the System.Runtime.CompilerServices.ExtensionAttribute type.
    /// </summary>
    private const string ExtensionAttributeFullName = "System.Runtime.CompilerServices.ExtensionAttribute";

    /// <summary>
    /// The full name of the Cake.Core.Annotations.CakeMethodAliasAttribute type.
    /// </summary>
    private const string CakeMethodAliasAttributeFullName = "Cake.Core.Annotations.CakeMethodAliasAttribute";

    /// <summary>
    /// The full name of the Cake.Core.Annotations.CakePropertyAliasAttribute type.
    /// </summary>
    private const string CakePropertyAliasAttributeFullName = "Cake.Core.Annotations.CakePropertyAliasAttribute";

    /// <summary>
    /// The full name of the Cake.Core.Annotations.CakeNamespaceImportAttribute type.
    /// </summary>
    private const string CakeNamespaceImportAttributeFullName = "Cake.Core.Annotations.CakeNamespaceImportAttribute";

    /// <summary>
    /// The full name of the Cake.Core.ICakeContext type.
    /// </summary>
    private const string ICakeContextFullName = "Cake.Core.ICakeContext";

    /// <summary>
    /// The full name of the Cake.Core.Annotations.CakeModuleAttribute type.
    /// </summary>
    private const string CakeModuleAttributeFullName = "Cake.Core.Annotations.CakeModuleAttribute";

    /// <summary>
    /// The full name of the Cake.Core.Composition.ICakeModule type.
    /// </summary>
    private const string ICakeModuleFullName = "Cake.Core.Composition.ICakeModule";
}
