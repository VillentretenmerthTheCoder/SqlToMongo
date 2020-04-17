using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SqlToMongo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Worker worker = new Worker();

         IList<Final_View> data = await worker.GetAllDataAsync();
            Console.WriteLine(data);
        }
    }
}
