using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figuri;

namespace Figuri
{
  
    
        public abstract class Figura
        {
            public abstract double CalculeazaArie();

        }
        public class Cerc : Figura
        {
            public double Raza { get; set; }
            public Cerc(double raza)
            {
                Raza = raza;
            }

            public override double CalculeazaArie()
            {
                return Math.PI * Raza * Raza;
            }

        }
        public class Patrat : Figura
        {
            public double Latura { get; set; }

            public Patrat(double latura)
            {
                Latura = latura;
            }

            public override double CalculeazaArie()
            {
                return Latura * Latura;
            }
        }
        public class Triunghi : Figura
        {
            public double Baza { get; set; }
            public double Inaltime { get; set; }

            public Triunghi(double baza, double inaltime)
            {
                Baza = baza;
                Inaltime = inaltime;
            }
            public override double CalculeazaArie()
            {
                return 0.5 * Baza * Inaltime;
            }
        }
}
    class Program
    {
        static void Main(string[] args)
        {
        List<Figura> figuri = new List<Figura>
            {
                new Cerc(5),
                new Patrat(4),
                new Triunghi(6,3)
            };
            foreach (var figura in figuri)
            {
                Console.WriteLine($"Aria:{figura.CalculeazaArie():F2}");
            }
            Console.ReadLine();
        }
    }

