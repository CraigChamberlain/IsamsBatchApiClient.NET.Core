using System.Xml.Serialization;

namespace Isams.BatchApiClient.Core.Model.SchoolManager
{
    public class MinimalYear : AuthoredEntity
    {
        /// <summary>
        /// The static Id of the associated National Curriculum Year.
        /// </summary>
        [XmlAttribute]
        public int YearId { get; set; }

        /// <summary>
        /// The static Id of the associated National Curriculum Year.
        /// </summary>
        // TODO docs do not mention depricated
        // [Obsolete("Use YearId Instead")]
        // public int NationalCurriculumYear { get; set; }
        // TODO update docs and delete commented code.
    }
}