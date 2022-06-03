using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о песни.
    /// </summary>
    public class Song
    {
        /// <summary>
        /// Продолжительность песни в минутах.
        /// </summary>
        private int _durationInMinutes;

        /// <summary>
        /// Создает экземпляр класса <<see cref="Song"/>.
        /// </summary>
        public Song()
        {
        }

        /// <summary>
        /// Создает экземпляр класса <<see cref="Song"/>.
        /// </summary>
        /// <param name="durationInMinutes">Продолжительность в минутах.</param>
        /// <param name="title">Название.</param>
        /// <param name="author">Автор.</param>
        public Song(int durationInMinutes, string title, string author)
        {
            DurationInMinutes = durationInMinutes;
            Title = title;
            Author = author;
        }

        /// <summary>
        /// Возвращает и задает название песни.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Возвращает и задает автора песни.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Возвращает и задает продолжительность 
        /// песни в минутах. Должна быть положительная.
        /// </summary>
        public int DurationInMinutes
        {
            get
            {
                return _durationInMinutes;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(DurationInMinutes));
                _durationInMinutes = value;
            }
        }
    }
}
