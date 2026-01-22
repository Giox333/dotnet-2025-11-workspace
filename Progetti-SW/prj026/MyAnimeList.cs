// Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
public class Root
{
    public string? title { get; set; }
    public string? picture_url { get; set; }
    public string? myanimelist_url { get; set; }
    public int myanimelist_id { get; set; }
    public int rank { get; set; }
    public double score { get; set; }
    public string? type { get; set; }
    public string? aired_on { get; set; }
    public int members { get; set; }

    public override string ToString()
    {
        return $" Titolo = {title}, Rank = {rank}, Score = {score}, Tipo = {type}";
    }
}

