/* 

RetrieverManager manager = new RetrieverManager("cf49b87064mshbd15f06691e0c69p177397jsn3b686c354843");
manager.Search(); */
using System.Text.Json;
using System.Net.Http.Headers;

var client = new HttpClient();
var request = new HttpRequestMessage
{
	Method = HttpMethod.Get,
	RequestUri = new Uri("https://myanimelist.p.rapidapi.com/anime/52991"),
	Headers =
	{
		{ "x-rapidapi-key", "cf49b87064mshbd15f06691e0c69p177397jsn3b686c354843" },
		{ "x-rapidapi-host", "myanimelist.p.rapidapi.com" },
	},
};
using (var response = await client.SendAsync(request))
{
	response.EnsureSuccessStatusCode();
	var body = await response.Content.ReadAsStringAsync();
    Console.WriteLine(body);
    //List<Root> anime = JsonSerializer.Deserialize<List<Root>>(body);
    /* StreamWriter sw = new StreamWriter("Anime1.txt");
    foreach(var item in anime)
    {
        sw.WriteLine(item.ToString());
    }
    sw.Dispose(); */
    //System.Console.WriteLine(anime.title);
    
}