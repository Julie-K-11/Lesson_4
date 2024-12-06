using Lesson_4.Task_1;
using Lesson_4.Task_2;
using Lesson_4.Task_3;
using Lesson_4.Task_4;

namespace Lesson_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("______________________________________1______________________________________");
            int count = 10;

            Console.WriteLine("Even Numbers:");
            EvenNumber.Generate(count);

            Console.WriteLine("Odd Numbers:");
            OddNumber.Generate(count);

            Console.WriteLine("Prime Numbers:");
            PrimeNumber.Generate(count);

            Console.WriteLine("Fibonacci Numbers:");
            FibonacciNumber.Generate(count);


            Console.WriteLine("______________________________________2______________________________________");
            int triangleHeight = 5;
            Console.WriteLine("Трикутник:");
            Triangle.Draw(triangleHeight);
            Console.WriteLine();

            int rectangleWidth = 7;
            int rectangleHeight = 4;
            Console.WriteLine("Прямокутник:");
            Rectangle.Draw(rectangleWidth, rectangleHeight);   
            Console.WriteLine();

            Console.WriteLine("Квадрат");
            int squareSide = 3;
            Square.Draw(squareSide);


            Console.WriteLine("______________________________________3______________________________________");
            Game game = new Game();
            game.Play();

            Console.WriteLine("______________________________________4______________________________________");
            TextGenerator textGenerator = new TextGenerator();
            textGenerator.Write();
        }
    }
}
