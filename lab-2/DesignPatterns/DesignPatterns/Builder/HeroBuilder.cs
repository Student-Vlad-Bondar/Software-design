using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class HeroBuilder : ICharacterBuilder<HeroBuilder>
    {
        private Character _hero = new Character();

        public HeroBuilder SetHeight(double height)
        {
            _hero.Height = height;
            return this;
        }

        public HeroBuilder SetPhysique(string physique)
        {
            _hero.Physique = physique;
            return this;
        }

        public HeroBuilder SetHairColor(string hairColor)
        {
            _hero.HairColor = hairColor;
            return this;
        }

        public HeroBuilder SetEyeColor(string eyeColor)
        {
            _hero.EyeColor = eyeColor;
            return this;
        }

        public HeroBuilder SetClothes(string clothes)
        {
            _hero.Clothes = clothes;
            return this;
        }

        public HeroBuilder AddInventoryItem(string item)
        {
            _hero.Inventory.Add(item);
            return this;
        }

        public HeroBuilder AddGoodDeed(string deed)
        {
            _hero.GoodDeeds.Add(deed);
            return this;
        }

        public Character Build()
        {
            return _hero;
        }
    }
}
