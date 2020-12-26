using System;
using System.Collections.Generic;

namespace Task9
{
    class Program
    {
        public static bool isBombPlanted = false;
        static void Main(string[] args)
        {
            //Класс для создания террористов
            Builder builderForTerrorist = new BuilderForTerrorist();
            //Создадим террориста
            Character myTerrorist = builderForTerrorist.createCharacter();
            //Наденем на него бронежилет
            builderForTerrorist.giveClothers(myTerrorist);
            //Вручим автомат, 2 гранаты и бомбу
            builderForTerrorist.giveArms(myTerrorist, new List<Outfit> { Outfit.Machine, Outfit.Grenade, Outfit.Grenade, Outfit.Bomb });

            //Класс для создания контертеррористов
            Builder builderForCounterTerrorist = new BuilderForCounterTerrorist();
            //Создадим контертеррориста
            Character myCounterTerrorist = builderForCounterTerrorist.createCharacter();
            //Наденем на него бронежилет
            builderForCounterTerrorist.giveClothers(myCounterTerrorist);
            //Вручим нож, пистолет и набор сапера
            builderForCounterTerrorist.giveArms(myCounterTerrorist, new List<Outfit> { Outfit.Knife, Outfit.Pistol, Outfit.Sapper_set });
            
            //Выведем в консоль информацию о созданных персонажах
            Console.Write(myTerrorist);
            Console.WriteLine(myCounterTerrorist);

        }
    }
}
