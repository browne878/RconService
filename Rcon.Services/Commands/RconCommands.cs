namespace Rcon.Services.Commands
{
    using System.Threading.Tasks;
    using DSharpPlus;
    using DSharpPlus.Entities;
    using DSharpPlus.SlashCommands;
    using Rcon.Services.Commands.Choices.CommandOptions;
    using Rcon.Services.Commands.Choices.MapOptions;
    using Rcon.Services.Commands.Choices.TargetOptions;

    public class RconCommands : SlashCommandModule
    {
        [SlashCommandGroup("Rcon", "Used to send commands to Servers via Rcon!")]
        public class Rcon
        {
            private readonly DiscordClient bot;

            public Rcon(DiscordClient _bot)
            {
                bot = _bot;
            }

            [SlashCommand("manual", "Manually enter a command")]
            public async Task ManualCommand(InteractionContext _ctx,
                                            [ChoiceProvider(typeof(TargetOptions))][Option("Cluster", "The target of the command")] string _cluster,
                                            [ChoiceProvider(typeof(MapOptions))][Option("Map", "Map you want to send the command too")] string _map,
                                            [Option("Command", "Command you want to execute")] string _command,
                                            [Option("Arguments", "Any Additional info required to execute the command")] string _args = null)
            {
                await _ctx.CreateResponseAsync(InteractionResponseType.DeferredChannelMessageWithSource);
                await Task.Delay(5000);
                await _ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent("5 second delay complete!"));
            }

            [SlashCommand("permissions", "Used to manage Player Permissions")]
            public async Task PermissionsCommand(InteractionContext _ctx,
                                          [ChoiceProvider(typeof(TargetOptions))][Option("Cluster", "The target of the command")] string _cluster,
                                          [ChoiceProvider(typeof(MapOptions))][Option("Map", "Map you want to send the command too")] string _map,
                                          [ChoiceProvider(typeof(PermissionsOptions))][Option("Command", "Command you want to execute")] string _command,
                                          [Option("MultipleTargets", "Will this command effect multiple people")] bool _multipleTargets = false,
                                          [Option("Arguments", "Any Steam Id or other info required to execute command")] string _args = null,
                                          [Option("Target", "Who this command will effect")] string _target = null)
            {
                await _ctx.CreateResponseAsync(InteractionResponseType.DeferredChannelMessageWithSource);
                await Task.Delay(5000);
                await _ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent("5 second delay complete!"));
            }
        }
    }
}
