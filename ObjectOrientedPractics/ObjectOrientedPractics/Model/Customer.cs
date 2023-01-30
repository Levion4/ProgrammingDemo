using Newtonsoft.Json;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Orders;
using System.Windows.Forms;

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
        private Address _address;

        /// <summary>
        /// Корзина покупателя.
        /// </summary>
        private Cart _cart;

        /// <summary>
        /// Список заказов покупателя.
        /// </summary>
        private List<Order> _orders;

        /// <summary>
        /// Возвращает и задает признак приоритетносити покупателя.
        /// </summary>
        public bool IsPriority { get; set; } = false;

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
        /// </summary>
        public Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }

        /// <summary>
        /// Возвращает и задает корзину покупателя.
        /// </summary>
        public Cart Cart
        {
            get
            {
                return _cart;
            }
            set
            {
                _cart = value;
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
        /// Возвращает и задает список заказов покупателя.
        /// </summary>
        public List<Order> Orders
        {
            get
            {
                return _orders;
            }
            set
            {
                _orders = value;
            }
        }

        /// <summary>
        /// Возвращает и задает список скидок.
        /// </summary>
        public List<IDiscount> Discounts { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>.
        /// </summary>
        public Customer()
        {
            _id = _allCustomersCount++;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullname">Полное имя.</param>
        /// <param name="index">Почтовый индекс.</param>
        /// <param name="country">Страна/регион.</param>
        /// <param name="city">Город (населенный пункт).</param>
        /// <param name="street">Улица.</param>
        /// <param name="building">Номер дома.</param>
        /// <param name="apartment">Номер квартиры/помещения.</param>
        public Customer(string fullname, int index, string country,
            string city, string street, string building, string apartment)
        {
            Fullname = fullname;
            Address = new Address(index, country, city, street,
                building, apartment);
            Address.AddressChanged += Address_AddressChanged;
            Cart = new Cart();
            Orders = new List<Order>();
            _id = _allCustomersCount++;
            Discounts = new List<IDiscount>();
            Discounts.Add(new PointsDiscount());
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullname">Полное имя.</param>
        /// <param name="id">Уникальный идентификатор покупателя.</param>
        [JsonConstructor]
        private Customer(string fullname, int id)
        {
            Fullname = fullname;
            Id = id;
            _allCustomersCount = id + 1;
        }

        private void Address_AddressChanged(object sender, EventArgs args)
        {
            MessageBox.Show("Адрес изменился");
        }
    }
}
