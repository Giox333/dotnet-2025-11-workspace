public class Abbonamento
{
    private int _id;
    private TipoAbbonamento _tipo;
    private DateTime _dataInizio;
    public DateTime DataInizio
    {
        get => _dataInizio;
        set => _dataInizio = value;
        /* {
            if(value < DateTime.Today)
                throw new Exception("La data dell'abbonamento non può essere prima di oggi ");
            _dataInizio = value;
        } */
    }
    private DateTime _dataScadenza;
    public DateTime DataScadenza
    {
        get => _dataScadenza;
        set => _dataScadenza = value;
        /* {
            if(value > _dataInizio)
                throw new Exception("La data della fine dell'abbonamento non può essere prima dell'inizio ");
            _dataInizio = value;
        } */
    }
    private decimal _prezzo;
    private Pagamento _pagamento;
    public Abbonamento() : this(1, TipoAbbonamento.Base, DateTime.Today, new DateTime(2026, 1, 1), 200, new Pagamento()) { }
    public Abbonamento(int id, TipoAbbonamento tipo, DateTime dataInizio, DateTime dataFine, decimal prezzo, Pagamento pagamento)
    {
        this._id = id;
        this._tipo = tipo;
        this.DataInizio = dataInizio;
        this.DataScadenza = dataFine;
        this._prezzo = prezzo;
        this._pagamento = pagamento;
    }
    public bool IsScaduto()
    {
        return (DateTime.Today > _dataScadenza) ? true : false;
    }
    public double CalcolaGiorniRimanenti()
    {
        if (IsScaduto())
            return 0;
        /* long oggi = DateTime.Today.Ticks;
        long scadenza = _dataScadenza.Ticks; */
        return (_dataScadenza - DateTime.Today).TotalDays;
    }
    public Abbonamento Rinnova()
    {
        return new Abbonamento(this._id, this._tipo, this._dataScadenza, _dataScadenza.AddYears(1).AddMonths(1), this._prezzo,
        new Pagamento(_pagamento.Id, _dataScadenza.AddYears(1).AddMonths(1), _pagamento.Importo, _pagamento.MetodoDiPagamento, false));
    }
    public override string ToString()
    {
        return @$"Id = {_id}, Tipo di abbonamento = {_tipo}, Data inizio = {_dataInizio}, Data fine = {_dataScadenza}
        Prezzo = {_prezzo}, Pagamento = {_pagamento.ToString()}";
    }
}