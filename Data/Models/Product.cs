using MongoDB.Bson;

namespace Demo.Models
{
    public class Product
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
    }
}
