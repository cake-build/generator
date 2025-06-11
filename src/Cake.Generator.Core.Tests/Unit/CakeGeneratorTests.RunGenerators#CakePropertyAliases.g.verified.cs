//HintName: CakePropertyAliases.g.cs

public static partial class Program
{
    public static partial class Cake_Common
    {
        // Backing fields for cached properties
        private static global::Cake.Common.Build.BuildSystem? _BuildSystem;
        private static global::Cake.Common.Build.AppVeyor.IAppVeyorProvider? _AppVeyor;
        private static global::Cake.Common.Build.TeamCity.ITeamCityProvider? _TeamCity;
        private static global::Cake.Common.Build.MyGet.IMyGetProvider? _MyGet;
        private static global::Cake.Common.Build.Bamboo.IBambooProvider? _Bamboo;
        private static global::Cake.Common.Build.ContinuaCI.IContinuaCIProvider? _ContinuaCI;
        private static global::Cake.Common.Build.Jenkins.IJenkinsProvider? _Jenkins;
        private static global::Cake.Common.Build.Bitrise.IBitriseProvider? _Bitrise;
        private static global::Cake.Common.Build.TravisCI.ITravisCIProvider? _TravisCI;
        private static global::Cake.Common.Build.BitbucketPipelines.IBitbucketPipelinesProvider? _BitbucketPipelines;
        private static global::Cake.Common.Build.GoCD.IGoCDProvider? _GoCD;
        private static global::Cake.Common.Build.GitLabCI.IGitLabCIProvider? _GitLabCI;
        private static global::Cake.Common.Build.GitHubActions.IGitHubActionsProvider? _GitHubActions;
        private static global::Cake.Common.Build.AzurePipelines.IAzurePipelinesProvider? _AzurePipelines;

        /// <member name="M:Cake.Common.Build.BuildSystemAliases.BuildSystem(Cake.Core.ICakeContext)">
        /// <summary>
        /// Gets a <see cref="T:Cake.Common.Build.BuildSystem" /> instance that can
        /// be used to query for information about the current build system.
        /// </summary>
        /// <example>
        /// <code>
        /// var isLocal = BuildSystem.IsLocalBuild;
        /// </code>
        /// </example>
        /// <returns>A <see cref="T:Cake.Common.Build.BuildSystem" /> instance.</returns>
        /// </member>
        public static global::Cake.Common.Build.BuildSystem BuildSystem
            => _BuildSystem ??= global::Cake.Common.Build.BuildSystemAliases.BuildSystem(Context);

        /// <member name="M:Cake.Common.Build.BuildSystemAliases.AppVeyor(Cake.Core.ICakeContext)">
        /// <summary>
        /// Gets a <see cref="T:Cake.Common.Build.AppVeyor.AppVeyorProvider" /> instance that can
        /// be used to manipulate the AppVeyor environment.
        /// </summary>
        /// <example>
        /// <code>
        /// var isAppVeyorBuild = AppVeyor.IsRunningOnAppVeyor;
        /// </code>
        /// </example>
        /// <returns>A <see cref="N:Cake.Common.Build.AppVeyor" /> instance.</returns>
        /// </member>
        public static global::Cake.Common.Build.AppVeyor.IAppVeyorProvider AppVeyor
            => _AppVeyor ??= global::Cake.Common.Build.BuildSystemAliases.AppVeyor(Context);

        /// <member name="M:Cake.Common.Build.BuildSystemAliases.TeamCity(Cake.Core.ICakeContext)">
        /// <summary>
        /// Gets a <see cref="T:Cake.Common.Build.TeamCity.TeamCityProvider" /> instance that can
        /// be used to manipulate the TeamCity environment.
        /// </summary>
        /// <example>
        /// <code>
        /// var isTeamCityBuild = TeamCity.IsRunningOnTeamCity;
        /// </code>
        /// </example>
        /// <returns>A <see cref="N:Cake.Common.Build.TeamCity" /> instance.</returns>
        /// </member>
        public static global::Cake.Common.Build.TeamCity.ITeamCityProvider TeamCity
            => _TeamCity ??= global::Cake.Common.Build.BuildSystemAliases.TeamCity(Context);

