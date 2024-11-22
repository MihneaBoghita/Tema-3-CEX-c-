using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _3
{
    class ContBancar
    {
        private double sold;
        public double ObtineSold()
        {
            return sold; 
        }

        public void DepuneBani(double suma)
        {
            if (suma > 0)
            {
                sold += suma;
                Console.WriteLine($"Ai depus {suma:C}.Soldul actual este:{sold:C}");
            }
            else
            {
                Console.WriteLine("Suma trebuie sa fie pozitiva!");
            }
        }

        public void RetrageBani(double suma)
        {
            if (suma > 0 && suma <= sold)
            {
                sold -= suma;
                Console.WriteLine($"Ai retras {suma:C}.Soldul actual este:{sold:C}");
            }
            else
            {
                Console.WriteLine("Fonduri insuficiente sau suma invalida!");
            }
            Console.ReadKey();
        }
       
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ContBancar cont=new ContBancar();
            Console.Write("Cati bani depuneti in cont:");
            cont.DepuneBani(Convert.ToInt32(Console.ReadLine()));
            Console.Write
                ("Cati bani retrageti din cont:");
            cont.RetrageBani(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine($"Sold final: {cont.ObtineSold():C}");
        }
    }
}
