namespace Rcon.Services.Services
{
    using System.IO;
    using DSharpPlus;
    using Rcon.Core.Entities;
    using Newtonsoft.Json;

    public static class FileReaderService
    {
        public static BaseConfig GetConfig()
        {
            const string file = "./Config/Config.json";
            string data = File.ReadAllText(file);
            return JsonConvert.DeserializeObject<BaseConfig>(data);
        }

        public static DiscordConfiguration GetBotConfig()
        {
            const string file = "./Config/BotConfiguration.json";
            string data = File.ReadAllText(file);
            return JsonConvert.DeserializeObject<DiscordConfiguration>(data);
        }
    }
}
