using RestSharp;
using System.Text.Json;
using System.Text.Json.Serialization;

public class DragonRetriever
{
    public static object RetrieveCharacter(int id)
    {
        //https://dragonball-api.com/api/characters/

        var client = new RestClient("https://dragonball-api.com/api/characters/");
        var request = new RestRequest($"api/characters/{id}", Method.Get);

        request.AddHeader("Accept", "application/json");

        RestResponse response = client.Execute(request);

        if (!response.IsSuccessful)
        {
            System.Console.WriteLine("Errore");
            return null;
        }

        Dragon? dragon = JsonSerializer.Deserialize<Dragon>(response.Content ?? string.Empty);

        return dragon;
    }
}