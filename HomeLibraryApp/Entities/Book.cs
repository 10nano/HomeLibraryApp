namespace HomeLibraryApp.Entities
{
    public class Book : EntityBase 
    {
        public long Id { get; set; } 
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Author { get; set; }
        //public long AuthorId { get; set; }
        public string? AuthorName { get; set; }
        public string? AuthorDescription { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Title: {Title}";
        }
    }
}
