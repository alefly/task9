using System.Collections.Generic;

namespace task9
{
    //множество типов персонажей
    public enum TypeCharacter
    {
        Terrorist,
        CounterTerrorist,
        Hostage
    }
    
    //класс, реализующий паттерн фабрика
    class Factory
    {
        private Builder builder;
        private List<Outfit> defaultArm;

        public Factory() {
            builder = new Builder();
            defaultArm = new List<Outfit> { Outfit.Автомат, Outfit.Бомба, Outfit.Граната, Outfit.Набор_сапера, Outfit.Нож, Outfit.Пистолет };
        }
        public object createCharacter(TypeCharacter type, List<Outfit> arms = null)
        {
            object character = new object();
            //Если снаряжение не было назначено, то присваиваем дефолтное
            if (arms == null && type != TypeCharacter.Hostage) {
                arms = new List<Outfit>(defaultArm);
            }
            if (type == TypeCharacter.Terrorist) {
                var terrorist = builder.createTerrorist();
                builder.giveClothers(terrorist);
                builder.giveArms(terrorist, arms);
                character = terrorist;
            }
            if (type == TypeCharacter.CounterTerrorist) {
                var counterTerrorist = builder.createCounterTerrorist();
                builder.giveClothers(counterTerrorist);
                builder.giveArms(counterTerrorist, arms);
                character = counterTerrorist;
            }
            if (type == TypeCharacter.Hostage) {
                character = builder.createTerrorist();
            }
            return character;
        }
    }
}

