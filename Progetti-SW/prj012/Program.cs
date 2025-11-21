class Program
{
    static void Main(string[] args)
    {
        Order ordine = new Order();
        Customer mario = new Customer();
        mario.placeOrder(new Order("02",new DateTime(2024, 12, 20, 0, 0, 0),100)); 
        mario.placeOrder(new Order("03",new DateTime(2022, 11, 20, 0, 0, 0),5)); 
        mario.placeOrder(new Order("03",DateTime.Today,50)); 
        List<Order> starbucks = mario.getOrders();
        foreach(var ord in starbucks)
        {
            System.Console.WriteLine(ord.GetOrderDetails());
        }
        System.Console.WriteLine("\n");
        //System.Console.WriteLine(ordine.getOrderDetails());
    }
}
