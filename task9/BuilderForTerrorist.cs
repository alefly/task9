using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9 
{
    public class BuilderForTerrorist : Builder
    {
        public override Character createCharacter()
        {
            return new Terrorist();
        }

        public override void giveArms(Character character, List<Outfit> arms)
        {
            foreach (var arm in arms)
            {
                if (arm != Outfit.Sapper_set && arm != Outfit.Bulletproof_vest)
                {
                    character.Outfits.Add(arm);
                }
            }
        }
    }
}
