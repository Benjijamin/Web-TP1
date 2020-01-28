using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Bonus
{
    class Program
    {
        private Dictionary<int, (string, double)> temperatures = new Dictionary<int, (string, double)>
        {
            {0 , ("juin",19.7) },
            {1 , ("juin",13.6) },
            {2 , ("juin",14.9) },
            {3 , ("juin",14.5) },
            {4 , ("juin",19.9) },
            {5 , ("juin",22.1) },
            {6 , ("juin",22.1) },
            {7 , ("juin",21.2) },
            {8 , ("juin",27.3) },
            {9 , ("juin",24.9) },
            {10, ("juillet",24.4) },
            {11, ("juillet",27.6) },
            {12, ("juillet",28.4) },
            {13, ("juillet",30.9) },
            {14, ("juillet",29.4) },
            {15, ("juillet",28.0) },
            {16, ("juillet",25.1) },
            {17, ("juillet",25.6) },
            {18, ("juillet",28.1) },
            {19, ("juillet",24.2) },
            {20, ("aout",27.7) },
            {21, ("aout",28.3) },
            {22, ("aout",23.5) },
            {23, ("aout",21.6) },
            {24, ("aout",24.3) },
            {25, ("aout",29.6) },
            {26, ("aout",26.8) },
            {27, ("aout",24.5) },
            {28, ("aout",22.9) },
            {29, ("aout",20.9) }
        };

        private void AfficherTemperatures(string mois)
        {
            Console.WriteLine("Temperatures en {0}: ", mois);
            foreach (KeyValuePair<int, (string, double)> value in temperatures.Where(temp => temp.Value.Item1 == mois))
            {
                Console.WriteLine(value.Value.Item2);
            }

            Console.WriteLine("");
        }

        private void AfficherTemperatureMax(string mois)
        {
            double max = 0;
            foreach (KeyValuePair<int, (string, double)> value in temperatures.Where(temp => temp.Value.Item1 == mois))
            {
                if (value.Value.Item2 > max) max = value.Value.Item2;
            }
            Console.WriteLine("Temperature maximale en {0}: {1}", mois, max);
            Console.WriteLine("");
        }
        private void AfficherTemperatureMin(string mois)
        {
            double min = 1000000;
            foreach (KeyValuePair<int, (string, double)> value in temperatures.Where(temp => temp.Value.Item1 == mois))
            {
                if (value.Value.Item2 < min) min = value.Value.Item2;
            }
            Console.WriteLine("Temperature minimale en {0}: {1}", mois, min);
            Console.WriteLine("");
        }

        private void AfficherTemperatureMoyenne(string mois)
        {
            double moyenne = 0;
            int i = 0;
            foreach (KeyValuePair<int, (string, double)> value in temperatures.Where(temp => temp.Value.Item1 == mois))
            {
                moyenne += value.Value.Item2;
                i++;
            }
            moyenne /= i;
            Console.WriteLine("Moyenne des temperatures en {0}: {1}", mois, moyenne);
            Console.WriteLine("");
        }

        private void AfficherTousLesMois()
        {
            foreach (KeyValuePair<int, (string, double)> value in temperatures)
            {
                Console.WriteLine(value.Value.Item2);
            }
            Console.WriteLine("");

            double max = 0;
            foreach (KeyValuePair<int, (string, double)> value in temperatures)
            {
                if (value.Value.Item2 > max) max = value.Value.Item2;
            }
            Console.WriteLine("Temperature maximale: " + max);
            Console.WriteLine("");

            double min = 1000000;
            foreach (KeyValuePair<int, (string, double)> value in temperatures)
            {
                if (value.Value.Item2 < min) min = value.Value.Item2;
            }
            Console.WriteLine("Temperature minimale: " + min);
            Console.WriteLine("");

            double moyenne = 0;
            int i = 0;
            foreach (KeyValuePair<int, (string, double)> value in temperatures)
            {
                moyenne += value.Value.Item2;
                i++;
            }
            moyenne /= i;
            Console.WriteLine("Moyenne des temperatures: " + moyenne);
            Console.WriteLine("");
        }

        private void AfficherMois(string mois)
        {
                AfficherTemperatures(mois);
                AfficherTemperatureMax(mois);
                AfficherTemperatureMin(mois);
                AfficherTemperatureMoyenne(mois);
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.AfficherTousLesMois();



            p.AfficherMois("juin");
            p.AfficherMois("juillet");
            p.AfficherMois("aout");

        }
    }
}
