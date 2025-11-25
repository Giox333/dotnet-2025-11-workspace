public class Libro
{
    public string Titolo{get;set;}
    private int _pagine;
    public int Pagine
    {
        get => _pagine;
        set
        {
            if(value > 0)
                _pagine = value;
            else   
                throw new ArgumentException("Non possono esserci 0 o meno pagine");
        }
    }
    public Libro(): this("Vuoto",10){}
    public Libro(string titolo, int pagine)
    {
        this.Titolo = titolo;
        this.Pagine = pagine;
    }
    public override string ToString()
    {
        return $"Titolo libro = {Titolo}, Numero di pagine = {_pagine}";
    }
}