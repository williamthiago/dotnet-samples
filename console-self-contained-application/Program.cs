using System;

namespace ConsoleSelfContainedApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            Console.Write("Sistema operacional: ");
            Console.WriteLine(System.Runtime.InteropServices.RuntimeInformation.OSDescription);
            Console.WriteLine("Exemplo de Self-Contained App com output personalizado por runtime.");
        }
    }
}
