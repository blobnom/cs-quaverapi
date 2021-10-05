using Newtonsoft.Json;
using System.Collections.Generic;

namespace QuaverAPI
{
    public class Structures
    {
        public class User
        {
            [JsonProperty("user")]
            public UserData user;
        }

        public class Users
        {
            [JsonProperty("status")]
            public int status;
            [JsonProperty("users")]
            public List<UserInfo> users;
        }

        public class UserData
        {
            [JsonProperty("info")]
            public UserInfo info;
            [JsonProperty("keys4")]
            public UserMode keys4;
            [JsonProperty("keys7")]
            public UserMode keys7;
        }

        public class UserInfo
        {
            [JsonProperty("id")]
            public int id;
            [JsonProperty("steam_id")]
            public string steamId;
            [JsonProperty("username")]
            public string username;
            [JsonProperty("country")]
            public string country;
            [JsonProperty("avatar_url")]
            public string avatarUrl;
        }

        public class UserMode
        {
            [JsonProperty("globalRank")]
            public int globalRank;
            [JsonProperty("countryRank")]
            public int countryRank;
            [JsonProperty("multiplayerWinRank")]
            public int multiplayerWinRank;
            [JsonProperty("stats")]
            public UserStats stats;
        }

        public class UserStats
        {
            [JsonProperty("total_score")]
            public int totalScore;
            [JsonProperty("ranked_score")]
            public int rankedScore;
            [JsonProperty("overall_accuracy")]
            public float accuracy;
            [JsonProperty("overall_performance_rating")]
            public float rating;
            [JsonProperty("play_count")]
            public int playCount;
            [JsonProperty("fail_count")]
            public int failCount;
            [JsonProperty("max_combo")]
            public int maxCombo;
            [JsonProperty("replays_watched")]
            public int replaysWatched;
            [JsonProperty("total_marv")]
            public int totalMarvelous;
            [JsonProperty("total_perf")]
            public int totalPerfect;
            [JsonProperty("total_great")]
            public int totalGreat;
            [JsonProperty("total_good")]
            public int totalGood;
            [JsonProperty("total_okay")]
            public int totalOkay;
            [JsonProperty("total_miss")]
            public int totalMiss;
            [JsonProperty("total_pauses")]
            public int totalPauses;
            [JsonProperty("multiplayer_wins")]
            public int multiplayerWins;
            [JsonProperty("multiplayer_losses")]
            public int multiplayerLosses;
            [JsonProperty("multiplayer_ties")]
            public int multiplayerTies;
        }

        public class RankHistory
        {
            [JsonProperty("status")]
            public int status;
            [JsonProperty("statistics")]
            public List<Rank> ranks;
        }

        public class Rank
        {
            [JsonProperty("rank")]
            public int rank;
            [JsonProperty("timestamp")]
            public string timestamp;
        }

        public class Achievements
        {
            [JsonProperty("status")]
            public int status;
            [JsonProperty("achievements")]
            public List<Achievement> achievements;
        }

        public class Achievement
        {
            [JsonProperty("id")]
            public int id;
            [JsonProperty("steam_api_name")]
            public string steamApiName;
            [JsonProperty("name")]
            public string name;
            [JsonProperty("description")]
            public string description;
            [JsonProperty("difficulty")]
            public string difficulty;
            [JsonProperty("unlocked")]
            public bool unlocked;
        }

        public class UserMapsets
        {
            [JsonProperty("status")]
            public int status;
            [JsonProperty("mapsets")]
            public List<Mapset> mapsets;
        }

        public class Mapsets
        {
            [JsonProperty("status")]
            public int status;
            [JsonProperty("mapset")]
            public Mapset mapset;
        }

        public class Mapset
        {
            [JsonProperty("id")]
            public int id;
            [JsonProperty("package_md5")]
            public string md5;
            [JsonProperty("creator_id")]
            public int creatorId;
            [JsonProperty("creator_username")]
            public string creatorUsername;
            [JsonProperty("creator_avatar_url")]
            public string creatorAvatarUrl;
            [JsonProperty("artist")]
            public string artist;
            [JsonProperty("title")]
            public string title;
            [JsonProperty("source")]
            public string source;
            [JsonProperty("tags")]
            public string tags;
            [JsonProperty("description")]
            public string description;
            [JsonProperty("date_submitted")]
            public string submissionTimestamp;
            [JsonProperty("date_last_update")]
            public string lastUpdateTimestamp;
            [JsonProperty("visibible")]
            public int visible;
            [JsonProperty("ranked_status")]
            public int ranked_status;
            [JsonProperty("maps")]
            public List<Map> maps;
        }

