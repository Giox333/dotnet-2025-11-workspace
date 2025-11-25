public class Lettera
{
    private string _mittente;
    private string _destinatario;
    private bool _ritornoAlMittente;
    public string Mittente
    {
        get => this._mittente;
        set => this._mittente = value;
    }
    public string Destinatario
    {
        get => this._destinatario;
        set => this._destinatario = value;
    }
    public bool RitornoAlMittente
    {
        get => this._ritornoAlMittente;
        set => this._ritornoAlMittente = value;
    }
    public Lettera(): this("Giacomo","Gianluca",false){}
    public Lettera(string mittente, string destinatario, bool ritorno)
    {
        this._mittente = mittente;
        this._destinatario = destinatario;
        this._ritornoAlMittente = ritorno;
    }
    public override string ToString()
    {
        return $"Mittente = {_mittente}, Destinatario = {_destinatario}, Ritorna al mittente =" + (_ritornoAlMittente ? "Sì" : "No");
    }
}