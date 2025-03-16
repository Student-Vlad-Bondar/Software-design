using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class EnemyBuilder : ICharacterBuilder<EnemyBuilder>
    {
        private Character _enemy = new Character();

        public EnemyBuilder SetHeight(double height)
        {
            _enemy.Height = height;
            return this;
        }

        public EnemyBuilder SetPhysique(string physique)
        {
            _enemy.Physique = physique;
            return this;
        }

        public EnemyBuilder SetHairColor(string hairColor)
        {
            _enemy.HairColor = hairColor;
            return this;
        }

        public EnemyBuilder SetEyeColor(string eyeColor)
        {
            _enemy.EyeColor = eyeColor;
            return this;
        }

        public EnemyBuilder SetClothes(string clothes)
        {
            _enemy.Clothes = clothes;
            return this;
        }

        public EnemyBuilder AddInventoryItem(string item)
        {
            _enemy.Inventory.Add(item);
            return this;
        }

        public EnemyBuilder AddEvilDeed(string deed)
        {
            _enemy.EvilDeeds.Add(deed);
            return this;
        }

        public Character Build()
        {
            return _enemy;
        }
    }
}
