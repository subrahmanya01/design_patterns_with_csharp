namespace Behavioural.Iterator
{
    internal class BookShelf : IBookShelf
    {
        private List<Book> _books =  new();

        public BookShelf(){

        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public Iterator<Book> CreateBookShelfIterator()
        {
            return new BookShelfIterator(this);
        }

        public List<Book> GetBooks()
        {
            return _books;
        }

        public Book GetBook(int index) { 
            return _books[index];
        }
    }
}
