namespace PCKonfiguratorBackend.Models
{
    public class Sitebar
    {
        public Guid? id { get; set; }
        public string? name { get; set; }
        public float? preis { get; set; }

        public Sitebar() { }

        public Sitebar(Guid? id, string? name, float? preis)
        {
            this.id = id;
            this.name = name;
            this.preis = preis;
        }
    }
}
