using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnparQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            string rePlay = "yes";         // while statement string condition

            while(rePlay == "yes")
            {
                Console.WriteLine("Hello" + '\n' + "Please Enter a number to sum");
                int numbah = Convert.ToInt32(Console.ReadLine());

                int sum = 0;
                sum += numbah;
                Console.WriteLine("The number(s) you have entered are " + store + " with a total of " + sum);
                Console.WriteLine("Would you like to enter another number?");
                rePlay = Console.ReadLine().ToLower();
            }
        }
    }
}
