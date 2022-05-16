using System;
using System.IO;
using System.Threading.Tasks;

namespace Forder_Index_Printer
{
    internal class Program
    {
        public string path;
        static async Task Main(string[] args)
        {
            Console.WriteLine($"Files in folder ");
            while (true)
            {
                PrintFilesFromFolder();
                await Task.Delay(5000);
            }
            
        }

        static void PrintFilesFromFolder()
        {
            string path = @"C:\";
            string[] files = Directory.GetFiles(path);

            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine(files[i]);
            }
        }
    }
}
