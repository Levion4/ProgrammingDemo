using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Предоставляет методы для создания случайных прямоугольников.
    /// </summary>
    public static class RectangleFactory
    {
        /// <summary>
        /// Создает случайные числа.
        /// </summary>
        static Random random = new Random();

        /// <summary>
        /// Создает новый случайный объект прямоугольника.
        /// </summary>
        /// <param name="panelBordersWidth">Ширина панели.</param>
        /// <param name="panelBordersHeight">Высота панели.</param>
        /// <returns>Возвращает новый случайный объект прямоугольника.</returns>
        public static Rectangle Randomize(int panelBordersWidth, int panelBordersHeight)
        {
            int lengthColor = Enum.GetNames(typeof(Model.Enums.Color)).Length;
            var x = random.Next(1, panelBordersWidth - 1);
            var y = random.Next(1, panelBordersHeight - 1);
            var color = ((Model.Enums.Color)random.Next(lengthColor)).ToString();
            var length = random.Next(1, panelBordersWidth - x);
            var width = random.Next(1, panelBordersHeight - y);
            var rectangle = new Rectangle(length, width, color, new Point2D(x, y));
            return rectangle;
        }
    }
}
