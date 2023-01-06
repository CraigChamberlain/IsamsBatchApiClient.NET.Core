using System.Collections.Generic;
using System.Xml.Serialization;

namespace Isams.BatchApiClient.Core.Collections
{
    /// <summary>
    /// The HR Manager module is a standard module that is present on all systems by default.
    /// </summary>
    public class HRManager
    {
        /// <summary>
        /// A collection of current staff which are managed through the HR Manager module [iSAMS_HRMANAGER].
        /// </summary>
        [XmlArrayItem(
            ElementName = "StaffMember",
            IsNullable = true,
            Type = typeof(Model.HRManager.StaffMember))]
        public List<Model.HRManager.StaffMember> CurrentStaff { get; set; }
    }
}
