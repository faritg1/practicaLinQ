
namespace practicaLinQ{
    public class LinqQueries { 
        List<Book> lstBooks = new List<Book>();
        public LinqQueries(){
            using(StreamReader reader = new StreamReader("books.json")){
                string json = reader.ReadToEnd();
                this.lstBooks = System.Text.Json.JsonSerializer.Deserialize<List<Book>>(json,new System.Text.Json.JsonSerializerOptions(){PropertyNameCaseInsensitive = true});
            }
        }
        public IEnumerable<Book> AllCollection(){
            return lstBooks;
        }

        public IEnumerable<Book> Libros2000(){
            return lstBooks.Where(book => book.PublishedDate.Year > 2000);
        }

        public IEnumerable<Book> LibrosAndroid(){
            return lstBooks.Where(books => books.Title.Contains("Android") && books.PublishedDate.Year > 2005);
        }

        public IEnumerable<Book> LibrosP(){
            return lstBooks.Where(books => books.PageCount > 250 && books.Title.Contains("Action"));
        }

        public bool LibroVerifi(){
            return lstBooks.All(books => books.Status.Length > 0);
        }

        public bool LibroPubli(){
            return lstBooks.Any(books => books.PublishedDate.Year == 2005);
        }

        public IEnumerable<Book> Libro2005(){
            if(LibroPubli()){
                return lstBooks.Where(books => books.PublishedDate.Year == 2005);
            }
            return new List<Book>();
        }
    }
}
