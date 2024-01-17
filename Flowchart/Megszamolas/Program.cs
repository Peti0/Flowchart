using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megszamolas
{
    using System;

    public class MyProgram
    {
        public static void Main(string[] args)
        {
         
            int szamlalo;

            szamlalo = 0;
            int n;

            n = (int)inputValue();
            int i;
            int[] t = new int[n];

            for (i = 0; i <= n - 1; i++)
            {
                t[i] = (int)inputValue();
            }
            for (i = 0; i <= n - 1; i++)
            {
                if (t[i] < 0)
                {
                    szamlalo = szamlalo + 1;
                }
            }
            Console.WriteLine(szamlalo);
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
