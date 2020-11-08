using System.Collections.Generic;

namespace task9
{
    //класс, реализующий паттерн билдер
    //на мой взгляд билдер скорее антипаттерн, но по шагам - так по шагам
    public class Builder
    {
        public Terrorist createTerrorist() {
            return new Terrorist();
        }
        public CounterTerrorist createCounterTerrorist()
        {
            return new CounterTerrorist();
        }
        public Hostage createHostage()
        {
            return new Hostage();
        }
        public void giveClothers(Terrorist character) {
            character.Outfits.Add(Outfit.Бронежилет);
        }
        public void giveClothers(CounterTerrorist character)
        {
            character.Outfits.Add(Outfit.Бронежилет);
        }
        public void giveArms(Terrorist character, List<Outfit> arms) {
            foreach (var arm in arms){
                if (arm != Outfit.Набор_сапера && arm != Outfit.Бронежилет) {
                    character.Outfits.Add(arm);
                }
            }
        }
        public void giveArms(CounterTerrorist character, List<Outfit> arms)
        {
            foreach (var arm in arms)
            {
                if (arm != Outfit.Бомба && arm != Outfit.Бронежилет)
                {
                    character.Outfits.Add(arm);
                }
            }
        }
    }
}
