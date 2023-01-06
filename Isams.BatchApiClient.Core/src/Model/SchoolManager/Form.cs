using System.Xml.Serialization;

namespace Isams.BatchApiClient.Core.Model.SchoolManager
{
    public class Form
    {
        /// <summary>
        /// The auto-generated Id of the last user to update or create this record.
        /// </summary>
        [XmlAttribute]
        public int AuthorId { get; set; }

        /// <summary>
        /// The name of this form.
        /// </summary>
        [XmlAttribute]
        public string Id { get; set; }

        /// <summary>
        /// The auto-generated Id of the associated staff member who is tutor of this form.
        /// </summary>
        [XmlAttribute]
        public int TutorId { get; set; }

        /// <summary>
        /// The auto-generated Id of the associated staff member who is assistant tutor of this form.
        /// </summary>
        // TODO check this ever works
        [XmlAttribute]
        public int AssistantTutorId { get; set; }

        /// <summary>
        /// Undocumented: The auto-generated Id of the associated staff member who is the 2nd assistant tutor of this form.
        /// </summary>
        [XmlAttribute]
        public int SecondAssistantTutorId { get; set; }

        /// <summary>
        /// The static Id of the associated National Curriculum Year.
        /// </summary>
        [XmlAttribute]
        public int YearId { get; set; }

        /// <summary>
        /// The auto-generated Id of the associated room.
        /// </summary>
        // TODO Has Legacy Node too.
        [XmlAttribute]
        public int RoomId { get; set; }

        /// <summary>
        /// The name of this form.
        /// </summary>
        [XmlElement(ElementName = "Form")]
        public string Name { get; set; }

        /// <summary>
        /// The user code of the associated staff member who is tutor of this form.
        /// </summary>
        [System.Obsolete("Use TutorId")]
        public string Tutor { get; set; }

        /// <summary>
        /// The user code of the associated staff member who is assistant tutor of this form.
        /// </summary>
        // [System.Obsolete("Use TutorId")]
        // public string AssistantFormTutor { get; set; }

        /// <summary>
        /// The user code of the associated staff member who is second assistant tutor of this form.
        /// </summary>
        // [System.Obsolete("Use SecondAssistantTutorId")]
        //        public string SecondAssistantFormTutor { get; set; }

        /// <summary>
        /// The static Id of the associated National Curriculum Year.
        /// </summary>
        // [System.Obsolete("Use YearId")]
        // public int NationalCurriculumYear { get; set; }

        /// <summary>
        /// The user code of the last user to update or create this record.
        /// </summary>
        // [System.Obsolete("Use related Author Object via AuthorId")]
        // public string Author { get; set; }

        // Todo update docs and delete commented code

        /// <summary>
        /// The email address of this form.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// The website for this form.
        /// </summary>
        public string Website { get; set; }

        /// <summary>
        /// The date and time that the record was last updated by the author.
        /// </summary>
        public System.DateTime LastUpdated { get; set; }
    }
}