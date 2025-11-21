public class Activity
{
    public string Title{get;set;}
    public int Duration{get;set;}
    public string Instructor{get;set;}
    public Activity():this("Classe di Yoga",60,"Gianpancrazio"){}
    public Activity(string titolo, int durata, string istruttore)
    {
        this.Title = titolo;
        this.Duration = durata;
        this.Instructor = istruttore;
    }
    public override string ToString()
    {
        return $"Titolo attività = {Title}, Durata = {Duration}, Istruttore = {Instructor}";
    }
    public string GetDetails()
    {
        return ToString();
    }
}