public class Waiter
{
    public string Id{get;set;}
    public string FullName{get;set;}
    public string Shift{get;set;}
    public Waiter(): this("00","John Smith","Mattina"){}
    public Waiter(string id, string nome, string turno)
    {
        this.Id = id;
        this.FullName = nome;
        this.Shift = turno;
    }
    public override string ToString()
    {
        return $"Id = {Id}, Nome cameriere = {FullName}, Turno = {Shift}";
    }
    public string GetInfo()
    {
        return ToString();
    }
}