public class Hotel
{
    public string Name { get; set; }
    public string Address { get; set; }
    public int Stars { get; set; }
    public List<Room> Rooms { get; set; }
    public List<Service> Services { get; set; }
    public Hotel() : this("Hotel Reverie", "Via Netflix 1", 1) { }
    public Hotel(string nome, string indirizzo, int stelle)
    {
        this.Name = nome;
        this.Address = indirizzo;
        this.Stars = stelle;
        this.Rooms = new List<Room>();
        this.Services = new List<Service>();
    }
    public void AddRoom(Room stanza)
    {
        if (stanza == null)
            return;
        this.Rooms.Add(stanza);
    }
    public void AddService(Service servizio)
    {
        if (servizio == null)
            return;
        this.Services.Add(servizio);
    }
    public List<Room> GetRooms()
    {
        return Rooms;
    }
    public List<Service> GetService()
    {
        return Services;
    }
    public override string ToString()
    {
        return $"Nome hotel = {Name}, Indirizzo = {Address}, Numero di stelle = {Stars}";
    }
}