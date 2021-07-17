namespace Rcon.Services.Services
{
    using System.IO;
    using DSharpPlus;
    using Rcon.Core.Entities;
    using Newtonsoft.Json;

    public static class FileReaderService
    {
        public static RconConfig GetRconConfig()
        {
            const string file = "./Config/RconConfig.json";
            string data = File.ReadAllText(file);
            return JsonConvert.DeserializeObject<RconConfig>(data);
        }

        public static DiscordConfiguration GetBotConfig()
        {
            const string file = "./Config/BotConfiguration.json";
            string data = File.ReadAllText(file);
            return JsonConvert.DeserializeObject<DiscordConfiguration>(data);
        }
    }
}
