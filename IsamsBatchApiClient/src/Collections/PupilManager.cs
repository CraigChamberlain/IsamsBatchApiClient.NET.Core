using System.Xml.Serialization;

namespace IsamsBatchApiClient.Collections
{
    /// <summary>
    /// The Student Manager module is a standard module that is present on all systems by default.
    /// </summary>
    public class PupilManager
    {
        /// <summary>
        /// A collection of current students which are managed through the Student Manager module [iSAMS_STUDENTMANAGEMENT].
        /// </summary>
        [XmlArrayItem(
                ElementName = "Pupil",
                IsNullable = true,
                Type = typeof(Model.PupilManager.PupilManagerCurrentPupil))]
        public Model.PupilManager.PupilManagerCurrentPupil[] CurrentPupils { get; set; }


        /// <summary>
        /// A collection of applicants or new students which are managed through the Student Manager module [iSAMS_STUDENTMANAGEMENT].
        /// </summary>
        [XmlArrayItem(
                ElementName = "Pupil",
                IsNullable = true,
                Type = typeof(Model.PupilManager.PupilManagerApplicant))]
        public Model.PupilManager.PupilManagerApplicant[] Applicants { get; set; }


        /// <summary>
        /// A collection of former students or alumni which are managed through the Student Manager module [iSAMS_STUDENTMANAGEMENT].
        /// </summary>
        [XmlArrayItem(
                ElementName = "Pupil",
                IsNullable = true,
                Type = typeof(Model.PupilManager.PupilManagerAlumni))]
        public Model.PupilManager.PupilManagerAlumni[] Alumni { get; set; }

        /// <summary>
        /// A collection of students' siblings which are managed through the Student Manager module [iSAMS_STUDENTMANAGEMENT].
        /// </summary>
        // TODO problem, passports on the same namespace!!
        [XmlArrayItem(
                ElementName = "Pupil",
                IsNullable = true,
                Type = typeof(Model.PupilManager.SiblingsPupil))]
        [XmlArray(ElementName = "Pupils")]
        public Model.PupilManager.SiblingsPupil[] Siblings { get; set; }

    }
}