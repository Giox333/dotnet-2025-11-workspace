public class LetteraPrioritaria : Lettera
{
    private int _priorità;
    public int Priorità
    {
        get
        {
            if (RitornoAlMittente)
                return 0;
            return this._priorità;
        }
        set
        {
            if (value < 1)
                throw new Exception("La priorità minima è 1");
            this._priorità = value;
        }
    }
    public LetteraPrioritaria() : base()
    {
        this._priorità = 1;
    }
    public LetteraPrioritaria(string mittente, string destinatario, bool ritorno, int priorità): base(mittente, destinatario, ritorno)
    {
        this._priorità = priorità;
    }
    public override string ToString()
    {
        return base.ToString() + $", Priorità = {_priorità}";
    }
}