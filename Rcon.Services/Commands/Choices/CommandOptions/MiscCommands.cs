namespace Rcon.Services.Commands.Choices.CommandOptions
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using DSharpPlus.Entities;
    using DSharpPlus.SlashCommands;

    public class MiscCommands : IChoiceProvider
    {
        public async Task<IEnumerable<DiscordApplicationCommandOptionChoice>> Provider()
        {
            return new[]
                   {
                       new DiscordApplicationCommandOptionChoice("Add Experience to Player", "AddExperience"),
                       new DiscordApplicationCommandOptionChoice("Set Dino Position", "SetDinoPos"),
                       new DiscordApplicationCommandOptionChoice("Add Experience to Dino", "AddDinoExperience"),
                       new DiscordApplicationCommandOptionChoice("Execute Script Command", "ScriptCommand"),
                       new DiscordApplicationCommandOptionChoice("Feed Dinos of a Tribe", "FeedDinos"),
                       new DiscordApplicationCommandOptionChoice("Change a Dino Colour", "DinoColor"),
                       new DiscordApplicationCommandOptionChoice("Change a Dino Colour", "DinoColor"),
                       new DiscordApplicationCommandOptionChoice("Set Dino Imprint Quality", "SetImprintQuality"),
                       new DiscordApplicationCommandOptionChoice("Set Imprint To Player", "SetImprintToPlayer"),
                       new DiscordApplicationCommandOptionChoice("Give Armor Set to Player", "GiveArmorSet"),
                      };
        }
    }
}
