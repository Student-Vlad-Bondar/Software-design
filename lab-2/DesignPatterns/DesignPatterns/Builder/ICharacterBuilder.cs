using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public interface ICharacterBuilder<TBuilder>
    where TBuilder : ICharacterBuilder<TBuilder>
    {
        TBuilder SetHeight(double height);
        TBuilder SetPhysique(string physique);
        TBuilder SetHairColor(string hairColor);
        TBuilder SetEyeColor(string eyeColor);
        TBuilder SetClothes(string clothes);
        TBuilder AddInventoryItem(string item);
        Character Build();
    }
}
