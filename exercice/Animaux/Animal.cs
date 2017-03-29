using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animaux
{
    public abstract class Animal : IMangeable
    {
        #region Propriétés
        public virtual string Description
        {
            get
            {
                return "Je suis l'animal";
            }
        }
        public static int Compteur { get; private set; }



        #endregion
        #region Constructeurs
        public Animal()
        {
            Compteur++;
        }

        public virtual bool Mangeable()
        {
            return true;
        }
        #endregion

    }
    public class Chat : Animal
    {
        public override string Description
        {
            get
            {
                return "Je suis un chat";
            }

        }
        public override bool Mangeable()
        {
            return false;
        }
    }
    public class Chien : Animal
    {
        public override string Description
        {
            get
            {
                return "Je suis un chien";
            }
        }
    }
}

