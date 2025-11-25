public class Garage
{
    public VeicoloAMotore[]? Veicoli { get; set; }
    //public Garage(){}
    public Garage()
    {
        Veicoli = new VeicoloAMotore[15];
    }
    public int ImmettiNuovoVeicolo(VeicoloAMotore veicolo)
    {
        if (veicolo == null)
        {
            throw new ArgumentNullException("Veicolo immesso non valido");
        }
        int conta = 0;
        foreach (var v in Veicoli)
        {
            if (this.Veicoli[conta] == null)
            {
                this.Veicoli[conta] = veicolo;
                return conta;
            }
            conta++;
        }
        throw new ArgumentOutOfRangeException("L'array è pieno ");
    }
    public VeicoloAMotore EstraiVeicolo(int posto)
    {
        if (posto > this.Veicoli.Length)
        {
            throw new ArgumentOutOfRangeException("Il posto non esiste nel garage");
        }
        //return this.Veicoli[posto] ? null : throw new ArgumentOutOfRangeException("Il posto non ha nessuna macchina");
        VeicoloAMotore v1 = this.Veicoli[posto];
        if (v1 == null)
            throw new ArgumentNullException("Il posto non ha nessuna macchina");
        this.Veicoli[posto] = null;
        return v1;
    }
    public void StampaSituazionePosti()
    {
        string stampa = "";
        int conta = 0;
        foreach (var veicolo in this.Veicoli)
        {
            if (veicolo != null)
            {
                conta++;
                stampa += $"\nVeicolo n.{conta}: {veicolo.ToString()}";
            }
        }
        System.Console.WriteLine(stampa);
    }
}