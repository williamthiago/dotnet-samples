using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;

namespace WebEntityFramework
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Sistema operacional: ");
            Console.WriteLine(System.Runtime.InteropServices.RuntimeInformation.OSDescription);
            Console.WriteLine("Exemplo de Web App, com Api e EntityFramework.");
            
            var host = new WebHostBuilder()
                .UseUrls("http://0.0.0.0:5000/")
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>()
                .Build();
                
            host.Run();
        }
    }
}
