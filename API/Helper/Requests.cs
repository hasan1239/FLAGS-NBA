using FLAGS_NBA.API.Enum;
using FLAGS_NBA.API.Objects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FLAGS_NBA.API.Helper
{
    class Requests
    {
        internal async Task<List<Player>> GetPlayersAsync(string lastName)
        {
            string endpoint = EndPoint(TargetTypes.players, SubTargetType.lastName, lastName);
            var client = new HttpClient();
            HttpRequestMessage request = CreateRequest(endpoint);

            using (var response = await client.SendAsync(request).ConfigureAwait(false))
            {
                response.EnsureSuccessStatusCode();

                string body = response.Content.ReadAsStringAsync().Result;

                string playerStr = JObject.Parse(body)["api"]["players"].ToString();
                return JsonConvert.DeserializeObject<List<Player>>(playerStr);
            }
        }

        internal async Task<List<Game>> GetGamesAsync(string date)
        {
            string endpoint = EndPoint(TargetTypes.games, SubTargetType.date, date);
            var client = new HttpClient();
            HttpRequestMessage request = CreateRequest(endpoint);

            using (var response = await client.SendAsync(request).ConfigureAwait(false))
            {
                response.EnsureSuccessStatusCode();

                string body = response.Content.ReadAsStringAsync().Result;

                string gameStr = JObject.Parse(body)["api"]["games"].ToString();
                return JsonConvert.DeserializeObject<List<Game>>(gameStr);
            }
        }

        internal async Task<List<Team>> GetTeamsAsync(string shortName)
        {
            string endpoint = EndPoint(TargetTypes.teams, SubTargetType.shortName, shortName);
            var client = new HttpClient();
            HttpRequestMessage request = CreateRequest(endpoint);

            using (var response = await client.SendAsync(request).ConfigureAwait(false))
            {
                response.EnsureSuccessStatusCode();

                string body = response.Content.ReadAsStringAsync().Result;

                string teamStr = JObject.Parse(body)["api"]["teams"].ToString();
                return JsonConvert.DeserializeObject<List<Team>>(teamStr);
            }
        }

        internal async Task<List<Team>> GetAllTeamsAsync()
        {
            var client = new HttpClient();
            List<Team> teams = new List<Team>();
            string eastEndpoint = EndPoint(TargetTypes.teams, SubTargetType.confName, "East");
            string westEndpoint = EndPoint(TargetTypes.teams, SubTargetType.confName, "West");

            HttpRequestMessage eastReq = CreateRequest(eastEndpoint);
            using (var response = await client.SendAsync(eastReq).ConfigureAwait(false))
            {
                response.EnsureSuccessStatusCode();

                string body = response.Content.ReadAsStringAsync().Result;

                string playerStr = JObject.Parse(body)["api"]["teams"].ToString();
                teams.AddRange(JsonConvert.DeserializeObject<List<Team>>(playerStr));
            }

            HttpRequestMessage westReq = CreateRequest(westEndpoint);
            using (var response = await client.SendAsync(westReq).ConfigureAwait(false))
            {
                response.EnsureSuccessStatusCode();

                string body = response.Content.ReadAsStringAsync().Result;

                string playerStr = JObject.Parse(body)["api"]["teams"].ToString();
                teams.AddRange(JsonConvert.DeserializeObject<List<Team>>(playerStr));
            }

            return teams;
        }

        public static HttpRequestMessage CreateRequest(string endpoint)
        {
            HttpRequestMessage request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(endpoint),
                Headers =
                    {
                        { "x-rapidapi-key", "8c347f02dfmsh7b9bc43d239fb3cp17e860jsna630297c5efe" },
                        { "x-rapidapi-host", "api-nba-v1.p.rapidapi.com" },
                        { "Accept", "application/json" }
                    },
            };

            return request;
        }

        public static string EndPoint(TargetTypes type, SubTargetType subType, string param)
        {
            string targetType = EnumMapper.MapTarget(type);
            string subTarget = EnumMapper.Map(subType);

            if (targetType != null)
            {
                if (subType != SubTargetType.not_applicable)
                {
                    return string.Format("https://api-nba-v1.p.rapidapi.com/{0}/{1}/{2}", targetType, subTarget, param);
                }

                return string.Format("https://api-nba-v1.p.rapidapi.com/{0}/", targetType); 
            }

            return string.Empty;
        }

        #region Unused Code
        //string body = response.Content.ReadAsStringAsync().Result;
        /*XmlDocument doc = (XmlDocument)JsonConvert.DeserializeXmlNode(body);
        XmlNodeList list = doc.SelectNodes("api/players");

        foreach (XmlNode xmlNode in list)
        {
            string test = string.Empty;

            XmlSerializer serializer = new XmlSerializer(typeof(Player));

            using (TextReader reader = new StringReader(xmlNode.InnerXml))
            {
                Player player = (Player)serializer.Deserialize(reader);
            }

        }*/

        /*internal async void TestHTTPClient()
        {
            var client = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://api-nba-v1.p.rapidapi.com/players/lastName/curry"),
                Headers =
                    {
                        { "x-rapidapi-key", "8c347f02dfmsh7b9bc43d239fb3cp17e860jsna630297c5efe" },
                        { "x-rapidapi-host", "api-nba-v1.p.rapidapi.com" },
                        { "Accept", "application/json" }
                    },
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();

                string body = response.Content.ReadAsStringAsync().Result;

                string playerStr = JObject.Parse(body)["api"]["players"].ToString();
                List<Player> player = JsonConvert.DeserializeObject<List<Player>>(playerStr);
            }
        }*/

        /*public async void TestHTTPClient2()
        {
            string endpoint = "https://api-nba-v1.p.rapidapi.com/players/lastName/curry";

            string content = string.Empty;
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("x-rapidapi-key", "8c347f02dfmsh7b9bc43d239fb3cp17e860jsna630297c5efe");
                //client.DefaultRequestHeaders.Host = "api-nba-v1.p.rapidapi.com";

                content = await client.GetStringAsync(endpoint).ConfigureAwait(false);
            }

            Player players = JsonConvert.DeserializeObject<Player>(content);
        }*/

        /*public void TestUniRest()
        {
            var client = new RestClient("https://api-nba-v1.p.rapidapi.com/seasons/");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-key", "8c347f02dfmsh7b9bc43d239fb3cp17e860jsna630297c5efe");
            request.AddHeader("x-rapidapi-host", "api-nba-v1.p.rapidapi.com");
            IRestResponse response = client.Execute(request);

            XmlDocument doc = (XmlDocument)JsonConvert.DeserializeXmlNode(response.Content);
        }*/
        #endregion
    }
}
