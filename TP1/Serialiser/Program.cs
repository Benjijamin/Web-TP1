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

        static Array GenListe()
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

            System.IO.File.WriteAllLines(@"C:\", listeconv);
        }

        static void Main(string[] args)
        {
            Array liste = GenListe();

            foreach (Produit p in liste)
            {
                Console.WriteLine(p);
            }



        }
    }
}
