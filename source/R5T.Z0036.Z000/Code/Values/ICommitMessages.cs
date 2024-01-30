using System;

using R5T.T0131;


namespace R5T.Z0036.Z000
{
    [ValuesMarker]
    public partial interface ICommitMessages : IValuesMarker
    {
        /// <summary>
        /// <para><value>Add .gitignore file.</value></para>
        /// </summary>
        public string AddGitIgnoreFile => "Add .gitignore file.";

        /// <summary>
        /// <para><value>Add initial solution.</value></para>
        /// </summary>
        public string AddInitialSolution => "Add initial solution.";

        /// <summary>
        /// <para><value>Initial commit.</value></para>
        /// </summary>
        public string InitialCommit => "Initial commit.";

        /// <summary>
        /// <para><value>Initial commit of source-stub.</value></para>
        /// </summary>
        public string InitialSourceStubCommit => "Initial commit of source-stub.";

        /// <summary>
        /// <para><value>Interim changes.</value></para>
        /// </summary>
        public string InterimChanges => "Interim changes.";

        /// <summary>
        /// <para><value>Remove extraneous files that should have been ignored, due to a missing .gitignore file.</value></para>
        /// </summary>
        public string RemoveExtraneousFilesDueToMissingGitIgnore => "Remove extraneous files that should have been ignored, due to a missing .gitignore file.";


        /// <summary>
        /// <para><value>Changed project to .NET 6.</value></para>
        /// </summary>
        public string ChangeProjectToNet6 => "Changed project to .NET 6.";

        /// <summary>
        /// <para><value>Change project to .NET Standard 2.0.</value></para>
        /// </summary>
        public string ChangeProjectToNetStandard2_0 => "Change project to .NET Standard 2.0.";

        /// <summary>
        /// <para><value>Change project to .NET Standard 2.1.</value></para>
        /// </summary>
        public string ChangeProjectToNetStandard2_1 => "Change project to .NET Standard 2.1.";

        /// <summary>
        /// <para><value>Upgrade solution file to Visual Studio 2022.</value></para>
        /// </summary>
        public string UpgradeSolutionFileToVS2022 => "Upgrade solution file to Visual Studio 2022.";
    }
}
