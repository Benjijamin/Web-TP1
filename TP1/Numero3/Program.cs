using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero3
{
    class Program
    {

        public String Test(string mot)
        {
            int min = 0;
            int max = mot.Length - 1;
            String rep = " ";
            while (true)
            {
                if (min > max)
                {
                    foreach(char c in mot)
                    {
                        
                        if((rep.Length % 2) != 0)
                        {
                            rep += Char.ToUpper(c);
                        }
                        else
                        {
                            rep += c;
                        }
                        Console.WriteLine(rep);
                    }
                    return "Vrai";
                }
                char a = mot[min];
                char b = mot[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return "Faux";
                }
                min++;
                max--;
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            string continu = "o";

            while (continu.Equals("o"))
            {
                Console.WriteLine("Entrez un mot");
                string mot = Console.ReadLine();
                Console.WriteLine(p.Test(mot));
                Console.WriteLine("Pour réessayer appuyez sur 'o' sinon n'importe quelle touche.");
               continu = Console.ReadLine();
                Console.Clear();
            }
            
                
            
        }
    }
}
