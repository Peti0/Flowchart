using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osszegzes
{

    public class MyProgram
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Add meg az elemek számát");
            int n;

            n = (int)inputValue();
            int[] tomb = new int[n];
            int i;

            for (i = 0; i <= n - 1; i++)
            {
                Console.WriteLine("Add meg a tömb " + (i + 1) + ". elemét!");
                tomb[i] = (int)inputValue();
            }
            int osszeg;

            osszeg = 0;
            for (i = 0; i <= n - 1; i++)
            {
                osszeg = osszeg + tomb[i];
            }
            Console.WriteLine("Az elemek összege: " + osszeg);
            Console.ReadKey();
        }

        private static double inputValue()
        {
            double result;
            while (!double.TryParse(Console.ReadLine(), out result)) ;
            return result;
        }
    }

}
