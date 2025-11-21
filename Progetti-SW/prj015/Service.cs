public class Service
{
    public string Name{get;set;}
    public string Description{get;set;}
    public List<Activity> Activities{get;set;}
    public Service(): this("Ginnastica","Varie attività fisiche per mantenere attivo il corpo"){}
    public Service(string nome, string descrizione)
    {
        this.Name = nome;
        this.Description = descrizione;
        this.Activities = new List<Activity>();
    }
    public void AddActivity(Activity attività)
    {
        if(attività == null)
            return;
        this.Activities.Add(attività);
    }
    public List<Activity> GetActivity()
    {
        return Activities;
    }
    public override string ToString()
    {
        return $"Nome Servizio = {Name}, Descrizione = {Description}";
    }
}