using RestSharp;

public class RetrieverManager
{
    private RestClient _client;
    private RestRequest _request;
    private const string URL = "https://games-details.p.rapidapi.com/gameinfo/single_game";
    //const string apiKey = "cf49b87064mshbd15f06691e0c69p177397jsn3b686c354843";

    //public RestClient {get}
    public RetrieverManager(string apiKey)
    {
        this._client = new RestClient(URL);
        this._request = new RestRequest("", Method.Get);
        _request.AddHeader("x-rapidapi-key", apiKey);
        _request.AddHeader("x-rapidapi-host", "games-details.p.rapidapi.com");
    }
    public string? Search(string value)
    {
        _client = new RestClient(URL + $"search?q={value}");
        var response = this._client.Execute(this._request);
        return response.Content;
    }
}