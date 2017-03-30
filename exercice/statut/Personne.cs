using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statut
{
    [Flags]
        public enum Statutenum
    {
        Aucun=0,
        CDI = 1,
        CDD = 2,
        DP = 4,
        CHSCT = 8,
        SYND = 16,
        
    }
    public class Personne
    {
        #region Propriétés
        public string Nom { get; }
        public string Prénom { get;  }
        public Statutenum Statut { get; set; }
        #endregion
        #region Constructeurs
        public Personne(string nom, string prénom)
        {
            Nom = nom;
            Prénom = prénom;
                    }
        public Personne(string nom, string prénom, Statutenum statut): this (nom, prénom)
        {
            
            Statut = statut;
        }
        #endregion
        #region Méthodes
        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", Nom, Prénom, Statut);
        }
        
        #endregion
    }
}
