using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProduitNumero9;

namespace ProduitTest
{


   
    [TestClass]
    public class UnitTest1
    {
        Produit p, p1, p2, p3, p4;


        [TestInitialize()]
        public void before()
        {
            //jeux valides pour chacun des constructeurs
              p = new Produit(1, "Ben");
              p1 = new Produit(2, "Ben");
              p2 = new Produit(3, "Ben");
              p3 = new Produit(4, "Ben");
            
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
            catch (ProduitException) {
               
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

           




        }
    }
}
