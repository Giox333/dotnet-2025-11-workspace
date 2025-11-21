
public class Order
{
    public string OrderId{get; set;}
    public DateTime Date{get; set;}
    public float TotalAmount{get; set;}

    public Order(): this("01",new DateTime(2008, 6, 1, 7, 47, 0),19){}

    public Order(string id,DateTime data, float totale)
    {
        OrderId = id;
        Date = data;
        TotalAmount = totale;
    }
    public string ToString()
    {
        return $"Id = {OrderId}, Data = {Date.ToString("dd/MM/yyyy")}, Totale = {TotalAmount}";
    }
    public string GetOrderDetails()
    {
        return ToString();
    }
    public string RemoveLastOrder()
    {
        
    }


    /* public void cancelOrder()
    {
        this.orderId = null;
        this.Date = null;
        this.totalAmount = null;
    } */
}