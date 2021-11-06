using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalvikasBalloons
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n, a, b, i, j;
            string balloon;
            Console.Write("Enter the number of test cases: ");
            n = Convert.ToByte(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Enter balloons: ");
                balloon = Console.ReadLine();
                for (j = 0, a = 0, b = 0; j < balloon.Length; j++)
                {
                    if (balloon[j] == 'a')
                        a++;
                    else
                        b++;
                }
                Console.WriteLine("You have to repaint " + Math.Min(a, b) + " balloons.");
            }
        }
    }
}
