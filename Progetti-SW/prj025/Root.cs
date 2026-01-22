using System.Collections.Generic;
using System.Text.Json.Serialization;

public class Root
{
    [JsonPropertyName("imageUrl")]
    public string? ImageUrl { get; set; }

    [JsonPropertyName("bookId")]
    public string? BookId { get; set; }

    [JsonPropertyName("workId")]
    public string? WorkId { get; set; }

    [JsonPropertyName("bookUrl")]
    public string? BookUrl { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("author")]
    public List<Author>? Author { get; set; }

    // nel JSON rank e rating sono stringhe (es. "1", "4.35") -> mantengo string per evitare errori di conversione
    [JsonPropertyName("rank")]
    public string? Rank { get; set; }

    [JsonPropertyName("rating")]
    public string? Rating { get; set; }

    [JsonPropertyName("totalRatings")]
    public string? TotalRatings { get; set; }

    [JsonPropertyName("publishedYear")]
    public string? PublishedYear { get; set; }

    [JsonPropertyName("totalEditions")]
    public string? TotalEditions { get; set; }

    public override string ToString()
    {
        return $"ISBN = {BookId}, Title = {Title}, Autore = {Author[0]}, Anno di publicazione = {PublishedYear}";
    }
}

public class Author
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}