namespace Rcon.Services.Services
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using DSharpPlus;
    using Microsoft.Extensions.Hosting;

    public class BotService : IHostedService, IDisposable
    {
        private readonly DiscordClient bot;
        public BotService(DiscordClient _bot)
        {
            bot = _bot;
        }

        public async Task StartAsync(CancellationToken _cancellationToken)
        {
            await bot.ConnectAsync();
        }

        public async Task StopAsync(CancellationToken _cancellationToken)
        {
            await bot.DisconnectAsync();
        }

        public void Dispose()
        {
            bot.Dispose();
        }
    }
}
