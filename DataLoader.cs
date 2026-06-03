using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace SteamPlayersTracker
{
    public class DataLoader
    {
        private static readonly HttpClient httpClient = new HttpClient();
        private static readonly SemaphoreSlim semaphore = new SemaphoreSlim(4);

        public async Task<JsonResponse?> LoadData(int appid)
        {
            await semaphore.WaitAsync();

            try
            {
                string url = $"https://api.steampowered.com/ISteamUserStats/GetNumberOfCurrentPlayers/v1/?appid={appid}"; //official steam api, basically you can change that, and it will be not "SteamPlayersTracker"
                string json = await httpClient.GetStringAsync(url);
                var data = JsonSerializer.Deserialize<JsonResponse>(json);
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                semaphore.Release();
            }
        }
    }
}
