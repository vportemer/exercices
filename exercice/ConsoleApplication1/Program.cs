using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int v;
            int c;
            string saisie;
            Console.WriteLine("saisir un mot :");
            saisie = Console.ReadLine();
            calcul(saisie, out c, out v);
            Console.WriteLine("le mot {0} comprend {1} et {2} voyelles",saisie,c,v);
            Console.ReadKey();
        }
        static void calcul(string mot, out int nbcons, out int Nbvoyelle)
        {
            Nbvoyelle = 0;
            mot=mot.ToLower(); //met le mot en majuscule existe ToLower
            for (int i = 0; i<mot.Length; i++)
            {
                if (mot[i] == 'a' || mot[i] == 'e' || mot[i] == 'i' || mot[i] == 'o' || mot[i] == 'u' || mot[i] == 'y')
                {
                    Nbvoyelle++;
                }

            }
            nbcons = mot.Length - Nbvoyelle;
        }

    }
}
