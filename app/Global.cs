using MongoDB.Driver;

namespace app
{
    public class Global
    {
        public static MongoClient GetClientDB()
        {
           return new MongoClient("mongodb://localhost:27017");
        }

        public static IMongoDatabase ConnectDB()
        {
            MongoClient client = GetClientDB();
            return client.GetDatabase("Quanlihocsinh");
        }
    }
}
