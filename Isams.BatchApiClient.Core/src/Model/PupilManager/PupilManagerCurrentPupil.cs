using System;
using System.Xml.Serialization;

namespace Isams.BatchApiClient.Core.Model.PupilManager
{
    /// <summary>
    /// A current student record managed through the Student Manager module.
    /// </summary>
    public class PupilManagerCurrentPupil : PupilManagerInitialisedPupil
    {
        /// <summary>
        /// The auto-generated Id of the associated division.
        /// </summary>
        [XmlAttribute]
        public int DivisionId { get; set; }

        /// <summary>
        /// The auto-generated Id of the associated academic house.
        /// </summary>
        [XmlAttribute]
        public int AcademicHouseId { get; set; }

        /// <summary>
        /// The auto-generated Id of the associated boarding house.
        /// </summary>
        [XmlAttribute]
        public int BoardingHouseId { get; set; }

        /// <summary>
        /// The school year in which this student was enrolled at this school which is a numeric value.
        /// </summary>
        public int EnrolmentSchoolYear { get; set; }

        /// <summary>
        /// The date in which this student was enrolled at this school.
        /// </summary>
        public DateTime EnrolmentDate { get; set; }

        /// <summary>
        /// The term in which this student was enrolled at this school.
        /// </summary>
        public string EnrolmentTerm { get; set; }

        /// <summary>
        /// The academic house of this student.
        /// </summary>
        public string AcademicHouse { get; set; }

        /// <summary>
        /// The boarding house of this student.
        /// </summary>
        public string BoardingHouse { get; set; }

        /// <summary>
        /// The form of this student.
        /// </summary>
        public string Form { get; set; }

        /// <summary>
        /// The static Id of the National Curriculum Year of this student.
        /// </summary>
        public int NCYear { get; set; }

        /// <summary>
        /// The first division associated with this student's National Curriculum Year.
        /// </summary>
        public string DivisionName { get; set; }

        /// <summary>
        /// The personal mobile number of this student.
        /// </summary>
        public string MobileNumber { get; set; }

        /// <summary>
        /// The type of student.
        /// </summary>
        public string PupilType { get; set; }

        /// <summary>
        /// A comma-separated list of nationalities of the student, ordered by priority.
        /// </summary>
        public string Nationalities { get; set; }

        /// <summary>
        /// A comma-separated list of languages of the student, ordered by priority.
        /// </summary>
        public string Languages { get; set; }

        /// <summary>
        /// The user code of this student's tutor.
        /// </summary>
        public string Tutor { get; set; }
    }
}