using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meuble
{
    class Program
    {
        static void Main(string[] args)
        {
            var rockingchair = new Chaise();
            var tablebasse = new Table();
            var chaisehaute = new Chaise();
            var chaisebar = new Chaise();

            Meuble[] meuble = new Meuble[] { rockingchair, tablebasse, chaisehaute, chaisebar };
            for (int i = 0; i < meuble.Length; i++)
            {
                Console.WriteLine(meuble[i].Description);
                Console.WriteLine(Meuble.Compteur);
                if (meuble[i].Mangeable()) {Console.WriteLine("je suis montable"); }
                else { Console.WriteLine("je ne suis pas montable"); }
            }
            
            Console.ReadKey();

        }
        
        
    }
}
