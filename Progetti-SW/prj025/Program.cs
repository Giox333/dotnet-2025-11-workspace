/* Utente user1 = new Utente();
try
{
    user1.AddPrenotazione(new Prenotazione("11111", DateTime.Today, new DateTime(2026, 1, 1), Prenotazione.StatoPrenotazione.attiva));
    user1.AddPrenotazione(new Prenotazione("22222", new DateTime(2010, 1, 2), DateTime.Today, Prenotazione.StatoPrenotazione.completata));
    user1.AddPrenotazione(new Prenotazione("3333", DateTime.Today, new DateTime(2026, 1, 1), Prenotazione.StatoPrenotazione.attiva));
}
catch (Exception e)
{
    System.Console.WriteLine("Eccezzione trovata = " + e.Message);
}

string ris = user1.ToString();
System.Console.WriteLine(ris); */

/* using System.Net.Http.Headers;
var client = new HttpClient();
var request = new HttpRequestMessage
{
	Method = HttpMethod.Get,
	RequestUri = new Uri("https://anime-db.p.rapidapi.com/anime?page=1&size=10&search=Fullmetal&genres=Fantasy%2CDrama&sortBy=ranking&sortOrder=asc"),
	Headers =
	{
		{ "x-rapidapi-key", "cf49b87064mshbd15f06691e0c69p177397jsn3b686c354843" },
		{ "x-rapidapi-host", "anime-db.p.rapidapi.com" },
	},
};
using (var response = await client.SendAsync(request))
{
	response.EnsureSuccessStatusCode();
	var body = await response.Content.ReadAsStringAsync();
	Console.WriteLine(body);
} */

RetrieverManager manager = new RetrieverManager("cf49b87064mshbd15f06691e0c69p177397jsn3b686c354843");
List<Root>? anime = manager.Search();
//System.Console.WriteLine(libro[0].ToString());

Libro book1 = new Libro(libro1[0], Libro.Stato.disponibile, new Prenotazione());
System.Console.WriteLine(book1.ToString());



using var db = new ApplicationDbContext();

db.Dvd.RemoveRange(db.Dvd.ToList());

db.Dvd.Add(new Dvd());
db.Dvd.Add(new Dvd("titolo1" , "genere1"));
db.Dvd.Add(new Dvd("Infinite Hyperdeath" , "ultrakill"));


//salvare i cambiamenti

db.SaveChanges();