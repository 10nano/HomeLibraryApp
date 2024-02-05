namespace HomeLibraryApp.Entities
{
    public class EBook : Book
    {
        public override string ToString() => base.ToString() + " (E-Book)";
    }
}
