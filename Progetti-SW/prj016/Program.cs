namespace prj016;

class Program
{
    static void Main(string[] args)
    {
        Employee impiegato1 = new Employee();
        //System.Console.WriteLine(impiegato1.GetInfo());

        Driver guida = new Driver("Gianni","01","Camion");
        guida.Drive();
        System.Console.WriteLine(guida.ToString());
        System.Console.WriteLine("\n");

        Admin admin1 = new Admin("Marco","02","HR");
        admin1.GenerateReport();
        System.Console.WriteLine(admin1.ToString());
        System.Console.WriteLine("\n");

        Route strada1 = new Route();
        System.Console.WriteLine(strada1.GetSummary());
        System.Console.WriteLine("\n");

        Vehicle macchina = new Vehicle();
        System.Console.WriteLine(macchina.ToString());
        macchina.AddRoute(strada1);
        macchina.AddRoute(new Route());
        List<Route> lista1 = macchina.GetRoutes();
        foreach(var strada in lista1)
        {
            System.Console.WriteLine(strada.ToString());
        }
        System.Console.WriteLine("\n");

        TransportCompany compagnia1 = new TransportCompany();
        System.Console.WriteLine(compagnia1.ToString());
        compagnia1.AddVehicle(macchina);
        compagnia1.AddEmployee(impiegato1);
        List<Vehicle> lista2 = compagnia1.GetFleet();
        foreach(var elemento in lista2)
        {
            System.Console.WriteLine(elemento.ToString());
        }
        List<Employee> lista3 = compagnia1.GetEmployees();
        foreach(var elemento in lista3)
        {
            System.Console.WriteLine(elemento.ToString());
        }
    }
}
