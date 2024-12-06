using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4.Task_3
{
    public class Game
    {
        public int minNum;
        public int maxNum;
        public int maxAttempts = 10;
        public void Play()
        {
            Console.Write("Введіть мінімальне число: ");
            minNum = int.Parse(Console.ReadLine());

            Console.Write("Введіть максимальне число: ");
            maxNum = int.Parse(Console.ReadLine());

            Console.WriteLine($"Загадайте число між {minNum} і {maxNum}");
            Console.WriteLine($"У мене є {maxAttempts} спроб");

            GuessNumber();
        }
        public void GuessNumber()
        {
            int guessNum;
            int attempts = 0;

            while (attempts < maxAttempts)
            {
                guessNum = (minNum + maxNum) / 2;
                attempts++;

                Console.WriteLine($"Ваше число {guessNum}? (Скажіть 'менше', 'більше' або 'так'))");
                string response = Console.ReadLine().ToLower();

                if (response == "так")
                {
                    Console.WriteLine($"Yeees! Я вгадав ваше число {guessNum} за {attempts} спроб");
                    break;
                }
                else if (response == "менше")
                {
                    maxNum = guessNum - 1;
                }
                else if (response == "більше")
                {
                    minNum = guessNum + 1;
                }
                else
                {
                    Console.WriteLine("ERORR, введіть 'менше', 'більше' або 'так'");
                }

                if (attempts == maxAttempts)
                {
                    Console.WriteLine($"На жаль, я не вгадав число за {maxAttempts} спроб");
                    return;
                }
            }
        }
    }
}
