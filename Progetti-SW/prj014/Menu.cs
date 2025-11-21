public class Menu
{
    public string MenuName{get;set;}
    public string Category{get;set;}
    public List<Dish> Dish{get;set;}
    public Menu(): this("Pizza super","Secondi"){}
    public Menu(string nome, string categoria)
    {
        this.MenuName = nome;
        this.Category = categoria;
        this.Dish = new List<Dish>();
    }
    public override string ToString()
    {
        return $"Nome menù = {MenuName}, Categoria = {Category}";
    }
    public void AddDish(Dish piatto)
    {
        if(piatto == null)
            return;
        Dish.Add(piatto);
    }
    public List<Dish> GetDishes()
    {
        return Dish;
    }
}