using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduitNumero9
{
    class Produit
    {

        private int noProduit;
        private string nomProduit;
        private string description;
        private double prix;
        private int quantite;
        private int qteRupture;
        private bool taxable;

        public Produit(int noProduit, string nomProduit)
        {
            NoProduit = noProduit;
            NomProduit = nomProduit;
        }

        public int NoProduit { get => noProduit; set => noProduit = value; }
        public string NomProduit { get => nomProduit; set => nomProduit = value; }
        public string Description { get => description; set => description = value; }
        public double Prix
        {
            get { return prix; }

            set
            {
                if (value <= 500 && value >= 0)
                {
                    prix = value;
                }
                else
                {
                    Console.WriteLine("mauvaise valeur");
                }
            }
        }
        public int Quantite
        {
            get { return quantite; }

            set
            {
                if (value <= 200 && value >= 0)
                {
                    quantite = value;
                }
                else
                {
                    Console.WriteLine("mauvaise valeur");
                }
            }
        }
        public int QteRupture
        {
            get { return qteRupture; }

            set
            {
                if ((value / 100) <= 0.2 && value / 100 >= 0)
                {
                    qteRupture = value;
                }
                else
                {
                    Console.WriteLine("mauvaise valeur");
                }
            }
        }
        public bool Taxable { get => taxable; set => taxable = value; }


        public override String ToString()
        {
            return String.Format("Produit : {0} {1} {2} ", nomProduit, noProduit, qteRupture);

        }

        public double Total(Produit p)
        {
            return p.prix* p.quantite;
        }



        static void Main(string[] args)
        {

            Produit p = new Produit(1, "Ben");

            Console.WriteLine(p);
            Console.ReadLine();








        }
    }
}
