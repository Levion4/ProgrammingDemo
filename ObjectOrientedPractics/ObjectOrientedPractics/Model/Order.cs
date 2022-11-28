using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Order
    {
        /// <summary>
        /// Уникальный идентификатор для всех объектов
        /// данного класса.
        /// </summary>
        private int _id;

        /// <summary>
        /// Дата создания заказа.
        /// </summary>
        private DateTime _date;

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
        public DateTime Date
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
    }
}
