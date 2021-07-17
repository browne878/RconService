namespace Rcon.Services.Commands.Choices.CommandOptions
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using DSharpPlus.Entities;
    using DSharpPlus.SlashCommands;

    public class TribePlayerCommandOptions : IChoiceProvider
    {
        public async Task<IEnumerable<DiscordApplicationCommandOptionChoice>> Provider()
        {
            return new[]
                   {
                       new DiscordApplicationCommandOptionChoice("Add Player to Tribe", "Te.AddPlayer"),
                       new DiscordApplicationCommandOptionChoice("Set a Player as Tribe Admin", "SetPlayerTribeAdmin"),
                       new DiscordApplicationCommandOptionChoice("Set a Player as Tribe Owner", "SetPlayerTribeOwner"),
                       new DiscordApplicationCommandOptionChoice("Set a Player Head Hair", "SetHeadHair"),
                       new DiscordApplicationCommandOptionChoice("Set a Player Facial Hair", "SetFacialHair"),
                       new DiscordApplicationCommandOptionChoice("Teleport Player to another Player", "TeleportToPlayer"),
                       new DiscordApplicationCommandOptionChoice("Unlock Engram for Player", "UnlockEngram")
                   };
        }
    }
}


