
class Program
{
    static void Main(string[] args)
    {
        Person persona1 = new Person();
        Casa casa1 = new Casa();
        Casa casa2 = new Casa("Padova", 1000, 518, 6);
        Person persona2 = new Person("Gianandrea", 30,casa2);
        persona1.AssegnaCasa(casa1);
        System.Console.WriteLine(persona2.toString());
        System.Console.WriteLine($"Prezzo casa 2 = {persona2.Casa.CalcolaValoreImmobiliare()}");
    }
}
