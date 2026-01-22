/* using System.Net.Http.Headers;

public class RetrieverManager
{
    private HttpClient _client;
    private HttpRequestMessage _request;
    const string URL = "https://myanimelist.p.rapidapi.com/anime/top/all?";
    public RetrieverManager()
    {
        this._client = new HttpClient();
        this._request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri(URL),
            Headers =
                {
                    { "x-rapidapi-key", "cf49b87064mshbd15f06691e0c69p177397jsn3b686c354843" },
                    { "x-rapidapi-host", "myanimelist.p.rapidapi.com" },
                },
        };
    }
    public async void Search()
    {
        using (var response = await _client.SendAsync(_request))
        {
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            Console.WriteLine(body);
        }
    }
} */

using System.Text.Json;
using RestSharp;

public class RetrieverManager
{
    private RestClient _client;
    private RestRequest _request;
    private const string URL = "https://myanimelist.p.rapidapi.com/anime/top/%7Bcategory%7D?p=1";
    //const string apiKey = "cf49b87064mshbd15f06691e0c69p177397jsn3b686c354843";

    //public RestClient {get}
    public RetrieverManager(string apiKey)
    {
        this._client = new RestClient(URL);
        this._request = new RestRequest("", Method.Get);
        _request.AddHeader("x-rapidapi-key", apiKey);
        _request.AddHeader("x-rapidapi-host", "myanimelist.p.rapidapi.com");
    }
    public object? Search(/* int value */)
    {
        _client = new RestClient(URL );
        var response = this._client.Execute(this._request);
        //return DeserializeData(response.Content!);
        return response.Content;
    }
    private Root? DeserializeData(string response)
    {
        return JsonSerializer.Deserialize<Root>(response);
    }
}