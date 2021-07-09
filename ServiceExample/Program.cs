using System.Threading.Tasks;

namespace ServiceExample
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            await CommonServiceStartup.Builder.Run<Startup>();
        }
    }
}
