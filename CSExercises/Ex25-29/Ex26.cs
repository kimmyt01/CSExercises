using System;

namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" NO\tINVERSE\t\tSQUARE ROOT\tSQUARE");
            double num, inv, sqrt, sq;
            for (num = 1; num <=10; num++)
            {
                inv = 1 / num;
                sqrt = Math.Sqrt(num);
                sq = Math.Pow(num, 2);
                Console.WriteLine("{0:0.0}\t{1:0.0##}\t\t{2:0.0##}\t\t{3:0.0}", num, inv, sqrt, sq);

            }
            
        }
    }
}
