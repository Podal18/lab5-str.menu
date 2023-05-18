using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
            string sentence = Convert.ToString(Console.ReadLine());
            string wordToRemove = Convert.ToString(Console.ReadLine());
            string result = "";

            int index = 0;
            while (index < sentence.Length)
            {
                int wordIndex = sentence.IndexOf(wordToRemove, index, StringComparison.OrdinalIgnoreCase);
                if (wordIndex == -1) // Если слово не найдено
                {
                    result += sentence.Substring(index); // Добавляем оставшуюся часть строки
                    break;
                }

                result += sentence.Substring(index, wordIndex - index); // Добавляем часть строки до слова
                index = wordIndex + wordToRemove.Length; // Устанавливаем индекс на следующую часть строки
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
