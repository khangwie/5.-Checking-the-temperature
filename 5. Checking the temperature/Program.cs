using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Checking_the_temperature
{
    public class Program
    {
        public static bool Check(int temp1, int temp2)
        {
            return (temp1 < 0  && temp2 > 100) || (temp2  < 0 && temp1 < 100);
        }

        static void Main(string[] args)
        {
            int[] TempInput1 = { 120, -1, 2 };
            int[] TempInput2 = {-1, 120, 120};
            for (int i = 0; 1 < TempInput1.Length; i++)

            { 
                bool result = Check(TempInput1[i], TempInput2[i]);
                Console.WriteLine($" (TempInput1[i] , (TempInput2[1]) -> (result]");
            }
                 Console.ReadLine();

        }
    }
}
