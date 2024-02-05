namespace HomeLibraryApp.Entities
{
    public class EBooks : Books
    {
        public override string ToString() => base.ToString() + " (E-Book)";
    }
}
