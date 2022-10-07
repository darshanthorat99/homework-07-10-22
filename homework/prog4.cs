using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal class prog4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (n > 0)
            {
                int r = n % 10;
                sum = sum + r;
                n = n / 10;
            }
            Console.WriteLine($"sum of all digits is {sum}");
        }
    }
}
