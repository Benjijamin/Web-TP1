using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProduitNumero9;

namespace UnitProduit
{
    [TestClass]
    public class UnitTest1
    {
        Produit p, p1, p2, p3, p4, p5;


        [TestInitialize()]
        public void before()
        {
            //jeux valides pour chacun des constructeurs
            p = new Produit(1, "Ben");
            p.Prix = 10;
            p.Quantite = 5;
            p1 = new Produit(2, "lait");
            p2 = new Produit(3, "jus");
            p3 = new Produit(4, "Beurre");
            p5 = new Produit(2, "lait");

        }

        [TestMethod]
        public void TestErreurProduit()
        {

            try
            {
                //Exception
                p.Prix = -100;
                Assert.Fail();

            }
            catch (ProduitException)
            {

            }
            try
            {
                //pas exception prix
                p1.Prix = 100;
            }
            catch (ProduitException)
            {
                Assert.Fail();
            }



            //Test Quantite

            try
            {
                //Exception
                p.Quantite = 250;
                Assert.Fail();

            }
            catch (ProduitException)
            {

            }
            try
            {
                //pas exception prix
                p1.Prix = 100;
            }
            catch (ProduitException)
            {
                Assert.Fail();
            }

            try
            {
                //Exception
                p1.QteRupture = 25;



                Assert.Fail();

            }
            catch (ProduitException)
            {

            }
            try
            {
                //pas exception qteRupture
                p1.QteRupture = 10;
            }
            catch (ProduitException)
            {
                Assert.Fail();
            }







        }
        [TestMethod]
        public void TestGetPreNoProduit()
        {
            Assert.AreEqual(p.NoProduit, 1);
            Assert.AreEqual(p1.NoProduit, 2);
            Assert.AreEqual(p2.NoProduit, 3);
            Assert.AreEqual(p3.NoProduit, 4);
        }
        [TestMethod]
        public void TestGetnomProduit()
        {
            Assert.AreEqual(p.NomProduit, "Ben");
            Assert.AreEqual(p1.NomProduit, "lait");
            Assert.AreEqual(p2.NomProduit, "jus");
            Assert.AreEqual(p3.NomProduit, "Beurre");
        }
        [TestMethod]
        public void TestTotal()
        {
            Assert.AreEqual(p.Total(p), 50);

        }

        [TestMethod]
        public void TestProduit()
        {
            Assert.IsTrue(p1.NomProduit.Equals("lait"));
            Assert.IsTrue(p1.ToString().Equals("Produit : lait 2"));


        }
        [TestMethod]
        public void TestEgal()
        {
            Assert.IsTrue(p1 == p5);

        }
        [TestMethod]
        public void TestNotEgal()
        {
            Assert.IsTrue(p1 != p2);

        }
        [TestMethod]
        public void TestPlusGrand()
        {
            p1.Quantite = 15;
            p1.QteRupture = 1;
            p2.Quantite = 5;
            p2.QteRupture = 1;
            Assert.IsTrue(p1 > p2);

        }
        [TestMethod]
        public void TestPlusPetit()
        {
            p1.Quantite = 5;
            p1.QteRupture = 1;
            p2.Quantite = 10;
            p2.QteRupture = 1;
            Assert.IsTrue(p1 < p2);

        }

    }
}
