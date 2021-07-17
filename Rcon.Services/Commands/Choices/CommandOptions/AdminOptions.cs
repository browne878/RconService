namespace Rcon.Services.Commands.Choices.CommandOptions
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using DSharpPlus.Entities;
    using DSharpPlus.SlashCommands;

    public class AdminOptions : IChoiceProvider
    {
        public async Task<IEnumerable<DiscordApplicationCommandOptionChoice>> Provider()
        {
            return new[]
                   {
                       new DiscordApplicationCommandOptionChoice("Kick Player", "KickPlayer"),
                       new DiscordApplicationCommandOptionChoice("Ban Player", "BanPlayer"),
                       new DiscordApplicationCommandOptionChoice("Unban Player", "UnbanPlayer"),
                       new DiscordApplicationCommandOptionChoice("Kick All Players", "KickAllPlayers"),
                       new DiscordApplicationCommandOptionChoice("Kill All Players", "KillAllPlayers"),
                       new DiscordApplicationCommandOptionChoice("Destroy Tribe Dinos", "DestroyTribeDinos"),
                       new DiscordApplicationCommandOptionChoice("Destroy Tribe Structures", "DestroyTribeStructures"),
                       new DiscordApplicationCommandOptionChoice("Destroy Tribe Players", "DestroyTribePlayers"),
                       new DiscordApplicationCommandOptionChoice("Destroy Tribe Players, Dinos and Structures", "DestroyTribeAll"),
                       new DiscordApplicationCommandOptionChoice("Rename Character", "RenameCharacter"),
                       new DiscordApplicationCommandOptionChoice("Wild Dino Wipe", "wdecay.WildDinoWipe"),
                       new DiscordApplicationCommandOptionChoice("Delete Player Record", "DeletePlayerRecord"),
                       new DiscordApplicationCommandOptionChoice("Add To Alt Whitelist", "AddToAltWhitelist"),
                       new DiscordApplicationCommandOptionChoice("Remove From Alt Whitelist", "RemoveFromAltWhitelist"),
                       new DiscordApplicationCommandOptionChoice("Add To Ip Whitelist", "AddToIpWhitelist"),
                       new DiscordApplicationCommandOptionChoice("Remove From Ip Whitelist", "RemoveFromIpWhitelist"),
                       new DiscordApplicationCommandOptionChoice("Ingame Mute", "DI.Mute"),
                       new DiscordApplicationCommandOptionChoice("Kill Dino", "KillDino"),
                       new DiscordApplicationCommandOptionChoice("Spawn Dino", "SpawnDino"),
                       new DiscordApplicationCommandOptionChoice("Teleport All Players", "TeleportAllPlayers"),
                       new DiscordApplicationCommandOptionChoice("Add Experience", "AddExperience"),
                       new DiscordApplicationCommandOptionChoice("Give Item To All Players", "GiveItemToAll"),
                       new DiscordApplicationCommandOptionChoice("Give Item To Player", "GiveItem"),
                       new DiscordApplicationCommandOptionChoice("Give Item To Player by Id", "GiveItemNum"),
                       new DiscordApplicationCommandOptionChoice("Reset Player Tribute Upload (Plugin)", "ItemsPlus.Reset")
                   };
        }
    }
}
