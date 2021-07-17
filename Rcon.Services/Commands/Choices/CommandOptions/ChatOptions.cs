namespace Rcon.Services.Commands.Choices.CommandOptions
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using DSharpPlus.Entities;
    using DSharpPlus.SlashCommands;

    public class ChatOptions : IChoiceProvider
    {
        public async Task<IEnumerable<DiscordApplicationCommandOptionChoice>> Provider()
        {
            return new[]
                   {
                       new DiscordApplicationCommandOptionChoice("Send a Client Chat Message Ingame", "ClientChat"),
                       new DiscordApplicationCommandOptionChoice("Send a Tribe Chat Msg to online Players", "TribeChatMsg"),
                       new DiscordApplicationCommandOptionChoice("Send a Tribe Log Msg to a Tribe Log", "TribeLogMsg")
                   };
        }
    }
}
