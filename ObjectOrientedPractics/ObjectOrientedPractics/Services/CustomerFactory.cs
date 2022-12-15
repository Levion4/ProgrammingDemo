using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Предоставляет методы для создания случайных покупателей.
    /// </summary>
    public static class CustomerFactory
    {
        /// <summary>
        /// Массив полных имен покупателей.
        /// </summary>
        private static string[] _fullnames = new string[] { 
            "Гришко Игнатий Павлович", "Туровский Севастьян Даниилович",
            "Борщёва Анастасия Степановна", "Латушкин Иннокентий Ефимович",
            "Жарыхин Константин Макарович"};

        /// <summary>
        /// Страна доставки.
        /// </summary>
        private static string _country = "Россия";

        /// <summary>
        /// Массив индексов.
        /// </summary>
        private static int[] _indexes = new int[] {
            410205, 644393, 426751, 394789, 443956};

        /// <summary>
        /// Массив городов.
        /// </summary>
        private static string[] _cities = new string[] {
            "г. Саратов", "г. Омск", "г. Ижевск", "г. Воронеж",
            "г. Самара" };

        /// <summary>
        /// Массив улиц.
        /// </summary>
        private static string[] _streets = new string[] {
            "ул. Кирова", "ул. Полевая", "ул. Интернациональная",
            "ул. Строительная", "ул. Горького" };

        /// <summary>
        /// Массив номеров строений.
        /// </summary>
        private static string[] _buildings = new string[] {
            "49", "13", "13", "5", "8"};

        /// <summary>
        /// Массив номеров квартир.
        /// </summary>
        private static string[] _apartments = new string[] {
            "22", "67", "81", "9", "81"};

        /// <summary>
        /// Создает случайный объект покупателя.
        /// </summary>
        /// <returns>Возвращает новый случайный объект покупателя.</returns>
        public static Customer RandomCustomer()
        {
            Random random = new Random(); 

            var fullname = _fullnames[random.Next(0, _fullnames.Length)];
            var index = _indexes[random.Next(0, _indexes.Length)];
            var city = _cities[random.Next(0, _cities.Length)];
            var street = _streets[random.Next(0, _streets.Length)];
            var building = _buildings[random.Next(0, _buildings.Length)];
            var apartment = _apartments[random.Next(0, _apartments.Length)];
            var country = _country;
            var customer = new Customer(fullname, index, country, city,
                street, building, apartment);

            return customer;
        }
    }
}
