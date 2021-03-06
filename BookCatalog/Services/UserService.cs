using BookCatalog.Models;
using BookCatalog.Models.Database;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookCatalog.Services
{
    public class UserService
    {
        private readonly IMongoCollection<User> _users;

        public UserService(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _users = database.GetCollection<User>("users");
        }

        public User Create(User user)
        {
            _users.InsertOne(user);
            return user;
        }

        public IList<User> Read() =>
            _users.Find(user => true).ToList();

        public User Find(ObjectId id) =>
            _users.Find(user => user.Id == id).SingleOrDefault();

        public void Update(User user) =>
            _users.ReplaceOne(usr => usr.Id == user.Id, user);
        
        public void Delete(ObjectId id) =>
            _users.DeleteOne(user => user.Id == id);

    }
}
