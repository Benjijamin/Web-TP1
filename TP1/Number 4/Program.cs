using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        string reg;

        public int RegChar(string reg)
        {
            int count;

            count = Regex.Matches(reg, "[~!@#$%^&*()_+{}:\"<>?,.'-]").Count;


            return count;
        }

        public int RegUp(string reg)
        {
            int count;

            count = Regex.Matches(reg, "[A-Z]").Count;

            return count;
        }

        public int RegCount(string reg)
        {
            int count;


            count = Regex.Matches(reg, "[a-zA-Z0-9]").Count;


            return count;
        }




        static void Main(string[] args)
        {
            String val;
            Console.Write("Entrez votre mot : ");
            val = Console.ReadLine();

            Program prog = new Program();

            Console.WriteLine("Char Special : " + prog.RegChar(val));
            Console.WriteLine("Upper : " + prog.RegUp(val));
            Console.WriteLine("Nbr Char : " + prog.RegCount(val));

            Console.ReadLine();


        }
    }
}
