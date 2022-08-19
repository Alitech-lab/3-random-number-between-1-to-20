using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_random_number_between_1__to_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random =new Random();

            int num1 = random.Next(1, 21);
            int num2 = random.Next(1, 21);
            int num3 = random.Next(1, 21);

            //double num = random.NextD0uble();

            Console.WriteLine(num1);
            Console.WriteLine(num2);   
            Console.WriteLine(num3);

            Console.ReadKey();



        }
    }I
}
