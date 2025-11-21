public class User
{
    public string Username{get; set;}
    public string Email{get; set;}

    public Phone Phone{get; set;}

    public User()
    {
        Username = "Palle";
        Email = "test@gmail.com";
        Phone = new Phone();
    }

    public User(string username, string email, Phone tel)
    {
        Username = username;
        Email = email;
        Phone = tel;
    }
    public void setPhone(Phone tel)
    {
        Phone = tel;
    }

    public Phone getPhone()
    {
        return Phone;
    }

    public string toString()
    {
        return $"{Username}, {Email}, {Phone.getDetails()}";
    }
}
