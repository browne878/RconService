namespace Rcon.Services.Commands.Choices.CommandOptions
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using DSharpPlus.Entities;
    using DSharpPlus.SlashCommands;

    public class RtaOptions : IChoiceProvider
    {
        public async Task<IEnumerable<DiscordApplicationCommandOptionChoice>> Provider()
        {
            return new[]
                   {
                       new DiscordApplicationCommandOptionChoice("Road to Alpha I", "rta1"),
                       new DiscordApplicationCommandOptionChoice("Road to Alpha II", "rta2"),
                       new DiscordApplicationCommandOptionChoice("Road to Alpha III", "rta3"),
                       new DiscordApplicationCommandOptionChoice("Road to Alpha IV", "rta4"),
                       new DiscordApplicationCommandOptionChoice("Road to Alpha V", "rta5"),
                       new DiscordApplicationCommandOptionChoice("Road to Alpha VI", "rta6"),
                       new DiscordApplicationCommandOptionChoice("Road to Alpha VII", "rta7"),
                       new DiscordApplicationCommandOptionChoice("Road to Alpha VIII", "rta8"),
                   };
        }
    }
}
