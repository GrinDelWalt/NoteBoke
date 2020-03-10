//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace NoteBook
//{
//    /// <summary>
//    /// Класс, описывающий модель студента
//    /// </summary>
//    class Students
//    {


//        /// <summary>
//        /// Имя студента
//        /// </summary>
//        public string Name { get; set; }

//        /// <summary>
//        /// Рост работника
//        /// </summary>
//        public int Height { get; set; }

//        /// <summary>
//        /// Возраст студента
//        /// </summary>
//        public int Age { get; set; }


//        /// <summary>
//        /// балл по истории
//        /// </summary>
//        public int History { get; set; }

//        /// <summary>
//        /// балл по математике
//        /// </summary>
//        public int mathematics { get; set; }

//        /// <summary>
//        /// балл по русскому
//        /// </summary>
//        public int russian { get; set; }

//        /// <summary>
//        /// Средний балл студента
//        /// </summary>
//        public double markSum { get; set; }

//        /// <summary>
//        /// Конструктор, позволяющий присвоить значение соответствующим полям работника
//        /// </summary>
//        /// <param name="Name">Имя</param>
//        /// <param name="Height">рост</param>
//        /// <param name="Age">Возраст</param>
//        /// <param name="History">,балk по истории</param>
//        /// <param name="mathematics">балл по математике</param>
//        /// <param name="russian">балл по русскому</param>
//        /// <param name="markSum">балл по русскому</param>
//        public Students(string Name, int Age, int Height, int History, int mathematics, int russian)
//        {
//            this.Name = Name; // Сохранить переданное значение имени
//            this.Height = Height;   // Сохранить переданное значение роста
//            this.Age = Age;             // Сохранить переданное значение возраста
//            this.History = History;       // Сохранить переданное значение балла по истории
//            this.mathematics = mathematics; // Сохранить переданное значение балла по математике
//            this.russian = russian; // Сохранить переданное значение балла по русскому 
//            //this.markSum = markSum; // Сохранить переданное значение среднего балла

//        }

//        /// <summary>
//        /// Организация вывода информации о работнике
//        /// </summary>
//        /// <returns>Строковое представление информации</returns>
//        //public override string ToString()
//        //{
//        //    return $"{Name,15} {Age,5} {Height,5} {History,5} {mathematics,5} {russian,5} {markSum,6}";
//        //}

//    }
//}
