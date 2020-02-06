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
            private int p1;
            private int p2;
            private int p3;

            public string NCouleur { get => nCouleur; set => nCouleur = value; }
            public int P1 { get => p1; set => p1 = value > 255 || value < 0 ? 0 : value; }
            public int P2 { get => p2; set => p2 = value > 255 || value < 0 ? 0 : value; }
            public int P3 { get => p3; set => p3 = value > 255 || value < 0 ? 0 : value; }



            public Couleur(string nom, int x1, int x2, int x3)
            {

                nCouleur = nom;
                p1 = x1;
                p2 = x2;
                p3 = x3;
            }

            

            public override string ToString()
            {
                return NCouleur.ToString() + ", " + p1.ToString() + ", " + p2.ToString() + ", " + p3.ToString();
            }


        }

        private List<Couleur> listC = new List<Couleur>();
        

        internal List<Couleur> ListC { get => listC; set => listC = value; }

        public void AjouterCouleur(Couleur coul)
        {
            if (!ListC.Contains(coul))
                ListC.Add(coul);
        }


        public void Listcouleur() {

            Couleur blanc = new Couleur("Blanc", 255, 255, 255);
            Couleur rouge = new Couleur("Rouge", 255, 0, 0);
            Couleur lime = new Couleur("Lime", 0, 255, 0);
            Couleur bleu = new Couleur("Bleu", 0, 0, 255);
            Couleur noir = new Couleur("Noir", 0, 0, 0);
            AjouterCouleur(blanc);
            AjouterCouleur(rouge);
            AjouterCouleur(lime);
            AjouterCouleur(bleu);
            AjouterCouleur(noir);


        }


        public void SupprimerCouleur(Couleur coul) {
            ListC.Remove(coul);
        }


        public void ShowCouleur()
        {
            for (int i = 0; i < ListC.Count; i++)
            {
                Console.WriteLine("Couleur est : " + ListC[i]);
            }
        }

        public Couleur TrouverCouleur(String coul)
        {
            Couleur couleur = new Couleur("", -1, -1, -1);
            foreach (Couleur c in ListC)
            {

                if (c.NCouleur == coul)
                {
                    couleur = c;
                }


            }
            
            return couleur;
        }


        public void trouverRGB(Couleur coul)
        {


            if (coul.P1 != -1 || coul.P2 != -1 || coul.P3 != -1)
            {

                Console.WriteLine("La couleur est : " + coul.NCouleur + " " + coul.P1 +", "+ coul.P2 +", "+ coul.P3);

            }
            else
            {
                Console.WriteLine("Code inexistant");
            }


           
        }

        public void ModifierCouleur(Couleur coul,string nom,int r, int g, int b) {
            Couleur mauve = new Couleur(coul.NCouleur = nom, coul.P1 = r, coul.P2 = g, coul.P3 = b);
            listC.Add(mauve);
            listC.Remove(TrouverCouleur("Blanc"));
          


        }



        static void Main(string[] args)
        {
            Program prog = new Program();
            prog.Listcouleur();
            prog.ShowCouleur();

            prog.trouverRGB(prog.TrouverCouleur("bleu"));


            prog.ListC.Remove(prog.TrouverCouleur("Blanc"));

            prog.ShowCouleur();

            Console.WriteLine();

            prog.Listcouleur();
            prog.ShowCouleur();

            Console.WriteLine();

            prog.ModifierCouleur(prog.TrouverCouleur("Blanc"),"Mauve",224,176,255);
            Console.WriteLine();
            prog.ShowCouleur();
            Console.WriteLine();
            Couleur c1 = new Couleur("Gris", 128, 128, 128);
            Couleur c2 = new Couleur("Blanc", 255, 255, 255);
            prog.AjouterCouleur(c1);
            prog.AjouterCouleur(c2);
            prog.ShowCouleur();
            c1 = c2;
            prog.AjouterCouleur(c1);
            prog.SupprimerCouleur(c1);
            Console.WriteLine();
            prog.ShowCouleur();
            prog.ModifierCouleur(prog.TrouverCouleur("Gris"), "Rose", 255, 51, 255);
            Console.WriteLine();
            prog.ShowCouleur();



            Console.ReadLine();





        }
    }
}

