using System;
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
    /// Предоставляет методы для управления приоритетным заказом.
    /// </summary>
    public partial class PriorityOrdersTab : UserControl
    {
        /// <summary>
        /// Текущий заказ.
        /// </summary>
        private PriorityOrder _order;

        /// <summary>
        /// Массив диапазонов времени доставки.
        /// </summary>
        private string[] _timeRanges = new string[]
        {
            "9:00 – 11:00",
            "11:00 – 13:00",
            "13:00 – 15:00",
            "15:00 – 17:00",
            "17:00 – 19:00",
            "19:00 – 21:00"
        };

        /// <summary>
        /// Создает экземпляр класса <see cref="PriorityOrdersTab"/>.
        /// </summary>
        public PriorityOrdersTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Создает пустой заказ.
        /// </summary>
        private void CreatingOrder()
        {
            var items = new List<Item>();
            var amount = 0;
            var date = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            Address address = new Address();
            var fullname = "fullname";
            var desiredDeliveryDate = DateTime.Now.Date;
            var desiredDeliveryTime = _timeRanges[0];
            _order = new PriorityOrder(date, address, items, amount,
                fullname, desiredDeliveryDate, desiredDeliveryTime);
            IDTextBox.Text = _order.Id.ToString();
            CreatedTextBox.Text = _order.Date;
            StatusComboBox.Text = _order.OrderStatus.ToString();
            AddressControl.Address = _order.Address;
            AddressControl.UpdateAddressInfo();
            AmountOrderNumberLabel.Text = _order.Amount.ToString();
        }

        private void PriorityOrdersTab_Load(object sender, EventArgs e)
        {
            AddressControl.ChangeAccessToChangeElements(true);

            foreach (var value in Enum.GetValues(typeof(OrderStatus)))
            {
                StatusComboBox.Items.Add(value.ToString());
            }

            foreach (var value in _timeRanges)
            {
                DeliveryTimeComboBox.Items.Add(value);
            }

            StatusComboBox.SelectedIndex = -1;

            CreatingOrder();
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            var item = ItemFactory.RandomItem();
            _order.Items.Add(item);
            OrderItemsListBox.Items.Add(item.Name);
            OrderItemsListBox.SelectedIndex = OrderItemsListBox.Items.Count - 1;
            _order.Amount += item.Cost;
            AmountOrderNumberLabel.Text = _order.Amount.ToString();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (OrderItemsListBox.SelectedIndex != -1)
            {
                int selectedIndex = OrderItemsListBox.SelectedIndex;
                var items = _order.Items;

                if (items.Count == 1)
                {
                    _order.Amount = 0;
                }
                else
                {
                    _order.Amount -= items[selectedIndex].Cost;
                }
                
                items.RemoveAt(selectedIndex);
                OrderItemsListBox.Items.RemoveAt(selectedIndex);
                AmountOrderNumberLabel.Text = _order.Amount.ToString();

                if (items.Count != 0)
                {
                    OrderItemsListBox.SelectedIndex = selectedIndex - 1;
                }
            }
        }

        private void ClearOrderButton_Click(object sender, EventArgs e)
        {
            OrderItemsListBox.Items.Clear();
            CreatingOrder();
        }
    }
}
