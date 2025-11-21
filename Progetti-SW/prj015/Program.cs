namespace prj015;

class Program
{
    static void Main(string[] args)
    {
        Hotel reverie = new Hotel();
        System.Console.WriteLine(reverie);
        reverie.AddRoom(new Room(1, "Pro", 10000));
        reverie.AddRoom(new Room());
        reverie.AddService(new Service());
        reverie.AddService(new Service("Test", "Descrizione test"));

        List<Room> stanze1 = reverie.GetRooms();
        foreach (var stanza in stanze1)
            System.Console.WriteLine(stanza.ToString());
        System.Console.WriteLine("\n");

        List<Service> servizi1 = reverie.GetService();
        foreach (var servizio in servizi1)
            System.Console.WriteLine(servizio.ToString());
        System.Console.WriteLine("\n");

        Room stanze2 = new Room();
        stanze2.AddBooking(new Booking());
        List<Booking> prenotazioni1 = stanze2.GetBooking();
        foreach(var prenotazione in prenotazioni1)
            System.Console.WriteLine(prenotazione.ToString());
    }
}
