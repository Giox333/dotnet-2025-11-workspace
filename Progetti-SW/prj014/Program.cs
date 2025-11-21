namespace prj014;

class Program
{
    static void Main(string[] args)
    {
        Restaurant ristorante = new Restaurant();
        System.Console.WriteLine(ristorante.ToString());
        
        Waiter cameriere1 = new Waiter();
        System.Console.WriteLine(cameriere1.ToString());

        Dish piatto1 = new Dish();
        System.Console.WriteLine(piatto1.ToString());

        Menu menu1 = new Menu();
        System.Console.WriteLine(menu1.ToString());

        Ingredient ingrediente1 = new Ingredient();
        System.Console.WriteLine(ingrediente1.ToString());
        System.Console.WriteLine("\n");

        piatto1.AddIngredient(ingrediente1);
        ristorante.AddMenu(menu1);
        ristorante.AddMenu(new Menu("menu super costoso","completo"));
        
        List<Menu> test = ristorante.GetMenu();
        foreach(var i in test)
        {
            System.Console.WriteLine(i.ToString());
        }
    }
}
