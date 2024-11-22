using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    public abstract class MetodaAutentificare
    {
        public abstract void Autentifica();
    }
    public class AutentificareSMS : MetodaAutentificare
    {
        private string numarTelefon;

        public AutentificareSMS(string numarTelefon)
        {
            this.numarTelefon = numarTelefon;
        }
        public override void Autentifica()
        {
            Console.WriteLine($"Trimite SMS catre{numarTelefon} pentru autentificare...");
            Console.WriteLine("Autentificare reusita prin SMS");
        }
    }
    public class AutentificareSocialMedia : MetodaAutentificare
    {
        private string platforma;

        public AutentificareSocialMedia(string platforma)
        {
            this.platforma = platforma;
        }

        public override void Autentifica()
        {
            Console.WriteLine($"Autentificare prin {platforma}");
            Console.WriteLine("Autentificare reusita prin reteaua sociala!");
        }
    }
    public class AutentificareUsernameParola : MetodaAutentificare
    {
        private string username;
        private string parola;

        public AutentificareUsernameParola(string username, string parola)
        {
            this.username = username;
            this.parola = parola;
        }
        public override void Autentifica()
        {
            Console.WriteLine($"Autentificare cu username: {username} si parola.");
            Console.WriteLine("Autentificare reusita prin username si parola!");
        }
    }

        class Program
        {
            static void Main(string[] args)
            {
                List<MetodaAutentificare> metodeAutentificare = new List<MetodaAutentificare>
            {
                new AutentificareUsernameParola("user1", "user2"),
                new AutentificareSMS("0771096157"),
                new AutentificareSocialMedia("Facebook")
            };

                foreach (var metoda in metodeAutentificare)
                {
                    metoda.Autentifica();
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
        }
    
}
