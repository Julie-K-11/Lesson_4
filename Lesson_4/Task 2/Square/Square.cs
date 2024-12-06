using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4.Task_2
{
    public class Square
    {
        public static void Draw(int side)
        {
            for (int i = 0; i < side; i++)
            {
                Console.WriteLine(new string('*', side));
            }
        }
    }
}
