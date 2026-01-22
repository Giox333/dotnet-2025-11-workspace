public class Corso
{
    private int _id;
    private string _nome;
    private string _descrizione;
    private DateTime _orario;
    private int _durataMinuti;
    private int _maxPartecipanti;
    private List<PartecipazioneCorso> _partecipanti;
    public Corso() : this(1, "Yoga", "Il power yoga è una lezione fluida potente, energica e giocosa che ha una forte enfasi sul respiro",
    DateTime.Now, 60, 20)
    { }
    public Corso(int it, string nome, string descrizione, DateTime orario, int durata, int max)
    {
        this._id = _id;
        this._nome = nome;
        this._descrizione = descrizione;
        this._orario = orario;
        this._durataMinuti = durata;
        this._maxPartecipanti = max;
        this._partecipanti = new List<PartecipazioneCorso>();
    }
    public override string ToString()
    {
        return $"Id = {_id}, Nome corso = {_nome}, Descrizione = {_descrizione}\nOrario = {_orario}, Durata = {_durataMinuti}minuti, Massimo numero di partecipanti = {_maxPartecipanti}";
    }
    /* public string GetDettagliCorso()
    {
        string testo = ToString();
        foreach(var partecipante in _partecipanti)
            testo += "Partecipante"
    } */

    public bool VerificaDisponibilità()
    {
        return PostiDisponibili() > 0;
    }
    public bool AggiungiPartecipante(PartecipazioneCorso partecipante)
    {
        if (!VerificaDisponibilità())
            return false;
        _partecipanti.Add(partecipante);
        return true;
    }
    public void RimuoviPartecipante(PartecipazioneCorso partecipante)
    {
        if (partecipante == null)
            throw new Exception("Il partecipante non può essere null");
        _partecipanti.Remove(partecipante);
        
        //da usare se tutti gli id sono unici
        /*var item = _partecipanti.SingleOrDefault(r => r.Id == partecipante.Id)
        if( item != null)
            _partecipanti.Remove(item);*/

        /* foreach(var partecipe in _partecipanti)
        {
            if(partecipante.Membro.Nome == partecipe.Membro.Nome)
                partecipe.Remove(partecipante);
        } */
    }
    public int PostiDisponibili()
    {
        return _maxPartecipanti - _partecipanti.Count;
    }
}