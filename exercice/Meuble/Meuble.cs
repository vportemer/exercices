using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meuble
{
    public class Meuble
    {
        #region Propriétés
        public virtual string Description
        {
            get
            {
                return "je suis un meuble";
            }
        }
        public static int Compteur { get; set; }
        #endregion
        #region Constructeurs
        public Meuble()
        {
            Compteur++;
        }
        #endregion
        #region Méthodes Publiques

        #endregion
    }
    public class Chaise : Meuble
    {
        #region Propriétés
        public override string Description
        {
            get
            {
                return "je suis une chaise";
            }
        }
        #endregion
        #region Constructeurs

        #endregion
        #region Méthodes Publiques

        #endregion

    }
    public class Table : Meuble
    {
        #region Propriétés
        public override string Description
        {
            get
            {
                return "je suis une table";
            }
        }
        #endregion
        #region Constructeurs
        #endregion
        #region Méthodes Publiques

        #endregion
    }
}
