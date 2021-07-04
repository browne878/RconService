namespace Rcon.Services.Commands
{
    using System.Threading.Tasks;
    using DSharpPlus;
    using DSharpPlus.SlashCommands;

    public class RconCommands : SlashCommandModule
    {
        private readonly DiscordClient bot;

        public RconCommands(DiscordClient _bot)
        {
            bot = _bot;
        }

        [SlashCommand("rcon", "Sends commands via Rcon")]
        public async Task RconCommand(InteractionContext _ctx,
                                      [Option()])
        {

        }
    }
}
