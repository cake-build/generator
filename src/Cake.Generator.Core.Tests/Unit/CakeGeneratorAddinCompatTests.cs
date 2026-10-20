// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Cake.Generator.Core.Tests.Unit;

/// <summary>
/// Tests that generated aliases compile for addin shapes found in the wild,
/// using fake addins compiled in memory.
/// </summary>
public sealed class CakeGeneratorAddinCompatTests
{
    [Test]
    public async Task AssemblyNameWithDash_GeneratesValidIdentifiers()
    {
        // Given
        var addin = AddinCompilation.CreateReference(
            "Cake.Fake-Addin",
            """
            using Cake.Core;
            using Cake.Core.Annotations;

            namespace Cake.Fake_Addin;

            public static class DashAliases
            {
                [CakeMethodAlias]
                public static void DashAlias(this ICakeContext context)
                {
                }
            }
            """);

        // When
        var outcome = AddinCompilation.Run(addin);

        // Then
        await Assert.That(outcome.Errors).IsEmpty();
        await Assert.That(outcome.GlobalUsings).Contains("global using static global::Program.Cake_Fake_Addin;");
        await Assert.That(outcome.GetAliasClass("Cake_Fake_Addin")).Contains("DashAlias");
    }

    [Test]
    public async Task GenericAliases_KeepTypeParameterConstraints()
    {
        // Given
        var addin = AddinCompilation.CreateReference(
            "Cake.Fake.Generics",
            """
            using System;
            using Cake.Core;
            using Cake.Core.Annotations;

            namespace Cake.Fake.Generics;

            public class FakeSettings
            {
            }

            public static class GenericAliases
            {
                [CakeMethodAlias]
                public static IDisposable WithSettings<T>(this ICakeContext context, T settings)
                    where T : FakeSettings
                    => null!;

                [CakeMethodAlias]
                public static void Constrained<TClass, TStruct, TUnmanaged, TNotNull, TNullableClass, TNullableBase>(this ICakeContext context)
                    where TClass : class, IDisposable, new()
                    where TStruct : struct
                    where TUnmanaged : unmanaged
                    where TNotNull : notnull
                    where TNullableClass : class?
                    where TNullableBase : FakeSettings?
                {
                }
            }
            """);

        // When
        var outcome = AddinCompilation.Run(addin);

        // Then
        await Assert.That(outcome.Errors).IsEmpty();
        await Verify(outcome.GetAliasClass("Cake_Fake_Generics"));
    }

    [Test]
    public async Task DefaultValues_AreTypedForTheParameter()
    {
        // Given
        var addin = AddinCompilation.CreateReference(
            "Cake.Fake.Defaults",
            """
            using System;
            using System.Threading;
            using Cake.Core;
            using Cake.Core.Annotations;

            namespace Cake.Fake.Defaults;

            public enum Mode
            {
                Negative = -1,
                None = 0,
                Local = 1,
                Remote = 2
            }

            [Flags]
            public enum Criteria
            {
                None = 0,
                Time = 1,
                Size = 2,
                Hash = 4,
                All = Time | Size
            }

            public static class DefaultAliases
            {
                [CakeMethodAlias]
                public static void EnumDefaults(
                    this ICakeContext context,
                    Mode mode = Mode.Remote,
                    Criteria criteria = Criteria.Time | Criteria.Hash,
                    Criteria all = Criteria.Time | Criteria.Size,
                    Criteria unknownFlag = (Criteria)8,
                    Criteria partial = Criteria.Time | (Criteria)8,
                    Mode? nullableMode = Mode.Local,
                    Mode? nullableNone = null,
                    Mode negative = Mode.Negative,
                    Mode zero = Mode.None,
                    Mode undefined = (Mode)5)
                {
                }

                [CakeMethodAlias]
                public static void NumericDefaults(
                    this ICakeContext context,
                    decimal amount = 1.5m,
                    decimal maxAmount = decimal.MaxValue,
                    float ratio = 0.1f,
                    float maxRatio = float.MaxValue,
                    double precise = 0.1,
                    double huge = 1e300,
                    double nan = double.NaN,
                    double positiveInfinity = double.PositiveInfinity,
                    float negativeInfinity = float.NegativeInfinity,
                    long min = long.MinValue,
                    ulong max = ulong.MaxValue,
                    int? nullableInt = 42)
                {
                }

                [CakeMethodAlias]
                public static void StructDefaults(
                    this ICakeContext context,
                    CancellationToken cancellationToken = default,
                    DateTime? when = null,
                    string? text = null)
                {
                }

                [CakeMethodAlias]
                public static void GenericDefault<T>(this ICakeContext context, T value = default!)
                {
                }
            }
            """);

        // When
        var outcome = AddinCompilation.Run(addin);

        // Then
        await Assert.That(outcome.Errors).IsEmpty();
        await Verify(outcome.GetAliasClass("Cake_Fake_Defaults"));
    }

