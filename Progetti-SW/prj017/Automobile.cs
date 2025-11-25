public class Automobile : VeicoloAMotore
{
    //public int NumPorte{get;set;}
    private int _NumeroPorte{}
    public int _NumeroPorte
    {
        get => _NumeroPorte;
        set
        {
            if (value == 3 || value == 5)
                _NumeroPorte = value;
            else
                throw new ArgumentException("Le porte devono essere 3 o 5");
        }
    }
    public Automobile() : base()
    {
        this.NumPorte = 3;
    }
    public Automobile(int anno, string marca, string alimentazione, int cilindrata, int numPorte)
    : base(anno, marca, alimentazione, cilindrata)
    {
        this.NumPorte = numPorte;
    }
    public override string ToString()
    {
        return base.ToString() + $", Numero di porte = {NumPorte}";
    }
}