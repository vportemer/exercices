using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statut
{
    class Program
    {
        static void Main(string[] args)
        {


            var statutpersonnes = new List<Personne>();

            statutpersonnes.Add(new Personne("TURPIN", "Abdel", Statutenum.CDI));
            statutpersonnes.Add(new Personne("BONNEAU", "Achille", Statutenum.CDD | Statutenum.DP));
            statutpersonnes.Add(new Personne("BLONDEL", "Adelphe", Statutenum.CDI | Statutenum.DP | Statutenum.CHSCT | Statutenum.SYND));
            statutpersonnes.Add(new Personne("BLACK", "Aimé", Statutenum.CDI));
            statutpersonnes.Add(new Personne("PERRIER", "Aimée", Statutenum.CDI));
            statutpersonnes.Add(new Personne("JORDAN", "Alain", Statutenum.CDI | Statutenum.CHSCT));
            statutpersonnes.Add(new Personne("BAUDRY", "Alban", Statutenum.CDD));
            statutpersonnes.Add(new Personne("ORLEANS", "Albert", Statutenum.CDI | Statutenum.DP | Statutenum.SYND));
            statutpersonnes.Add(new Personne("VALOIS", "Alexandra", Statutenum.CDI | Statutenum.CHSCT));
            statutpersonnes.Add(new Personne("WEST", "Alexandre", Statutenum.CDI | Statutenum.DP | Statutenum.CHSCT));

            var nouvelleliste = new List<Personne>();
            var nouvelleliste2 = new List<Personne>();
            foreach (Personne a in statutpersonnes)
            {
               
                Statutenum masque = Statutenum.CDD | Statutenum.CHSCT;
                if ((a.Statut & masque) == masque)
               {
                    nouvelleliste.Add(a);
                }

                Statutenum masque2 = Statutenum.CDI | Statutenum.DP;
                if ((a.Statut & masque2) == masque2)
                {
                    nouvelleliste2.Add(a);
                    Console.WriteLine(a);
                    a.Statut |= Statutenum.CHSCT;
                    Console.WriteLine(a);
                }
                
            }

            
            Console.ReadKey();
        }
    }
}
