public class Persona
{
    public string Nome{ get; set;}
    public string Cognome{get; set;}
    public int Età{get; set;}

    public Persona()
    {
        Nome = "Mario";
        Cognome = "Rossi";
        Età = 25;
    }

    //public Persona(string name, string surname, int age): Nome(name); Cognome(surname); Età(age){}
    public Persona(string name, string surname, int age)
    {
        Nome = name;
        Cognome = surname;
        Età = age;
    }
    public void mostraInformazioni()
    {
        System.Console.WriteLine($"Nome: {Nome}\nCognome: {Cognome}\nEtà: {Età}");
    }
}