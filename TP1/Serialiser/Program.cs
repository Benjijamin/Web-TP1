using ProduitNumero9;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
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
                System.IO.File.WriteAllLines("test.txt", listeconv);
            }
            catch (Exception e)
            {
                Console.WriteLine("Echec d'ecriture au fichier");
            }
        }


        public void Serializer(Produit[] liste)
        {
            XmlSerializer xmls = new XmlSerializer(typeof(Produit[]));
            using (TextWriter writer = new StreamWriter("test.xml"))
            {
                xmls.Serialize(writer, liste);

            }
        }

        public void Lecture(string fichier)
        {
            if (Regex.IsMatch(fichier, "xml"))
            {
                XmlTextReader r = new XmlTextReader(fichier);

                while (r.Read())
                {
                    if (r.NodeType == XmlNodeType.Element && r.Name == "NoProduit")
                    {
                        Console.WriteLine("noProduit : " + r.ReadElementString());
                    }
                    if (r.NodeType == XmlNodeType.Element && r.Name == "NomProduit")
                    {
                        Console.WriteLine("nomProduit : " + r.ReadElementString());
                    }
                    if (r.NodeType == XmlNodeType.Element && r.Name == "Prix")
                    {
                        Console.WriteLine("prix : " + r.ReadElementString());
                    }
                    if (r.NodeType == XmlNodeType.Element && r.Name == "Quantite")
                    {
                        Console.WriteLine("quantite : " + r.ReadElementString());
                    }
                    if (r.NodeType == XmlNodeType.Element && r.Name == "QteRupture")
                    {
                        Console.WriteLine("qteRupture : " + r.ReadElementString());
                    }
                    if (r.NodeType == XmlNodeType.Element && r.Name == "Taxable")
                    {
                        Console.WriteLine("taxable : " + r.ReadElementString() + "\n");
                    }
                }


            }
            else if (Regex.IsMatch(fichier, "txt"))
            {
                string[] lignes = File.ReadAllLines(fichier);
                foreach (string ligne in lignes)
                {
                    Console.WriteLine(ligne);
                }
            }
        }


        static void Main(string[] args)
        {
            No10 p = new No10();

            Produit[] liste = p.GenListe();

            p.ListeVersTexte(liste);

            p.Serializer(liste);

            p.Lecture("test.xml");
            p.Lecture("test.txt");
        }
    }
}
