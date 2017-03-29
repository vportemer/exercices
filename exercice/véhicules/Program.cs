using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Véhicules
{
    public enum Energies{ Aucune, Essence, Gazole, GPL, electrique}
    class Program
    {
        static void Main(string[] args)
        {
            Véhicule a = new Voiture();
            //Console.WriteLine(a.Description);
            Voiture b = new Voiture();
            Véhicule c = new Moto();
            //Véhicule[] toto = new Véhicule[3] { a, b, c };

            //for(int i=0; i < toto.Length;i++)
            //{
            //    Console.WriteLine(toto[i].Description);
            //}

            Console.WriteLine(b.Description);
           Console.WriteLine(c.Description);

            //Véhicule d = new Véhicule();

            Voiture b2 = new Voiture();
           
            int ggh = b2.CompareTo(c);
            if (ggh == 0)
            {
                Console.WriteLine("La {0} est plus économique que la {1} ", b2.Nom,c.Nom);
            }
                    
            
            

            Console.ReadKey();
        }
    }
}
