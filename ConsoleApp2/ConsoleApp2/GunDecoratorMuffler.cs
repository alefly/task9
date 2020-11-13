using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class GunDecoratorMuffler
    {
        public Gun gun { get; set; }
        private double DownDamageCoef = 0.8;

        public GunDecoratorMuffler(Gun gun) {
            this.gun = (Gun)gun.Clone();
            this.gun.muffler = true;
            this.gun.damage = Convert.ToInt32(gun.damage * DownDamageCoef);
        }
        
    }
}
