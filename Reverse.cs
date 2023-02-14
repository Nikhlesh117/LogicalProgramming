using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class Reverse
    {
        public static void ReverseNumber()
        {
            int n, reverse = 0, rem;
            Console.WriteLine("Enter the Number");
            n = Convert.ToInt32(Console.ReadLine());

            while(n != 0) 
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n = n / 10;
            }

            Console.WriteLine("Reversed Number : " + reverse);

        }
    }
}
