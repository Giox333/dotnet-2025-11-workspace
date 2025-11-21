class Phone
{
    public string Marca{get; set;}
    public bool isDualSim{get;set;}
    public int Prezzo{get;set;}
    public string Modello{get;set;}

    public Phone()
    {
        Marca = "Xiaomi";
        isDualSim = false;
        Prezzo = 450;
        Modello = "Poco F5";
    }

    public Phone(string marca, string modello, int prezzo, bool dualsim)/* : Marca(marca), Modello(modello), Prezzo(prezzo), isDualSim(dualsim) */
    {
        Marca = marca;
        Modello = modello;
        Prezzo = prezzo;
        isDualSim = dualsim;
    }

    public void Stampa()
    {
        System.Console.WriteLine($"Marca = {Marca}\nModello = {Modello}\nPrezzo = {Prezzo}€\nÈ Dual sim = {(isDualSim? "Si" : "No")}");
    }   

    public string toString()
    {
        return $"{Marca} {Modello} {Prezzo}€ {isDualSim}";
    }
}