using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Gun gunWithoutMuffler = new Gun("Glock", 100);
            GunDecoratorMuffler gunWithMuffler = new GunDecoratorMuffler(gunWithoutMuffler);
            Console.WriteLine($"Модель: {gunWithoutMuffler.model}, глушитель: {gunWithoutMuffler.muffler}, урон: {gunWithoutMuffler.damage}");
            Console.WriteLine($"Модель: {gunWithMuffler.gun.model}, глушитель: {gunWithMuffler.gun.muffler}, урон: {gunWithMuffler.gun.damage}");
        }
    }
}
