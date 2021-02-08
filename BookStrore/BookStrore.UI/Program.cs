using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System.IO;

namespace BookStrore.UI
{
    public class Program
    {
        private static PhysicalFileProvider _fileProvider = new PhysicalFileProvider(Directory.GetCurrentDirectory());

        public static void Main(string[] args)
        {



            CreateHostBuilder(args).Build().Run();



        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });


    }
}
