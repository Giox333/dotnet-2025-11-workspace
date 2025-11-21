public class Ingredient
{
    public string Name{get; set;}
    public int Quantity{get;set;}
    public Ingredient():this("Pomodoro",150){}
    public Ingredient(string nome,int quantità)
    {
        this.Name = nome;
        this.Quantity = quantità;
    }
    public override string ToString()
    {
        return $"Nome ingrediente = {Name}, Quantità = {Quantity}";
    }
    public string GetDetails()
    {
        return ToString();
    }
}