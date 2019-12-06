using Microsoft.Extensions.Configuration;

namespace FootballApi.Io
{
    public class AppConfig
    {
        public string sqlCS { get; set; }

        public AppConfig(IConfiguration config)
        {
            sqlCS = config.GetConnectionString("defaultConnection");
        }
    }
}
