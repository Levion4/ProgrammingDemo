using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о фильме.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Продолжительность фильма в минутах.
        /// </summary>
        private int _durationInMinutes;

        /// <summary>
        /// Год выпуска фильма.
        /// </summary>
        private int _yearOfRelease;

        /// <summary>
        /// Рейтинг фильма.
        /// </summary>
        private double _rating;

        /// <summary>
        /// Создает экземпляр класса <<see cref="Movie"/>.
        /// </summary>
        public Movie()
        {
        }

        /// <summary>
        /// Создает экземпляр класса <<see cref="Movie"/>.
        /// </summary>
        /// <param name="durationInMinutes">Продолжительность в минутах.</param>
        /// <param name="yearOfRelease">Год выпуска.</param>
        /// <param name="rating">Рейтинг.</param>
        /// <param name="title">Название.</param>
        /// <param name="genre">Жанр.</param>
        public Movie(int durationInMinutes, int yearOfRelease, 
            double rating, string title, string genre) 
        {
            DurationInMinutes = durationInMinutes;
            YearOfRelease = yearOfRelease;
            Rating = rating;
            Title = title;
            Genre = genre;
        }

        /// <summary>
        /// Возвращает и задает название фильма.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Возвращает и задает жанр фильма.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Возвращает и задает продолжительность 
        /// фильма в минутах. Должна быть положительная.
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

        /// <summary>
        /// Возвращает и задает год выпуска фильма.
        /// Должен быть в диапазоне от 1900 по настоящий год.
        /// </summary>
        public int YearOfRelease
        {
            get
            {
                return _yearOfRelease;
            }
            set
            {
                Validator.AssertValueInRange(value, 1900, DateTime.Now.Year, nameof(YearOfRelease));
                _yearOfRelease = value;
            }
        }

        /// <summary>
        /// Возвращает и задает рейтинг фильма.
        /// Должен быть от 0 до 10.
        /// </summary>
        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 10, nameof(Rating));
                _rating = value;
            }
        }
    }
}
