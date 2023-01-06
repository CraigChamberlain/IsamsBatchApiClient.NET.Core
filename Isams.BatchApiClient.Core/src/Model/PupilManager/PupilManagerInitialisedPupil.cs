namespace Isams.BatchApiClient.Core.Model.PupilManager
{
    /// <summary>
    /// Base Class for Alumni and Current Pupils.
    /// </summary>
    public abstract class PupilManagerInitialisedPupil : PupilManagerPupil
    {
        /// <summary>
        /// The user code of this student.
        /// </summary>
        public string UserCode { get; set; }

        /// <summary>
        /// The username of this student.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// The email address of this student.
        /// </summary>
        public string EmailAddress { get; set; }
    }
}