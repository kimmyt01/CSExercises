using System;

namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            int A = 0; //user input
            Random r = new Random();
            int scrtn = r.Next(0, 9);

            //Console.WriteLine ("{0}",scrtn);

            Console.WriteLine("Please guess the number.");
            A = Convert.ToInt32(Console.ReadLine()); //read the use input
            
            int count=0; //calculate how many times
            while (A != scrtn)
                {
                Console.WriteLine("Wrong! Try again");
                A = Convert.ToInt32(Console.ReadLine());
                count++;
                }
                    if (count<=2)
                    {
                        Console.WriteLine("You are a Wizard! You have used {0} to attempt. ", count);
                    }
                    else if ((count > 2) && (count<=5))
                    { 
                        Console.WriteLine("You are a good guess! You have used {0} to attempt. ", count); 
                    }
                    else if (count > 5)
                    {
                        Console.WriteLine("You are lousy! You have used {0} to attempt. ", count);
                    }
                
        }

    }
}


