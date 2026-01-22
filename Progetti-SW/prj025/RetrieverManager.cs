using System.Text.Json;
using RestSharp;

public class RetrieverManager
{
    private RestClient _client;
    private RestRequest _request;
    private const string URL = "https://goodreads12.p.rapidapi.com/searchBooks?";
    //const string apiKey = "cf49b87064mshbd15f06691e0c69p177397jsn3b686c354843";

    public RetrieverManager(string apiKey)
    {
        this._client = new RestClient(URL);
        this._request = new RestRequest("", Method.Get);
        _request.AddHeader("x-rapidapi-key", apiKey);
        _request.AddHeader("x-rapidapi-host", "goodreads12.p.rapidapi.com");
    }
    public List<Root>? Search(string ricerca)
    {
        _client = new RestClient(URL + $"keyword={SplitString(ricerca)}&page=1");
        var response = this._client.Execute(this._request);
        System.Console.WriteLine(response.Content);
        return DeserializeData(response.Content!);
        //return response.Content;
    }
     private List<Root>? DeserializeData(string response)
    {
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        return JsonSerializer.Deserialize<List<Root>>(response ?? "[]", options);
    } 
    private string SplitString(string ricerca)
    {
        List<string> lista = ricerca.Split().ToList();
        string ris = "";
        foreach(var item in lista)
            ris += $"{item}%20";
        return ris;
    }
}