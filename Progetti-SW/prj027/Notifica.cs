public class Notifica
{
    private int _id;
    private TipoNotifica _tipo;
    private string _messaggio;
    private DateTime _dataInvio;
    private bool _letta;
    public bool Letta
    {
        get=> _letta;
        set=> _letta = value;
    }
    public Notifica(): this(1,TipoNotifica.PromemoriaPagamento,"Promemoria pagamento!",DateTime.Today,false){}
    public Notifica(int id, TipoNotifica tipo, string messaggio, DateTime data, bool letta)
    {
        this._id = id;
        this._tipo = tipo;
        this._messaggio = messaggio;
        this._dataInvio = data;
        this._letta = letta;
    }
    public override string ToString()
    {
        return $"NOTIFICA:\nId = {_id}, Tipo = {_tipo}, Messaggio = {_messaggio}, Data Invio ={_dataInvio}, Letto = {(_letta? "Sì" : "No")}";
    }
    public string Invia()
    {
        return ToString();
    }
    public void SegnaComeLetta()
    {
        _letta = true;
    }
    
}