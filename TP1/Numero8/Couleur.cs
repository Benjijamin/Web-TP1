using System;
using System.Collections.Generic;
using System.Text;

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


        public void afficheC()
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
    }
}
