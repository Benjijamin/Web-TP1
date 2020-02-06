
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduitNumero9
{
    public class Produit
    {

        private int noProduit;
        private string nomProduit;
        private string description;
        private double value;
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
            get { return value; }

            set
            {
                if (value <= 500 && value >= 0)
                {
                    this.value = value;

                }
                else
                {
                    throw new ProduitException("prix (" + value + ") invalide");
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
                    throw new ProduitException("quantite (" + value + ") invalide");
                }
            }
        }
        public int QteRupture
        {
            get { return qteRupture; }

            set
            {
                if (value <= 20 && value >= 0)
                {
                    qteRupture = value;
                }
                else
                {
                    throw new ProduitException("QteRupture (" + value + ") invalide");
                }
            }
        }
        public bool Taxable { get => taxable; set => taxable = value; }


        public override String ToString()
        {

            return string.Format("Produit : {0} {1}", nomProduit, noProduit);

        }

        public double Total(Produit p)
        {
            return p.value * p.quantite;
        }




        //Operateurs

        public static bool operator ==(Produit I, Produit J)
        {

            return I.noProduit == J.noProduit;

        }


        public static bool operator !=(Produit I, Produit J)
        {
            return I.noProduit != J.noProduit;
        }


        public static bool operator >(Produit I, Produit J)
        {
            return I.quantite - I.qteRupture > J.quantite - J.qteRupture;
        }

        public static bool operator <(Produit I, Produit J)
        {
            return I.quantite - I.qteRupture < J.quantite - J.qteRupture;


        }




        static void Main(string[] args)
        {

            Produit p = new Produit(1, "Ben");





            Console.WriteLine(p);
            Console.ReadLine();








        }
    }
}
