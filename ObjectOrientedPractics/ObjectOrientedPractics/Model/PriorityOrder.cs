using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о заказах приоритетного обслуживания.
    /// </summary>
    public class PriorityOrder : Order
    {
        /// <summary>
        /// Желаемая дата доставки.
        /// </summary>
        private DateTime _desiredDeliveryDate;

        /// <summary>
        /// Желаемое время доставки.
        /// </summary>
        private string _desiredDeliveryTime;

        /// <summary>
        /// Возвращает массив диапазонов времени доставки.
        /// </summary>
        public string[] TimeRanges { get;}
            = {
            "9:00 – 11:00",
            "11:00 – 13:00",
            "13:00 – 15:00",
            "15:00 – 17:00",
            "17:00 – 19:00",
            "19:00 – 21:00"
            };

        /// <summary>
        /// Возвращает и задает желаемую дату доставки.
        /// </summary>
        public DateTime DesiredDeliveryDate
        {
            get 
            { 
                return _desiredDeliveryDate; 
            }
            set
            {
                _desiredDeliveryDate = value;
            }
        }

        /// <summary>
        /// Возвращает и задает желаемое время доставки.
        /// </summary>
        public string DesiredDeliveryTime
        {
            get
            {
                return _desiredDeliveryTime;
            }
            set
            {
                _desiredDeliveryTime = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        public PriorityOrder()
        {
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        /// <param name="date">Дата создания заказа.</param>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="items">Список товаров в заказе.</param>
        /// <param name="amount">Общая стоимость заказа.</param>
        /// <param name="fullname">Полное имя покупателя.</param>
        public PriorityOrder(string date, Address address,
            List<Item> items, double amount, string fullname)
            : base(date, address, items, amount, fullname)
        {
            DesiredDeliveryDate = DateTime.Now.Date;
            DesiredDeliveryTime = TimeRanges[0];
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        /// <param name="date">Дата создания заказа.</param>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="items">Список товаров в заказе.</param>
        /// <param name="amount">Общая стоимость заказа.</param>
        /// <param name="fullname">Полное имя покупателя.</param>
        /// <param name="id">Уникальный идентификатор заказа.</param>
        [JsonConstructor]
        public PriorityOrder(string date, Address address,
            List<Item> items, double amount, string fullname, int id)
            : base(date, address, items, amount, fullname, id)
        {
            DesiredDeliveryDate = DateTime.Now.Date;
            DesiredDeliveryTime = TimeRanges[0];
        }
    }
}
