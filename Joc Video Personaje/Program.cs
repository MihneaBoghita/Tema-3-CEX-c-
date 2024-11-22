using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    public abstract class Personaj
    {
        public abstract void Ataca();
    }

    public class Razboinici : Personaj
    {
        public override void Ataca()
        {
            Console.WriteLine("Razboinicul ataca cu sabiuta!!!!!!!");

        }
    }
    public class Magician : Personaj
    {
        public override void Ataca()
        {
            Console.WriteLine("Magicianul arunca o vrajitorie cu sabiuta!!!!");
        }
    }
    
    public class Arcas : Personaj
    {
        public override void Ataca()
        {
            Console.WriteLine("Arcasul trage cu arcul si nu are sabiuta :(!!!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Personaj>personaje = new List<Personaj>
            {
                new Razboinici(),
                new Magician(),
                new Arcas()
            };

            foreach (var p in personaje)
            {
                p.Ataca();
            }
            Console.ReadLine();
        }
    }
}
