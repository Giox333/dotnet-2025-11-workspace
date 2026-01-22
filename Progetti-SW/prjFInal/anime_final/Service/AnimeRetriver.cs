using RestSharp;
using System.Text.Json;
using System.Text.Json.Serialization;

public class AnimeRetriver
{
    public static object RetrieveAnimeById(int id)
    {
        //https://dragonball-api.com/api/characters/

        var client = new RestClient("https://anime-db.p.rapidapi.com/anime/by-id/");
        var request = new RestRequest($"api/characters/{id}", Method.Get);

        request.AddHeader("Accept", "application/json");

        RestResponse response = client.Execute(request);

        if (!response.IsSuccessful)
        {
            System.Console.WriteLine("Errore");
            return null;
        }

        Root? dragon = JsonSerializer.Deserialize<Root>(response.Content ?? string.Empty);

        return dragon;
    }
}