using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Véhicules
{
    public enum Energies { Aucune, Essence, Gazole, GPL, electrique }
    class Program
    {
        static void Main(string[] args)
        {
            Véhicule a = new Voiture("titi", Energies.electrique);
            //Console.WriteLine(a.Description);
            Voiture b = new Voiture("tito", Energies.electrique);
            Véhicule c = new Moto("coco", Energies.electrique);
            //Véhicule[] toto = new Véhicule[3] { a, b, c };

            //for(int i=0; i < toto.Length;i++)
            //{
            //    Console.WriteLine(toto[i].Description);
            //}

            Console.WriteLine(b.Description);
            Console.WriteLine(c.Description);

            //Véhicule d = new Véhicule();

            Voiture b2 = new Voiture("toto", Energies.Essence);

            int ggh = b2.CompareTo(c);
            if (ggh == 0)
            {
                Console.WriteLine("La {0} est plus économique que la {1} ", b2.Nom, c.Nom);
            }

            var v1 = new Voiture("mégane", 19000);
            var v2 = new Moto("Intruder", 13000);
            var v3 = new Voiture("Enzo", 380000);
            var v4 = new Moto("Yamaha", 11000);

            var dico = new Dictionary<string, Véhicule>();
            dico.Add(v1.Nom, v1);
            dico.Add(v2.Nom, v2);
            dico.Add(v4.Nom, v4);
            dico.Add(v3.Nom, v3);

            foreach (var v in dico)
            {
                Console.WriteLine("{0} {1}", v.Key, v.Value.Prix);
            }
            var sortieliste = new SortedList<string, Véhicule>();
            foreach (var v in dico)
            {
                sortieliste.Add(v.Key, v.Value);
            }
            // dico.Clear();

            foreach (var v in sortieliste)
             Console.WriteLine("{0} : {1}", v.Key.Nom, v.Key.Prix); 


            string[] tabmarque = new string[] { "Clio", "Mégane", "Golf", "Enzo", "Polo" };
            foreach (var s in tabmarque)
            {
                Véhicule vv;
                if(dico.TryGetValue(s,out vv))
                    Console.WriteLine
            }

                Console.ReadKey();
        }
    }
}
