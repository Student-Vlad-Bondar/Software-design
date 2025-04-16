using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Strategy
{
    public class Image
    {
        private IImageLoader _imageLoader;

        public string Href { get; private set; }

        public Image(string href)
        {
            Href = href;
            if (File.Exists(href))
                _imageLoader = new FileImageLoader();
            else
                _imageLoader = new WebImageLoader();
        }

        public async Task<byte[]> LoadAsync()
        {
            return await _imageLoader.LoadImageAsync(Href);
        }
    }
}
