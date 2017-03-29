using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boites
{
    public enum Formats{ Xs,s,M,L,XL, }

    public class Etiquette

    
        #region Propriétés
   {
        private string _texte;
        private Couleurs _couleur;
        private Formats _format;

        public string Texte
        {
            get { return _texte; }
            set { _texte = value; }
        }

        public Couleurs Couleur
        {
            get { return _couleur; }
            set { _couleur = value; }
        }
        public Formats Format
        {
            get { return _format; }
            set { _format = value; }
        }
        #endregion

        #region constructeurs
        public Etiquette(Couleurs coul, Formats form, string texte)
        {
            _couleur = coul;
            _format =form;
            _texte= texte;
        }
        #endregion


    }
}
