using System;

namespace IsamsBatchApiClient.Model.PupilManager
{
    /// <summary>
    /// Base Class for Alumni and Current Pupils.
    /// </summary>
    public abstract class PupilManagerInitialisedPupil : PupilManagerPupil
    {
        /// <summary>
        /// The email address of this student.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// The reason for leaving.
        /// </summary>
        public string LeavingReason { get; set; }

        /// <summary>
        /// The date this student left school.
        /// </summary>
        public DateTime LeavingDate { get; set; }

        /// <summary>
        /// The auto-generated Id of the future school.
        /// </summary>
        public int FutureSchoolId { get; set; }

        /// <summary>
        /// The future school type.
        /// </summary>
        public string FutureSchoolType { get; set; }

        

    }
}