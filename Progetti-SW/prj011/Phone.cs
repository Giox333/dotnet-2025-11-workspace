public class Phone
{
    public string Brand{get; set;}
    public float Price{get;set;}
    public string Model{get;set;}

    public Phone()
    {
        Brand = "Xiaomi";
        Model = "Poco F5";
        Price = 450;
    }

    public Phone(string marca, string modello, float prezzo)
    {
        Brand = marca;
        Model = modello;
        Price = prezzo;
    }

    public string toString()
    {
        return $"{Brand} {Model} {Price}€";
    }

    public string getDetails()
    {
        return toString();
    }

    public void call(string number)
    {
        System.Console.WriteLine($"Sta chiamando il numero {number}");
    }

}