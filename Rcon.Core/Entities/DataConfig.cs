namespace Rcon.Core.Entities
{
    public class DataConfig
    {
        public string MySqlHost { get; set; }
        public string MySqlUser { get; set; }
        public string MySqlPass { get; set; }
        public string MySqlDb { get; set; }
        public int MySqlPort { get; set; }

        public string GetConnectionString()
        {
            return $"Server={MySqlHost}; Database={MySqlDb}; User Id={MySqlUser}; Password={MySqlPass}; Port={MySqlPort};";
        }
    }
}
