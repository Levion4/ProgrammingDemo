using Newtonsoft.Json;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о заказе.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Счетчик всех существующих заказов.
        /// </summary>
        private static int _allOrdersCount;

        /// <summary>
        /// Уникальный идентификатор для всех объектов
        /// данного класса.
        /// </summary>
        private int _id;

        /// <summary>
        /// Дата создания заказа.
        /// </summary>
        private string _date;

        /// <summary>
        /// Адрес доставки.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Общая стоимость заказа.
        /// </summary>
        private double _amount;

        /// <summary>
        /// Полное имя покупателя.
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Возвращает и задает статус заказа.
        /// </summary>
        public OrderStatus OrderStatus { get; set; }

        /// <summary>
        /// Возвращает и задает полное имя покупателя.
        /// </summary>
        public string Fullname
        {
            get
            {
                return _fullname;
            }
            set
            {
                _fullname = value;
            }
        }

        /// <summary>
        /// Возвращает и задает уникальный идентификатор заказа.
        /// Задает только во время инициализации.
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
        /// Возвращает и задает дату создания заказа.
        /// Задает только во время инициализации.
        /// </summary>
        public string Date
        {
            get
            {
                return _date;
            }
            private set
            {
                _date = value;
            }
        }

        /// <summary>
        /// Возвращает и задает адрес доставки заказа.
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
        /// Возвращает и задает список товаров.
        /// </summary>
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set 
            {
                _items = value;
            }
        }

        /// <summary>
        /// Возвращает и задает общую стоимость заказа.
        /// </summary>
        public double Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Order"/>.
        /// </summary>
        public Order()
        { 
            _id = _allOrdersCount++;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Order"/>.
        /// </summary>
        /// <param name="date">Дата создания заказа.</param>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="items">Список товаров в заказе.</param>
        /// <param name="amount">Общая стоимость заказа.</param>
        /// <param name="fullname">Полное имя покупателя.</param>
        public Order(string date, Address address,
            List<Item> items, double amount, string fullname)
        {
            Date = date;
            OrderStatus = OrderStatus.New;
            Address = address;
            Items = items;
            Amount = amount;
            Fullname = fullname;
            _id = _allOrdersCount++;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Order"/>.
        /// </summary>
        /// <param name="date">Дата создания заказа.</param>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="items">Список товаров в заказе.</param>
        /// <param name="amount">Общая стоимость заказа.</param>
        /// <param name="fullname">Полное имя покупателя.</param>
        /// <param name="id">Уникальный идентификатор заказа.</param>
        [JsonConstructor]
        public Order(string date, Address address,
            List<Item> items, double amount, string fullname,
            int id)
        {
            Date = date;
            OrderStatus = OrderStatus.New;
            Address = address;
            Items = items;
            Amount = amount;
            Fullname = fullname;
            Id = id; 
            _allOrdersCount = id + 1;
        }
    }
}
