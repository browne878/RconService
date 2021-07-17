namespace Rcon.Services.Commands.Choices.CommandOptions
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using DSharpPlus.Entities;
    using DSharpPlus.SlashCommands;

    public class OrpPveCommandOptions : IChoiceProvider
    {
        public async Task<IEnumerable<DiscordApplicationCommandOptionChoice>> Provider()
        {
            return new[]
                   {
                       new DiscordApplicationCommandOptionChoice("Remove a Tribes ORP", "Orp.Blacklist.Add"),
                       new DiscordApplicationCommandOptionChoice("Set a Tribes PVE Time", "Pvpve.SetPve")
                   };
        }
    }
}
