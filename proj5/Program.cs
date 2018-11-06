using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPrime(49));
            AllPrimes(49);
        }


        static bool IsPrime(int num)
        {

      
            for (int i = 2; i <=Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
                    
            }
            return true;
        }

        static void AllPrimes(int num)
        {
            for (int i = 2; i <= num; i++)
            {

                if (IsPrime(i))
                    {

                    Console.WriteLine(i + " ");
                }
            }

        }

    }
}

