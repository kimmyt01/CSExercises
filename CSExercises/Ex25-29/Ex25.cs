using System;

namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
            
        {
            Console.WriteLine("Please enter a integer to find its factorial ");
            int input = Convert.ToInt32(Console.ReadLine());
            int a;
            int total = 1;

            for (a = 1; a <= input; a++)
            {
                total = total * a;
            }
            Console.WriteLine("Factorial of {0} is {1}", input, total);
            Console.ReadLine();

            /*
            Console.WriteLine("Please enter a integer to find its factorial ");
            int input = Convert.ToInt32(Console.ReadLine());
            int a;
            int total = 1;

            for (a = 1; a >=input; a--)
            {
                total = total * a;
            }
            Console.WriteLine("Factorial of {0} is {1}", input, total);
            Console.ReadLine();
            */
        }
    }
}
