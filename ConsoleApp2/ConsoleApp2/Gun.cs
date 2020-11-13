using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Gun : ICloneable
    {
        public string model { get; set; }
        public int damage { get; set; }
        public bool muffler { get; set; }

        public Gun(string model, int damage) {
            this.model = model;
            this.damage = damage;
            this.muffler = false;
        }

        public object Clone()
        {
            return new Gun(model, damage);
        }
    }
}
