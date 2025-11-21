public class Dog
{
    public string Nome{get; set;}
    public int Età{get; set;}
    public string Razza{get; set;}

    public Dog()
    {
        Nome = "Sissi";
        Età = 15;
        Razza = "Jack Russel";
    }

    public Dog(string name, int age, string race)
    {
        Nome = name;
        Età = age;
        Razza = race;
    }

    public void Bark()
    {
        System.Console.WriteLine("Woof Woof");
    }
}