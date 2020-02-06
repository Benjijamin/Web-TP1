using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALEA
{
    class Program
    {
        private int[] tab;

        public int[] Tab { get => tab; set => tab = value; }

        public int[] GenTableau()
        {
            int[] tabi = new int[20];
            Random rnd = new Random();

            for (int i = 0; i < tabi.Length; i++)
            {
                tabi[i] = rnd.Next(1, 101);
            }

            Tab = tabi;

            return tabi;
        }

        public int[] TriCroissant()
        {
            Array.Sort(Tab);
        
            return Tab;
        }

        public void ValImpaires()
        {
            Console.WriteLine("Nombres impairs :");
            foreach (int i in this.Tab)
            {
                if (i % 2 != 0) Console.WriteLine(i);
            }
            Console.WriteLine("");
        }

        public void MaxVal()
        {
            int max = 1;
            foreach (int i in Tab)
            {
                if (i > max) max = i;
            }
            Console.WriteLine("Nombre Max = {0}", max);
            Console.WriteLine("");
        }

        public override string ToString() {
            string s = "";

            foreach (int i in Tab)
            {
                s = s + i + "\n";
            }
            return s;
        }


        static void Main(string[] args)
        {
            Program p = new Program();

            p.GenTableau();

            Console.WriteLine("Tableau :\n"+p);
            

           
            p.TriCroissant();
            Console.WriteLine("Tableau trie\n" + p);

            p.ValImpaires();

            p.MaxVal();
        }
    }
}
