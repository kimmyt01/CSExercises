using System;

namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
            bool isPrime = true;
            int a,b;
            Console.WriteLine("Print all the prime number from 5 to 10000");

            for (a = 5; a<= 10000; a++)
            {
                for(b =5; b<=a; b++)
                {
                    if (a!=b && a%b==0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime == true)
                {
                    Console.Write("\t"+ a);
                }
                isPrime = true;
            }
        }
    }
}
