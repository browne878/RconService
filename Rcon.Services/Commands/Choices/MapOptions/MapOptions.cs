namespace Rcon.Services.Commands.Choices.MapOptions
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using DSharpPlus.Entities;
    using DSharpPlus.SlashCommands;

    public class MapOptions : IChoiceProvider
    {
        public async Task<IEnumerable<DiscordApplicationCommandOptionChoice>> Provider()
        {
            return new[]
                   {
                       new DiscordApplicationCommandOptionChoice("All", "All"),
                       new DiscordApplicationCommandOptionChoice("Island", "Island"),
                       new DiscordApplicationCommandOptionChoice("Scorched", "Scorched"),
                       new DiscordApplicationCommandOptionChoice("Aberration", "Aberration"),
                       new DiscordApplicationCommandOptionChoice("Center", "Center"),
                       new DiscordApplicationCommandOptionChoice("Ragnarok", "Ragnarok"),
                       new DiscordApplicationCommandOptionChoice("Extinction", "Extinction"),
                       new DiscordApplicationCommandOptionChoice("Valguero", "Valguero"),
                       new DiscordApplicationCommandOptionChoice("GenesisP1", "GenesisP1"),
                       new DiscordApplicationCommandOptionChoice("Crystal", "Crystal"),
                       new DiscordApplicationCommandOptionChoice("GenesisP2", "GenesisP2")
                   };
        }
    }
}
