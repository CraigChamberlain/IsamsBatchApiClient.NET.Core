using System.Xml.Serialization;

namespace Isams.BatchApiClient.Core.Collections
{
    /// <summary>
    /// The School Manager module is a standard module that is present on all systems by default.
    /// </summary>
    public class SchoolManager
    {
        /// <summary>
        /// A collection of academic houses which are managed through the School Manager module [iSAMS_SCHOOLMANAGEMENT].
        /// </summary>
        public Model.SchoolManager.House[] AcademicHouses { get; set; }

        /// <summary>
        /// A collection of year groups which are managed through the School Manager module [iSAMS_SCHOOLMANAGEMENT].
        /// </summary>
        public Model.SchoolManager.Year[] Years { get; set; }

        /// <summary>
        /// A collection of boarding houses which are managed through the School Manager module [iSAMS_SCHOOLMANAGEMENT].
        /// </summary>
        public Model.SchoolManager.House[] BoardingHouses { get; set; }

        /// <summary>
        /// A collection of pastoral tutors which are managed through the School Manager module [iSAMS_SCHOOLMANAGEMENT].
        /// </summary>
        [XmlArrayItem(
                ElementName = "StaffMember",
                IsNullable = true,
                Type = typeof(Model.SchoolManager.StaffMemberId))]
        public Model.SchoolManager.StaffMemberId[] PastoralTutors { get; set; }

        /// <summary>
        /// A collection of school divisions which are managed through the School Manager module [iSAMS_SCHOOLMANAGEMENT].
        /// </summary>
        public Model.SchoolManager.SchoolDivision[] SchoolDivisions { get; set; }

        /// <summary>
        /// A collection of school forms which are managed through the School Manager module [iSAMS_SCHOOLMANAGEMENT].
        /// </summary>
        public Model.SchoolManager.Form[] Forms { get; set; }

        /// <summary>
        /// A collection of school terms which are managed through the School Manager module [iSAMS_SCHOOLMANAGEMENT].
        /// </summary>
        public Model.SchoolManager.Term[] Terms { get; set; }
    }
}