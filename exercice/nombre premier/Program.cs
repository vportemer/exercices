using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nombre_premier
{
    class Program
    {
        static void Main(string[] args)
        {
            nbpremier();
            Console.ReadKey();

        
              
        }
        static void nbpremier()
        {
            int n, compt, divis, nbr;
            string saisie;
            bool estpremier;

            Console.WriteLine("Combien de nombres premiers");
            saisie = Console.ReadLine();
            n = int.Parse(saisie);
            compt = 2;
            nbr = 3;
            Console.WriteLine("1\n2");
            while (compt < n)
            {
                divis = 3;
                estpremier = true;
                while (divis>nbr) //||estpremier=false)
                {
                    if (nbr % divis == 0)
                    {
                        estpremier = false;
                    }
                    else
                    {
                        divis = divis + 2;
                    }
                }
               if (estpremier == true)
                {
                    Console.WriteLine(nbr);
                    compt++;
                }
                nbr += 2;
            }
            
        }
    }
}
