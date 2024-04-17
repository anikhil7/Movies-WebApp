namespace WebApplication_L2V2
{
    public class ConfigHelper
    {
        public static IConfiguration config;
        public static void Initialize(IConfiguration Configuration)
        {
            config = Configuration;
        }
    }
}
