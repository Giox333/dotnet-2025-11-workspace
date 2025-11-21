public class Customer
{
    public string Name{get;set;}
    public string Email{get; set;}
    public string PhoneNumber{get;set;}
    public List<Order> Order{get;set;}

    public Customer()
    {
        Name = "Mario";
        Email = "Mario@gmail.com";
        PhoneNumber = "3421007799";
        Order = new List<Order>();
    }
    public Customer(string nome, string email, string numero,List<Order> ordine)
    {
        Name = nome;
        Email = email;
        PhoneNumber = numero;
        foreach(var ord in ordine)
        {
            ordine.Add(ord);
        }
    }
    public void placeOrder(Order ordine)
    {
        if(ordine == null)
        {
            return;
        }
        Order.Add(ordine);
    }
    public List<Order> getOrders()
    {
        return Order;
    }
}