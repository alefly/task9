using System.Collections.Generic;

namespace Task9
{
    public enum Outfit
    {
        Bulletproof_vest,
        Knife,
        Pistol,
        Machine,
        Grenade,
        Sapper_set,
        Bomb
    }
    public class Character
    {
        public int Health { get; internal set; }
        public List<Outfit> Outfits { get; internal set; }
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
