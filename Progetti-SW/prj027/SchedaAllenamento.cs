public class SchedaAllenamento
{
    private int _id;
    private string _obbiettivi;
    private Livello _livello;
    private DateTime _dataCreazione;
    private Esercizio[] _esercizi;
    private const int max = 10;
    public SchedaAllenamento() : this(1, "Sollevare 100 kg", Livello.Principiante, DateTime.Today) { }
    public SchedaAllenamento(int id, string obbiettivi, Livello livello, DateTime data)
    {
        this._id = id;
        this._obbiettivi = obbiettivi;
        this._livello = livello;
        this._dataCreazione = data;
        this._esercizi = new Esercizio[max];
    }
    public override string ToString()
    {
        string testo = $"Id = {_id}, Obbiettivi = {_obbiettivi}, Livello = {_livello}, Data creazione = {_dataCreazione}";
        foreach (var item in _esercizi)
        {
            if (item != null)
                testo += $"\nEsercizio = {item}";
        }
        return testo;
    }
    public void AggiungiEsercizio(Esercizio esercizio)
    {
        if (CercaPostoLibero() == max)
            throw new Exception("Raggiunto il numero massimo di esercizi sulla scheda, impossibile aggiungere altri es");
        _esercizi[CercaPostoLibero()] = esercizio;
    }
    public void RimuoviEsercizio(Esercizio esercizio)
    {
        if (esercizio == null)
            throw new Exception("Esericizio inserito nullo!");
        for (int i = 0; i < _esercizi.Length; i++)
        {
            if (_esercizi[i].Nome == esercizio.Nome)
            {
                _esercizi[i] = null;
                break;
            }
        }
    }
    public int CalcolaDurataTotale()
    {
        if (_esercizi == null)
            return 0;
        int ris = 0;
        for (int i = 0; i < _esercizi.Length; i++)
        {
            if(_esercizi[i] != null)
                ris += _esercizi[i].CalcolaCaricoLavoro();
        }
        return ris;
    }
    public string GeneraReport()
    {
        return ToString();
    }
    private int CercaPostoLibero()
    {
        int i = 0;
        for (; i < _esercizi.Length; i++)
        {
            if (_esercizi[i] == null)
                return i;
        }
        return i;
    }
}