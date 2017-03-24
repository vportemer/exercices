using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Boite[] tabBoite = new Boite[3];
            Boite maBoite = tabBoite[1];

            int[] tabEntier = { 1, 2, 3 };
            //string prénom = "Virginie";
            for (int i = 0; i < tabEntier.Length; i++)
                Console.Write("\'{0}\' ", tabEntier[i]);


           // char char2 = prénom[1];

            string chaine = "";
            Boite toto = new Boite();//création un objet de type boite  nommé toto et initialisé en appelant le constructeur de la class boite ici par défaut car pas de paramètre
            toto.Etiqueter(chaine);
            
            Console.ReadKey();

            //string chaine = "coucou";
            //int taille = chaine.Length;

        }


        public class Boite
        {
            public enum Couleur { Blanc, Bleu, Vert, Jaune, Orange, Rouge, Marron }
            public enum Matiere { Carton, Plastique, Bois, Métal }
            #region champs privés 
            //déclare les attributs
            private double _largeur;
            private double _hauteur;
            private double _longueur;
            private Couleur _couleurBoite;
            private Matiere _matiereBoite;
            #endregion

            #region Propriétés
            //permet à l'utilisateur d'acceder aux attributs avec les limitations que l'on souhaite (soit lire ou ecrire), on ne met pas de propriété si ca ne concerne pas l'utilisateur
            public double Largeur
            {
                get { return _largeur; }
            }
            public double Longueur
            {
                get { return _longueur; }
            }
            public double Hauteur
            {
                get { return _hauteur; }
            }
            public Couleur CouleurBoite
            {
                get { return _couleurBoite; }
                set { _couleurBoite=value; }
            
            }
            public Matiere MatiereBoite
            {
                get { return _matiereBoite; }
            }
            public double Volume
            {
                get { return _largeur * _longueur * _hauteur; }
            }

            #endregion

            #region Constructeurs
            //permet d'initialiser la class, on l'appele avec new 
            public Boite()
            {
                _largeur = 30;
                _hauteur = 30;
                _longueur = 30;
                _matiereBoite = Matiere.Carton;
            }

            public Boite(double taille)
            {
                _largeur = taille;
                _hauteur = taille;
                _longueur = taille;
            }// pour appeller Boite too =new Boite (20)
            #endregion

            #region Méthodes publiques 
            // on peut appeller la fonction en dehors de la class

            public void Etiqueter(string destinataire)
            {
               //TODO : faire le code plus tard
            }
            public void Etiqueter(string destinataire, bool fragile)
            {
                //TODO : faire le code plus tard
            }
            #endregion


        }


    }
}

