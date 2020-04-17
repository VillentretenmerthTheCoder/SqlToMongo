using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace SqlToMongo
{
    class Worker
    {
        private string URL = "https://localhost:44382/Final_View";

        public async Task<IList<Final_View>> GetAllDataAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                string content = await client.GetStringAsync(URL);
                IList<Final_View> cList = JsonConvert.DeserializeObject<IList<Final_View>>(content);
                return cList;
            }
        }

       
    }
}
