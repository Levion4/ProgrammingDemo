using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о покупателе.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Счетчик всех существующих объектов
        /// покупателей.
        /// </summary>
        private static int _allCustomersCount;

        /// <summary>
        /// Ограничение на количество символов в
        /// полном имени покупателя.
        /// </summary>
        private readonly int _maxLengthFullname = 200;

        /// <summary>
        /// Ограничение на количество символов в
        /// адресе доставки для покупателя.
        /// </summary>
        private readonly int _maxLengthAddress = 500;

        /// <summary>
        /// Уникальный идентификатор для всех
        /// объектов данного класса.
        /// </summary>
        private int _id;

        /// <summary>
        /// Полное имя покупателя.
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Адрес доставки для покупателя.
        /// </summary>
        private string _address;

        /// <summary>
        /// Возвращает и задает полное имя покупателя.
        /// Длина не более 200 символов. 
        /// </summary>
        public string Fullname
        {
            get
            {
                return _fullname;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value,
                    _maxLengthFullname, nameof(Fullname));
                _fullname = value;
            }
        }
        
        /// <summary>
        /// Возвращает и задает адрес доставки для покупателя.
        /// Длина не более 500 символов.
        /// </summary>
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value,
                    _maxLengthAddress, nameof(Address));
                _address = value;
            }
        }

        /// <summary>
        /// Возвращает и задает уникальный идентификатор
        /// покупателя. Задает только во время инициализации.
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
        /// Создает экземпляр класса <see cref="Customer"/>.
        /// </summary>
        public Customer()
        {
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullname">Полное имя.
        /// Должно быть не длинее 200 символов.</param>
        /// <param name="address">Адрес доставки.
        /// Должен быть не длинее 500 символов.</param>
        public Customer(string fullname, string address)
        {
            Fullname = fullname;
            Address = address;
            _allCustomersCount++;
            _id = _allCustomersCount;
        }
    }
}
