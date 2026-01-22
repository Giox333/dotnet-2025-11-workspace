public class Pagamento
{
    private int _id;
    public int Id
    {
        get => _id;
        set => _id = value;
    }
    private DateTime _data;
    private decimal _importo;
    public decimal Importo
    {
        get => _importo;
        set => _importo = value;
    }
    private string _metodoDiPagamento;
    public string MetodoDiPagamento
    {
        get => _metodoDiPagamento;
        set => _metodoDiPagamento = value;
    }
    private bool _pagato;
    public bool Pagato
    {
        get => _pagato;
        set => _pagato = value;
    }
    private Abbonamento _abbonamento; 
    public Pagamento(): this(1,DateTime.Today,145,"Bancomat",true){}
    public Pagamento(int id, DateTime data, decimal importo, string metodo, bool pagato)
    {
        this._id = id;
        this._data = data;
        this._importo = importo;
        this._metodoDiPagamento = metodo;
        this._pagato = pagato;
    }
    public void EseguiPagamento()
    {
        _pagato = true;
        _data = DateTime.Today;
        //aggiorna abbonamento
    }
    public bool VerificaScadenzaPagamento()
    {
        return (!_pagato && DateTime.Today > _data)? false : true;
    }
    public string GeneraRicevuta()
    {
        return ToString();
    }
    public override string ToString()
    {
        return $"Id = {_id}, Data = {_data}, Importo = {_importo}, Metodo di pagamento = {_metodoDiPagamento}, Pagato = {(_pagato? "Sì" : "No")}";
    }
}