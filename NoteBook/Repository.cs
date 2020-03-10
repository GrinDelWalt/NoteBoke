//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace NoteBook
//{

//    /// <summary>
//    /// Организация хранения и генерации данных
//    /// </summary>
//    class Repository
//    {
//        /// <summary>
//        /// База данных имён
//        /// </summary>
//        static readonly string[] Names;

//        /// <summary>
//        /// генератор псевдорандомных чисел
//        /// </summary>
//        static Random randomize;

//        /// <summary>
//        /// Статический конструктор, в котором "хранятся"
//        /// данные о именах базы данных Names
//        /// </summary>
//        static Repository()
//        {
//            randomize = new Random(); // Размещение в памяти генератора случайных чисел

//            // Размещение имен в базе данных Names
//            Names = new string[]
//            {
//                    "Агата",
//                    "Агнес",
//                    "Аделаида",
//                    "Аделина",
//                    "Алдона",
//                    "Алима",
//                    "Аманда"

//            };
//        }

//        /// <summary>
//        /// База данных учеников, в которой хранятся 
//        /// Имя, возраст, рост, баллы по предмета и средний балл
//        /// </summary>

//        public List<Students> Pupil { get; set; }

//        /// <summary>
//        /// Конструктор, заполняющий базу данных Students
//        /// </summary>
//        /// <param name="Count">Количество учиников, которых нужно создать</param>
//        public Repository(int Count)
//        {
//            this.Pupil = new List<Students>(); // Выделение памяти для хранения базы данных Workers

//            for (int i = 0; i < Count; i++)    // Заполнение базы данных Workers. Выполняется Count раз
//            {
//                // Добавляем нового работника в базы данных Workers
//                this.Pupil.Add(
//                    new Students(
//                        // выбираем случайное имя из базы данных имён
//                        Names[Repository.randomize.Next(Repository.Names.Length)],

//                        // Генерируем случайный возраст в диапазоне 17 лет - 30 лет
//                        randomize.Next(17, 30),

//                        // Генерируем случайный рост в диапазоне 165 см - 199 см
//                        randomize.Next(165, 199),

//                        // Генерируем случайный балл по Истории
//                        randomize.Next(25, 100),

//                        // Генерируем случайный балл по Математике

//                        randomize.Next(25, 100),

//                        // Генерируем случайный балл по Русскому

//                        randomize.Next(25, 100)
//                        ));
//            }
//        }

//        /// <summary>
//        /// Метод вывода базы данных Workers в консоль
//        /// </summary>
//        /// <param name="Text">Вспомогательный текст, который будет напечатан перед выводом базы</param>
//        public void Print(string Text)
//        {
//            Console.WriteLine(Text);    // Печать в консоль вспомогательного текста

//            // Изменяем цвет шрифта для печати в консоли на DarkBlue
//            Console.ForegroundColor = ConsoleColor.DarkRed;

//            // Выводим Заголовки колонок базы данных
//            Console.WriteLine($"{"Имя",15} {"Рост",10} {"Возраст",10} {"История",10} {"Математика",10} {"Русский",10} {"Средний бал",10}");

//            // Изменяем цвет шрифта для печати в консоли на Gray
//            Console.ForegroundColor = ConsoleColor.Gray;


//            foreach (var Students in this.Pupil)
//            {
//                // Печатаем в консоль всех работников
//                double mark = ((double)Students.History + (double)Students.mathematics + (double)Students.russian) / 3;

//                string markSum = mark.ToString("#.#");

//                Console.WriteLine($"{Students.Name,15} {Students.Age,10} {Students.Height,10} {Students.History,10}" +
//                    $" {Students.mathematics,10} {Students.russian,10} {markSum,10}");
//            }

//            Console.WriteLine($"Итого: {this.Pupil.Count}\n");    // Сводный отчёт. Сколько работников распечатано
//        }




//    }

//}

