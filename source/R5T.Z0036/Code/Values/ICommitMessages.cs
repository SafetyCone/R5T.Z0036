using System;

using R5T.T0131;
using R5T.T0188;
using R5T.T0188.Extensions;


namespace R5T.Z0036
{
    /// <summary>
    /// Commit messages are written in the sense of _Strings.
    /// </summary>
    [ValuesMarker]
    public partial interface ICommitMessages : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        public Z000.ICommitMessages _Strings => Z000.CommitMessages.Instance;
#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Z000.ICommitMessages.AddGitIgnoreFile"/>
        public ICommitMessage AddGitIgnoreFile => _Strings.AddGitIgnoreFile.ToCommitMessage();

        /// <inheritdoc cref="Z000.ICommitMessages.AddInitialSolution"/>
        public ICommitMessage AddInitialSolution => _Strings.AddInitialSolution.ToCommitMessage();

        /// <inheritdoc cref="Z000.ICommitMessages.InitialCommit"/>
        public ICommitMessage InitialCommit => _Strings.InitialCommit.ToCommitMessage();

        /// <inheritdoc cref="Z000.ICommitMessages.InitialSourceStubCommit"/>
        public ICommitMessage InitialSourceStubCommit => _Strings.InitialSourceStubCommit.ToCommitMessage();

        /// <inheritdoc cref="Z000.ICommitMessages.InterimChanges"/>
        public ICommitMessage InterimChanges => _Strings.InterimChanges.ToCommitMessage();

        /// <inheritdoc cref="Z000.ICommitMessages.RemoveExtraneousFilesDueToMissingGitIgnore"/>
        public ICommitMessage RemoveExtraneousFilesDueToMissingGitIgnore => _Strings.RemoveExtraneousFilesDueToMissingGitIgnore.ToCommitMessage();


        /// <inheritdoc cref="Z000.ICommitMessages.ChangeProjectToNet6"/>
        public ICommitMessage ChangeProjectToNet6 => _Strings.ChangeProjectToNet6.ToCommitMessage();

        /// <inheritdoc cref="Z000.ICommitMessages.ChangeProjectToNetStandard2_0"/>
        public ICommitMessage ChangeProjectToNetStandard2_0 => _Strings.ChangeProjectToNetStandard2_0.ToCommitMessage();

        /// <inheritdoc cref="Z000.ICommitMessages.ChangeProjectToNetStandard2_1"/>
        public ICommitMessage ChangeProjectToNetStandard2_1 => _Strings.ChangeProjectToNetStandard2_1.ToCommitMessage();

        /// <inheritdoc cref="Z000.ICommitMessages.UpgradeSolutionFileToVS2022"/>
        public ICommitMessage UpgradeSolutionFileToVS2022 => _Strings.UpgradeSolutionFileToVS2022.ToCommitMessage();
    }
}
