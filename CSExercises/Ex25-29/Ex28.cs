using System;
namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a integer. ");
            int input = Convert.ToInt32(Console.ReadLine());

            double a;
            double b = 0;

            for (a=1; a<= input; a++)
            {
                if (input % a == 0)
                {
                    b = b + 1;
                }
            }
            if (b == 2)
                Console.WriteLine("Prime");
            else
                Console.WriteLine("Not prime");

        }
    }
}
