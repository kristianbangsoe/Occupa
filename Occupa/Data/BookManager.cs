using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BookClient.Data
{
    public class BookManager
    {
        const string Url = "http://nooter.dk/api/api/collections/get/groups?token=c73f307d2bb545063243446e2cda92";
      


        public async Task<IEnumerable<Book>> GetAll()
        {
            // TODO: use GET to retrieve books
            HttpClient client = new HttpClient();
            string result = await client.GetStringAsync(Url);
            
            return JsonConvert.DeserializeObject<IEnumerable<Book>>(result);
        }

    }
}

