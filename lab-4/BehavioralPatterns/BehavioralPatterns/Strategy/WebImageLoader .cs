using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Strategy
{
    public class WebImageLoader : IImageLoader
    {
        public async Task<byte[]> LoadImageAsync(string href)
        {
            Console.WriteLine("Завантаження зображення з мережі.");
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/90.0.4430.85 Safari/537.36");
                    client.DefaultRequestHeaders.Add("Accept", "image/webp,image/apng,image/*,*/*;q=0.8");
                    return await client.GetByteArrayAsync(href);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка завантаження зображення з мережі: {ex.Message}");
                return new byte[0];
            }
        }
    }
}
