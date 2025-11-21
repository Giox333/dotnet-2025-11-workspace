public class Booking
{
    public string BookingId{get;set;}
    public DateTime CheckIn{get;set;}
    public DateTime CheckOut{get;set;}
    public Guest Guest{get;set;}
    public Booking(): this("00",new DateTime(2025,1,1) ,new DateTime(2025,1,2),new Guest()){}
    public Booking(string id, DateTime checkIn,DateTime checkOut, Guest ospite)
    {
        this.BookingId = id;
        this.CheckIn = checkIn;
        this.CheckOut = checkOut;
        this.Guest = ospite;
    }
    public void AssignGuest(Guest ospite)
    {
        Guest = ospite;
    }
    public Guest GetGuest()
    {
        return Guest;
    }
    public override string ToString()
    {
        return $"Id prenotazione = {BookingId}, Check In = {CheckIn}, Check Out = {CheckOut}";
    }
}