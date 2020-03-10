using System;
using System.Text;
using System.IO;

namespace NoteBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // Данные учеников

            // Имя
            string Name1 = "Игорь";

            // Возраст
            byte age1 = 18;

            // Рост
            byte height1 = 175;

            // Балл по Истории
            byte history1 = 76;

            // Балл по Математики
            byte mathematics1 = 57;

            // Балл по Русскому
            byte russian1 = 87;

            //Подсчет среднего бала
            float srednee1 = (((float)history1 + (float)mathematics1 + (float)russian1) / 3);

            //Окуругление до одной десятой
            string markSum1 = srednee1.ToString("#.#");




            // Имя
            string Name2 = "Влад";

            // Возраст
            byte age2 = 19;

            // Рост
            byte height2 = 187;

            // Балл по Истории
            byte history2 = 56;

            // Балл по Математики
            byte mathematics2 = 67;

            // Балл по Русскому
            byte russian2 = 78;

            //Подсчет среднего бала
            float srednee2 = (((float)history2 + (float)mathematics2 + (float)russian2) / 3);

            //Окуругление до одной десятой
            string markSum2 = srednee2.ToString("#.#");



            // Имя
            string Name3 = "Виталий";

            // Возраст
            byte age3 = 19;

            // Рост
            byte height3 = 185;

            // Балл по Истории
            byte history3 = 98;

            // Балл по Математики
            byte mathematics3 = 87;

            // Балл по Русскому
            byte russian3 = 76;

            //Подсчет среднего бала
            float srednee3 = (((float)history3 + (float)mathematics3 + (float)russian3) / 3);

            //Окуругление до одной десятой
            string markSum3 = srednee3.ToString("#.#");






            ////Обычный вывод

            //Console.WriteLine(Name1 + height1 + history1 + mathematics1 + russian1 + "{0:0.0}", ball1);
            //Console.ReadKey();

            ////Форматированный вывод 

            //string pattern = "Имя: {0} \nВозраст: {1} \nРост: {2} \nИстория: {3} \nМатематика: {4} \nРуский язык: {5} \nБаллы: {6}";
            //Console.WriteLine(pattern,
            //                  Name1,
            //                  age1,
            //                  height1,
            //                  history1,
            //                  mathematics1,
            //                  russian1,
            //                  ball1);
            //Console.ReadKey();


            //Вывод с использованием интерполяции

            // Изменяем цвет шрифта для печати в консоли на Red
            Console.ForegroundColor = ConsoleColor.Red;




            // Создаем переменные для коректного расположения по центру консоли
            string data = ($"{Name1,15} {age1,10} {height1,10} {history1,10} {mathematics1,10} {russian1,10} {markSum1,10}");
            string data2 = ($"{Name2,15} {age2,10} {height2,10} {history2,10} {mathematics2,10} {russian2,10} {markSum2,10}");
            string data3 = ($"{Name3,15} {age3,10} {height3,10} {history3,10} {mathematics3,10} {russian3,10} {markSum3,10}");
            string header = ($"{"Имя",15} {"Рост",10} {"Возраст",10} {"История",10} {"Математика",10} {"Русский",10} {"Средний бал",10}");


            // Измеряем размер консоли для росположения текста по центру
            Console.SetCursorPosition((Console.WindowWidth - header.Length) / 2, Console.CursorTop);
            Console.SetCursorPosition((Console.WindowHeight - header.Length) / 2, Console.CursorTop);
            // Выводим Заголовки колонок базы данных
            Console.WriteLine(header);

            //// Изменяем цвет шрифта для печати в консоли на Gray
            //Console.ForegroundColor = ConsoleColor.Gray;

            //// Печатаем в консоль всех студентов
            //Console.SetCursorPosition((Console.WindowWidth - data.Length) / 2, Console.CursorTop);
            //Console.WriteLine(data);

            //Console.SetCursorPosition((Console.WindowWidth - data2.Length) / 2, Console.CursorTop);
            //Console.WriteLine(data2);

            //Console.SetCursorPosition((Console.WindowWidth - data3.Length) / 2, Console.CursorTop);
            //Console.WriteLine(data3);

            Console.ReadKey();

            //реализовать ввод в центре консоли не получилось, не могли бы вы скинуть как бы вы в данном коде это реализовали?

            //Создана рандомная база студентов, для ее работы нужно раскоментировать еще 2 класса, делал просто так для себя 

            //// Создание базы данных из 20 студентов
            //Repository repository = new Repository(20);

            //// Печать в консоль всех студентов
            //repository.Print("База данных");


            //Console.ReadKey();


            Console.WriteLine("The current buffer height is {0} rows.",
                                  Console.BufferHeight);
            Console.WriteLine("The current buffer width is {0} columns.",
                                  Console.BufferWidth);
            

        }

    }
}