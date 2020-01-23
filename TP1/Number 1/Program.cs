using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_1
{
    class Program
    {
        private double temp;
        public double TempKel(double temp)
        {
            double kel;

            kel = temp + 273.15;

            return kel;
        }

        public double TempFah(double temp)
        {
            double fah;

            fah = (temp * 9 / 5) + 32;

            return fah;
        }




        static void Main(string[] args)
        {
            string val;


            double a;
            while (true)
            {
                try
                {


                    Console.Write("Entrez Temperature : ");
                    val = Console.ReadLine();
                    a = Convert.ToDouble(val);
                    break;
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Ce n'est pas une Temp valide");
                }

            }
            Program num1 = new Program();
            Console.WriteLine("Temp en Kelvin : " + num1.TempKel(a));
            Console.WriteLine("Temp en Fahrenheit : " + num1.TempFah(a));

            Console.ReadLine();



        }
    }
}
