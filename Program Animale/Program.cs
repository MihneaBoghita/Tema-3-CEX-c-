using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Animal
{
    public string Nume { get; set; }
    public int Vartsa { get; set; }

    public Animal(string nume, int varsta)
    {
        Nume = nume;
        Vartsa = varsta;
    }
    public void Mananca()
    {
        Console.WriteLine($"{Nume} mananca.");
    }
    public void Somn()
    {
        Console.WriteLine($"{Nume} doarme.");

    }

}
class Caine : Animal
{
    public Caine(string nume, int varsta)
        : base(nume, varsta)
    {

    }
    public void Latra()
    {
        Console.WriteLine($"{Nume} latra.");
    }
}
class Pisica : Animal
{
    public Pisica(string nume, int varsta)
    : base(nume, varsta)
    {

    }
    public void Zgarie()
    {
        Console.WriteLine($"{Nume} zgarie.");
    }
}

class Pasare : Animal
{
    public Pasare(string nume, int varsta)
    : base(nume, varsta)
    {

    }
    public void Canta()
    {
        Console.WriteLine($"{Nume} Canta.");

    }
}

class Program
{
    static void Main()
    {
        Caine caine = new Caine("Rex", 3);
        Pisica pisica = new Pisica("Whiskers", 2);
        Pasare pasare = new Pasare("Tweetie", 1);
        Console.WriteLine("Acțiuni ale câinelui:");
        caine.Mananca();
        caine.Somn();
        caine.Latra();
        Console.WriteLine("\nAcțiuni ale pisicii:");
        pisica.Mananca();
        pisica.Somn();
        pisica.Zgarie();
        Console.WriteLine("\nAcțiuni ale păsării:");
        pasare.Mananca();
        pasare.Somn();
        pasare.Canta();
        Console.ReadKey();
    }
}