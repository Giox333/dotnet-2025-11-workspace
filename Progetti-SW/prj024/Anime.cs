
public class Anime
{
    public int __v { get; set; }
    public List<string>? alternativeTitles { get; set; }
    public List<string>? genres { get; set; }
    public bool hasRanking { get; set; }
    public string? image { get; set; }
    public string? link { get; set; }
    public int ranking { get; set; }
    public string? thumb { get; set; }
    public string? title { get; set; }
    public object? episodes { get; set; }
    public bool hasEpisode { get; set; }
    public string? status { get; set; }
    public string? synopsis { get; set; }
    public string? type { get; set; }
    public DateTime updatedAt { get; set; }
    public string? workerId { get; set; }
    public string? id { get; set; }
    public string? _id { get; set; }

    public override string ToString()
    {
        return @$"Titolo = {title}, Ranking = {ranking}
        Descrizione = {synopsis}
        " + Generi();
    }
    public string? TitoliAlternativi()
    {
        string titoli = "Titoli alternativi: ";
        foreach (var titolo in this.alternativeTitles!)
        {
            titoli += $"\n {titolo}";
        }
        return titoli;
    }
    public string? Generi()
    {
        string generi="Generi: ";
        foreach(var genere in genres!)
        {
            generi += $"{genere}, ";
        }
        return generi;
    }
} 