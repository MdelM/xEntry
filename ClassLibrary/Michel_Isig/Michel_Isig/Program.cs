using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Michel_Isig
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entrez un nombre positif :");
            int nbr = int.Parse(Console.ReadLine());
            //for(int j=6;j<1000;j++)
            //TestNbreParfait(j);
            DecToBin(nbr);

            Console.ReadLine();
        }

        private static bool TestNbreParfait(int nbr)
        {
           // bool isParfait;
            while (nbr <= 0)
            {
                Console.WriteLine("nombre non positif :");
                nbr = int.Parse(Console.ReadLine());
            }

            int a = 0, d = 0;

            for (int i = 1; i < nbr; ++i)
            {
                //np = np + 1;
                int reste = nbr % i;
                if (reste == 0)
                {
                    a = i;
                    d+=a;
                    
                }

            }
           // Console.Write(a + "  ");
            if (d == nbr)
            {
                Console.WriteLine(" la somme de ces diviseurs est {0}", d);
                //Console.WriteLine("true");
                return true;
            }
            else
            {
               // Console.WriteLine("false");
                return false;
            }

        }

        private static int NbreComplexe(int a, int b, int bp, int ap)
        {
            double t = Math.Sqrt(-1);
            int i = (int)t;
            int Multiplication = ((-bp * b) + (a * ap)) + ((a * bp) + (ap * b)) * i;
            return Multiplication;
        }

        private static void DecToBin(int Nombre)
        {
            int p = 0;
            String j="";
            for (int i = 2; i <= Nombre; i++)
            {
                int r = Nombre % 2;
                if (r == 0 || r == 1)
                {
                    
                    p = r;
                    if (j.Equals(""))
                    {
                        j = p.ToString();
                    }
                    else
                    {
                        j = j + p.ToString();
                    }
                    Console.Write(p + " ");
                }
                
            }
            
        }

    }
}
