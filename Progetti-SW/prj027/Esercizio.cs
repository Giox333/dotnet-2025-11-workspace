public class Esercizio
{
    private int _id;
    private string? _nome;
    public string Nome
    {
        get=> _nome;
        set=> _nome = value;
    }
    private string? _descrizione;
    private int _serie;
    public int Serie
    {
        get=> _serie;
        set=> _serie =value;
    }
    private int _ripetizioni;
    public int Ripetizioni
    {
        get=> _ripetizioni;
        set=> _ripetizioni =value;
    }
    private int _recuperoSecondi;
    private string? _attrezzatura;
    private Livello _livello;
    public Livello Livello
    {
        get=>_livello;
        set=> _livello = value;
    }
    public Esercizio(): this(1,"Chest press","Spingere le maniglie in avanti e poi riportarle verso il petto",
    10,3,60,"Chest Press", Livello.Principiante){}
    public Esercizio(int id, string nome, string descrizione, int serie, int ripetizione, int recupero, string attrezzatura, Livello livello)
    {
        this._id = id;
        this._nome = nome;
        this._descrizione = descrizione;
        this._serie = serie;
        this._ripetizioni = ripetizione;
        this._recuperoSecondi = recupero;
        this._attrezzatura = attrezzatura;
        this._livello = livello;
    }
    public int CalcolaCaricoLavoro()
    {
        return Serie*Ripetizioni;
    }
    public void VerificaDifficoltà(Livello liv)
    {
        _livello = liv;
    }
    public string? GetIstruzioni()
    {
        return _descrizione;
    }
    public override string ToString()
    {
        return @$"Id = {_id}, Nome = {_nome}, Descrizione = {_descrizione}
        Serie = {_serie}, Ripetizioni = {_ripetizioni}, Recupero = {_recuperoSecondi} secondi
        Attrezzatura = {_attrezzatura}, Livello di difficoltà = {_livello}";
    }
}