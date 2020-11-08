using System;
using System.Collections.Generic;

namespace task9
{
    class Program
    {
        public static bool isBombPlanted = false; 
        static void Main(string[] args)
        {
            //Паттерн билдер
            Builder builder = new Builder();
            //Создадим террориста
            Terrorist myTerrorist = builder.createTerrorist();
            //Наденем на него бронежилет
            builder.giveClothers(myTerrorist);
            //Вручим автомат, 2 гранаты и бомбу
            builder.giveArms(myTerrorist, new List<Outfit> { Outfit.Автомат, Outfit.Граната, Outfit.Граната, Outfit.Бомба });
            //Создадим контертеррориста
            CounterTerrorist myCounterTerrorist = builder.createCounterTerrorist();
            //Наденем на него бронежилет
            builder.giveClothers(myCounterTerrorist);
            //Вручим нож, пистолет и набор сапера
            builder.giveArms(myCounterTerrorist, new List<Outfit> { Outfit.Нож, Outfit.Пистолет, Outfit.Набор_сапера });
            //Выведем в консоль информацию о созданных персонажах
            Console.Write(myTerrorist);
            Console.WriteLine(myCounterTerrorist);

            //Паттерн фабрика
            Factory factory = new Factory();
            //Создадим дефолтных террориста, контртеррориста и заложника
            var defaultTerrorist = factory.createCharacter(TypeCharacter.Terrorist, new List<Outfit> { Outfit.Пистолет, Outfit.Бомба });
            var defaultCounterTerrorist = factory.createCharacter(TypeCharacter.CounterTerrorist);
            var defaultHostage = factory.createCharacter(TypeCharacter.Hostage);
            //Выведем дефолтных персонажей 
            Console.Write(defaultTerrorist);
            Console.Write(defaultCounterTerrorist);
            Console.Write(defaultHostage);
        }
    }
}
