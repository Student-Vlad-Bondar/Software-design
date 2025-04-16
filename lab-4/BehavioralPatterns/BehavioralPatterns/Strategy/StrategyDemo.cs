using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Strategy
{
    public class StrategyDemo
    {
        public static async Task Run()
        {
            Console.WriteLine("\n>> Strategy Demo:\n");

            string localImagePath = "C:\\Users\\Vlad\\source\\repos\\Універ\\Конструювання програмного забезпечення\\Software-design\\lab-4\\BehavioralPatterns\\BehavioralPatterns\\Strategy\\ogon.webp";
            if (!File.Exists(localImagePath))
            {
                Console.WriteLine("Штучно створений файл");
                await File.WriteAllBytesAsync(localImagePath, new byte[] { 0xFF, 0xD8, 0xFF });
            }
            Image localImage = new Image(localImagePath);
            var localData = await localImage.LoadAsync();
            Console.WriteLine("Файлове зображення завантажено, розмір: " + localData.Length + " байт.");

            string webImageUrl = "https://www.vecteezy.com/photo/36598644-ai-generated-horror-party-advertisment-background-with-copy-space";
            Image webImage = new Image(webImageUrl);

            byte[] webData = await webImage.LoadAsync();
            Console.WriteLine("Мережеве зображення завантажено, розмір: " + webData.Length + " байт.");
        }
    }
}
