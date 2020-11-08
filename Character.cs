using System.Collections.Generic;

namespace task9
{
    public enum Outfit
    {
        Бронежилет,
        Нож,
        Пистолет,
        Автомат,
        Граната,
        Набор_сапера,
        Бомба
    }
    public class Character
    {
        public int Health { get; set; }
        public List<Outfit> Outfits { get; set; }
        protected Character() {
            Health = 100;
            Outfits = new List<Outfit>();
        }

        public override string ToString()
        {
            string str = $"Здоровье: {Health}; Cнаряжение: {{ ";
            foreach (var outfit in Outfits) {
                str += $"{outfit} ";
            }
            str += "}\n";
            return str;
        }
    }
}
