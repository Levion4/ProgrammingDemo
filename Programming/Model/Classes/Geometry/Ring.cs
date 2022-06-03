using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о кольце.
    /// </summary>
    public class Ring
    {
        /// <summary>
        /// Внешний радиус кольца.
        /// </summary>
        private double _outerRadius;

        /// <summary>
        /// Внутренний радиус кольца.
        /// </summary>
        private double _innerRadius;

        /// <summary>
        /// Создает экземпляр класса <see cref="Ring"/>.
        /// </summary>
        public Ring()
        {
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Ring"/>.
        /// </summary>
        /// <param name="center">Координаты центра класса <see cref="Point2D"/>.</param>
        /// <param name="outerRadius">Внешний радиус.</param>
        /// <param name="innerRadius">Внутренний радиус.</param>
        public Ring(Point2D center, double outerRadius, double innerRadius)
        {
            Center = center;
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
        }

        /// <summary>
        /// Возвращает и задает координаты центра 
        /// кольца класса <see cref="Point2D"/>.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Возвращает и задает внешний радиус кольца. Должен быть положительным.
        /// Должен быть больше, чем внутренний радиус.
        /// </summary>
        public double OuterRadius
        {
            get
            {
                return _outerRadius;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(OuterRadius));
                Validator.AssertValueInRange(value, InnerRadius, 
                    double.PositiveInfinity, nameof(OuterRadius));
                _outerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает и задает внутрениий радиус кольца. Должен быть положительным.
        /// Должен быть меньше, чем внешний радиус.
        /// </summary>
        public double InnerRadius
        {
            get
            {
                return _innerRadius;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(InnerRadius));
                Validator.AssertValueInRange(value, 0, OuterRadius,
                    nameof(InnerRadius));
                _innerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает площадь кольца.
        /// </summary>
        public double Area
        {
            get
            {
                return Math.PI * Math.Pow(OuterRadius, 2) - 
                    Math.PI * Math.Pow(InnerRadius, 2);
            }
        }
    }
}
