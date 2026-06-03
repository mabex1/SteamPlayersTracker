using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace SteamPlayersTracker
{
    public class JsonResponse
    {
        [JsonPropertyName("response")]
        public ResponseData Response { get; set; }
    }

    public class ResponseData
    {
        [JsonPropertyName("player_count")]
        public int PlayerCount { get; set; }
        public int result { get; set; }
    }
}
