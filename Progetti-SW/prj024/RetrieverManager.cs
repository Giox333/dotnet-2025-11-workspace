using System.Text.Json;
using RestSharp;

public class RetrieverManager
{
    private RestClient _client;
    private RestRequest _request;
    private const string URL = "https://anime-db.p.rapidapi.com/anime/by-ranking/";
    //const string apiKey = "cf49b87064mshbd15f06691e0c69p177397jsn3b686c354843";

    //public RestClient {get}
    public RetrieverManager(string apiKey)
    {
        this._client = new RestClient(URL);
        this._request = new RestRequest("", Method.Get);
        _request.AddHeader("x-rapidapi-key", apiKey);
        _request.AddHeader("x-rapidapi-host", "anime-db.p.rapidapi.com");
    }
    public object? Search(int value)
    {
        _client = new RestClient(URL + $"{value}");
        var response = this._client.Execute(this._request);
        return DeserializeData(response.Content!);
    }
    private Anime? DeserializeData(string response)
    {
        return JsonSerializer.Deserialize<Anime>(response);
    }
}