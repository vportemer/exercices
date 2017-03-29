using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animaux
{
    class Program
    {
        static void Main(string[] args)
        {
            var chat1 = new Chat();
            var chat2 = new Chat();
            var chien1 = new Chien();
            var chien2 = new Chien();
            // var animal = new Animal();


            Animal[] ancetre = new Animal[4] { chat1, chat2, chien1, chien2 };
            for (int i = 0; i < ancetre.Length; i++)
            {
                Console.WriteLine(ancetre[i].Description);//car pas statique
                Console.WriteLine(Animal.Compteur);//car statique
                if (ancetre[i].Mangeable())
                {
                    Console.WriteLine("Je suis mangeable");
                }
                else
                {
                    Console.WriteLine("Je ne suis pas mangeable");
                }
            }
            Console.ReadKey();
        }
    }
}
