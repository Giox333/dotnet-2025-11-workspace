namespace prj019;

class Program
{
    static void Main(string[] args)
    {
        //Libro libro1;
        /* try
        {
            Libro libro1 = new Libro();
        }
        catch(Exception e)
        {
            System.Console.WriteLine(e.Message);
        } */
        Libro libro1 = new Libro();
        System.Console.WriteLine(libro1);
        System.Console.WriteLine(libro1.Pagine);

        Rivista rivista1 = new Rivista();
        System.Console.WriteLine(rivista1);

        Utente user1 = new Utente();
        System.Console.WriteLine(user1);

        UtenteAbbonato user2 = new UtenteAbbonato();
        System.Console.WriteLine(user2);

        user1.PrendiInPrestito(new Libro());
        user1.PrendiInPrestito(new Rivista());
        System.Console.WriteLine("\n"+user1);
    }
}
