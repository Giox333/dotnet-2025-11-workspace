using System.Net.Http.Headers;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;


RetrieverManager manager = new RetrieverManager("cf49b87064mshbd15f06691e0c69p177397jsn3b686c354843");
System.Console.WriteLine(manager.Search(1));


/* 
int numero;
do
{
    System.Console.WriteLine("Inserisci un numero:");
} while (!int.TryParse(Console.ReadLine(), out numero) || numero < 1);
//System.Console.WriteLine($"Richiesti {numero} fun facts");


var client = new HttpClient();
var request = new HttpRequestMessage
{
    Method = HttpMethod.Get,
    RequestUri = new Uri($"https://anime-db.p.rapidapi.com/anime/by-ranking/{numero}"),
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
    //Console.WriteLine(body);
    Anime anime1 = JsonSerializer.Deserialize<Anime>(body);
    System.Console.WriteLine(anime1.ToString());
    //System.Console.WriteLine(anime1.TitoliAlternativi());
} */