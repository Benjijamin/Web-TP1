using ProduitNumero9;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialiser
{
    class No10
    {

        public Produit[] GenListe()
        {
            Produit p1 = new Produit(1, "Banane");
            Produit p2 = new Produit(2, "Max");
            Produit p3 = new Produit(3, "Ben");
            Produit p4 = new Produit(4, "Sam");
            Produit p5 = new Produit(5, "Pain");
            Produit p6 = new Produit(6, "Roche");
            Produit p7 = new Produit(70, "Un tissu");
            Produit[] liste = new Produit[] { p1, p2, p3, p4, p5, p6, p7 };

            return liste;
        }

        public void ListeVersTexte(Produit[] liste)
        {
            String[] listeconv = new string[liste.Length];

            for (int i = 0; i < listeconv.Length; i++)
            {
                listeconv[i] = string.Format("noProduit: {0}  nomProduit: {1}", liste[i].NoProduit, liste[i].NomProduit);
            }

            try
            {
                System.IO.File.WriteAllLines(AppDomain.CurrentDomain.BaseDirectory + @"\test.txt", listeconv);
            }
            catch (Exception e)
            {
                Console.WriteLine("Echec d'ecriture au fichier");
            }
        }


        public void Serializer(Produit[] liste)
        {
            XmlSerializer xmls = new XmlSerializer(typeof(Produit));
            using (TextWriter writer = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"\test.xml")) {
                foreach (Produit p in liste)
                {
                    xmls.Serialize(writer, p);
                }
            }
        }


        static void Main(string[] args)
        {
            No10 p = new No10();

            Produit[] liste = p.GenListe();

            p.ListeVersTexte(liste);

            foreach (Produit prod in liste)
            {
                Console.WriteLine(prod);
            }

            p.Serializer(liste);
        }
    }
}
