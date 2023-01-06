using System;

namespace Isams.BatchApiClient.Core.Model.SchoolManager
{
    /// <summary>
    /// A term.
    /// </summary>
    public class Term : AuthoredEntityIdOnly
    {
        /// <summary>
        /// The year of this school term.
        /// </summary>
        public int SchoolYear { get; set; }

        /// <summary>
        /// The name of this school term.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The start date of this school term.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// The end date of this school term.
        /// </summary>
        public DateTime FinishDate { get; set; }
    }
}