    [Test]
    public async Task UnresolvedDependency_SkipsAffectedAliases()
    {
        // Given
        var library = AddinCompilation.CreateReference(
            "Fake.Lib",
            """
            namespace Fake.Lib;

            public interface IThing
            {
            }
            """);
        var addin = AddinCompilation.CreateReference(
            "Cake.Fake.Missing",
            """
            using System.Collections.Generic;
            using Cake.Core;
            using Cake.Core.Annotations;
            using Fake.Lib;

            namespace Cake.Fake.Missing;

            public static class MissingAliases
            {
                [CakeMethodAlias]
                [CakeNamespaceImport("Fake.Lib")]
                public static IThing GetThing(this ICakeContext context) => null!;

                [CakeMethodAlias]
                public static void UseThings(this ICakeContext context, IEnumerable<IThing> things)
                {
                }

                [CakeMethodAlias]
                public static void ConstrainedThing<T>(this ICakeContext context, T thing)
                    where T : IThing
                {
                }

                [CakeMethodAlias]
                public static void StillWorks(this ICakeContext context)
                {
                }
            }
            """,
            library);

        // When, Fake.Lib is not referenced by the script
        var outcome = AddinCompilation.Run(addin);

        // Then
        await Assert.That(outcome.Errors).IsEmpty();
        var aliasClass = outcome.GetAliasClass("Cake_Fake_Missing");
        await Assert.That(aliasClass).Contains("StillWorks");
        await Assert.That(aliasClass).DoesNotContain("GetThing");
        await Assert.That(aliasClass).DoesNotContain("UseThings");
        await Assert.That(aliasClass).DoesNotContain("ConstrainedThing");
        await Assert.That(outcome.GlobalUsings).DoesNotContain("Fake.Lib");
        await Assert.That(outcome.GeneratorDiagnostics.Count(diagnostic => diagnostic.Id == "CAKEGEN001")).IsEqualTo(3);
    }

    [Test]
    public async Task NamespaceImports_OnlyEmitsResolvableNamespaces()
    {
        // Given
        var addin = AddinCompilation.CreateReference(
            "Cake.Fake.Imports",
            """
            using Cake.Core;
            using Cake.Core.Annotations;

            namespace Cake.Fake.Imports
            {
                public class SomeClass
                {
                }

                public static class ImportAliases
                {
                    [CakeMethodAlias]
                    [CakeNamespaceImport("Cake.Fake.Imports.SomeClass")]
                    [CakeNamespaceImport("Missing.Namespace")]
                    [CakeNamespaceImport("Cake.Fake.Imports.Valid")]
                    public static void Imports(this ICakeContext context)
                    {
                    }
                }
            }

            namespace Cake.Fake.Imports.Valid
            {
                public class Marker
                {
                }
            }
            """);

        // When
        var outcome = AddinCompilation.Run(addin);

        // Then
        await Assert.That(outcome.Errors).IsEmpty();
        await Assert.That(outcome.GlobalUsings).Contains("global using global::Cake.Fake.Imports.Valid;");
        await Assert.That(outcome.GlobalUsings).DoesNotContain("Cake.Fake.Imports.SomeClass");
        await Assert.That(outcome.GlobalUsings).DoesNotContain("Missing.Namespace");
        await Assert.That(outcome.GetAliasClass("Cake_Fake_Imports")).Contains("Imports");
        await Assert.That(outcome.GeneratorDiagnostics.Count(diagnostic => diagnostic.Id == "CAKEGEN002")).IsEqualTo(2);
    }

