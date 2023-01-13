﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Предоставляет методы для обработки товаров.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        public event EventHandler<EventArgs> ItemsChanged;

        /// <summary>
        /// Текущий товар.
        /// </summary>
        private Item _currentItem = new Item();

        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items;

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

                if (_items != null)
                {
                    ItemsListBox.Items.Clear();

                    for (var i = 0; i < _items.Count; i++)
                    {
                        ItemsListBox.Items.Add(_items[i].Name);
                    }
                }
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="ItemsTab"/>.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обновляет информацию о товарах в элементах.
        /// </summary>
        /// <param name="item">Товар, 
        /// информация о котором обновляется.</param>
        private void UpdateItemInfo(Item item)
        {
            IDTextBox.Text = item.Id.ToString();
            CostTextBox.Text = item.Cost.ToString();
            NameTextBox.Text = item.Name;
            DescriptionTextBox.Text = item.Info;
            CategoryComboBox.Text = item.Category.ToString();
        }

        /// <summary>
        /// Очищает элементы.
        /// </summary>
        private void ClearItemInfo()
        {
            IDTextBox.Clear();
            CostTextBox.Clear();
            NameTextBox.Clear();
            DescriptionTextBox.Clear();
            CategoryComboBox.SelectedIndex = -1;
            CostTextBox.BackColor = AppColors.NormalColor;
            NameTextBox.BackColor = AppColors.NormalColor;
            DescriptionTextBox.BackColor = AppColors.NormalColor;
        }

        /// <summary>
        /// Меняет доступ к редактированию элементов.
        /// </summary>
        private void ChangeAccessToChangeElements()
        {
            bool value = ItemsListBox.SelectedIndex == -1;
            NameTextBox.ReadOnly = value;
            CostTextBox.ReadOnly = value;
            DescriptionTextBox.ReadOnly = value;
            CategoryComboBox.DropDownStyle =
              ComboBoxStyle.DropDownList;
        }

        private void Item_NameChanged(object sender, EventArgs args)
        {
            MessageBox.Show("Имя изменилось");
        }

        private void Item_InfoChanged(object sender, EventArgs args)
        {
            MessageBox.Show("Описание изменилось");
        }

        private void Item_CostChanged(object sender, EventArgs args)
        {
            MessageBox.Show("Цена изменилась");
        }

        private void ItemsListBox_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            try
            {
                var selectedIndex = ItemsListBox.SelectedIndex;

                if (selectedIndex >= 0)
                {
                    _currentItem = _items[selectedIndex];
                    UpdateItemInfo(_currentItem);
                }

                ChangeAccessToChangeElements();
            }
            catch
            {
                ClearItemInfo();
                ChangeAccessToChangeElements();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var item = new Item("Name", "Info", 0, Category.Сables);
            item.NameChanged += Item_NameChanged;
            item.CostChanged += Item_CostChanged;
            item.InfoChanged += Item_InfoChanged;
            _items.Add(item);
            ItemsListBox.Items.Add(item.Name);
            ItemsListBox.SelectedIndex = ItemsListBox.Items.Count - 1;
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                int selectedIndex = ItemsListBox.SelectedIndex;
                _items.RemoveAt(selectedIndex);
                ItemsListBox.Items.RemoveAt(selectedIndex);

                if (_items.Count != 0)
                {
                    ItemsListBox.SelectedIndex = selectedIndex - 1;
                }

                if (ItemsListBox.SelectedIndex == -1)
                {
                    ClearItemInfo();
                }

                ItemsChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentItem.Cost = Convert.ToDouble(CostTextBox.Text);
                CostTextBox.BackColor = AppColors.NormalColor;
                ToolTip.SetToolTip(CostTextBox, "");
                ItemsChanged?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(CostTextBox, exception.Message);
                CostTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedIndex = ItemsListBox.SelectedIndex;
                _currentItem.Name = NameTextBox.Text;
                NameTextBox.BackColor = AppColors.NormalColor;
                ToolTip.SetToolTip(NameTextBox, "");
                ItemsListBox.Items[selectedIndex] =
                    _currentItem.Name;
                ItemsChanged?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(NameTextBox, exception.Message);
                NameTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentItem.Info = DescriptionTextBox.Text;
                DescriptionTextBox.BackColor = AppColors.NormalColor;
                ToolTip.SetToolTip(DescriptionTextBox, "");
                ItemsChanged?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(DescriptionTextBox, exception.Message);
                DescriptionTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void ItemsTab_Load(object sender, EventArgs e)
        {
            ChangeAccessToChangeElements();

            foreach(var value in Enum.GetValues(typeof(Category)))
            {
                CategoryComboBox.Items.Add(value.ToString());
            }

            CategoryComboBox.SelectedIndex = -1;
        }

        private void RandomizeButton_Click(object sender, EventArgs e)
        {
            var item = ItemFactory.RandomItem();
            _items.Add(item);
            ItemsListBox.Items.Add(item.Name);
            ItemsListBox.SelectedIndex = ItemsListBox.Items.Count - 1;
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse(CategoryComboBox.Text, out Category category);
            _currentItem.Category = category;
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
