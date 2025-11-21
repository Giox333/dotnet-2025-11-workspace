public class Employee
{
    public string FullName { get; set; }
    public string EmployeeId { get; set; }
    public Employee() : this("Giacomo", "00") { }
    public Employee(string nome, string id)
    {
        this.FullName = nome;
        this.EmployeeId = id;
    }
    public override string ToString()
    {
        return $"Nome impgiegato = {FullName}, Id = {EmployeeId}";
    }
    public string GetInfo()
    {
        return ToString();
    }
}