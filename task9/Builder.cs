using System.Collections.Generic;

namespace Task9
{
    public abstract class Builder
    {
        public abstract Character createCharacter();
       
        public void giveClothers(Character character) {
            character.Outfits.Add(Outfit.Bulletproof_vest);
        }

        public abstract void giveArms(Character character, List<Outfit> arms);
        
    }
}
