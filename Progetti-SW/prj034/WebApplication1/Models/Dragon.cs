// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class OriginPlanet
    {
        public object? id { get; set; }
        public string name { get; set; }
        public bool isDestroyed { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        public object deletedAt { get; set; }
    }

    public class Dragon
    {
        public object? id { get; set; }
        public string name { get; set; }
        public string ki { get; set; }
        public string maxKi { get; set; }
        public string race { get; set; }
        public string gender { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        public string affiliation { get; set; }
        public object deletedAt { get; set; }
        public OriginPlanet originPlanet { get; set; }
        public List<Transformation> transformations { get; set; }
    }

    public class Transformation
    {
        public object? id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string ki { get; set; }
        public object deletedAt { get; set; }
    }

