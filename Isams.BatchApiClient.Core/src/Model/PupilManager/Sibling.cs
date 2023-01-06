using System.Xml.Serialization;

namespace Isams.BatchApiClient.Core.Model.PupilManager
{
    /// <summary>
    /// A sibling of a student.
    /// </summary>
    public class Sibling : AuthoredEntityWithAuthorID
    {
        /// <summary>
        /// The auto-generated Id of the sibling.
        /// </summary>
        [XmlAttribute]
        public int PupilId { get; set; }

        /// <summary>
        /// The auto-generated GUID of the person.
        /// </summary>
        [XmlAttribute]
        public string PersonGuid { get; set; }

        /// <summary>
        /// The status of this student at the school, such as Current, Former, etc.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// A collection of student siblings associated with a student.
        /// </summary>
        public string SchoolId { get; set; }
    }
}