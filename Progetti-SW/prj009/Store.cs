public class Store
{
    public Phone[] Phones { get; set; }
    public string Nome { get; set; }

    public Store()
    {
        Phones = new Phone[10];
        Nome = "Super Store";
    }

    public void StampTuttiTelefoni()
    {
        foreach (var tel in Phones)
            System.Console.WriteLine(tel);
    }

    public void AddPhone(Phone tel)
    {
        for(int i=0; i<Phones.Length; i++)
        {
            if(Phones[i] == null)
            {
                Phones[i] = tel;
                break;
            }
        }
    }
}