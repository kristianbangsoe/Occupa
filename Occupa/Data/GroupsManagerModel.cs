using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace Occupa.Data
{
    class GroupsManagerModel
    {
        string url = "http://nooter.dk/api/api/collections/get/groups?token=c73f307d2bb545063243446e2cda92";
        string authorizationKey;

        private async Task<HttpClient> GetClient()
        {
            HttpClient client = new HttpClient();
            if (string.IsNullOrEmpty(authorizationKey))
            {
                authorizationKey = JsonConvert.DeserializeObject<string>(await client.GetStringAsync(url));
            }

            client.DefaultRequestHeaders.Add("Accept", "application/json");

            return client;
        }


        public async Task<IEnumerable<GroupsModel>> GetAll()
        {

            HttpClient client = await GetClient();
            return JsonConvert.DeserializeObject<IEnumerable<GroupsModel>>(await client.GetStringAsync(url));

        }

      /*  public async Task<GroupsModel> Add(string title, string author, string genre)
        {
            HttpClient client = await GetClient();
            GroupsModel groupsModelObj = new GroupsModel();
            groupsModelObj.Authors = new List<string>(new[] { author });
            groupsModelObj.Genre = genre;
            groupsModelObj.Title = title;
            groupsModelObj.PublishDate = DateTime.Now.Date;

            StringContent groupsModelObjToSend = new StringContent(JsonConvert.SerializeObject(groupsModelObj), Encoding.UTF8, "application/json");
            var response = await client.PostAsync(url, groupsModelObjToSend);
            return JsonConvert.DeserializeObject<GroupsModel>(await response.Content.ReadAsStringAsync());
        }

        public async Task Update(GroupsModel groupsModel)
        {
            HttpClient client = await GetClient();
            GroupsModel groupsModelObj = new GroupsModel();
            groupsModelObj.Authors = new List<string>(new[] { author });
            groupsModelObj.Genre = genre;
            groupsModelObj.Title = title;
            groupsModelObj.PublishDate = DateTime.Now.Date;

            StringContent bookObjToSend = new StringContent(JsonConvert.SerializeObject(groupsModelObj), Encoding.UTF8, "application/json");
            var response = await client.PutAsync(url, bookObjToSend);
            return JsonConvert.DeserializeObject<GroupsModel>(await response.Content.ReadAsStringAsync());
        }

        public async Task Delete(string isbn)
        {
            HttpClient client = await GetClient();

            // TODO: use DELETE to delete a book
            throw new NotImplementedException();
        }
        */
    }
}
