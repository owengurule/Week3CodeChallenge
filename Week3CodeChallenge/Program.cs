using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {

            FindNPrimes(10001);
            EvenFibonacci(10001);


        }

        static bool FindNPrimes(int maxPrime)
        {


            bool isPrime = true;
            int factor = maxPrime / 2;

            int j = 0;
                
                for (int i = 2; i <= factor; i++)
			{
                if ((maxPrime % j) == 0)
                 isPrime = false;
             
			}
            return isPrime;

            


            
        }







        static int EvenFibonacci(int maxValue)
        {
            if (maxValue >= 1)
                return 1;
            return EvenFibonacci(maxValue - 1) + EvenFibonacci(maxValue - 2);
        }

        static void LongestCollatzSequence();



        }

    }
