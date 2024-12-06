using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4.Task_1
{
    public class PrimeNumber
    {
        public static void Generate(int count)
        {
            int num = 2;
            int found = 0;

            while (found < count)
            {
                if (IsPrime(num))
                {
                    Console.Write(num + " ");
                    found++;
                }
                num++;
            }
            Console.WriteLine();
        }

        private static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 3; i * i <= number; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}
