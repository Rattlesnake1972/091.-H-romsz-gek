using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haromszogekCLI
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Haromszog> haromszoglista = new List<Haromszog>();
            List<Haromszog> derekszoguharomszoglista = new List<Haromszog>();
            StreamReader sr = new StreamReader("haromszogek2.csv");
            while (!sr.EndOfStream) 
            {
                Haromszog h = new Haromszog(sr.ReadLine());
                haromszoglista.Add(h);
            }

            sr.Close();

            // 10. feladat

            Console.WriteLine("Derékszögű háromszögek adatai:");
            foreach(var item in haromszoglista) 
            {
                if (derekszogu(item.A, item.B, item.C))
                {
                    Console.WriteLine($"a: {item.A} b: {item.B} c: {item.C}");
                    derekszoguharomszoglista.Add(item);
                }
            }

            // 11. feladat

            Haromszog maxharomszog = derekszoguharomszoglista[0];
            foreach(var item in derekszoguharomszoglista)
            {
                if (maxharomszog.A * maxharomszog.B < item.A * item.B)
                {
                    maxharomszog = item;
                }
            }

            Console.WriteLine("A legnagyobb derékszögű háromszög adatai:");
            Console.WriteLine($"a: {maxharomszog.A} b: {maxharomszog.B} c: {maxharomszog.C}");

            Console.ReadLine();
        }

        // Megnézi, hogy derékszögű-e a háromszög.

        public static bool derekszogu(int a, int b, int c)
        {
            if(a*a + b*b == c*c) 
            {
                return true;
            }

            return false;
        }
    }
}
