﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Véhicules
{
    public class Véhicule
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
        #endregion
        #region constructeurs
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
    }
    public class Voiture : Véhicule
    {
        #region Propriétés
        public override string Description
        {
            get { return string.Format("Je suis une voiture\r\n") + base.Description; }
        }

        #endregion


        #region constructeurs
        public Voiture() : base()
        {

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




    }
}
