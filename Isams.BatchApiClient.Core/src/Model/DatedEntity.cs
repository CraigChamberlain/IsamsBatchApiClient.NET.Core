using System;

public abstract class DatedEntity : Entity
{
    /// <summary>
    /// The date and time that the record was last updated by the author.
    /// </summary>
    public DateTime LastUpdated { get; set; }
}
