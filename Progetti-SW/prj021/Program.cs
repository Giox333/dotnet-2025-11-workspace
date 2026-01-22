using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

// Classe che rappresenta la risposta JSON
public class DogFacts
{
    public string[] facts { get; set; }
    public bool success { get; set; }
}

class Program
{
    static async Task Main(string[] args)
    {
        // Creare un'istanza di HttpClient
        using HttpClient client = new HttpClient();
        int numero;
        do
        {
            System.Console.WriteLine("Inserisci un numero tra 1 e 4:");
        } while (!int.TryParse(Console.ReadLine(), out numero) || numero < 1 || numero > 5);
        System.Console.WriteLine($"Richiesti {numero} fun facts");

        try
        {
            // Effettuare una richiesta GET all'API
            HttpResponseMessage response = await client.GetAsync("https://dogapi.dog/api/facts?number=4");
            response.EnsureSuccessStatusCode();

            // Leggere il contenuto della risposta come stringa
            string responseBody = await response.Content.ReadAsStringAsync();

            // Deserializzare il JSON nella classe FoxImage
            DogFacts dogfacts = JsonSerializer.Deserialize<DogFacts>(responseBody);

            // Stampare l'URL dell'immagine
            string testo = "Fun facts: ";
            for (int i = 0; i < numero; i++)
            {
                testo += $"\n {i + 1}: " + dogfacts.facts[i];
            }
            Console.WriteLine(testo);
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine("\nEccezione catturata!");
            Console.WriteLine("Messaggio: {0} ", e.Message);
        }
    }
}