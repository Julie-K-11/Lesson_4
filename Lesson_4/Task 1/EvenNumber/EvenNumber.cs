using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4.Task_1
{
    public class EvenNumber
    {
        public static void Generate(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(i * 2 + " ");
            }
            Console.WriteLine();
        }
    }
}
