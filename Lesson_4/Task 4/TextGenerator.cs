using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4.Task_4
{
    public class TextGenerator
    {
        static char[] Vowels = { 'а', 'е', 'є', 'и', 'і', 'о', 'у', 'ю', 'я' };
        static char[] Consonants = { 'б', 'в', 'г', 'ґ', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ' };

        public void Write()
        {
            Console.Write("Введіть кількість голосних: ");
            int vowelCount = int.Parse(Console.ReadLine());

            Console.Write("Введіть кількість приголосних: ");
            int consonantCount = int.Parse(Console.ReadLine());

            Console.Write("Введіть максимальну довжину слова: ");
            int maxLength = int.Parse(Console.ReadLine());

            string generatedText = Generate(vowelCount, consonantCount, maxLength);
            Console.WriteLine($"Згенерований текст: {generatedText}");
        }

        private string Generate(int vowelCount, int consonantCount, int maxLength)
        {
            string result = "";

            for (int i = 0; i <= maxLength; i++)
            {
                int wordLength = (i % maxLength) + 1;
                string word = "";

                for (int j = 0; j < wordLength; j++)
                {
                    if (j % 2 == 0 && vowelCount > 0)
                    {
                        word += Vowels[(j % Vowels.Length)];
                        vowelCount--;
                    }
                    else if (j % 2 != 0 && consonantCount > 0)
                    {
                        word += Consonants[(j % Consonants.Length)];
                        consonantCount--;
                    }
                }

                if (result.Length > 0)
                {
                    result += " ";
                }
                result += word;
            }
            return result;
        }
    }
}
