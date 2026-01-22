 using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
/*
public class Datum
{
    public int __v { get; set; }
    public List<string> alternativeTitles { get; set; }
    public List<string> genres { get; set; }
    public bool hasRanking { get; set; }
    [Required]
    [MaxLength(300)]
    public string image { get; set; }
    [Required]
    [MaxLength(300)]
    public string link { get; set; }
    [Required]
    public int ranking { get; set; }
    public string thumb { get; set; }
    [Required]
    [MaxLength(300)]
    public string title { get; set; }
    public int episodes { get; set; }
    [Required]
    public bool hasEpisode { get; set; }
    [Required]
    [MaxLength(100)]
    public string status { get; set; }
    [Required]
    [Column(TypeName = "longtext")]
    public string synopsis { get; set; }
    [Required]
    [MaxLength(100)]
    public string type { get; set; }
    public DateTime updatedAt { get; set; }
    public string workerId { get; set; }
    [Required]
    public double score { get; set; }
    [Required]
    [MaxLength(10)]
    public string id { get; set; }
    [Key]
    [MaxLength(10)]
    public string _id { get; set; }

    public override string ToString()
    {
        return $"Dati Anime:\n " +
               $"ID: {_id}, Title: {title}, Type: {type}, Status: {status}, Score: {score}, " +
               $"Ranking: {ranking}, Episodes: {episodes}, " +
               $"Synopsis: {synopsis}";
        //return $"[{_id}] {title} ({type}) - Score: {score}, Status: {status}, Episodes: {episodes}";

    }
}

public class Meta
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int page { get; set; }
    public int size { get; set; }
    public int totalData { get; set; }
    public int totalPage { get; set; }
    public override string ToString()
    {
        return $"Meta:\nId = {Id}, Pagina = {page}, Size = {size}, Dati totali ={totalData}, Pagine totali ={totalPage}";
    }
}

public class Root
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public List<Datum> data { get; set; }
    public Meta meta { get; set; }
    public Root(Meta meta)
    {
        this.meta = meta;
        this.data = new List<Datum>();
    }
    public Root(Root root)
    {
        this.meta = root.meta;
        this.data = root.data;
    }
    public Root()
    {
        data = new List<Datum>();
    }
    public static Root From(Root other)
    {
        var r = new Root();
        r.meta = other.meta;
        r.data = other.data;
        return r;
    }
    public override string ToString()
    {
        /* var metaStr = meta != null ? meta.ToString() : "[meta is null]";
        var dataCount = data != null ? data.Count : 0;
        return $"Root ID: {Id}, Data count: {dataCount}, {metaStr}"; 
        string testo = "";
        foreach(var a in data)
            testo += $"\n\n {a.ToString()}";
        return testo;
    }
} */

//versione MyAnimeList
public class Root
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    [MaxLength(200)]
    public string title { get; set; }
    [Required]
    [MaxLength(300)]
    public string picture_url { get; set; }
    [Required]
    [MaxLength(300)]
    public string myanimelist_url { get; set; }
    [Required]
    public int myanimelist_id { get; set; }
    public int rank { get; set; }
    public double score { get; set; }
    [Required]
    [MaxLength(100)]
    public string type { get; set; }
    [Required]
    [MaxLength(200)]
    public string aired_on { get; set; }
    public int members { get; set; }
    public Root(){}
    public Root(string titolo, string picture_url, string malUrl, int rank, double score, string tipo, string aired_on, int membri)
    {
        this.title = titolo;
        this.picture_url = picture_url;
        this.myanimelist_url = malUrl;
        this.rank = rank;
        this.score = score;
        this.type = tipo;
        this.aired_on = aired_on;
        this.members = membri;
    }
    public override string ToString()
    {
        return $"Titolo = {title}, Rank = {rank}, Score = {score}, Tipo = {type}" +
               $" Periodo di rilascio = {aired_on}, Membri = {members}";
    }
}

