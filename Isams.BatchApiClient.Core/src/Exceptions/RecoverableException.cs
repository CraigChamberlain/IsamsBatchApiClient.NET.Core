using System;

namespace Isams.BatchApiClient.Core.Errors
{
    /// <summary>
    /// Recoverable error.
    /// </summary>
    public class RecoverableException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecoverableException"/> class.
        /// </summary>
        public RecoverableException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecoverableException"/> class.
        /// </summary>
        /// <param name="title">e.g. "Unknown Error".</param>
        /// <param name="description">e.g. "Transaction (Process ID 118) was deadlocked on lock resources with another process and has been chosen as the deadlock victim. Rerun the transaction.".</param>
        public RecoverableException(string title, string description)
            : base($"{title}:{System.Environment.NewLine}{description}")
        {
        }
    }
}