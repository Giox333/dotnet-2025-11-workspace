using System;

public class Prenotazione
{
    private string _codice_prenotazione;
    private DateTime _data_prenotazione;
    public DateTime DataPrenotazione
    {
        get => _data_prenotazione;
        set
        {
            //int result = DateTime.Compare(value,DateTime.Today);
            DateTime oggi = DateTime.Today;
            int result = value.CompareTo(oggi);
            System.Console.WriteLine("Stampo risultato compare = " + result);
            System.Console.WriteLine("Value = "+ value);
            if(result > 0)
                throw new Exception("La data di prenotazione non può essere antecedente a oggi");
            _data_prenotazione = value;
        }
    }
    private DateTime _data_scadenza;
    public DateTime DataScadenza
    {
        get => _data_scadenza;
        set
        {
            if(value <= _data_prenotazione)
                throw new Exception("La data di scadenza non può essere lo stesso giorno della prenotazione o prima");
            _data_scadenza = value;
        }
    }
    public enum StatoPrenotazione{
        attiva,
        annullata,
        completata
    }
    private StatoPrenotazione _statoPrenotazione;
    public Prenotazione(): this("1234", DateTime.Today, DateTime.Today,StatoPrenotazione.attiva){}
    public Prenotazione(string codice, DateTime dataPrenotazione, DateTime dataScadenza,StatoPrenotazione stato)
    {
        this._codice_prenotazione = codice;
        this._data_prenotazione = dataPrenotazione;
        this._data_scadenza = dataScadenza;
        this._statoPrenotazione = stato; 
    }
    public override string ToString()
    {
        return $"Codice Prenotazione = {_codice_prenotazione}, Data prenotazione = {_data_prenotazione}, Data Scadenza = {_data_scadenza}, Stato prenotazione = {_statoPrenotazione}";
    }
}