public class Restaurant
{
    public string Name{get;set;}
    public string Address{get;set;}
    public List<Menu> Menu{get;set;}
    public List<Waiter> Waiter{get;set;}
    public Restaurant(): this("Kebab SUper", "Via Kebab 12"){}
    public Restaurant(string nome, string indirizzo)
    {
        this.Name = nome;
        this.Address = indirizzo;
        this.Menu = new List<Menu>();
        this.Waiter = new List<Waiter>();
    }
    public void AddMenu(Menu menu)
    {
        if(menu == null)
        {
            return;
        }
        this.Menu.Add(menu);
    }
    public void AddWaiter(Waiter cameriere)
    {
        if(cameriere == null)
        {
            return;
        }
        this.Waiter.Add(cameriere);
    }
    public override string ToString()
    {
        return $"Ristorante = {Name}, Indirizzo = {Address}";
    }
    public List<Menu> GetMenu()
    {
        return Menu;
    }
    public List<Waiter> GetWaiter()
    {
        return Waiter;
    }
}