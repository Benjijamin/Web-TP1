using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCalcul
{
    class Program
    {

        private double Calcul(string op, double nb1, double nb2) {
            double nb3;
            switch (op) {
                case "+":
                    nb3 = nb1 + nb2;
                    break;
                case "-":
                    nb3 = nb1 - nb2;
                    break;
                case "/":
                    nb3 = nb1 / nb2;
                    break;
                case "*":
                    nb3 = nb1 * nb2;
                    break;
                default:
                    Console.WriteLine("Operateur iconnu");
                    nb3 = 0;
                    break;
            }

            return nb3;
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("Premier nombre :");
            double nb1 =  Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Operateur (+ , - , / , *) :");
            string op = Console.ReadLine();

            Console.WriteLine("Deuxieme nombre :");
            double nb2 = Convert.ToDouble(Console.ReadLine());

            Program miniCalcul = new Program();
            double res = miniCalcul.Calcul(op,nb1,nb2);

            Console.WriteLine("Resulat :" + res);
        }
    }
}
