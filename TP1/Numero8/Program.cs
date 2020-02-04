using System;
using System.Collections.Generic;

namespace Numero8
{
    class Couleur
    {
        private string nCouleur;
        private int r;
        private int g;
        private int b;

        public string NCouleur { get => nCouleur; set => nCouleur = value; }
        public int R { get => r; set => r = value; }
        public int G { get => g; set => g = value; }
        public int B { get => b; set => b = value; }

        public Couleur(string nCouleur, int r, int g, int b)
        {
            NCouleur = nCouleur;
            R = r;
            G = g;
            B = b;
        }

        public override string ToString()
        {
            return NCouleur;
        }


        public void AfficheC()
        {
            Console.WriteLine("{0} : {1}, {2}, {3}", NCouleur, R, G, B);
        }

        public static bool operator ==(Couleur l, Couleur r)
        {
            return l.NCouleur == r.NCouleur
                && l.R == r.R
                && l.G == r.G
                && l.B == r.B;
        }

        public static bool operator !=(Couleur l, Couleur r)
        {
            return l.NCouleur != r.NCouleur
                || l.R != r.R
                || l.G != r.G
                || l.B != r.B;
        }

        public void modifierCouleur(string s, int r, int g, int b) {
            NCouleur = s;
            R = r;
            G = g;
            G = b;
        }
    }
    class Program
    {
        private List<Couleur> listec;
        internal List<Couleur> Listec { get => listec; set => listec = value; }

        public Program()
        {
            Listec = new List<Couleur>();
        }

        public void AjouterCouleur(Couleur couleur) {
            Listec.Add(couleur);
        }

        public Couleur TrouverCouleur(string nomCouleur)
        {
            foreach (Couleur c in Listec)
            {
                if (c.NCouleur == nomCouleur) return c;
            }
            return null;
        }


        static void Main(string[] args)
        {
            Couleur c1 = new Couleur("blanc", 255, 255, 255);
            Couleur c2 = new Couleur("noir", 0, 0, 0);
            Couleur c3 = new Couleur("rouge", 255, 0, 0);
            Couleur c4 = new Couleur("vert", 0, 255, 0);
            Couleur c5 = new Couleur("bleu", 0, 0, 255);
            Couleur c6 = new Couleur(null, 0, 0, 1);
            Couleur c7 = new Couleur("supervert", -10, 400, 1);

            Program p = new Program();

            p.AjouterCouleur(c1);
            p.AjouterCouleur(c2);
            p.AjouterCouleur(c3);
            p.AjouterCouleur(c4);
            p.AjouterCouleur(c5);

            foreach (Couleur c in p.Listec) {
                c.AfficheC();
            }





        }
    }
}
