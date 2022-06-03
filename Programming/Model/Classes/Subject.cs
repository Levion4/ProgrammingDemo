using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о дисциплине.
    /// </summary>
    public class Subject
    {
        /// <summary>
        /// Оценка по цисциплине.
        /// </summary>
        private int _mark;

        /// <summary>
        /// Создает экземпляр класса <<see cref="Subject"/>.
        /// </summary>
        public Subject()
        {
        }

        /// <summary>
        /// Создает экземпляр класса <<see cref="Subject"/>.
        /// </summary>
        /// <param name="teacher">Преподаватель.</param>
        /// <param name="name">Имя учащегося.</param>
        /// <param name="mark">Оценка.</param>
        public Subject(string teacher, string name, int mark)
        {
            Teacher = teacher;
            Name = name;
            Mark = mark;
        }

        /// <summary>
        /// Возвращает и задает преподавателя по дисциплине.
        /// </summary>
        public string Teacher { get; set; }

        /// <summary>
        /// Возвращает и задает имя учащегося по дисциплине.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задает оценку по дисциплине.
        /// Должна быть от 2 до 5.
        /// </summary>
        public int Mark
        {
            get
            {
                return _mark;
            }
            set
            {
                Validator.AssertValueInRange(value, 2, 5, nameof(Mark));
                _mark = value;
            }
        }
    }
}
