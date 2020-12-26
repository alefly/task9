using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    public class Terrorist : Character
    {
        //закладываем бомбу, если она еще не заложена, и если она есть в снаряжении
        public bool mine() {
            if (Program.isBombPlanted)
                return false;
            Program.isBombPlanted = Outfits.Remove(Outfit.Bomb);
            return Program.isBombPlanted;
        }

        //красивый вывод информации о персонаже
        public override string ToString()
        {
            return $"Тип: Террорист; {base.ToString()}";
        }
    }
}
