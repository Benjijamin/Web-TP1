using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero6
{
    class Program
    {
    public ArrayList Converte()
        {
            int min = 15;
            int max = 125;
            int aleatoire;
            Random random = new Random();
            ArrayList initial = new ArrayList();
            ArrayList tab = new ArrayList();


            for (int i = 0; i < 25; i++)
            {
                aleatoire = random.Next(min, max);
                initial.Add( aleatoire);
                tab.Add(Convert.ToChar(aleatoire));

            }
            Console.WriteLine("Voici le tableau de chiffres:");
            foreach (int i in initial)
            {
                Console.Write(i + " ");

                

            }
            Console.WriteLine("\nVoici le tableau de caractères:");
            foreach (char i in tab)
            {
                Console.Write(i + " ");


            }


            return initial;

        


       
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Converte();
          
            Console.ReadLine();
            

        }
    }
}
