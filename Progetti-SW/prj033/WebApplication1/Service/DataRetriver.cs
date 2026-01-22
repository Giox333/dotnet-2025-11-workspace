
using System.Text.Json;


public class DataRetriver
{
    
   

    public static string CreaJson(string nome, string cognome)
    {
            Persona persona = new Persona
            {
                Nome = nome,
                Cognome = cognome
            };

            return JsonSerializer.Serialize(persona);
    }


}