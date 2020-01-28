using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialiser
{
    class Program
    {
        enum Produit
        {
            LAIT, CAFE, OEUF, VIANDE, FROMAGE, PAIN, BAGEL, FRUIT
        }

        static Produit[] GenListe()
        {
            Produit[] liste = new Produit[5];

            Random rnd = new Random();
            Array produits = Enum.GetValues(typeof(Produit));
            for (int i = 0; i < liste.Length; i++)
            {
                liste[i] = (Produit)produits.GetValue(rnd.Next(produits.Length));
            }
            return liste;
        }

        static void ListeVersTexte(Produit[] liste)
        {
            String[] listeconv = new string[liste.Length];
            for (int i = 0; i < listeconv.Length; i++)
            {
                listeconv[i] = Enum.GetName(typeof(Produit), liste[i]);
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

        static void Main(string[] args)
        {
            Produit[] liste = GenListe();

            foreach (Produit p in liste)
            {
                Console.WriteLine(p);
            }

            ListeVersTexte(liste);

        }
    }
}
