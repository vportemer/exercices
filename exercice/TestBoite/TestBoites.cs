using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Boites;

namespace TestBoites
{
    [TestClass]
    public class TestBoites
    {
        [TestMethod]
        public void TestCompteurBoite()
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
        }

    }
}
