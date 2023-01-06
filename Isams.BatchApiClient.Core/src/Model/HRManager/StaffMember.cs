using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Isams.BatchApiClient.Core.Model.HRManager
{
    public class StaffMember : Entity
    {
        /// <summary>
        /// The auto-generated Id of the person.
        /// </summary>
        [XmlAttribute]
        public int PersonId { get; set; }

        /// <summary>
        /// The auto-generated GUID of the person.
        /// </summary>
        [XmlAttribute]
        public string PersonGuid { get; set; }

        /// <summary>
        /// The previous Management Information System identity of this staff member.
        /// </summary>
        public string PreviousMISId { get; set; }

        /// <summary>
        /// The school initials of this staff member.
        /// </summary>
        public string Initials { get; set; }

        /// <summary>
        /// The user code of this staff member.
        /// </summary>
        public string UserCode { get; set; }

        /// <summary>
        /// The username of this staff member.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// The title of this staff member.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The forename of this staff member.
        /// </summary>
        public string Forename { get; set; }

        /// <summary>
        /// The middle names of this staff member.
        /// </summary>
        public string MiddleNames { get; set; }

        /// <summary>
        /// The surname of this staff member.
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// The full name of this staff member.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// The initials of this staff member.
        /// </summary>
        public string NameInitials { get; set; }

        /// <summary>
        /// The preferred forename of this staff member.
        /// </summary>
        public string PreferredName { get; set; }

        /// <summary>
        /// The school salutation for this staff member.
        /// </summary>
        public string Salutation { get; set; }

        /// <summary>
        /// The date of birth of this staff member.
        /// </summary>
        public DateTime DOB { get; set; }

        /// <summary>
        /// The gender of this staff member, specified as a single character string.
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// The school email address of this staff member.
        /// </summary>
        public string SchoolEmailAddress { get; set; }

        /// <summary>
        /// The school mobile number of this staff member.
        /// </summary>
        public string SchoolMobileNumber { get; set; }

        /// <summary>
        /// The personal mobile number of this staff member.
        /// </summary>
        public string PersonalMobileNumber { get; set; }

        /// <summary>
        /// Specifies whether this staff member is a teaching member of staff.
        /// </summary>
        public bool TeachingStaff { get; set; }

        /// <summary>
        /// The leaving date for this staff member.
        /// </summary>
        public DateTime LeavingDate { get; set; }

        /// <summary>
        /// A collection of school roles associated with a staff member.
        /// </summary>
        public List<Role> Roles { get; set; }

        /// <summary>
        /// A collection of school divisions associated with a staff member.
        /// </summary>
        public List<Division> Divisions { get; set; }
    }
}