        /// <member name="M:Cake.Common.Build.BuildSystemAliases.MyGet(Cake.Core.ICakeContext)">
        /// <summary>
        /// Gets a <see cref="T:Cake.Common.Build.MyGet.MyGetProvider" /> instance that can
        /// be used to manipulate the MyGet environment.
        /// </summary>
        /// <example>
        /// <code>
        /// var isMyGetBuild = MyGet.IsRunningOnMyGet;
        /// </code>
        /// </example>
        /// <returns>A <see cref="N:Cake.Common.Build.MyGet" /> instance.</returns>
        /// </member>
        public static global::Cake.Common.Build.MyGet.IMyGetProvider MyGet
            => _MyGet ??= global::Cake.Common.Build.BuildSystemAliases.MyGet(Context);

        /// <member name="M:Cake.Common.Build.BuildSystemAliases.Bamboo(Cake.Core.ICakeContext)">
        /// <summary>
        /// Gets a <see cref="T:Cake.Common.Build.Bamboo.BambooProvider" /> instance that can
        /// be used to manipulate the Bamboo environment.
        /// </summary>
        /// <example>
        /// <code>
        /// var isBambooBuild = Bamboo.IsRunningOnBamboo;
        /// </code>
        /// </example>
        /// <returns>A <see cref="N:Cake.Common.Build.Bamboo" /> instance.</returns>
        /// </member>
        public static global::Cake.Common.Build.Bamboo.IBambooProvider Bamboo
            => _Bamboo ??= global::Cake.Common.Build.BuildSystemAliases.Bamboo(Context);

        /// <member name="M:Cake.Common.Build.BuildSystemAliases.ContinuaCI(Cake.Core.ICakeContext)">
        /// <summary>
        /// Gets a <see cref="T:Cake.Common.Build.ContinuaCI.ContinuaCIProvider" /> instance that can
        /// be used to manipulate the Continua CI environment.
        /// </summary>
        /// <example>
        /// <code>
        /// var isContinuaCIBuild = ContinuaCI.IsRunningContinuaCI;
        /// </code>
        /// </example>
        /// <returns>A <see cref="N:Cake.Common.Build.ContinuaCI" /> instance.</returns>
        /// </member>
        public static global::Cake.Common.Build.ContinuaCI.IContinuaCIProvider ContinuaCI
            => _ContinuaCI ??= global::Cake.Common.Build.BuildSystemAliases.ContinuaCI(Context);

        /// <member name="M:Cake.Common.Build.BuildSystemAliases.Jenkins(Cake.Core.ICakeContext)">
        /// <summary>
        /// Gets a <see cref="T:Cake.Common.Build.Jenkins.JenkinsProvider" /> instance that can be used to
        /// obtain information from the Jenkins environment.
        /// </summary>
        /// <example>
        /// <code>
        /// var isJenkinsBuild = Jenkins.IsRunningOnJenkins;
        /// </code>
        /// </example>
        /// <returns>A <see cref="N:Cake.Common.Build.Jenkins" /> instance.</returns>
        /// </member>
        public static global::Cake.Common.Build.Jenkins.IJenkinsProvider Jenkins
            => _Jenkins ??= global::Cake.Common.Build.BuildSystemAliases.Jenkins(Context);

        /// <member name="M:Cake.Common.Build.BuildSystemAliases.Bitrise(Cake.Core.ICakeContext)">
        /// <summary>
        /// Gets a <see cref="T:Cake.Common.Build.Bitrise.BitriseProvider" /> instance that can be used to
        /// obtain information from the Bitrise environment.
        /// </summary>
        /// <example>
        /// <code>
        /// var isBitriseBuild = Bitrise.IsRunningOnBitrise;
        /// </code>
        /// </example>
        /// <returns>A <see cref="N:Cake.Common.Build.Bitrise" /> instance.</returns>
        /// </member>
        public static global::Cake.Common.Build.Bitrise.IBitriseProvider Bitrise
            => _Bitrise ??= global::Cake.Common.Build.BuildSystemAliases.Bitrise(Context);

        /// <member name="M:Cake.Common.Build.BuildSystemAliases.TravisCI(Cake.Core.ICakeContext)">
        /// <summary>
        /// Gets a <see cref="T:Cake.Common.Build.TravisCI.TravisCIProvider" /> instance that can be used to
        /// obtain information from the Travis CI environment.
        /// </summary>
        /// <example>
        /// <code>
        /// var isTravisCIBuild = TravisCI.IsRunningOnTravisCI;
        /// </code>
        /// </example>
        /// <returns>A <see cref="N:Cake.Common.Build.TravisCI" /> instance.</returns>
        /// </member>
        public static global::Cake.Common.Build.TravisCI.ITravisCIProvider TravisCI
            => _TravisCI ??= global::Cake.Common.Build.BuildSystemAliases.TravisCI(Context);

