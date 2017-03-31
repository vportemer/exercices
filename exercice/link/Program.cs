using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace link
{
    class Program
    {
        static void Main(string[] args)
        {
            var A1 = new AnalyseurLINQ();
            A1.ChargerDonnées();// appeler charger fichier et vérifier en débug et dans le watch et ou locals on met Data car DAta.add c'est là ou la collection est charger petit à petit


            Console.ReadKey();
        }
    }
}
