using System;


namespace R5T.Z0036
{
    public class CommitMessages : ICommitMessages
    {
        #region Infrastructure

        public static ICommitMessages Instance { get; } = new CommitMessages();


        private CommitMessages()
        {
        }

        #endregion
    }
}
