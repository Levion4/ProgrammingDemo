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
    public class CustomerFactory
    {
        /// <summary>
        /// Массив полных имен покупателей.
        /// </summary>
        private static string[] _fullnames = new string[] { 
            "Гришко Игнатий Павлович", "Туровский Севастьян Даниилович",
            "Борщёва Анастасия Степановна", "Латушкин Иннокентий Ефимович",
            "Жарыхин Константин Макарович"};

        /// <summary>
        /// Массив адресов доставки для покупателей.
        /// </summary>
        private static string[] _addresses = new string[] {
            "Россия, г. Волгодонск, Зеленая ул., д. 3 кв.217",
            "Россия, г. Реутов, Первомайская ул., д. 9 кв.109",
            "Россия, г. Самара, Мичурина ул., д. 21 кв.39",
            "Россия, г. Жуковский, Пролетарская ул., д. 7 кв.220",
            "Россия, г. Томск, Пионерская ул., д. 5 кв.173"};

        /// <summary>
        /// Создает случайные числа.
        /// </summary>
        static Random random = new Random();

        /// <summary>
        /// Создает случайный объект покупателя.
        /// </summary>
        /// <returns>Возвращает новый случайный объект продавца.</returns>
        public static Customer RandomCustomer()
        {
            var fullname = _fullnames[random.Next(0, _fullnames.Length)];
            var adress = _addresses[random.Next(0, _addresses.Length)];
            var customer = new Customer(fullname, adress);
            return customer;
        }
    }
}
