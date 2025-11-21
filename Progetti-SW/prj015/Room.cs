public class Room
{
    public int RoomNumber{get;set;}
    public string Type{get;set;}
    public float PricePerNight{get;set;}
    public List<Booking> Bookings{get;set;}
    public Room(): this(00,"Matrimoniale",1000){}
    public Room(int numeroStanza, string tipo, float prezzo)
    {
        this.RoomNumber = numeroStanza;
        this.Type = tipo;
        this.PricePerNight = prezzo;
        this.Bookings = new List<Booking>();
    }
    public void AddBooking(Booking prenotazione)
    {
        if(prenotazione == null)
        {
            return;
        }
        this.Bookings.Add(prenotazione);
    }
    public List<Booking> GetBooking()
    {
        return Bookings;
    }
    public override string ToString()
    {
        return $"Numero stanza = {RoomNumber}, Tipo stanza = {Type}, Prezzo per notte = {PricePerNight}";
    }
}