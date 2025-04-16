using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Strategy
{
    public interface IImageLoader
    {
        Task<byte[]> LoadImageAsync(string href);
    }
}
