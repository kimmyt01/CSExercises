using System;

namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        { 
           
            Console.WriteLine("Please key in a guess number.");
            double N = Convert.ToDouble(Console.ReadLine());
            double squareroot = Math.Sqrt(N);
            Random rnd = new Random();
            double guess = rnd.Next(1, Convert.ToInt32(N + 1));

            if (guess * guess == N)
            {
                Console.WriteLine("You get the correct number!");  
            }
          
            while (guess * guess != N)
            {
                guess = ((guess + (N / guess)) / 2);
                Console.WriteLine("The guess number is {0:0.00000} ", guess);
                break;
             } 
            
             //double N = input
             //double G = getrannumbetween1 and n
             //bool status = false;
             //do
             //{
               //status = check();
                 //if (status == false)
                 //{
                   //  G= calculate(G,N);
                 //}
                 //while (status == false);
             }
      }
 }
 

