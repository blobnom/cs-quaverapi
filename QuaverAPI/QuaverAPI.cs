using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace QuaverAPI
{
    public class API
    {
        private static readonly HttpClient _http = new();

        public static async Task<string> ApiCallAsync(string endpoint)
        {
            var resp = await _http.GetAsync("https://api.quavergame.com/v1" + endpoint);
            return await resp.Content.ReadAsStringAsync();
        }

        public static async Task<Structures.ServerStats> GetServerStatsAsync()
        {
            var data = await ApiCallAsync("/stats");
            Structures.Server server = JsonConvert.DeserializeObject<Structures.Server>(data);
            return server.stats;
        }

        public static async Task<Structures.UserData> GetUserAsync(int id)
        {
            var data = await ApiCallAsync("/users/full/" + id);
            Structures.User user = JsonConvert.DeserializeObject<Structures.User>(data);
            return user.user;
        }

        public static async Task<List<Structures.UserInfo>> SearchUsersAsync(string name)
        {
            var data = await ApiCallAsync("/users/search/" + name);
            Structures.Users users = JsonConvert.DeserializeObject<Structures.Users>(data);
            return users.users;
        }

        public static async Task<List<Structures.Rank>> GetUserRankGraphAsync(int id, int mode)
        {
            var data = await ApiCallAsync($"/users/graph/rank?id={id}&mode={mode}");
            Structures.RankHistory ranks = JsonConvert.DeserializeObject<Structures.RankHistory>(data);
            return ranks.ranks;
        }

        public static async Task<List<Structures.Achievement>> GetUserAchievementsAsync(int id)
        {
            var data = await ApiCallAsync($"/users/{id}/achievements");
            Structures.Achievements achievements = JsonConvert.DeserializeObject<Structures.Achievements>(data);
            return achievements.achievements;
        }

        public static async Task<List<Structures.Mapset>> GetUserMapsetsAsync(int id)
        {
            var data = await ApiCallAsync("/users/mapsets/" + id);
            Structures.UserMapsets mapsets = JsonConvert.DeserializeObject<Structures.UserMapsets>(data);
            return mapsets.mapsets;
        }

        public static async Task<Structures.Map> GetMapAsync(int id)
        {
            var data = await ApiCallAsync("/maps/" + id);
            Structures.Maps map = JsonConvert.DeserializeObject<Structures.Maps>(data);
            return map.map;
        }

        public static async Task<Structures.Mapset> GetMapsetAsync(int id)
        {
            var data = await ApiCallAsync("/mapsets/" + id);
            Structures.Mapsets mapset = JsonConvert.DeserializeObject<Structures.Mapsets>(data);
            return mapset.mapset;
        }

        public static async Task<List<Structures.Score>> GetUserRecentAsync(int id, int mode)
        {
            var data = await ApiCallAsync($"/users/scores/recent?id={id}&mode={mode}");
            Structures.Scores scores = JsonConvert.DeserializeObject<Structures.Scores>(data);
            return scores.scores;
        }

        public static async Task<List<Structures.Score>> GetUserBestAsync(int id, int mode)
        {
            var data = await ApiCallAsync($"/users/scores/best?id={id}&mode={mode}");
            Structures.Scores scores = JsonConvert.DeserializeObject<Structures.Scores>(data);
            return scores.scores;
        }

        public static async Task<List<Structures.Score>> GetUserFirstPlaceAsync(int id, int mode)
        {
            var data = await ApiCallAsync($"/users/scores/firstplace?id={id}&mode={mode}");
            Structures.Scores scores = JsonConvert.DeserializeObject<Structures.Scores>(data);
            return scores.scores;
        }

        public static async Task<List<Structures.MapScore>> GetMapScoresAsync(int id)
        {
            var data = await ApiCallAsync("/scores/map/" + id);
            Structures.MapScores scores = JsonConvert.DeserializeObject<Structures.MapScores>(data);
            return scores.scores;
        }
    }
}
