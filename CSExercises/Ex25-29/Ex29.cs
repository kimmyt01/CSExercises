using System;

namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a integer which is perfect number.");
            int n = Convert.ToInt32(Console.ReadLine());
            int i;
            int f = 0;
            for (i = 1; i<n; i++)
            {
                if (f < n)
                {
                    f = f + i; 
                }
            }
            if (f == n)
            {
                Console.WriteLine("Perfect Number.");
            }
            else
            {
                Console.WriteLine("Not Perfect Number.");
            }
        }
    }
}
