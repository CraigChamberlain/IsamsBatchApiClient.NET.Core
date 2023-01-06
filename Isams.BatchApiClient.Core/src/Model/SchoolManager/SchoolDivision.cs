using System.Collections.Generic;
using System.Xml.Serialization;

namespace Isams.BatchApiClient.Core.Model.SchoolManager
{
    public class SchoolDivision : AuthoredEntity
    {
        /// <summary>
        /// The name of this division.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A short code for this division.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// A collection of school years associated with a school division.
        /// </summary>
        [XmlArrayItem(
            ElementName = "Year",
            IsNullable = true,
            Type = typeof(Model.SchoolManager.MinimalYear))]
        public List<MinimalYear> Years { get; set; }
    }
}