using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compt_voyelle_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int c;
            int v;
            string saisie;
            Console.WriteLine("saisir un mot");
            saisie = Console.ReadLine();
            Calcul(saisie, out c, out v);
            Console.WriteLine(" {0} comporte {1} voyelles et {2} consonnes", saisie, v, c);
            Console.ReadKey();

        }
        static void Calcul(string mot, int nbcons, int nbvoy)
        {
            for (int i=0; i>mot.Length ; i++)
            {
        //        if (mot[0]=='a'||)
            }
        }
    }
}
