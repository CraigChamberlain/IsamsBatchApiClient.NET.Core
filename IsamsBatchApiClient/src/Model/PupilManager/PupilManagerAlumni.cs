using System;

namespace IsamsBatchApiClient.Model.PupilManager
{
    /// <summary>
    /// A former student.
    /// </summary>
    public class PupilManagerAlumni : PupilManagerInitialisedPupil
    {

        /// <summary>
        /// The term in which this student left school.
        /// </summary>
        public string LeavingTerm { get; set; }

        /// <summary>
        /// The school year in which this student left school which is a numeric value.
        /// </summary>
        public int LeavingSchoolYear { get; set; }

        /// <summary>
        /// The academic house of this student when they left school.
        /// </summary>
        public string LeavingAcademicHouse { get; set; }

        /// <summary>
        /// The boarding house of this student when they left school.
        /// </summary>
        public string LeavingBoardingHouse { get; set; }
    }
}