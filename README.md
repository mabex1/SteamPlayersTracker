# Steam Players Tracker

A console application that retrieves current player counts for Valve games using the Steam Web API.

## Features

- Fetches online player data for multiple Steam games
- Limits concurrent API requests using SemaphoreSlim
- Handles API errors gracefully
- Displays results in a formatted console table

## Supported Games

Includes GoldSource, Source, and Source 2 titles:
- Half-Life series
- Counter-Strike series (including the 2026 CS:GO re-release)
- Portal series
- Team Fortress 2
- Dota 2
- Left 4 Dead series
- Garry's Mod
- Half-Life: Alyx
- And more (see source code for full list)

## Requirements

- [.NET 9.0 or later](https://dotnet.microsoft.com/download)
- Internet connection for Steam API access

## Setup

1. Clone the repository:
    git clone https://github.com/yourusername/SteamPlayersTracker.git
    cd SteamPlayersTracker
2. Run the application:
    dotnet run

## Configuration

Edit the games dictionary in Program.cs to add or remove games using their Steam AppID.
API Reference

Uses the official Steam Web API:

    ISteamUserStats/GetNumberOfCurrentPlayers/v1/

## License

MIT

## Disclaimer

This project is not affiliated with Valve Corporation or Steam.
