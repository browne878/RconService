namespace Rcon.Core.Entities
{
    using System.Collections.Generic;

    public class RconConfig
    {
        public List<Servers> Servers { get; set; }
    }

    public class Servers
    {
        public string ClusterName { get; set; }
        public string ServerName { get; set; }
        public string RconIp { get; set; }
        public string RconPass { get; set; }
        public int RconPort { get; set; }
    }
}