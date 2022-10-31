using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о адресе.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Фиксированная длина почтового индекса.
        /// </summary>
        private readonly int _indexLength = 6;

        /// <summary>
        /// Ограничение на количество символов
        /// в стране/регионе.
        /// </summary>
        private readonly int _maxLengthCountry = 50;

        /// <summary>
        /// Ограничение на количество символов
        /// в городе (населенном пункте).
        /// </summary>
        private readonly int _maxLengthCity = 50;

        /// <summary>
        /// Ограничение на количество символов
        /// в улице.
        /// </summary>
        private readonly int _maxLengthStreet = 100;

        /// <summary>
        /// Ограничение на количество символов
        /// в номере дома.
        /// </summary>
        private readonly int _maxLengthBuilding = 10;

        /// <summary>
        /// Ограничение на количество символов
        /// в номере квартиры/помещения.
        /// </summary>
        private readonly int _maxLengthApartment = 10;

        /// <summary>
        /// Почтовый индекс.
        /// </summary>
        private int _index;

        /// <summary>
        /// Страна/регион.
        /// </summary>
        private string _country;

        /// <summary>
        /// Город (населенный пункт).
        /// </summary>
        private string _city;

        /// <summary>
        /// Улица.
        /// </summary>
        private string _street;

        /// <summary>
        /// Номер дома.
        /// </summary>
        private string _building;

        /// <summary>
        /// Номер квартиры/помещения.
        /// </summary>
        private string _apartment;

        /// <summary>
        /// Возвращает и задает почтовый индекс.
        /// Должно быть целым шестизначным числом.
        /// </summary>
        public int Index
        {
            get
            {
                return _index;
            }
            set
            {
                ValueValidator.AssertStringOnCertainLength(
                    value.ToString(), _indexLength, nameof(Index));
                _index = value;
            }
        }

        /// <summary>
        /// Возвращает и задает страну/регион.
        /// Длина не более 50 символов.
        /// </summary>
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value,
                    _maxLengthCountry, nameof(Country));
                _country = value;
            }
        }

        /// <summary>
        /// Возвращает и задает город (населенный пункт).
        /// Длина не более 50 символов.
        /// </summary>
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value,
                    _maxLengthCity, nameof(City));
                _city = value;
            }
        }

        /// <summary>
        /// Возвращает и задает улицу.
        /// Длина не более 100 символов.
        /// </summary>
        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value,
                    _maxLengthStreet, nameof(Street));
                _street = value;
            }
        }

        /// <summary>
        /// Возвращает и задает номер дома.
        /// Длина не более 10 символов.
        /// </summary>
        public string Building
        {
            get
            {
                return _building;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value,
                    _maxLengthBuilding, nameof(Building));
                _building = value;
            }
        }

        /// <summary>
        /// Возвращает и задает номер квартиры/помещения.
        /// Длина не более 10 символов.
        /// </summary>
        public string Apartment
        {
            get
            {
                return _apartment;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value,
                    _maxLengthApartment, nameof(Apartment));
                _apartment = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Address"/>.
        /// </summary>
        public Address()
        {
            Index = 100000;
            Country = "";
            City = "";
            Street = "";
            Building = "";
            Apartment = "";
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Address"/>.
        /// </summary>
        /// <param name="index">Почтовый индекс.</param>
        /// <param name="country">Страна/регион.</param>
        /// <param name="city">Город (населенный пункт).</param>
        /// <param name="street">Улица.</param>
        /// <param name="building">Номер дома.</param>
        /// <param name="apartment">Номер квартиры/помещения.</param>
        public Address(int index, string country, string city,
            string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }
    }
}
