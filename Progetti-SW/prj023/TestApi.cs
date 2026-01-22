
using System.Net.Http.Headers;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;


RetrieverManager manager = new RetrieverManager("cf49b87064mshbd15f06691e0c69p177397jsn3b686c354843");

System.Console.WriteLine(manager.Search("Monster Hunter"));





/* 
var client = new RestClient("https://games-details.p.rapidapi.com/gameinfo/single_game/2246340");
var request = new RestRequest("", Method.Get);
request.AddHeader("x-rapidapi-key", "cf49b87064mshbd15f06691e0c69p177397jsn3b686c354843");
request.AddHeader("x-rapidapi-host", "games-details.p.rapidapi.com");
var response = client.Execute(request);

//System.Console.WriteLine($"Status: {response.StatusCode}, Success: {response.IsSuccessful}");

//IRestResponse response = client.Execute(request);
try
{
    var root = JsonSerializer.Deserialize<Root>(response.Content);
    Data gioco = root?.data;
    System.Console.WriteLine(root.message + " " + root.status);
    System.Console.WriteLine(root.data.name);
    System.Console.WriteLine(gioco.name);
    System.Console.WriteLine(gioco.release_date);
    System.Console.WriteLine(gioco.desc);

    System.Console.WriteLine(gioco.ToString());
     if(gioco == null)
    {
        var root = JsonSerializer.Deserialize<Root>(response.Content);
        gioco = root?.Data;
    } 

    if (gioco == null)
    {
        System.Console.WriteLine("Deserializzazione fallita");
    }
    else
        gioco.ToString();
}
catch (JsonException e)
{
    System.Console.WriteLine("Errore Deserializzazione " + e.Message);
}

//System.Console.WriteLine(response.Content);
//System.Console.WriteLine(gioco.ToString());
// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
 */