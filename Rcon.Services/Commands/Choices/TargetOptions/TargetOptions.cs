namespace Rcon.Services.Commands.Choices.TargetOptions
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using DSharpPlus.Entities;
    using DSharpPlus.SlashCommands;

    public class TargetOptions : IChoiceProvider
    {
        public async Task<IEnumerable<DiscordApplicationCommandOptionChoice>> Provider()
        {
            return new[]
                   {
                       new DiscordApplicationCommandOptionChoice("All", "All"),
                       new DiscordApplicationCommandOptionChoice("Pvpve", "Pvpve"),
                       new DiscordApplicationCommandOptionChoice("Pvp", "Pvp"),
                       new DiscordApplicationCommandOptionChoice("Pve", "Pve")
                   };
        }
    }
}
