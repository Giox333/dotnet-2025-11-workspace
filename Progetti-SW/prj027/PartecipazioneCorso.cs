public class PartecipazioneCorso
{
    private int _id;
    private DateTime _data;
    private bool _presente;
    public bool Presente
    {
        get => _presente;
        set => _presente = value;
    }
    public PartecipazioneCorso(): this(1,DateTime.Today,false){}
    public PartecipazioneCorso(int id, DateTime data, bool presente)
    {
        this._id = id;
        this._data = data;
        this._presente = presente;
    }
    public override string ToString()
    {
        return $"Partecipazione corso: Id = {_id}, Data = {_data}, Presente = {(_presente ? "Sì" : "No")}";
    }
    public void RegistraPresenza()
    {
        _presente = true;
        _data = DateTime.Now;
        //aggiorna statistiche partecipazione
    }
    public decimal VerificaPresenza()
    {
        //da finire
        return 0;
    }
}