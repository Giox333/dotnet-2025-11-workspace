public class Dish
{
    public string Name{get;set;}
    public float Price{get;set;}
    public List<Ingredient> Ingredient{get;set;}
    public Dish(): this("Pizza",5){}
    public Dish(string nome, float prezzo)
    {
        this.Name = nome;
        this.Price = prezzo;
        this.Ingredient = new List<Ingredient>();
    }
    public override string ToString()
    {
        return $"Nome piatto = {Name}, Prezzo = {Price}";
    }
    public List<Ingredient> GetIngredients()
    {
        return Ingredient;
    }
    public void AddIngredient(Ingredient ingrediente)
    {
        if(ingrediente == null)
            return;
        Ingredient.Add(ingrediente);
    }
}