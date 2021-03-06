using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookCatalog.Models
{
    public class Book
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public int SchemaVersion { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public DateTime EntryDate { get; set; }
        public string ImageUrl { get; set; }
        public List<string> Notes { get; set; }
        public List<string> Quotes { get; set; }
    }
}
