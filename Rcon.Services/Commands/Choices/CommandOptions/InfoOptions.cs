namespace Rcon.Services.Commands.Choices.CommandOptions
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using DSharpPlus.Entities;
    using DSharpPlus.SlashCommands;

    public class InfoOptions : IChoiceProvider
    {
        public async Task<IEnumerable<DiscordApplicationCommandOptionChoice>> Provider()
        {
            return new[]
                   {
                       new DiscordApplicationCommandOptionChoice("Find Steam Id of Discord User", "LookupSteamId"),
                       new DiscordApplicationCommandOptionChoice("Find Discord User from Steam Id", "LookupDiscordId"),
                       new DiscordApplicationCommandOptionChoice("List All Structures", "ListAllStructures"),
                       new DiscordApplicationCommandOptionChoice("List All Player Steam Id", "ListAllPlayerSteamId"),
                       new DiscordApplicationCommandOptionChoice("List Tribe Dinos", "ListTribeDinos"),
                       new DiscordApplicationCommandOptionChoice("List Unclaimed Dinos", "ListUnclaimedDinos"),
                       new DiscordApplicationCommandOptionChoice("Get Player HWID", "GetPlayerHWID"),
                       new DiscordApplicationCommandOptionChoice("List All Player Pos", "ListAllPlayerPos"),
                       new DiscordApplicationCommandOptionChoice("Get Tribe Name", "GetTribeName"),
                       new DiscordApplicationCommandOptionChoice("Get Player Name", "GetPlayerName"),
                       new DiscordApplicationCommandOptionChoice("Get Player Pve Time", "PveTime"),
                       new DiscordApplicationCommandOptionChoice("Get Player Points", "GetPlayerPoints"),
                       new DiscordApplicationCommandOptionChoice("Get Player Pos", "GetPlayerPos"),
                       new DiscordApplicationCommandOptionChoice("List Player Dinos", "ListPlayerDinos"),
                       new DiscordApplicationCommandOptionChoice("Get Tribe Id Of Player", "GetTribeIdOfPlayer"),
                       new DiscordApplicationCommandOptionChoice("Get Tribe Log", "GetTribeLog"),
                       new DiscordApplicationCommandOptionChoice("Get Dino Pos", "GetDinoPos")
                   };
        }
    }
}
