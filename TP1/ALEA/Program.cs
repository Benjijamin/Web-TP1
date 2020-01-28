using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALEA
{
    class Program
    {
        static int[] GenTableau()
        {
            int[] tab = new int[20];
            Random rnd = new Random();

            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = rnd.Next(1, 101);
            }

            return tab;
        }

        static int[] TriCroissant(int[] tab)
        {
            Array.Sort(tab);
            return tab;
        }

        static void ValImpaires(int[] tab)
        {
            Console.WriteLine("Nombres impairs :");
            foreach (int i in tab)
            {
                if (i % 2 != 0) Console.WriteLine(i);
            }
            Console.WriteLine("");
        }

        static void MaxVal(int[] tab)
        {
            int max = 1;
            foreach (int i in tab)
            {
                if (i > max) max = i;
            }
            Console.WriteLine("Nombre Max = {0}", max);
            Console.WriteLine("");
        }

        static void Main(string[] args)
        {
            int[] tab = GenTableau();
            Console.WriteLine("Tableau :");
            foreach (int i in tab)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("");

            Console.WriteLine("Tableau trie");
            tab = TriCroissant(tab);
            foreach (int i in tab)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("");

            ValImpaires(tab);

            MaxVal(tab);
        }
    }
}
