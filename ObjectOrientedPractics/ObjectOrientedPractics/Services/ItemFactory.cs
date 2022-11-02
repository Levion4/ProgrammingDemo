using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Предоставляет методы для создания случайных товаров.
    /// </summary>
    public static class ItemFactory
    {
        /// <summary>
        /// Массив названий товаров.
        /// </summary>
        private static string[] _names =
            new string[] { "Xbox Series S", "Xbox Series X",
            "Elden Ring - PlayStation 5", "JBL Reflect Aero TWS",
            "Apple Lightning to USB Cable (1 m)"};

        /// <summary>
        /// Массив описаний товаров.
        /// </summary>
        private static string[] _descriptions =
            new string[] { "The newest game console.",
            "The most powerful game console.",
            "Video game for the Playstation 5 game console.",
            "The latest headphones with excellent sound.",
            "This USB 2.0 cable connects your iPhone."};

        /// <summary>
        /// Создает случайный объект товара.
        /// </summary>
        /// <returns>Возвращает новый случайный объект товара.</returns>
        public static Item RandomItem()
        {
            Random random = new Random();

            var name = _names[random.Next(0, _names.Length)];
            var discription = _descriptions[random.Next(0,
                _descriptions.Length)];
            var cost = random.Next(1, 999);
            var category = (Category)random.Next(
                Enum.GetNames(typeof(Category)).Length);
            var item = new Item(name, discription, cost, category);

            return item;
        }
    }
}
