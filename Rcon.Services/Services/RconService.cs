namespace Rcon.Services.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Rcon.Core.Entities;
    using RconSharp;

    public class RconService
    {
        private readonly RconConfig config;
        private RconClient rconClient;

        public RconService(RconConfig _config)
        {
            config = _config;
        }

        private async Task<bool> OpenRcon(int _serverId)
        {

            rconClient = RconClient.Create(config.Servers[_serverId].RconIp, config.Servers[_serverId].RconPort);
            await rconClient.ConnectAsync();
            bool isAuth = await rconClient.AuthenticateAsync(config.Servers[_serverId].RconPass);
            return isAuth;
        }

        private async Task<string> RconCommand(string _command, int _serverId)
        {
            if (await OpenRcon(_serverId))
            {
                string response = await rconClient.ExecuteCommandAsync(_command);
                rconClient.Disconnect();
                return response;
            }

            rconClient.Disconnect();
            return "Server is offline.";
        }
        
        public async Task<List<string>> RconSendCommand(string _command, IEnumerable<string> _servername)
        {
            List<string> result = new List<string>();

            foreach (string server in _servername)
            {
                int serverId = -1;
                for (int i = 0; i < config.Servers.Count; i++)
                {
                    if (config.Servers[i].ServerName == server)
                    {
                        serverId = i;
                    }
                }
                result.Add(await RconCommand(_command, serverId));
            }
            
            return result;
        }

    }
}