using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Produs
    {
        private double pret;
        private int stoc;

        public string Nume { get; set; }

        public Produs(string nume, double pretInitial, int stocInitial)
        {
            Nume = nume;
            SetPret(pretInitial);
            SetStoc(stocInitial);
        }

        public void SetPret(double pretNou)
        {
            if (pretNou < 0)
            {
                throw new ArgumentException("Pretul nu poate fi negativ");
            }
            pret = pretNou;
        }
        public double ObtinePret()
        {
            return pret;
        }
        public void SetStoc(int stocNou)
        {
            if (stocNou < 0)
            {
                throw new ArgumentException("Cantitatea nu poate fi negativa");

            }
            stoc = stocNou;
        }
        public int ObtineStoc()
        {

            return stoc;
        }
        public void CresteStoc(int cantitate)
        {
            if (cantitate <= 0)
            {
                throw new ArgumentException("Cantitatea trebuie sa fie pozitiva");
            }
            stoc += cantitate;
            Console.WriteLine("Stocul pentru {0} a fost crescut cu {1}. Stoc curent:{2}", Nume, cantitate, stoc);
        }
        public void ScadeStoc(int cantitate)
        {
            if (cantitate <= 0)
            {
                throw new ArgumentException("Cantitatea trebuie sa fie pozitiva");

            }
            if (cantitate > stoc)
            {
                throw new InvalidOperationException("Fonduri insuficiente pentru a scade stocul");

            }
            stoc -= cantitate;
            Console.WriteLine($"Stocul pentru {Nume} a fost scăzut cu {cantitate}. Stoc curent: {stoc}");
            Console.ReadLine();
        } 
    }



class Program
    {
        static void Main(string[] args)
        {
            // Crearea unui nou produs
            Produs produs = new Produs("Laptop", 2500.0, 10);
            // Afișăm detalii despre produs
            Console.WriteLine($"Produs: {produs.Nume}, Pret: {produs.ObtinePret():C}, Stoc: {produs.ObtineStoc()}");
            // Creștem stocul
            produs.CresteStoc(5);
            // Scădem stocul
            produs.ScadeStoc(3);
            // Afișăm stocul final
            Console.WriteLine($"Stoc final pentru {produs.Nume}: {produs.ObtineStoc()}");
            Console.ReadKey();

        }
    }
}
