using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;

namespace My_Residence
{
    public class MainRoomDataService
    {
        private const string GET_MAINROOM = "https://api.myjson.com/bins/zshoi";

        public async Task<List<MainRoom>> getMainRoomListAsync()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await httpClient.GetAsync(GET_MAINROOM);

            if (response != null || response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();

                System.Diagnostics.Debug.WriteLine("Kishan " + content);
                Console.Out.WriteLine("Response Body: \r\n {0}", content);
                var mrListData = new List<MainRoom>();
                JObject jsonResponse = JObject.Parse(content);
                IList<JToken> results = jsonResponse["mainroom"].ToList();
                foreach (JToken token in results)
                {
                    MainRoom mr = token.ToObject<MainRoom>();
                    mrListData.Add(mr);
                }
                System.Diagnostics.Debug.WriteLine("Kishan " + mrListData);

                return mrListData;
            }
            else
            {
                Console.Out.WriteLine("Failed to fetch JSON data. Please try again later");
                return null;
            }
        }
    }


}