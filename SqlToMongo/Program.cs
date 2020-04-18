using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using MongoDB.Driver;

namespace SqlToMongo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("AirData2020");
            var collection = database.GetCollection<Final_View>("AirData2020");

            if (collection.Count(FilterDefinition<Final_View>.Empty) <= 1)
            {
                await PopulateMongoDb(collection);
            }
            var list = await collection.Find(x => x.Navn == "Risø")
                .ToListAsync();

            foreach (var data in list)
            {
                Console.WriteLine(data.StofNavn);
            }
        }

        public static async Task PopulateMongoDb(IMongoCollection<Final_View> collection)
        {
            Worker worker = new Worker();
            // Populate
            var data = await worker.GetAllDataAsync();
            await collection.InsertManyAsync(data);
        }
    }
}
