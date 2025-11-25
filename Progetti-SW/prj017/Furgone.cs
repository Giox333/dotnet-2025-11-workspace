public class Furgone : VeicoloAMotore
{
    public int CapacitàCarico{get;set;}
    public Furgone() : base()
    {
        this.CapacitàCarico = 0;
    }
    public Furgone(int anno, string marca, string alimentazione, int cilindrata,int capacità): base(anno,marca,alimentazione,cilindrata)
    {
        this.CapacitàCarico = capacità;
    }
    public override string ToString()
    {
        return base.ToString() + $", Capacità carico = {CapacitàCarico}";
    }
}