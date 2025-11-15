using Behavioural.Iterator;

var bookShelf = new BookShelf();

bookShelf.AddBook(new Book { Name = "The Karma", Authour = "Chandra T S", Price = 20 });
bookShelf.AddBook(new Book { Name = "Hardware vs Software", Authour = "Ramachandra S", Price = 20 });
bookShelf.AddBook(new Book { Name = "Is Design Pattern Matters", Authour = "Design Dasappa", Price = 34568 });


var iterator = bookShelf.CreateBookShelfIterator();

Console.WriteLine($"Book {iterator.Value.Name} - {iterator.Value.Authour} - {iterator.Value.Price}");

while (iterator.HasNext())
{
    Console.WriteLine($"Book {iterator.Value.Name} - {iterator.Value.Authour} - {iterator.Value.Price}");
    iterator.Next();
}