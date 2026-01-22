using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

public class ItalianJoke
{
    public int id{get;set;}
    public string? joke {get;set;}
    public string? type {get;set;}
    public string? subtype{get;set;}
}

class Program
{
    static async Task Main(string[] args)
    {
        using HttpClient client = new HttpClient();
        try
        {
            HttpResponseMessage risposta = await client.GetAsync("https://italian-jokes.vercel.app/api/jokes");
            risposta.EnsureSuccessStatusCode();

            string testoRisposta = await risposta.Content.ReadAsStringAsync();
            ItalianJoke battuta = JsonSerializer.Deserialize<ItalianJoke>(testoRisposta)!;

            System.Console.WriteLine("\nBattuta: \n"+ battuta.joke);
        }
        catch(HttpRequestException e)
        {
            System.Console.WriteLine("\nEccezione catturata");
            System.Console.WriteLine("Messaggio: {0}", e.Message);
        }
    }
}
