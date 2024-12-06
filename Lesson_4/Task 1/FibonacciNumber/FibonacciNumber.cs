using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4.Task_1
{
    public class FibonacciNumber
    {
        public static void Generate(int count)
        {
            if (count >= 1) Console.Write("0 ");
            if (count >= 2) Console.Write("1 ");

            int first = 0, second = 1;

            for (int i = 2; i < count; i++)
            {
                int next = first + second;
                Console.Write(next + " ");
                first = second;
                second = next;
            }

            Console.WriteLine();
        }
    }
}
