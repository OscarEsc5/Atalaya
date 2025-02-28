using System.Text;

namespace Atalaya.Data
{
    public class KeyConfiguration
    {
        private readonly IConfiguration _configuration;

        public KeyConfiguration(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public byte[] SecretKey => Encoding.UTF8.GetBytes(_configuration["JwtSettings:Secret"]);
    }
}
