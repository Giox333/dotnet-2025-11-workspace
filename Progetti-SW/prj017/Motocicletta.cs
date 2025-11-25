public class Motocicletta: VeicoloAMotore
{
    public string Tipologia{get;set;}
    public int NumTempiMotore{get;set;}
    public Motocicletta(): base()
    {
        Tipologia  = "Veloce";
        NumTempiMotore = 0;
    }
    public Motocicletta(int anno, string marca, string alimentazione, int cilindrata, string tipo, int tempi)
    : base(anno, marca, alimentazione, cilindrata)
    {
        this.Tipologia = tipo;
        this.NumTempiMotore = tempi;
    }
    public override string ToString()
    {
        return base.ToString() + $", Tipologia = {Tipologia}, Numero di tempi motore = {NumTempiMotore}";
    }
}