        public class Maps
        {
            [JsonProperty("status")]
            public int status;
            [JsonProperty("map")]
            public Map map;
        }

        public class Map
        {
            [JsonProperty("id")]
            public int id;
            [JsonProperty("mapset_id")]
            public int mapsetId;
            [JsonProperty("md5")]
            public string md5;
            [JsonProperty("creator_id")]
            public int creatorId;
            [JsonProperty("creator_username")]
            public string creatorUsername;
            [JsonProperty("artist")]
            public string artist;
            [JsonProperty("title")]
            public string title;
            [JsonProperty("source")]
            public string source;
            [JsonProperty("tags")]
            public string tags;
            [JsonProperty("description")]
            public string description;
            [JsonProperty("difficulty_name")]
            public string difficultyName;
            [JsonProperty("count_hitobject_normal")]
            public int objectsNormal;
            [JsonProperty("count_hitobject_long")]
            public int objectsLong;
            [JsonProperty("play_count")]
            public int playcount;
            [JsonProperty("fail_count")]
            public int failcount;
            [JsonProperty("mods_pending")]
            public int modsPending;
            [JsonProperty("mods_accepted")]
            public int modsAccepted;
            [JsonProperty("mods_denied")]
            public int modsDenied;
            [JsonProperty("mods_ignored")]
            public int modsIgnored;
            [JsonProperty("online_offset")]
            public int onlineOffset;
        }

        public class Server
        {
            [JsonProperty("status")]
            public int status;
            [JsonProperty("stats")]
            public ServerStats stats;
        }

        public class ServerStats
        {
            [JsonProperty("total_online_users")]
            public long onlineUsers;
            [JsonProperty("total_users")]
            public long totalUsers;
            [JsonProperty("total_mapsets")]
            public long totalMapsets;
            [JsonProperty("total_scores")]
            public long totalScores;
        }

        public class Scores
        {
            [JsonProperty("status")]
            public int status;
            [JsonProperty("scores")]
            public List<Score> scores;
        }

        public class Score
        {
            [JsonProperty("id")]
            public int id;
            [JsonProperty("time")]
            public string timestamp;
            [JsonProperty("mode")]
            public int mode;
            [JsonProperty("mods")]
            public int mods;
            [JsonProperty("mods_string")]
            public string modsString;
            [JsonProperty("performance_rating")]
            public double rating;
            [JsonProperty("personal_best")]
            public bool personalBest;
            [JsonProperty("total_score")]
            public int totalScore;
            [JsonProperty("accuracy")]
            public double accuracy;
            [JsonProperty("grade")]
            public string grade;
            [JsonProperty("max_combo")]
            public int maxCombo;
            [JsonProperty("count_marv")]
            public int countMarvellous;
            [JsonProperty("count_perf")]
            public int countPerfect;
            [JsonProperty("count_great")]
            public int countGreat;
            [JsonProperty("count_good")]
            public int countGood;
            [JsonProperty("count_okay")]
            public int countOkay;
            [JsonProperty("count_miss")]
            public int countMiss;
            [JsonProperty("scroll_speed")]
            public int scrollSpeed;
            [JsonProperty("tournament_game_id")]
            public int tournamentGameId;
            [JsonProperty("ratio")]
            public double ratio;
            [JsonProperty("map")]
            public Map map;
        }

        public class MapScores
        {
            [JsonProperty("status")]
            public int status;
            [JsonProperty("scores")]
            public List<MapScore> scores;
        }

        public class MapScore
        {
            [JsonProperty("id")]
            public int id;
            [JsonProperty("map_md5")]
            public string mapMd5;
            [JsonProperty("time")]
            public string timestamp;
            [JsonProperty("mode")]
            public int mode;
            [JsonProperty("mods")]
            public int mods;
            [JsonProperty("mods_string")]
            public string modsString;
            [JsonProperty("performance_rating")]
            public double rating;
            [JsonProperty("personal_best")]
            public bool personalBest;
            [JsonProperty("total_score")]
            public int totalScore;
            [JsonProperty("accuracy")]
            public double accuracy;
            [JsonProperty("grade")]
            public string grade;
            [JsonProperty("max_combo")]
            public int maxCombo;
            [JsonProperty("count_marv")]
            public int countMarvellous;
            [JsonProperty("count_perf")]
            public int countPerfect;
            [JsonProperty("count_great")]
            public int countGreat;
            [JsonProperty("count_good")]
            public int countGood;
            [JsonProperty("count_okay")]
            public int countOkay;
            [JsonProperty("count_miss")]
            public int countMiss;
            [JsonProperty("user")]
            public UserInfo user;
        }
    }
}
