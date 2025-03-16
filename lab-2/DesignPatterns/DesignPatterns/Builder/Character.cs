using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class Character
    {
        public double Height { get; set; }
        public string Physique { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string Clothes { get; set; }
        public List<string> Inventory { get; set; } = new List<string>();
        public List<string> GoodDeeds { get; set; } = new List<string>();
        public List<string> EvilDeeds { get; set; } = new List<string>();

        public override string ToString()
        {
            return $"Height: {Height}, Physique: {Physique}, Hair: {HairColor}, Eyes: {EyeColor}, " +
                   $"Clothes: {Clothes}, Inventory: {string.Join(", ", Inventory)}" +
                   $"\nGoodDeeds: {string.Join(", ", GoodDeeds)}" +
                   $"\nEvilDeeds: {string.Join(", ", EvilDeeds)}";
        }
    }
}
