using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // исходная последовательность слов
            List<string> words = new List<string>() { "мама", "папа", "дочь" };

            // сортировка списка слов
            words.Sort();

            // вывод списка слов
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            Console.ReadLine();
        }
    }
}
