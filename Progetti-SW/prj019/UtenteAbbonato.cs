public class UtenteAbbonato : Utente
{
    public UtenteAbbonato() : base() { }
    public UtenteAbbonato(string nome, int max) : base(nome, max) { }
    public override bool PrendiInPrestito(Libro libro)
    {
        if (libro is Rivista){
            ListaLibri.Add(libro);
            return true;
        }
        //codice duplicato, riuso il metodo virtuale definito in utente 
        /* else if (ContaPagineInPrestito() + libro.Pagine > MassimoPagineInPrestito)
            return false;
        ListaLibri.Add(libro);
        return true; */
        return base.PrendiInPrestito(libro);
    }
    public override int ContaPagineInPrestito()
    {
        int conta=0;
        foreach(Libro libro in ListaLibri)
        {
            if(!(libro is Rivista))
                conta += libro.Pagine;
        }
        return conta;
    }
}