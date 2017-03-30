using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Boites;

namespace TestBoites
{
    [TestClass]
    public class TestBoites
    {
        [TestMethod]

        public void TestCompteurBoite()//variable statique en premier car la valeur est partagé entre toute les instances dont le compteur va être incrémenté avec l'autre test volume si il était placé après
        {
            Boite nbBoitea = new Boite();
            Boite nbBoiteb = new Boite();
            Boite nbBoitec = new Boite();
            Boite nbBoited = new Boite();
            Boite nbBoitee = new Boite();
            Assert.AreEqual(Boite.CompteurBoite, 5);
        }

        [TestMethod]
        public void TestVolume()
        {
            Boite titi = new Boite(20, 20, 20);
            double resultat = titi.Volume;
            Assert.AreEqual(resultat, 8000);

            //    Boite titi = new Boite(200,0.1, 3.0);
            //    Assert.AreEqual(60.0, titi.Volume, 0.00000001);//on peut mettre un delta, pour les doubles (ou Float) car résisdus, pas de problème avec décimal
            //}//il faut soit tester la différence <0.01 ou mettre un delta
            //décimal pas de problème pour calcul précis mais prend plus de mémoire

        }
    }
}
