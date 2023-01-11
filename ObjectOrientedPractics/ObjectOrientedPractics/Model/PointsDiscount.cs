using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о скидке накопительных баллов.
    /// </summary>
    public class PointsDiscount
    {
        /// <summary>
        /// Количество накопленных баллов.
        /// </summary>
        private int _accumulatedPointsCount;

        /// <summary>
        /// Возвращает и задает количество накопленных баллов.
        /// Задает только во время инициализации.
        /// </summary>
        public int AccumulatedPointsCount
        {
            get
            {
                return _accumulatedPointsCount;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(
                        $"The AccumulatedPointsConunt should be greater than 0," +
                        $" but was {value}");
                }

                _accumulatedPointsCount = value;
            }
        }

        /// <summary>
        /// Возвращает строку с названием скидки и текущим количеством баллов.
        /// </summary>
        public string Info
        {
            get
            {
                return $"Накопительная – {AccumulatedPointsCount} баллов";
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="PointsDiscount"/>.
        /// </summary>
        public PointsDiscount()
        {
        }

        /// <summary>
        /// Вычисляет процент от суммы товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <param name="percent">Процент.</param>
        /// <returns>Возвращает процент от суммы товаров.</returns>
        public double CalculatePercentAmount(List<Item> items, int percent)
        {
            double amountItems = 0;

            foreach (Item item in items)
            {
                amountItems += item.Cost;
            }

            double percentAmount =
                (amountItems / 100) * percent;

            return percentAmount;
        }

        /// <summary>
        /// Высчитывает размер скидки.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Возвращает размер скидки.</returns>
        public int Calculate(List<Item> items)
        {
            int maxPercent = 30;
            int maxPossibleDiscount = 
                (int)CalculatePercentAmount(items, maxPercent);

            if(maxPossibleDiscount >= AccumulatedPointsCount)
            {
                return AccumulatedPointsCount;
            }
            else
            {
                return maxPossibleDiscount;
            }
        }

        /// <summary>
        /// Применяет скидку к товарам.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Возвращает размер скидки.</returns>
        public double Apply(List<Item> items)
        {
            int discount = Calculate(items);
            _accumulatedPointsCount -= discount;

            return discount;
        }

        /// <summary>
        /// Добавляет баллы.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public void Update(List<Item> items)
        {
            int purchasePercent = 10;
            double percentAmount =
                CalculatePercentAmount(items, purchasePercent);

            if(percentAmount % 1 != 0)
            {
                percentAmount = Math.Ceiling(percentAmount);
            }

            _accumulatedPointsCount += (int)percentAmount;
        }
    }
}
