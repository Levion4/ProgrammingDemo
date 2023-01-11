using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Хранит данные о скидке в процентах.
    /// </summary>
    public class PercentDiscount : IDiscount
    {
        /// <summary>
        /// Текущая скидка в процентах.
        /// </summary>
        private int _currentDiscountPercentage = 1;

        /// <summary>
        /// Категория товаров, на которую предоставляется скидка.
        /// </summary>
        private Category _category;

        /// <summary>
        /// Сумма, на которую покупатель уже сделал покупки данной категории товаров.
        /// </summary>
        private double _amountBuysCategory;

        /// <summary>
        /// Возвращает и задает текущую скидку в процентах.
        /// Задает только во время инициализации.
        /// </summary>
        public int CurrentDiscountPercentage
        {
            get 
            { 
                return _currentDiscountPercentage; 
            }
            private set
            {
                _currentDiscountPercentage = value;
            }
        }

        /// <summary>
        /// Возвращает и задает категорию.
        /// Задает только во время инициализации.
        /// </summary>
        public Category Category
        {
            get
            {
                return _category;
            }
            private set
            {
                _category = value;
            }
        }

        /// <summary>
        /// Возвращает и задает сумму, на которую покупатель
        /// уже сделал покупки данной категории товаров.
        /// Задает только во время инициализации.
        /// </summary>
        public double AmountBuysCategory
        {
            get
            {
                return _amountBuysCategory;
            }
            private set
            {
                _amountBuysCategory = value;
            }
        }


        /// <summary>
        /// Возвращает строку с названием скидки,
        /// категорией скидки и текущим значением процента.
        /// </summary>
        public string Info
        {
            get
            {
                return $"Процентная {Category} – {CurrentDiscountPercentage}%";
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="PercentDiscount"/>.
        /// </summary>
        /// <param name="category">Категория.</param>
        public PercentDiscount(Category category)
        {
            Category = category;
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
        public double Calculate(List<Item> items)
        {
            double amount = 0;

            foreach(Item item in items)
            {
                if(item.Category == Category)
                {
                    amount += item.Cost;
                }
            }

            return ((double) amount / 100) * CurrentDiscountPercentage;
        }

        /// <summary>
        /// Применяет скидку к товарам.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Возвращает размер скидки.</returns>
        public double Apply(List<Item> items)
        {
            return Calculate(items);
        }

        /// <summary>
        /// Высчитывает процент скидки.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public void Update(List<Item> items)
        {
            int maxDiscount = 10;
            double amount = 0;

            foreach (Item item in items)
            {
                if (item.Category == Category)
                {
                    amount += item.Cost;
                }
            }

            AmountBuysCategory += amount;
            _currentDiscountPercentage = 1 + (int)(AmountBuysCategory / 1000);

            if(_currentDiscountPercentage > maxDiscount)
            {
                _currentDiscountPercentage = maxDiscount;
            }
        }
    }
}
