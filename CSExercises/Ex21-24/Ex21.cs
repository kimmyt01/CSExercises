using System;

namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            int a = 88;
            Console.Write("Please enter a number :");
            a=Convert.ToInt32(Console.ReadLine());

            while (a!=88)
                {
                    Console.WriteLine("Please try again.");
                    a=Convert.ToInt32(Console.ReadLine());
                }
            Console.WriteLine("Lucky you ...");
         }
            
     }
}
