namespace Rcon.Services.Commands
{
    using System.Threading.Tasks;
    using DSharpPlus;
    using DSharpPlus.Entities;
    using DSharpPlus.SlashCommands;

    public class RconCommands : SlashCommandModule
    {
        private readonly DiscordClient bot;

        public RconCommands(DiscordClient _bot)
        {
            bot = _bot;
        }

        /*[SlashCommand("rcon", "Sends commands via Rcon")]
        public async Task RconCommand(InteractionContext _ctx,
                                      [Option()])
        {

        }*/

        [SlashCommand("test", "A slash command made to test the DSharpPlusSlashCommands library!")]
        public async Task TestCommand(InteractionContext ctx)
        {
            await ctx.CreateResponseAsync(InteractionResponseType.DeferredChannelMessageWithSource);
            await Task.Delay(5000);
            await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent("5 second delay complete!"));
        }
    }
}
