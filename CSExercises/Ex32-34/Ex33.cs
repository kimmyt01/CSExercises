using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            int [] number = new int []{86, 35, 41, 49, 89, 51, 11, 71, 50, 75, 25, 58, 40, 14,44, 3, 63, 81, 93,79};
            Array.Sort(number);
            foreach(int i in number)
            {
                Console.WriteLine(i);
            }

        }
    }
}
