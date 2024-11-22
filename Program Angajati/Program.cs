using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Angajat
{
    public string Nume { get; set; }
    public double Salariu { get; set; }
    public int Varsta { get; set; }

    public Angajat(string nume, double salariu, int varsta)
    {
        Nume = nume;
        Salariu = salariu;
        Varsta = varsta;
    }

    public void Lucreaza()
    {
        Console.WriteLine($"{Nume} lucreaza.");
    }
}

class AngajatFullTime : Angajat
{
    public string Departament { get; set; }

    public AngajatFullTime(string nume, double salariu, int varsta, string departament)

    : base(nume, salariu, varsta)
    {
        Departament = departament;
    }

    public void RaporteazaLaMunca()
    {
        Console.WriteLine($"{Nume} raporteaza la munca in departamentul {Departament}.");
    }
}

class AngajatPartTime : Angajat
{
    public int OreLucratePeSaptamana { get; set; }

    public AngajatPartTime(string nume, double salariu, int varsta, int oreLucrate)
        : base(nume, salariu, varsta)
    {
        OreLucratePeSaptamana = oreLucrate;

    }
    public void LucreazaPartTime()
    {
        Console.WriteLine($"{Nume} lucreaza part time {OreLucratePeSaptamana} ore pe saptamana");
    }
}

class Program
{
    static void Main()
    {
        AngajatFullTime angajatFT = new AngajatFullTime("John Doe", 50000.0, 30, "IT");
        AngajatPartTime angajatPT = new AngajatPartTime("Jane Smith", 20.0, 25, 20);

        Console.WriteLine("Angajat full-time:");
        angajatFT.Lucreaza();
        angajatFT.RaporteazaLaMunca();

        Console.WriteLine("\nAngajat part-time:");
        angajatPT.Lucreaza();
        angajatPT.LucreazaPartTime();
        Console.ReadKey();
    }
}