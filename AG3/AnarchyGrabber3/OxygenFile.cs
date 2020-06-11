namespace yikes
{
    public class OxygenFile
    {
        public string Path { get; set; }
        public string Contents { get; set; }

        public OxygenFile(string path, string contents)
        {
            Path = path;
            Contents = contents;
        }
    }
}
