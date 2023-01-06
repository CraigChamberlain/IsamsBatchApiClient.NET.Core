using System;
using System.Xml.Serialization;

namespace Isams.BatchApiClient.Core.Model.PupilManager
{
    /// <summary>
    /// A base calss for Applicants, Alumni and Current Pupils.
    /// </summary>
    public abstract class PupilManagerPupil : Entity
    {
        /// <summary>
        /// The auto-generated GUID of the person.
        /// </summary>
        [XmlAttribute]
        public string PersonGuid { get; set; }

        /// <summary>
        /// The Unique Pupil Number (UPN) is a number that identifies each learner in England.
        /// </summary>
        public string UPN { get; set; }

        /// <summary>
        /// The unique school identity of this student.
        /// </summary>
        public string SchoolId { get; set; }

        /// <summary>
        /// The title of this student.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The forename of this student.
        /// </summary>
        public string Forename { get; set; }

        /// <summary>
        /// The surname of this student.
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// The middle names of this student.
        /// </summary>
        public string Middlename { get; set; }

        /// <summary>
        /// The initials of this student.
        /// </summary>
        public string Initials { get; set; }

        /// <summary>
        /// The preferred forename of this student.
        /// </summary>
        public string Preferredname { get; set; }

        /// <summary>
        /// The full name of this student.
        /// </summary>
        public string Fullname { get; set; }

        /// <summary>
        /// The gender of this student.
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// The date of birth of this student which is in DateTime format.
        /// </summary>
        public DateTime DOB { get; set; }

        /// <summary>
        /// The auto-generated Id of the associated family members.
        /// </summary>
        public int FamilyId { get; set; }

        /// <summary>
        /// This optional field is used by some schools to specify an internal school identifier.
        /// </summary>
        public string SchoolCode { get; set; }

        /// <summary>
        /// The ethnicity of this student.
        /// </summary>
        public string Ethnicity { get; set; }
    }
}