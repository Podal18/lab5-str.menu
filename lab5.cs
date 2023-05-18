//Подгорнова Александра 21-ис
//Вариант №16 (Страхование)
//Строковому меню предшествует центрированная надпись: «Выберите форму или вид страхования:». Надпись участвует в «пролистывании» пунктов меню, но не даёт отклика 
//по нажатии клавиши «Enter» при размещении курсора на ней. В качестве пунктов меню предложить: «Обязательное», «Добровольное», «Личное», «Имущественное», «Выход». 
//Реализовать «пролистывание» без перехода через границы (стрелка вверх не работает на элементе с нулевым индексом и стрелка вниз не работает на элементе с последним 
//индексом). Подтверждение выбранного пункта меню реализовать по клавише «Enter».

using System;

class Program
{
    static void Main(string[] args)
    {
        string[] menuItems = { "Обязательное", "Добровольное", "Личное", "Имущественное", "Выход" };
        int selectedItemIndex = 0;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Выберите форму или вид страхования:");
            for (int i = 0; i < menuItems.Length; i++)
            {
                if (i == selectedItemIndex)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }

                Console.WriteLine(menuItems[i]);

                Console.ResetColor();
            }

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                if (selectedItemIndex > 0)
                {
                    selectedItemIndex--;
                }
            }
            else if (keyInfo.Key == ConsoleKey.DownArrow)
            {
                if (selectedItemIndex < menuItems.Length - 1)
                {
                    selectedItemIndex++;
                }
            }
            else if (keyInfo.Key == ConsoleKey.Enter)
            {
                if (selectedItemIndex == menuItems.Length - 1)
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Вы выбрали: " + menuItems[selectedItemIndex]);
                    Console.ReadKey();
                }
            }
        }
    }
}