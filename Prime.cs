using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class Prime
    {
        public static void PrimeNumber()
        {
            int i, num, prime = 1;
            System.Console.WriteLine("Enter Number : ");
            num = Convert.ToInt32(System.Console.ReadLine());
            for(i = 2; i < num; i++)
            {
                if(num%i == 0)
                {
                    prime++;
                }
            }
            if(prime == 1)
            {
                Console.WriteLine("It is Prime Number");
            }
            else
            {
                Console.WriteLine("IT is Not a Prime Number");
            }
        }
    }
}
