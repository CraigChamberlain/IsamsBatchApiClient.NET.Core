using System.Xml.Serialization;

namespace Isams.BatchApiClient.Core.Model.SchoolManager
{
    /// <summary>
    /// A year.
    /// </summary>
    public class Year : AuthoredEntityIdOnly
    {
        /// <summary>
        /// The auto-generated Id of the associated staff member who is tutor of this year.
        /// </summary>
        [XmlAttribute]
        public int TutorId { get; set; }

        /// <summary>
        /// The auto-generated Id of the associated staff member who is assistant tutor of this year.
        /// </summary>
        [XmlAttribute]
        public int AssistantTutorId { get; set; }

        /// <summary>
        /// The static Id of the associated National Curriculum Year.
        /// </summary>
        public int NationalCurriculumYear { get; set; }

        /// <summary>
        /// The user code of the associated staff member who is tutor of this year.
        /// </summary>
        public string Tutor { get; set; }

        /// <summary>
        /// The user code of the associated staff member who is assistant tutor of this year.
        /// </summary>
        public string AssistantTutor { get; set; }

        /// <summary>
        /// The name of this year.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A short code for this year.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// The email address for this year.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The website for this year.
        /// </summary>
        public string Website { get; set; }
    }
}