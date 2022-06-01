using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о точке.
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// Координата по X.
        /// </summary>
        private int _x;

        /// <summary>
        /// Координата по Y.
        /// </summary>
        private int _y;

        /// <summary>
        /// Создает экземпляр класса <see cref="Point2D"/>.
        /// </summary>
        public Point2D()
        {
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Point2D"/>.
        /// </summary>
        /// <param name="x">Координата по X. Должна быть положительная.</param>
        /// <param name="y">Координата по Y. Должна быть положительная.</param>
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Возвращает и задает координату по X. Должна быть положительная.
        /// </summary>
        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(X));
                _x = value;
            }
        }

        /// <summary>
        /// Возвращает и задает координату по Y. Должна быть положительная.
        /// </summary>
        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Y));
                _y = value;
            }
        }
    }
}
