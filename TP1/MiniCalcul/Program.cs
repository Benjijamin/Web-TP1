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
                    Console.WriteLine("Operateur inconnu");
                    nb3 = 0;
                    break;
            }

            return nb3;
        }

        static void Main(string[] args)
        {
            string op = "";
            double nb1 = 0;
            double nb2 = 0;

            while (true) {
                try
                {
                    Console.WriteLine("Premier nombre :");
                    nb1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Operateur (+ , - , / , *) :");
                    op = Console.ReadLine();

                    Console.WriteLine("Deuxieme nombre :");
                    nb2 = Convert.ToDouble(Console.ReadLine());

                    break;
                }
                catch (FormatException fe) {
                    Console.WriteLine("Ce n'est pas un nombre");
                }
            }

            Program miniCalcul = new Program();
            double res = miniCalcul.Calcul(op,nb1,nb2);

            Console.WriteLine("Resultat :" + res);
        }
    }
}
