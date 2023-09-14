namespace practicaLinQ
{
    public class Book
    {
        string title;
        int pageCount;
        DateTime publishedDate;
        string status;
        string[] authors;
        string[] categorias;

        public string Title { get => title; set => title = value; }
        public int PageCount { get => pageCount; set => pageCount = value; }
        public DateTime PublishedDate { get => publishedDate; set => publishedDate = value; }
        public string Status { get => status; set => status = value; }
        public string[] Authors { get => authors; set => authors = value; }
        public string[] Categorias { get => categorias; set => categorias = value; }
    }
}