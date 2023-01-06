using System.Collections.Generic;
using System.Xml.Serialization;

namespace Isams.BatchApiClient.Core.Model.PupilManager
{
    /// <summary>
    /// A student.
    /// </summary>
    // TODO should not be confused with PassportPupil.  Could use a custom deserialiser?  ISAMS have made a mess of the API and it is broken.
    public class SiblingsPupil : AuthoredEntityWithAuthorID
    {

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
        public List<Sibling> Siblings { get; set; }
    }
}