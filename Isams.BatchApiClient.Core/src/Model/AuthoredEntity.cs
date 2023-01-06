public abstract class AuthoredEntity : DatedEntity
{
    /// <summary>
    /// The user code of the last user to update or create this record.
    /// </summary>
    public string Author { get; set; }
}
