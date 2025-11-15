namespace Behavioural.Iterator
{
    internal class BookShelfIterator : Iterator<Book>
    {
        private readonly BookShelf _bookShelf;
        private int _index = 0;

        public BookShelfIterator(BookShelf bookShelf)
        {
            _bookShelf = bookShelf;
        }

        public Book Value => _bookShelf.GetBook(_index);

        public bool HasNext()
        {
            return _index+1 < _bookShelf.GetBooks().Count();
        }

        public Book Next()
        {
            if (HasNext())
            {
                _index++;
                return _bookShelf.GetBook(_index);
            }
            throw new InvalidOperationException("No more elements to iterate");
        }
    }
}
