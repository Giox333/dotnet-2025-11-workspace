public class Rivista : Libro
{
    private int _numero;
    public int Numero
    {
        get => _numero;
        set
        {
            if(value > 0)
                _numero = value;
            else
                throw new Exception("La rivista non può avere un numero =0");
        }
    }
    public Rivista(): base()
    {
        _numero = 1;
    }
    public Rivista(string titolo, int pagine, int numero): base(titolo, pagine)
    {
        this._numero = numero;
    }
    public override string ToString()
    {
        return base.ToString() + $", Numero della rivista = {_numero}";
    }
}