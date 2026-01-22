using System;
using System.Diagnostics;

public class Utente
{
    private Guid _id;
    private string _nome;
    private string _cognome;
    private string _email;
    private string _numero_di_tessera;
    private List<Prenotazione> _prenotazione;
    public Utente(): this(Guid.NewGuid(), "Giovanni","Bronte","giovanni.bronte@gmail.com","123456"){}
    public Utente(Guid id, string nome, string cognome, string email, string numeroTessera)
    {
        this._id = id;
        this._nome = nome;
        this._cognome = cognome;
        this._email = email;
        this._numero_di_tessera = numeroTessera;
        this._prenotazione = new List<Prenotazione>();
    }
    public override string ToString()
    {
        return @$"Id = {_id}, Nome = {_nome}, Cognome = {_cognome}, Email = {_email}, Numero di tessera = {_numero_di_tessera}
        Prenotazione = {StampaPrenotazioni()}";
    }
    public void AddPrenotazione(Prenotazione prenotazione)
    {
        if(prenotazione == null)
            return;
        _prenotazione.Add(prenotazione);
    }
    public string StampaPrenotazioni()
    {
        string testo = "";
        int i = 0;
        foreach(var item in _prenotazione)
        {
            testo += $"\nPrenotazione n.{i} = {item.ToString()}";
        }
        return testo;
    }
    /* public bool AnnullaPrenotazione(Prenotazione prenotazione)
    {
        //if(prenotazione.)
    } */
}