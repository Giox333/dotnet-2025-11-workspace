public class Vehicle
{
    public string PlateNumber{get;set;}
    public string Model{get;set;}
    public int Capacity{get;set;}
    public List<Route> Routes{get;set;}
    public Vehicle(): this("123456","Lancia Musa",100){}
    public Vehicle(string numeroTarga, string modello, int capacità)
    {
        this.PlateNumber = numeroTarga;
        this.Model = modello;
        this.Capacity = capacità;
        this.Routes = new List<Route>();
    }
    public void AddRoute(Route strada)
    {
        if(strada == null)
            return;
        this.Routes.Add(strada);
    }
    public List<Route> GetRoutes()
    {
        return Routes;
    }
    public override string ToString()
    {
        return $"Numero targa = {PlateNumber}, Modello = {Model}, Capacità = {Capacity}";
    }

}