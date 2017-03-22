using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgcd
{
    class Program
    {
        static void Main(string[] args)
        {
            Pgcd();
            Console.ReadKey();
        }

      
        static void Pgcd()
        {
            int p, q;
            string saisie;

            Console.WriteLine("Entrez le premier nombre");
            saisie = Console.ReadLine();
            p = int.Parse(saisie);

            Console.WriteLine("Deuxième chiffre!!!");
            saisie = Console.ReadLine();
            q = int.Parse(saisie);

            while (p != q)
            {
                if (p > q)
                {
                    p -= q;
                }
                else
                {
                    q -= p;

                }
            }

            Console.WriteLine("PGCD = " + p);
                
          
        }
    }
}
