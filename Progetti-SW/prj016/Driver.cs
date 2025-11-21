public class Driver : Employee
{
    public string LicenseType { get; set; }
    public Driver() : base()
    {
        this.LicenseType = "AA";
    }
    public Driver(string nome, string id, string licensa): base(nome,id)
    {
        this.LicenseType = licensa;
    }
    public void Drive()
    {
        System.Console.WriteLine("Vroom Vroom");
    }
    public override string ToString()
    {
        return base.ToString() +  ", Tipo di licenza = " + LicenseType;
    }
}