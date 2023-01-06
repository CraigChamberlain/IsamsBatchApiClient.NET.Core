using System.Xml.Serialization;

namespace Isams.BatchApiClient.Core.Collections
{
    public class Isams
    {
        public PupilManager PupilManager { get; set; }

        public HRManager HRManager { get; set; }

        public SchoolManager SchoolManager { get; set; }
    }
}