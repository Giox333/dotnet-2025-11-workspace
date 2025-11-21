public class Route
{
    public string RouteID{get;set;}
    public string Origin{get;set;}
    public string Destination{get;set;}
    public float DistanceKm{get;set;}
    public Route(): this("00","China","Padova",7954){}
    public Route(string id, string origine, string destinazione, float distanza)
    {
        this.RouteID = id;
        this.Origin = origine;
        this.Destination = destinazione;
        this.DistanceKm = distanza;
    }
    public override string ToString()
    {
        return $"Id strada = {RouteID}, Origine = {Origin}, Destinazione = {Destination}, Distanza = {DistanceKm}";
    }
    public string GetSummary()
    {
        return ToString();
    }
}