using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о заказах приоритетного обслуживания.
    /// </summary>
    public class PriorityOrder: Order
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
        /// <param name="date">Дата создания заказа.</param>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="items">Список товаров в заказе.</param>
        /// <param name="amount">Общая стоимость заказа.</param>
        /// <param name="fullname">Полное имя покупателя.</param>
        /// <param name="desiredDeliveryDate">Желаемая дата доставки.</param>
        /// <param name="desiredDeliveryTime">Желаемое время доставки.</param>
        public PriorityOrder(string date, Address address,
            List<Item> items, double amount, string fullname,
            DateTime desiredDeliveryDate, string desiredDeliveryTime)
            : base(date, address, items, amount, fullname)
        {
            DesiredDeliveryDate = desiredDeliveryDate;
            DesiredDeliveryTime = desiredDeliveryTime;
        }
    }
}
