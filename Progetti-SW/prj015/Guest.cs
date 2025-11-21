public class Guest
{
    public string FullName{get;set;}
    public string DocumentId{get;set;}
    public string Phone{get;set;}
    public Guest(): this("Giovanni","BRN111","3331117755"){}
    public Guest(string nome, string id, string telefono)
    {
        this.FullName = nome;
        this.DocumentId = id;
        this.Phone = telefono;
    }
    public override string ToString()
    {
        return $"Nome ospite = {FullName}, Documento = {DocumentId}, Numero di telefono = {Phone}";
    } 
    public string GetSummary()
    {
        return ToString();
    }
}