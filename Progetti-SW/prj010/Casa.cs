public class Casa
{
    public string Ubicazione{get; set;}
    public double PrezzoMetroQuadro{get; set;}
    public double Metratura{get; set;}
    public int NumeroStanze{get; set;}

    public Casa()
    {
        Ubicazione = " ";
        PrezzoMetroQuadro = 0;
        Metratura = 0;
        NumeroStanze = 0; 
    }

    public Casa(string ubi, double prezzo, double metr, int nStanze)
    {
        Ubicazione = ubi;
        PrezzoMetroQuadro = prezzo;
        Metratura = metr;
        NumeroStanze = nStanze; 
    }

    public double CalcolaValoreImmobiliare()
    {
        return Metratura * PrezzoMetroQuadro;
    } 

    public string toString()
    {
        return $"{Ubicazione}, {Metratura}, {NumeroStanze}, {PrezzoMetroQuadro}";
    }
}