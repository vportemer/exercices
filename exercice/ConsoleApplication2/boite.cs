using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public enum Couleurs { Blanc, Bleu, Vert, Jaune, Orange, Rouge, Marron }
    public enum Matieres { Carton, Plastique, Bois, Métal }

    public class Boite
    {

        //  public static int 


        #region champs privés 
        //déclare les attributs
        private double _largeur;
        private double _hauteur;
        private double _longueur;
        private Etiquette _etiquetteDest;
        private Etiquette _etiquetteFragile;

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
        public Couleurs Couleur { get; set; }


        public Matieres Matiere { get; private set; }


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
            Matiere = Matieres.Carton;
        }
        public Boite(double longu, double haut, double larg)
        {


            _longueur = longu;
            _largeur = larg;
            _hauteur = haut;
        }
                        public Boite(double longu, double haut, double larg, Matieres mat) : this(longu, haut, larg)
        {
            Matiere = mat;
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

        public void Etiqueter(string texte)
        {
            Etiquette etq = new Etiquette(Couleurs.Blanc, Formats.L, texte);
        }
        public void Etiqueter(string destinataire, bool fragile)
        {
            Etiqueter(destinataire);
            if (fragile)
            {
                _etiquetteFragile = new Etiquette
                {

                };
            }

        }
        public bool Compare(Boite autreBoite)
        {
            //if (this.Hauteur == autreBoite.Hauteur && this.Largeur == autreBoite.Largeur && this.Longueur == autreBoite.Longueur && this.Matiere++autreBoite) ;
            //{
            //    return true;
            //}
            //else{ return false; }
            return true;
        }

        #endregion


    }


}



