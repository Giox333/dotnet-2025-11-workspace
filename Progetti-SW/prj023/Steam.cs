public class Data
{
    public string name { get; set; }
    public string desc { get; set; }
    public string release_date { get; set; }
    public List<Pricing> pricing { get; set; }
    public List<ExternalLink> external_links { get; set; }
    public List<string> tags { get; set; }
    public List<string> lang { get; set; }
    public DevDetails dev_details { get; set; }
    public Media media { get; set; }
    public SysReq sys_req { get; set; }
    public string about_game { get; set; }
    public override string ToString()
    {
        return $"Gioco: {name}, About = {about_game}";
    }
}

public class DevDetails
{
    public List<string> developer_name { get; set; }
    public List<string> publisher { get; set; }
    public List<object> franchise { get; set; }
}

public class ExternalLink
{
    public string name { get; set; }
    public string link { get; set; }
}

public class Linux
{
    public List<string> min { get; set; }
    public List<string> recomm { get; set; }
}

public class Media
{
    public List<object> screenshot { get; set; }
    public List<object> videos { get; set; }
}

public class Pricing
{
    public string discount { get; set; }
    public string originalPrice { get; set; }
    public string discountPrice { get; set; }
}

public class Root
{
    public int status { get; set; }
    public string message { get; set; }
    public Data data { get; set; }
}

public class SysReq
{
    public Window window { get; set; }
    public Linux linux { get; set; }
}

public class Window
{
    public List<string> min { get; set; }
    public List<string> recomm { get; set; }
}
