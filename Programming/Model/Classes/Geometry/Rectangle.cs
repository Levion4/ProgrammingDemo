using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Rectangle
    {
        /// <summary>
        /// 
        /// </summary>
        private static int _allRectanglesCount;

        private int _length;

        private int _width;

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
        /// <param name="center">Координаты центра класса <see cref="Point2D"/></param>
        public Rectangle(int length, int width, string color, Point2D center)
        {
            Color = color;
            Width = width;
            Length = length;
            Center = center;
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }

        public string Color { get; set; }

        public Point2D Center { get; set; }

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

        public static int AllRectanglesCount
        {
            get
            {
                return _allRectanglesCount;
            }
        }
    }
}
