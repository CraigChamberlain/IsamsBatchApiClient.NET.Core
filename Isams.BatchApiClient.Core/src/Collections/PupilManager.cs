using System.Xml.Serialization;

namespace Isams.BatchApiClient.Core.Collections
{
    /// <summary>
    /// The Student Manager module is a standard module that is present on all systems by default. This method is currently restricted to Home contacts only.
    /// </summary>
    public class PupilManager
    {
        /// <summary>
        /// A collection of health records for current students which are managed through the Student Manager module [iSAMS_STUDENTMANAGEMENT].
        /// </summary>
        [XmlArrayItem(
                ElementName = "Pupil",
                IsNullable = true,
                Type = typeof(Model.PupilManager.PupilManagerCurrentPupil))]
        public Model.PupilManager.PupilManagerCurrentPupil[] CurrentPupils { get; set; }

        /// <summary>
        /// A collection of students' siblings which are managed through the Student Manager module [iSAMS_STUDENTMANAGEMENT].
        /// </summary>
        // TODO problem, double use of pupil!!
        [XmlArrayItem(
                ElementName = "Pupil",
                IsNullable = true,
                Type = typeof(Model.PupilManager.SiblingsPupil))]
        [XmlArray(ElementName = "Pupils")]
        public Model.PupilManager.SiblingsPupil[] SiblingsAndPassports { get; set; }

    }
}