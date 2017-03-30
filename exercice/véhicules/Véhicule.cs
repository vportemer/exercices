using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Véhicules
{
    public abstract class Véhicule : IComparable
    {
        #region Propriétés

        public string Nom { get; }
        public int NbRoues { get; }
        public Energies Energie { get; }
        public virtual string Description
        {
            get
            {
                return string.Format("Véhicule {0} roule sur {1} roues et à l'énergie {2}",
                    Nom, NbRoues, Energie);
            }
        }
        public abstract double PRK { get; }
        public int Prix { get; }
        #endregion

        #region Constructeurs
        public Véhicule()
        {
            NbRoues = 4;
        }
        public Véhicule(string nom, int nbroues, Energies energie)
        {
            Nom = nom;
            NbRoues = nbroues;
            Energie = energie;
        }
        public Véhicule(string nom, int prix)
        {
            Nom = nom;
            Prix = prix;
      
        }
        #endregion
        #region Méthodes publiques
        public abstract void CalculerConso();
        
        public int CompareTo(object objet)
        {
            Véhicule v = (Véhicule)objet;
            //if (PRK < v.PRK)
            //    return - 1;
            //if (PRK > v.PRK)
            //    return 1;
            //return 0;
            return Prix.CompareTo(v.Prix);
        }
        #endregion
    }

    public class Voiture : Véhicule
    {
        #region Propriétés
        public override string Description
        {
            get { return string.Format("Je suis une voiture\r\n") + base.Description; }
        }

        public override double PRK
        {
            get
            {
                return 2;
            }
        }
        #endregion


        #region Constructeurs
        public Voiture(string nom, Energies energie) : base(nom, 4, energie)
        {

        }

        public override void CalculerConso()
        {
            throw new NotImplementedException();
        }
        public Voiture(string nom, int prix) :base (nom, prix)
        {

        }
        #endregion
    }
    public class Moto : Véhicule
    {
        #region Propriétés


        public override string Description
        {
            get
            {
                { return string.Format("Je suis une moto\r\n") + base.Description; };
            }
        }

        public override double PRK
        {
            get
            {
                return 2;
            }
        }
        #endregion

        #region Constructeurs

        public override void CalculerConso()
        {
            throw new NotImplementedException();
        }

        public Moto(string nom, Energies energie) : base(nom, 2, energie)
        {

        }
        public Moto (string nom, int prix) : base(nom, prix)
        {

        }
        #endregion
    }
}
