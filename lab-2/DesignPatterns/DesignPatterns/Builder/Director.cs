using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class Director
    {
        public Character BuildHero(HeroBuilder builder)
        {
            return builder
                .SetHeight(1.85)
                .SetPhysique("Athletic")
                .SetHairColor("Brown")
                .SetEyeColor("Blue")
                .SetClothes("Shining Armor")
                .AddInventoryItem("Sword")
                .AddInventoryItem("Shield")
                .AddGoodDeed("Rescued a village")
                .Build();
        }

        public Character BuildEnemy(EnemyBuilder builder)
        {
            return builder
                .SetHeight(1.75)
                .SetPhysique("Muscular")
                .SetHairColor("Black")
                .SetEyeColor("Red")
                .SetClothes("Dark Cloak")
                .AddInventoryItem("Axe")
                .AddInventoryItem("Dagger")
                .AddEvilDeed("Destroyed a town")
                .Build();
        }
    }
}
