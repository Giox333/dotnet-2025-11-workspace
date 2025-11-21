
class Program
{
    static void Main(string[] args)
    {
        Phone tel1 = new Phone();
        User utente = new User("Giox","asdrubale@gmail.com",tel1);
        User utente2 = new User("Anna", "dasad@gmail.com",new Phone("Samsung","S11",1000));
        System.Console.WriteLine(utente2.toString());
        tel1.call("3421007791");
    }
}
