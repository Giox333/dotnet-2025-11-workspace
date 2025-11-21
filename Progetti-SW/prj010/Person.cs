public class Person
{
    public string Nome{get; set;}
    public int Età{get; set;}
    public Casa Casa{get; set;}

    public Person()
    {
        Nome = "Giovanni";
        Età = 23;
        Casa = new Casa();
    }

    public Person(string name, int age,Casa home)
    {
        Nome = name;
        Età = age;
        Casa = home;
    }

    public void AssegnaCasa(Casa home)
    {
        Casa = home;
    }

    public string toString()
    {
        return $"{Nome}, {Età}, {Casa.toString()}";
    }

}