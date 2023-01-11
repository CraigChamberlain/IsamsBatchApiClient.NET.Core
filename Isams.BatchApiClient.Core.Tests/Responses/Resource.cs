namespace Isams.BatchApiClient.Tests
{

    public struct Resource
    {
        public Resource(string url, string file, string filter = "", bool requiresFilter = false)
        {
            Url = url;
            File = file;
            Filter = filter;
            RequiresFilter = requiresFilter;
        }
        public readonly string Url { get; }
        public readonly string File { get; }
        public readonly string Filter { get; }
        public readonly bool RequiresFilter { get; }


    }
}