public class Library
{
    public string Name{get; set;}
    public string Address{get; set;}
    public List<Book> Book{get;set;}
    public Library(): this("Biblioteca di Abano", "Via Montessori 11"){}
    public Library(string nome, string indirizzo)
    {
        Name = nome;
        Address = indirizzo;
        this.Book = new List<Book>();
    }
    public override string ToString()
    {
        /* string ris;
        foreach(var libro in Book)
        {
            ris += $"";
        } */
        return $"Nome = {Name}, Indirizzo = {Address}";
    }
    public void AddBook(Book libro)
    {
        if(libro == null)
        {
            return;
        }
        CercaLibro(libro);
        Book.Add(libro);
    }
    private bool CercaLibro(Book libro)
    {
        /* foreach(var lib in Book)
        {
            if(Book.Title == libro.Title)
            {
                return true;
            }
        }
        return false; */
        return this.Book.Contains(libro);
    }
    public List<Book> GetBooks()
    {
        return Book;
    }
    public void BorrowBook(Book libro)
    {
        if(!CercaLibro(libro) || libro == null)
        {
            return;
        }
        /* for(int i=0; i<Book.Count; i++)
        {
            if(Book[i].Title == libro.Title)
            {
                Book.RemoveAt(i);
            }
        } */
        this.Book.Remove(libro);
    }
}