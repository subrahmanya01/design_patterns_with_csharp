namespace Behavioural.Iterator
{
    internal interface IBookShelf
    {
        void AddBook(Book book);
        Iterator<Book> CreateBookShelfIterator();
        List<Book> GetBooks();
        Book GetBook(int index);
    }
}
