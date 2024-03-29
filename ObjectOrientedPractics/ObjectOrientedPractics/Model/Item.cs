﻿using Newtonsoft.Json;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model.Enums;
using System.Windows.Forms;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о товаре.
    /// </summary>
    public class Item
    {
        public event EventHandler<EventArgs> NameChanged;

        public event EventHandler<EventArgs> CostChanged;

        public event EventHandler<EventArgs> InfoChanged;

        /// <summary>
        /// Счетчик всех существующих объектов товаров.
        /// </summary>
        private static int _allItemsCount;

        /// <summary>
        /// Ограничение на количество символов
        /// в названии товара.
        /// </summary>
        private readonly int _maxLengthName = 200;

        /// <summary>
        /// Ограничение на количество символов
        /// в описании товара.
        /// </summary>
        private readonly int _maxLengthInfo = 1000;

        /// <summary>
        /// Ограничение на минимальную цену товара.
        /// </summary>
        private readonly double _minCost = 0;

        /// <summary>
        /// Ограничение на максимальную цену товара.
        /// </summary>
        private readonly double _maxCost = 100000;

        /// <summary>
        /// Уникальный идентификатор для всех объектов
        /// данного класса.
        /// </summary>
        private int _id;

        /// <summary>
        /// Название товара.
        /// </summary>
        private string _name;

        /// <summary>
        /// Описание товара.
        /// </summary>
        private string _info;

        /// <summary>
        /// Стоимость товара.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Возвращает и задает название товара.
        /// Длина не более 200 символов.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value,
                    _maxLengthName, nameof(Name));

                if(_name != value)
                {
                    _name = value;
                    NameChanged?.Invoke(this, EventArgs.Empty);
                }    
            }
        }

        /// <summary>
        /// Возвращает и задает описание товара.
        /// Длина не более 1000 символов.
        /// </summary>
        public string Info
        {
            get
            {
                return _info;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value,
                    _maxLengthInfo, nameof(Info));

                if (_info != value)
                {
                    _info = value;
                    InfoChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Возвращает и задает стоимость товара.
        /// Стоимость должна быть не меньше 0 и не больше 100000.
        /// </summary>
        public double Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                ValueValidator.AssertValueInRange(value,
                    _minCost, _maxCost, nameof(Cost));

                if (_cost != value)
                {
                    _cost = value;
                    CostChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Возвращает и задает уникальный идентификатор товара.
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
        /// Возвращает и задает категорию товара.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>.
        /// </summary>
        public Item()
        {
            _id = _allItemsCount++;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Название.
        /// Должно быть не длинее 200 символов.</param>
        /// <param name="info">Описание.
        /// Должно быть не длинее 1000 символов.</param>
        /// <param name="cost">Стоимость. Должна быть
        /// не меньше 0 и не больше 100000.</param>
        /// <param name="category">Категория.</param>
        public Item(string name, string info, double cost,
            Category category)
        {
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
            _id = _allItemsCount++;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Название.
        /// Должно быть не длинее 200 символов.</param>
        /// <param name="info">Описание.
        /// Должно быть не длинее 1000 символов.</param>
        /// <param name="cost">Стоимость. Должна быть
        /// не меньше 0 и не больше 100000.</param>
        /// <param name="category">Категория.</param>
        /// <param name="id">Уникальный идентификатор товара.</param>
        [JsonConstructor]
        private Item(string name, string info, double cost,
            Category category, int id)
        {
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
            Id = id;
            _allItemsCount = id + 1;
        }
    }
}