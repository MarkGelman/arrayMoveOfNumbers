using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayMoveOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = new int[3];
            
            for (int i = 0; i < 3; i++)
            {
                numbers1[i] = int.Parse(Console.ReadLine());
               
            }
            Console.WriteLine("");

            int intermediate = 0;

            intermediate = numbers1[0]; numbers1[0] = numbers1[1]; numbers1[1] = numbers1[2]; numbers1[2] = intermediate;

            Console.WriteLine($"[ {numbers1[0]} {numbers1[1]} {numbers1[2]} ]");

            Console.ReadKey();
        }
    }
}
