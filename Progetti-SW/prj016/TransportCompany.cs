public class TransportCompany
{
    public string Name{get;set;}
    public string HeadQuarters{get;set;}
    public List<Vehicle> Vehicles{get;set;}
    public List<Employee> Employees{get;set;}
    public TransportCompany(): this("Amazon","Seattle"){}
    public TransportCompany(string nome, string quartierGenerale)
    {
        this.Name = nome;
        this.HeadQuarters = quartierGenerale;
        this.Vehicles = new List<Vehicle>();
        this.Employees = new List<Employee>();
    }
    public void AddVehicle(Vehicle veicolo)
    {
        if(veicolo == null)
            return;
        this.Vehicles.Add(veicolo);
    }
    public void AddEmployee(Employee impiegato)
    {
        if(impiegato == null)
            return;
        this.Employees.Add(impiegato);
    }
    public List<Vehicle> GetFleet()
    {
        return Vehicles;
    }
    public List<Employee> GetEmployees()
    {
        return Employees;
    }
    public override string ToString()
    {
        return $"Nome compagnia = {Name}, Quartier generale = {HeadQuarters}";
    }
}