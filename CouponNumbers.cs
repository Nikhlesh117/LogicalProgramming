using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class CouponNumbers
    {
        public static void Coupon()
        {
            Console.WriteLine("Enter total lenght of the coupon: ");
            int size = Convert.ToInt32(Console.ReadLine());

            char[] coupon = new char[size];
            char[] digit = "0123456789".ToCharArray();
            Random random = new Random();

            for (int i = 0; i <= size; i++)
            {
                int randomCode = random.Next(digit.Length);
                coupon[i] = (digit[randomCode]);
                Console.Write(coupon[i]);

                if (coupon.Contains(coupon[i]))
                {
                    continue;
                }
                else
                {
                    coupon[i] = digit[randomCode];
                }
            }
        }
    }
}
