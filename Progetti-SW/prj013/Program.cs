class Program
{
    static void Main(string[] args)
    {
        Book libro1 = new Book();
        System.Console.WriteLine(libro1.ToString());
        Library libreria = new Library();
        System.Console.WriteLine(libreria.ToString());
        libreria.AddBook(libro1);
        libreria.AddBook(new Book("1111","Hunger Games",2010));
        System.Console.WriteLine(libreria.ToString());
        System.Console.WriteLine(libro1.ToString());
        System.Console.WriteLine("\n");
        
        List<Book> libri = libreria.GetBooks();
        foreach(var l in libri)
        {
            System.Console.WriteLine(l.ToString());
        }
        System.Console.WriteLine("\n");

        libreria.BorrowBook(libro1);
        libri = libreria.GetBooks();
        foreach(var l in libri)
        {
            System.Console.WriteLine(l.ToString());
        }
        System.Console.WriteLine("\n");
        
    }
}
