using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tri_tableau
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tableau = new string[3] { "date", "type", "commentaires" };
            AfficherTableau(tableau);
            Console.ReadKey();
        }
        static void AfficherTableau(string[] tableau)
        {
            Console.WriteLine(tableau);
        }
        //static void TriTableau(string[] tableau = 
        //{    
            
        //    Console.WriteLine(tableau[]);
        //}    
    }        
}
