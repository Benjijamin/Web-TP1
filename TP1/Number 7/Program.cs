using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_7
{
    class Program
    {
        public struct Couleur
        {

            private string nCouleur;
            private int p3;
            private int p1;
            private int p2;



            public Couleur(string nom, int x1, int x2, int x3)
            {

                nCouleur = nom;
                p1 = x1;
                p2 = x2;
                p3 = x3;
            }

            public string NCouleur { get => nCouleur; set => nCouleur = value; }
            public int P1 { get => p1; set => p1 = value; }
            public int P2 { get => p2; set => p2 = value; }
            public int P3 { get => p3; set => p3 = value; }


            public override string ToString()
            {
                return nCouleur.ToString() + ", " + p1.ToString() + ", " + p2.ToString() + ", " + p3.ToString();
            }


        }

        private List<Couleur> listC = new List<Couleur>();

        public void ajouterCouleur(Couleur coul)
        {
            if (!listC.Contains(coul))
                listC.Add(coul);
        }


        public void showCouleur()
        {
            for (int i = 0; i < listC.Count; i++)
            {
                Console.WriteLine("Couleur est : " + listC[i]);
            }
        }

        public void trouverCouleur(String coul) {
            for(int i = 0;i < listC.Count; i++)
            {

            }
            
        }


        public (int, int, int) trouverRGB(Couleur coul)
        {
            return (coul.P1, coul.P2, coul.P3);
        }



        static void Main(string[] args)
        {
            Program prog = new Program();
            Couleur val;
            Couleur a;
            Couleur blanc = new Couleur("Blanc", 255, 255, 255);
            Couleur rouge = new Couleur("Rouge", 255, 0, 0);
            Couleur lime = new Couleur("Lime", 0, 255, 0);
            Couleur bleu = new Couleur("Bleu", 0, 0, 255);
            Couleur noir = new Couleur("Noir", 0, 0, 0);

            prog.ajouterCouleur(blanc);
            prog.ajouterCouleur(rouge);
            prog.ajouterCouleur(lime);
            prog.ajouterCouleur(bleu);
            prog.ajouterCouleur(noir);

            prog.showCouleur();

            Console.Write("Entrez couleur : ");
            val = Console.ReadLine();
          


            prog.trouverCouleur(bleu);






            Console.ReadLine();





        }
    }
}

