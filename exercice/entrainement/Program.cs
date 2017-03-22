using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrainement
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo();
            Console.ReadKey();
        }
        static void Demo()
        {
            string texte;
            string phrase;
            int nbPhrases, nbmots, nbCaractères; //plusieurs déclarations
            const double PI = 3.14;
            const string DEB_LISTE = "-";
            phrase = "Le C# est un langage moderne et puissant";
            texte = phrase;
            texte = texte + "Il est utilisé pour toutes sortes d'applications\n";
            texte += DEB_LISTE + " Application console\n";
            texte += DEB_LISTE + " Application fenêtrée Winforms et WPF\n";

            Console.WriteLine(texte);
            char lettre;
            lettre = phrase[3];
            Console.WriteLine(lettre);

            int[] tabPos = new int[5] { 3, 4, 40, 50, 60 };
           
            Console.WriteLine(tabPos.Length); //longueur du tableau

            for (int i = 0; i < tabPos.Length; i++)

            {
                Console.WriteLine(tabPos [i]);
            }

            int j = 0;
            while (j < tabPos.Length)
            {
                j++;
            }
                Console.Clear();
                Console.WriteLine(texte);


                nbPhrases = 0; 
                for (int i = 0; i < texte.Length; i++)

                {
                        if (texte[i] == '\n')
                    { 
                        nbPhrases++;
                    }
                }

                Console.WriteLine("il y a " + nbPhrases + " lignes dans le texte");
                Console.Clear();

                nbmots = 0;
            for (int i = 0; i < phrase.Length; i++)
            {
                if (phrase[i] == ' ' || phrase[i] == '\'' || phrase[i] == '\n')
                {
                    nbmots++;
                }
            }
            Console.WriteLine("il y a " + nbmots + " mots dans le texte");
            {
                Console.WriteLine("Entrer un nombre :");
                string valeur = Console.ReadLine();
                int x = int.Parse(valeur);
            }
        }
    }
}
