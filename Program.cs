using System;
using System.Runtime.InteropServices;

namespace SteamPlayersTracker;

class Program
{
    static async Task Main(string[] args)
    {
        DataLoader loader = new DataLoader();
        Dictionary<string, int> games = new Dictionary<string, int>
            {
                // Goldsrc games
                { "Half-Life", 70 },
                { "Half-Life: Opposing Force", 50 },
                { "Half-Life: Blue Shift", 130 },
                { "Deathmatch Classic", 40 },
                { "Ricochet", 60 },
                { "Team Fortress Classic", 20 },
                { "Day of Defeat", 30 },
                { "Counter-Strike", 10 },
                { "Counter-Strike: Condition Zero", 80 },

                // Source games
                { "Half-Life 2", 220 },
                { "Half-Life 2: Deathmatch", 320 },
                { "Half-Life 2: Lost Coast", 340 },
                { "Half-Life 2: Episode One", 380 },
                { "Half-Life 2: Episode Two", 420 },
                { "Half-Life: Source", 280 },
                { "Half-Life Deathmatch: Source", 360 },
                { "Counter-Strike: Source", 240 },
                { "Day of Defeat: Source", 300 },
                { "Portal", 400 },
                { "Portal 2", 620 },
                { "Team Fortress 2", 440 },
                { "Left 4 Dead", 500 },
                { "Left 4 Dead 2", 550 },
                { "Alien Swarm", 630 },
                { "Garry's Mod", 4000 },
                { "Counter-Strike: Global Offensive", 4465480 }, //new id from csgo publish in march of 2026
                { "Counter-Strike 2", 730 },

                // Source 2 games
                { "Dota 2", 570 },
                { "Artifact", 583950 },
                { "Artifact Foundry", 583950 },
                { "Dota Underlords", 1046930 },
                { "Half-Life: Alyx", 546560 },

                // SDK's
                { "Source SDK Base 2006", 215 },
                { "Source SDK Base 2007", 218 },
                { "Source SDK Base 2013 Singleplayer", 243730 },
                { "Source SDK Base 2013 Multiplayer", 243750 }

                //you can actually change that, just type game name and it's appid from steam or steamdb
            };

        foreach (var game in games)
        {
            try
            {
                var data = await loader.LoadData(game.Value);
                if (data?.Response == null)
                {
                    Console.WriteLine($"{game.Key,-33} | Error, no data");
                }
                Console.WriteLine($"{game.Key, -33} | online: {data.Response.PlayerCount,0:0}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}