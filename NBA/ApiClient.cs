using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBA
{
    public class ApiClient
    {
        private static readonly HttpClient client = new HttpClient();
        private const string apiKey = "0f5fb167-3fc5-4cdc-a058-562d78209ce7";
        private const string baseUrl = "https://api.balldontlie.io/v1/";

        public ApiClient()
        {
            client.DefaultRequestHeaders.Add("Authorization", apiKey);
        }

        public string GetTeams()
        {
            string url = baseUrl + "teams";
            HttpResponseMessage response = client.GetAsync(url).Result;

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsStringAsync().Result;
            }
            else
            {
                MessageBox.Show($"Ошибка: {response.StatusCode}");
                return null;
            }
        }
    }
}