        /// <member name="M:Cake.Common.Build.BuildSystemAliases.BitbucketPipelines(Cake.Core.ICakeContext)">
        /// <summary>
        /// Gets a <see cref="T:Cake.Common.Build.BitbucketPipelines.BitbucketPipelinesProvider" /> instance that can be used to
        /// obtain information from the Bitbucket Pipelines environment.
        /// </summary>
        /// <example>
        /// <code>
        /// var isBitbucketPipelinesBuild = BitbucketPipelines.IsRunningOnBitbucketPipelines;
        /// </code>
        /// </example>
        /// <returns>A <see cref="N:Cake.Common.Build.BitbucketPipelines" /> instance.</returns>
        /// </member>
        public static global::Cake.Common.Build.BitbucketPipelines.IBitbucketPipelinesProvider BitbucketPipelines
            => _BitbucketPipelines ??= global::Cake.Common.Build.BuildSystemAliases.BitbucketPipelines(Context);

        /// <member name="M:Cake.Common.Build.BuildSystemAliases.GoCD(Cake.Core.ICakeContext)">
        /// <summary>
        /// Gets a <see cref="T:Cake.Common.Build.GoCD.GoCDProvider" /> instance that can be used to
        /// obtain information from the Go.CD environment.
        /// </summary>
        /// <example>
        /// <code>
        /// var isGoCDBuild = GoCD.IsRunningOnGoCD;
        /// </code>
        /// </example>
        /// <returns>A <see cref="N:Cake.Common.Build.GoCD" /> instance.</returns>
        /// </member>
        public static global::Cake.Common.Build.GoCD.IGoCDProvider GoCD
            => _GoCD ??= global::Cake.Common.Build.BuildSystemAliases.GoCD(Context);

        /// <member name="M:Cake.Common.Build.BuildSystemAliases.GitLabCI(Cake.Core.ICakeContext)">
        /// <summary>
        /// Gets a <see cref="T:Cake.Common.Build.GitLabCI.GitLabCIProvider" /> instance that can be used to
        /// obtain information from the GitLab CI environment.
        /// </summary>
        /// <example>
        /// <code>
        /// var isGitLabCIBuild = GitLabCI.IsRunningOnGitLabCI;
        /// </code>
        /// </example>
        /// <returns>A <see cref="N:Cake.Common.Build.GitLabCI" /> instance.</returns>
        /// </member>
        public static global::Cake.Common.Build.GitLabCI.IGitLabCIProvider GitLabCI
            => _GitLabCI ??= global::Cake.Common.Build.BuildSystemAliases.GitLabCI(Context);

        /// <member name="M:Cake.Common.Build.BuildSystemAliases.GitHubActions(Cake.Core.ICakeContext)">
        /// <summary>
        /// Gets a <see cref="T:Cake.Common.Build.GitHubActions.GitHubActionsProvider" /> instance that can be used to
        /// obtain information from the GitHub Actions environment.
        /// </summary>
        /// <example>
        /// <code>
        /// var isGitHubActionsBuild = GitHubActions.IsRunningOnGitHubActions;
        /// </code>
        /// </example>
        /// <returns>A <see cref="N:Cake.Common.Build.GitHubActions" /> instance.</returns>
        /// </member>
        public static global::Cake.Common.Build.GitHubActions.IGitHubActionsProvider GitHubActions
            => _GitHubActions ??= global::Cake.Common.Build.BuildSystemAliases.GitHubActions(Context);

        /// <member name="M:Cake.Common.Build.BuildSystemAliases.AzurePipelines(Cake.Core.ICakeContext)">
        /// <summary>
        /// Gets a <see cref="T:Cake.Common.Build.AzurePipelines.AzurePipelinesProvider" /> instance that can be used to
        /// obtain information from the Azure Pipelines environment.
        /// </summary>
        /// <example>
        /// <code>
        /// var isAzurePipelines = AzurePipelines.IsRunningOnAzurePipelines;
        /// </code>
        /// </example>
        /// <returns>A <see cref="N:Cake.Common.Build.AzurePipelines" /> instance.</returns>
        /// </member>
        public static global::Cake.Common.Build.AzurePipelines.IAzurePipelinesProvider AzurePipelines
            => _AzurePipelines ??= global::Cake.Common.Build.BuildSystemAliases.AzurePipelines(Context);

    }

}
