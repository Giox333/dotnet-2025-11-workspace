public class Libro
{
    private string _ISBN;
    private string _titolo;
    private string _autore;
    private int _anno_publicazione;
    //private RetrieverManager manager;
    public enum Stato
    {
        disponibile,
        prenotato,
        in_prestito
    }
    private Stato _stato;
    private Prenotazione _prenotazione;
    public Libro(): this("987654","Twilight","Stephenie Meyer",2005,Stato.disponibile, new Prenotazione()){}
    public  Libro(Root libro,Stato stato, Prenotazione prenotazione)
    {
        this._ISBN = libro.BookId;
        this._titolo = libro.Title;
        this._autore = libro.Author[0].Name;
        this._anno_publicazione = int.Parse(libro.PublishedYear);
        this._stato = stato;
        this._prenotazione = prenotazione;
    }
    public Libro(string isbn, string titolo, string autore, int anno, Stato stato, Prenotazione prenotazione)
    {
        this._ISBN = isbn;
        this._titolo = titolo;
        this._autore = autore;
        this._anno_publicazione = anno;
        this._stato = stato;
        this._prenotazione = prenotazione;
    }
    public override string ToString()
    {
        return @$"ISBN = {_ISBN}, Titolo = {_titolo}, Autore = {_autore}, Anno = {_anno_publicazione}, Stato = {_stato}
        Prenotazione = {_prenotazione.ToString()}";
    }
}