public class Admin : Employee
{
    public string Department { get; set; }
    public Admin() : base()
    {
        this.Department = "Trasporti";
    }
    public Admin(string nome, string id, string dipartimento) : base(nome, id)
    {
        this.Department = dipartimento;
    }
    public void GenerateReport()
    {
        System.Console.WriteLine("Rapporto generato!");
    }
    public override string ToString()
    {
        return $"{base.ToString()}, Dipartimento = {Department}";
    }
}