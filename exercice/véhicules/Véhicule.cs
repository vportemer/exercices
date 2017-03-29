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
        public string Energie { get; }
        public virtual string Description
        {
            get
            {
                return string.Format("Véhicule {0} roule sur {1} roues et à l'énergie {2}",
                    Nom, NbRoues, Energie);
            }
        }
        public abstract double PRK { get; }
        #endregion

        #region Constructeurs
        public Véhicule()
        {
            NbRoues = 4;
        }
        public Véhicule(string nom, int nbroues, string energie)
        {
            Nom = nom;
            NbRoues = nbroues;
            Energie = energie;
        }

        #endregion
        #region Méthodes publiques
        public abstract void CalculerConso();
        #endregion
        public int CompareTo(object objet)
            {
            Véhicule v = (Véhicule)objet;
            //if (PRK < v.PRK)
            //    return - 1;
            //if (PRK > v.PRK)
            //    return 1;
            //return 0;
            return PRK.CompareTo(v.PRK);
        }
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
    public Voiture() : base()
    {

    }

    public override void CalculerConso()
    {
        throw new NotImplementedException();
    }
    #endregion
}
public class Moto : Véhicule
{
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

    public override void CalculerConso()
    {
        throw new NotImplementedException();
    }
}
}
