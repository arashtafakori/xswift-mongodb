using Microsoft.Extensions.Configuration;

namespace MongoDB.XSwift
{
    public class MongoDBSettings
    {
 
        private IConfigurationRoot? _configuration;

        public string? _connectString;
        public string ConnectString
        {
            get => _connectString!;
        }

        public MongoDBSettings()
        {

        }
        public MongoDBSettings(IConfigurationRoot configuration)
        {
            _configuration = configuration;

            _connectString = _configuration
                .GetSection("MongoDBSettings")
                .GetSection("ConnectionStrings").Value!;
        }

        public void SetMongoBdConnectString(string value)
        {
            _connectString = value;
        }
    }
}