    [Test]
    public async Task NamespaceImports_IncludeClassAndAssemblyLevel()
    {
        // Given
        var addin = AddinCompilation.CreateReference(
            "Cake.Fake.Scoped",
            """
            using Cake.Core;
            using Cake.Core.Annotations;

            [assembly: CakeNamespaceImport("Cake.Fake.Scoped.AssemblyLevel")]
            [assembly: CakeNamespaceImport("Missing.Assembly.Namespace")]

            namespace Cake.Fake.Scoped
            {
                [CakeNamespaceImport("Cake.Fake.Scoped.ClassLevel")]
                public static class ScopedAliases
                {
                    [CakeMethodAlias]
                    [CakeNamespaceImport("Cake.Fake.Scoped.MethodLevel")]
                    public static void FirstScoped(this ICakeContext context)
                    {
                    }

                    [CakeMethodAlias]
                    public static void SecondScoped(this ICakeContext context)
                    {
                    }
                }
            }

            namespace Cake.Fake.Scoped.AssemblyLevel
            {
                public class AssemblyMarker
                {
                }
            }

            namespace Cake.Fake.Scoped.ClassLevel
            {
                public class ClassMarker
                {
                }
            }

            namespace Cake.Fake.Scoped.MethodLevel
            {
                public class MethodMarker
                {
                }
            }
            """);

        // When
        var outcome = AddinCompilation.Run(addin);

        // Then
        await Assert.That(outcome.Errors).IsEmpty();
        await Assert.That(outcome.GlobalUsings).Contains("global using global::Cake.Fake.Scoped.AssemblyLevel;");
        await Assert.That(outcome.GlobalUsings).Contains("global using global::Cake.Fake.Scoped.ClassLevel;");
        await Assert.That(outcome.GlobalUsings).Contains("global using global::Cake.Fake.Scoped.MethodLevel;");
        await Assert.That(outcome.GlobalUsings).DoesNotContain("Missing.Assembly.Namespace");
        await Assert.That(outcome.GeneratorDiagnostics.Count(diagnostic => diagnostic.Id == "CAKEGEN002")).IsEqualTo(1);
    }

    [Test]
    public async Task KeywordIdentifiers_AreEscaped()
    {
        // Given
        var addin = AddinCompilation.CreateReference(
            "Cake.Fake.Keywords",
            """
            using Cake.Core;
            using Cake.Core.Annotations;

            namespace Cake.Fake.Keywords;

            public static class KeywordAliases
            {
                [CakeMethodAlias]
                public static void @class<@event>(this ICakeContext context, string @object, int @in = 1, @event @base = default!)
                    where @event : notnull
                {
                }

                [CakePropertyAlias]
                public static string @operator(this ICakeContext context) => "operator";

                [CakePropertyAlias(Cache = true)]
                public static string @checked(this ICakeContext context) => "checked";
            }
            """);

        // When
        var outcome = AddinCompilation.Run(addin);

        // Then
        await Assert.That(outcome.Errors).IsEmpty();
        await Verify(
            outcome.GetAliasClass("Cake_Fake_Keywords")
            + "\n\n"
            + outcome.GetPropertyAliasClass("Cake_Fake_Keywords"));
    }

    [Test]
    public async Task RefReadOnlyParameters_AreForwarded()
    {
        // Given
        var addin = AddinCompilation.CreateReference(
            "Cake.Fake.Refs",
            """
            using Cake.Core;
            using Cake.Core.Annotations;

            namespace Cake.Fake.Refs;

            public static class RefAliases
            {
                [CakeMethodAlias]
                public static void Refs(this ICakeContext context, ref readonly int value, in int other, ref int changed, out int result)
                {
                    changed = value + other;
                    result = changed;
                }
            }
            """);

        // When
        var outcome = AddinCompilation.Run(addin);

        // Then
        await Assert.That(outcome.Errors).IsEmpty();
        await Verify(outcome.GetAliasClass("Cake_Fake_Refs"));
    }
}
