using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class BuilderForCounterTerrorist : Builder
    {
        public override Character createCharacter()
        {
            return new CounterTerrorist();
        }

        public override void giveArms(Character character, List<Outfit> arms)
        {
            foreach (var arm in arms)
            {
                if (arm != Outfit.Bomb && arm != Outfit.Bulletproof_vest)
                {
                    character.Outfits.Add(arm);
                }
            }
        }
    }
}
