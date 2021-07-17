namespace Rcon.Services.Services
{
    public class CommandService
    {
        private readonly RconService rcon;
        
        public CommandService(RconService _rcon)
        {
            rcon = _rcon;
        }
    }
}