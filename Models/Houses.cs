namespace csgregslist.Models
{
    public class Houses
    {
        public string Id { get; set; }
        public int Bathrooms { get; set; }
        public int Bedrooms { get; set; }
        public int Levels { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public Houses(string id, int bathrooms, int bedrooms, int levels, double price, string description)
        {
            Id = id;
            Bathrooms = bathrooms;
            Bedrooms = bedrooms;
            Levels = levels;
            Price = price;
            Description = description;

        }
    }
}