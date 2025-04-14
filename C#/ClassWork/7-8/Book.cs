
//var library = new Library();
//try
//{
//    var book1 = new Book
//    {
//        Id = 1,
//        Title = "Война и мир"
//    };
//    var book2 = new Book
//    {
//        Id = 2,
//        Title = "мертвые души"
//    };
//    var book3 = new Book
//    {
//        Id = 3,
//        Title = "идиот"
//    };
//    library.Add(book1);
//    library.Add(book2);
//    library.Add(book3);

//    var book = library.Search(1);

//    book = library.Search(6);

//} 
//catch(NotFoundException msg)
//{
//    Console.WriteLine(msg.Message);
//}

//public class Library
//{
//    private List<Book> books = new List<Book>();
//    public int count
//    {
//        get
//        {
//            return books.Count;
//        }
//    }
//    public void Add(Book book)
//    {
//        books.Add(book);
//    }
//    public void Remove(Book book)
//    {
//        books.Remove(book);
//    }
//    public Book Search(int id)
//    {
//        for (int i = 0; i < books.Count; i++)
//        {
//            if (books[i].Id == id)
//            {
//                return books[i];
//            }
//        }
//        throw new Exception();
//    }
//    public Book this[int index]
//    {
//        get
//        {
//            return books[index];
//        }
//        set
//        {
//            books[index] = value;
//        }
//    }
//}
//public class Book
//{
//    public int Id { get; set; }
//    public string Title { get; set; }
//    public int Description { get; set; }
//}

//public enum BookTypes
//{
//    Type1, Type2, Type3
//}

//public class NotFoundException : Exception
//{
//    public NotFoundException(int id): base($"Книга по данному id: {id} не была найдена")
//    {

//    }
//}