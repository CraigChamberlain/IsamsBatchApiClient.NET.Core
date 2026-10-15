using System;

namespace IsamsBatchApiClient.Model.PupilManager
{
    /// <summary>
    /// An applicant.
    /// </summary>
    public class PupilManagerApplicant : PupilManagerPupil
    {
        /// <summary>
        /// The current admissions status of this applicant.
        /// </summary>
        public string AdmissionsStatus { get; set; }

        /// <summary>
        /// The school year in which this applicant will enrol with the school.
        /// </summary>
        public int EnrolmentSchoolYear { get; set; }

        /// <summary>
        /// The NC year in which this applicant will enrol with the school.
        /// </summary>
        public int EnrolmentNCYear { get; set; }

        /// <summary>
        /// The date when this applicant will enrol with the school.
        /// </summary>
        public DateTime EnrolmentDate { get; set; }

        /// <summary>
        /// The term in which this applicant will enrol with the school.
        /// </summary>
        public string EnrolmentTerm { get; set; }


        /// <summary>
        /// The date when this applicant registered with the school.
        /// </summary>
        public DateTime RegisteredDate { get; set; }
        
        /// <summary>
        /// Specifies whether the applicant is a re-admission.
        /// </summary>
        public bool IsReAdmission { get; set; }

        /// <summary>
        /// The auto-generated Id of the current school of this applicant.
        /// </summary>
        public int CurrentSchoolId { get; set; }
    }
}