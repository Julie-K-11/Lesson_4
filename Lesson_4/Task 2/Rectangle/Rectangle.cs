using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4.Task_2
{
    public class Rectangle
    {
        public static void Draw(int width, int height)
        {
            for (int i = 0; i < height; i++)
            {
                Console.WriteLine(new string('*', width));
            }
        }
    }
}