using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookCatalog.Models
{
    public class Note
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public int SchemaVersion { get; set; }
        public string Title { get; set; }
        public string NoteText { get; set; }
        public string Chapter { get; set; }
        public string Page { get; set; }
        public DateTime EntryDate { get; set; }    
    }
}
