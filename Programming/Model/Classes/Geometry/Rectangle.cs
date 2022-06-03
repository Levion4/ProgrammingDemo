using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о прямоугольнике.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Счетчик всех существующих объектов прямоугольников.
        /// </summary>
        private static int _allRectanglesCount;

        /// <summary>
        /// Длина прямоугольника.
        /// </summary>
        private int _length;

        /// <summary>
        /// Ширина прямоугольника.
        /// </summary>
        private int _width;

        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private int _id;

        /// <summary>
        /// Создает экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        public Rectangle()
        {
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="length">Длина. Должна быть положительная.</param>
        /// <param name="width">Ширина. Должна быть положительная.</param>
        /// <param name="color">Цвет.</param>
        /// <param name="center">Координаты центра класса <see cref="Point2D"/>.</param>
        public Rectangle(int length, int width, string color, Point2D center)
        {
            Color = color;
            Width = width;
            Length = length;
            Center = center;
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }

        /// <summary>
        /// Возвращает и задает цвет прямоугольника.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Возвращает и задает координаты центра 
        /// прямоугольника класса <see cref="Point2D"/>.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Возвращает и задает уникальный идентификатор прямоугольника.
        /// Задает только во время инициализации.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
            private set
            {
                _id = value;
            }
        }

        /// <summary>
        /// Возвращает и задает длину прямоугольника. Должна быть положительная.
        /// </summary>
        public int Length
        {
            get
            {
                return _length;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Length));
                _length = value;
            }
        }

        /// <summary>
        /// Возвращает и задает ширину прямоугольника. Должна быть положительная.
        /// </summary>
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Width));
                _width = value;
            }
        }

        /// <summary>
        /// Возвращает количество всех существующих объектов прямоугольников.
        /// </summary>
        public static int AllRectanglesCount
        {
            get
            {
                return _allRectanglesCount;
            }
        }
    }
}
