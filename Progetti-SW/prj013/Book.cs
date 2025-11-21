public class Book
{
    public string Isbn{get; set;}
    public string Title{get;set;}
    public int Year{get;set;}
    public Book(): this("123456","Twilight",2005){}
    public Book(string isbn, string titolo, int anno)
    {
        Isbn = isbn;
        Title = titolo;
        Year = anno;
    }
    public override string ToString()
    {
        return $"ISBN = {Isbn}, Titolo = {Title}, Anno = {Year}";
    }
    public string GetInfo()
    {
        return ToString();
    }
}