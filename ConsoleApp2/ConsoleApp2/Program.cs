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
            User petya = new User("Петя");
            User dima = new User("Дима");
            User gena = new User("Гена");
            User masha = new User("Маша");
            User sveta = new User("Света");

            masha.follow(gena);
            masha.follow(sveta);
            dima.follow(petya);
            sveta.follow(dima);
            dima.follow(sveta);

            masha.say("Привет!");
            dima.say("Пока!");
        }
    }
}
