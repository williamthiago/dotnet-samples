using System;

namespace ConsolePortableApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Sistema operacional: ");
            Console.WriteLine(System.Runtime.InteropServices.RuntimeInformation.OSDescription);
            Console.WriteLine("Exemplo de Portable App.");
        }
    }
}
