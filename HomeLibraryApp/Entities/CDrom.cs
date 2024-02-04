namespace HomeLibraryApp.Entities
{
    public class CDrom
    {
        public long Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Author { get; set; }
        public string? Url { get; set; }

        public override string ToString() => $"Id: {Id}, Name: {Title} (CDrom)";
    }
}
