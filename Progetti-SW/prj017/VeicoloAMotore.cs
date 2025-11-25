public class VeicoloAMotore
{
    public int AnnoImmatricolazione{get;set;}
    public string Marca{get;set;}
    public string TipoAlimentazione{get;set;}
    public int Cilindrata{get;set;}
    public VeicoloAMotore(): this(2005,"Lancia","Diesel",100){}
    public VeicoloAMotore(int anno, string marca, string alimentazione, int cilindrata)
    {
        this.AnnoImmatricolazione = anno;
        this.Marca = marca; 
        this.TipoAlimentazione = alimentazione;
        this.Cilindrata = cilindrata;
    }
    public override string ToString()
    {
        return $"Anno imatricolazione= {AnnoImmatricolazione}, Marca = {Marca}, Tipo di alimentazione = {TipoAlimentazione}, Cilindrata = {Cilindrata}";
    }
}