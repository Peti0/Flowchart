using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eldontesA
{
    using System;

    public class MyProgram
    {
        public static void Main(string[] args)
        {
         
            int n;

            n = (int)inputValue();
            int[] tomb = new int[n];
            int i;

            for (i = 0; i <= n - 1; i++)
            {
                tomb[i] = (int)inputValue();
            }
            int szam;

            szam = (int)inputValue();
            int k;

            k = 0;
            for (i = 0; i <= n - 1; i++)
            {
                if (tomb[i] == szam)
                {
                    k = k + 1;
                }
            }
            if (k == 0)
            {
                Console.WriteLine("Nincs benne");
            }
            else
            {
                Console.WriteLine("Benne van");
            }
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
