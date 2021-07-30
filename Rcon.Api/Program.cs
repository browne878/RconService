using DSharpPlus;
using DSharpPlus.SlashCommands;

namespace Rcon.Api
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Services.Commands;

    public static class Program
    {
        public static async Task Main(string[] _args)
        {
            IHost host = CreateHostBuilder(_args).Build();

            DiscordClient bot = host.Services.GetRequiredService<DiscordClient>();

            SlashCommandsExtension slash = bot.UseSlashCommands(new SlashCommandsConfiguration
            {
                Services = host.Services
            });

            slash.RegisterCommands<RconCommands>(764600703624282153);

            await host.RunAsync();
        }

        private static IHostBuilder CreateHostBuilder(string[] _args) =>
            Host.CreateDefaultBuilder(_args)
                .ConfigureWebHostDefaults(_webBuilder =>
                {
                    _webBuilder.UseStartup<Startup>();
                });
    }
}
