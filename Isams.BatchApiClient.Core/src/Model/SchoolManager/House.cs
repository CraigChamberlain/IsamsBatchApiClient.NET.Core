using System.Xml.Serialization;

namespace Isams.BatchApiClient.Core.Model.SchoolManager
{
    /// <summary>
    /// A house.
    /// </summary>
    public class House : Entity
    {
        /// <summary>
        /// The auto-generated Id of the house master.
        /// </summary>
        [XmlAttribute]
        public int HouseMasterId { get; set; }

        /// <summary>
        /// The auto-generated Id of the assistant house master.
        /// </summary>
        [XmlAttribute]
        public int AssistantHouseMasterId { get; set; }

        /// <summary>
        /// The user code of the house master.
        /// </summary>
        public string HouseMaster { get; set; }

        /// <summary>
        /// The user code of the assistant house master.
        /// </summary>
        public string AssistantHouseMaster { get; set; }

        /// <summary>
        /// The name of this house.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A short code for this house.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// The type of this house.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The genders for this house.
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        /// The first line of the address.
        /// </summary>
        public string Address1 { get; set; }

        /// <summary>
        /// The second line of the address.
        /// </summary>
        public string Address2 { get; set; }

        /// <summary>
        /// The third line of the address.
        /// </summary>
        public string Address3 { get; set; }

        /// <summary>
        /// The town where this house is located.
        /// </summary>
        public string Town { get; set; }

        /// <summary>
        /// The county where this house is located.
        /// </summary>
        public string County { get; set; }

        /// <summary>
        /// The country where this house is located.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// The postcode of this house.
        /// </summary>
        public string Postcode { get; set; }

        /// <summary>
        /// The telephone number for this house.
        /// </summary>
        public string Telephone { get; set; }

        /// <summary>
        /// The fax number for this house.
        /// </summary>
        public string Fax { get; set; }

        /// <summary>
        /// The primary email address for this house.
        /// </summary>
        public string PrimaryEmail { get; set; }

        /// <summary>
        /// The secondary email address for this house.
        /// </summary>
        public string SecondaryEmail { get; set; }

        /// <summary>
        /// The website for this house.
        /// </summary>
        public string Website { get; set; }

        /// <summary>
        /// House Tutor 1.
        /// </summary>
        public string Tutor1 { get; set; }

        /// <summary>
        /// House Tutor 2.
        /// </summary>
        public string Tutor2 { get; set; }

        /// <summary>
        /// House Tutor 3.
        /// </summary>
        public string Tutor3 { get; set; }

        /// <summary>
        /// House Tutor 4.
        /// </summary>
        public string Tutor4 { get; set; }

        /// <summary>
        /// House Tutor 5.
        /// </summary>
        public string Tutor5 { get; set; }

        /// <summary>
        /// House Tutor 6.
        /// </summary>
        public string Tutor6 { get; set; }

        /// <summary>
        /// House Tutor 7.
        /// </summary>
        public string Tutor7 { get; set; }

        /// <summary>
        /// House Tutor 8.
        /// </summary>
        public string Tutor8 { get; set; }
    }
}