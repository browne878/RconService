namespace Rcon.Services.Commands.Choices.CommandOptions
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using DSharpPlus.Entities;
    using DSharpPlus.SlashCommands;

    public class PointsBoxKitOptions : IChoiceProvider
    {
        public async Task<IEnumerable<DiscordApplicationCommandOptionChoice>> Provider()
        {
            return new[]
                   {
                       new DiscordApplicationCommandOptionChoice("Add Points to Player", "AddPoints"),
                       new DiscordApplicationCommandOptionChoice("Set Points of Player", "SetPoints"),
                       new DiscordApplicationCommandOptionChoice("Change Points of Player", "ChangePoints"),
                       new DiscordApplicationCommandOptionChoice("Change Kit Amount", "ChangeKitAmount"),
                       new DiscordApplicationCommandOptionChoice("Give Lootbox", "WLootBox.GiveLootBoxItem"),
                       new DiscordApplicationCommandOptionChoice("Add Hexagons to Player", "AddHexagon"),
                       new DiscordApplicationCommandOptionChoice("Player Renamer Add Tokens", "PlayerRenamer.AddTokens"),
                       new DiscordApplicationCommandOptionChoice("Player Renamer List Name Changes", "PlayerRenamer.ListNameChanges")
                   };
        }
    }
}
