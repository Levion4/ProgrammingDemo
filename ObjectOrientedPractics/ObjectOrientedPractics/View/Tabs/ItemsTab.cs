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
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Предоставляет методы для обработки товаров.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Текущий товар.
        /// </summary>
        private Item _currentItem = new Item();

        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Создает экземпляр класса <see cref="ItemsTab"/>.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обновляет информацию о товарах в текстовых полях.
        /// </summary>
        /// <param name="item"></param>
        private void UpdateItemInfo(Item item)
        {
            IDTextBox.Text = item.Id.ToString();
            CostTextBox.Text = item.Cost.ToString();
            NameTextBox.Text = item.Name;
            DescriptionTextBox.Text = item.Info;
        }

        /// <summary>
        /// Очищает текстовые поля.
        /// </summary>
        private void ClearItemInfo()
        {
            IDTextBox.Clear();
            CostTextBox.Clear();
            NameTextBox.Clear();
            DescriptionTextBox.Clear();
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
            var item = new Item("Name", "Info", 0);
            _items.Add(item);
            ItemsListBox.Items.Add(item.Name);
            ItemsListBox.SelectedIndex = ItemsListBox.Items.Count - 1;
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
            }
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentItem.Cost = Convert.ToDouble(CostTextBox.Text);
                CostTextBox.BackColor = AppColors.NormalColor;
                ToolTip.SetToolTip(CostTextBox, "");
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
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(DescriptionTextBox, exception.Message);
                DescriptionTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void NameTextBox_Leave(object sender, EventArgs e)
        {
            ItemsListBox.Items.Clear();
            _items = _items.OrderBy(item => item.Name).ToList();

            foreach (var item in _items)
            {
                ItemsListBox.Items.Add(item.Name);
            }

            ItemsListBox.SelectedIndex = ItemsListBox.Items.Count - 1;
        }

        private void ItemsTab_Load(object sender, EventArgs e)
        {
            ChangeAccessToChangeElements();
        }
    }
}
