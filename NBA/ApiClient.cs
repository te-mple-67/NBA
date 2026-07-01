using Newtonsoft.Json;
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

        public List<Team> GetTeams()
        {
            try
            {
                string url = baseUrl + "teams";
                HttpResponseMessage response = client.GetAsync(url).Result;

                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                    var result = JsonConvert.DeserializeObject<TeamResponse>(json);
                    return result.data;
                }
                else
                {
                    MessageBox.Show($"Ошибка: {response.StatusCode}");
                    return new List<Team>();
                }
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("Нет подключения к интернету");
                return new List<Team>();
            }
        }

        public List<Player> GetPlayers(int teamId)
        {
            try
            {
                string url = baseUrl + $"players?team_ids[]={teamId}&per_page=25";
                HttpResponseMessage response = client.GetAsync(url).Result;

                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                    var result = JsonConvert.DeserializeObject<PlayerResponse>(json);
                    return result.data;
                }
                else
                {
                    MessageBox.Show($"Ошибка: {response.StatusCode}");
                    return new List<Player>();
                }
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("Нет подключения к интернету");
                return new List<Player>();
            }
        }
    }

}

