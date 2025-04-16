using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Strategy
{
    public class FileImageLoader : IImageLoader
    {
        public async Task<byte[]> LoadImageAsync(string href)
        {
            if (File.Exists(href))
            {
                Console.WriteLine("Завантаження зображення з файлової системи.");
                return await File.ReadAllBytesAsync(href);
            }
            else
            {
                throw new FileNotFoundException("Файл не знайдено: " + href);
            }
        }
    }
}
