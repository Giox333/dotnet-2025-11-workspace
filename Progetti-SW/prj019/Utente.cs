using System;
using System.Collections;
public class Utente
{
    private string? _nome;
    public string Nome
    {
        get => this._nome!;
        set => this._nome = value;
    }
    private int _massimoPagineInPrestito;
    public int MassimoPagineInPrestito
    {
        get => this._massimoPagineInPrestito;
        set
        {
            if (value <= 0)
                throw new Exception("Il valore deve essere maggiore di 0");
            this._massimoPagineInPrestito = value;
        }
    }
    private ArrayList _listaLibri;
    public ArrayList ListaLibri
    {
        get => this._listaLibri;
    }
    public Utente() : this("John Smith", 1000) { }
    public Utente(string nome, int max)
    {
        this._nome = nome;
        this._massimoPagineInPrestito = max;
        this._listaLibri = new ArrayList();
    }
    public virtual int ContaPagineInPrestito()
    {
        int conta = 0;
        foreach (Libro libro in ListaLibri)
        {
            conta += libro.Pagine;
        }
        return conta;
    }
    public int GetPagineInPrestito()
    {
        return ContaPagineInPrestito();
    }
    public virtual bool PrendiInPrestito(Libro libro)
    {
        if (libro == null || !(libro is Libro))
            return false;
        if (ContaPagineInPrestito() + libro.Pagine > this.MassimoPagineInPrestito)
            return false;
        this.ListaLibri.Add(libro);
        return true;
    }
    public Libro? RestituisciLibro()
    {
        if (this.ListaLibri.Count == 0)
            return null;
        Libro temp = (Libro)ListaLibri[0]!;
        if (temp == null)
            return null;
        this.ListaLibri.RemoveAt(0);
        return temp;
    }
    public override string ToString()
    {
        string testo = $"Nome = {Nome}, Massimo numero di pagine in prestito = {MassimoPagineInPrestito}, Numero di pagine attualmente in prestito = {ContaPagineInPrestito()}, Lista libri:";
        foreach (var libro in ListaLibri)
        {
            testo += $"\n{libro.ToString()}";
        }
        return testo;
    }
}