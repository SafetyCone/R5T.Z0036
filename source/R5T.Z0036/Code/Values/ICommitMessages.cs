using System;

using R5T.T0131;
using R5T.T0188;
using R5T.T0188.Extensions;


namespace R5T.Z0036
{
    /// <summary>
    /// Commit messages are written in the sense of "This commit will X".
    /// </summary>
    [ValuesMarker]
    public partial interface ICommitMessages : IValuesMarker
    {
        public ICommitMessage AddGitIgnoreFile => "Add .gitignore file.".ToCommitMessage();
        public ICommitMessage AddInitialSolution => "Add initial solution.".ToCommitMessage();
        // Ok, message does not follow "This commit will X" format.
        public ICommitMessage InitialCommit => "Initial commit.".ToCommitMessage();
        // Ok, message does not follow "This commit will X" format.
        public ICommitMessage InitialSourceStubCommit => "Initial commit of source-stub.".ToCommitMessage();
        // Ok, message does not follow "This commit will X" format.
        public ICommitMessage InterimChanges => "Interim changes.".ToCommitMessage();
        public ICommitMessage RemoveExtraneousFilesDueToMissingGitIgnore => "Remove extraneous files that should have been ignored, due to a missing .gitignore file.".ToCommitMessage();

        public ICommitMessage ChangeProjectToNet6 => "Changed project to .NET 6.".ToCommitMessage();
        public ICommitMessage ChangeProjectToNetStandard2_0 => "Change project to .NET Standard 2.0.".ToCommitMessage();
        public ICommitMessage ChangeProjectToNetStandard2_1 => "Change project to .NET Standard 2.1.".ToCommitMessage();
        public ICommitMessage UpgradeSolutionFileToVS2022 => "Upgrade solution file to Visual Studio 2022.".ToCommitMessage();
    }
}
