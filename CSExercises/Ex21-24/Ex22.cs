using System;

namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            int a, b; 
            //request input A and B
            Console.Write("Please enter a number for A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter a number for B: ");
            b = Convert.ToInt32(Console.ReadLine());

            int HCF;
            int LCM;
            int AB = a * b; //this is the original of the input A and B
                       
            while (a != b) // a is not equal to b
            { 
            if (a > b) //if a larger than b, then a-b
            {
                a = a - b;
            }
            else if (b > a) //if b larger than 1, then b-a
                b = b - a;
            }

            HCF = a;
            LCM = AB/ HCF;

            Console.WriteLine("HCF: {0}", HCF);
            Console.WriteLine("LCM: {0}", LCM);           
            Console.ReadLine();
        }
    }
}
