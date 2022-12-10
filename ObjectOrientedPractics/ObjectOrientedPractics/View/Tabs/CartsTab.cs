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

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Предоставляет методы для управления корзинами.
    /// </summary>
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Текущий покупатель.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customers;

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
                    ItemsCartListBox.Items.Clear();

                    for (var i = 0; i < _items.Count; i++)
                    {
                        ItemsCartListBox.Items.Add(_items[i].Name);
                    }
                }
            }
        }

        /// <summary>
        /// Возвращает и задает список покупателей.
        /// </summary>
        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;

                if (value != null)
                {
                    CustomerCartComboBox.Items.Clear();

                    foreach (var customer in _customers)
                    {
                        CustomerCartComboBox.Items.Add(customer.Fullname);
                    }

                    CustomerCartComboBox.SelectedIndex = -1;
                }
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="CartsTab"/>.
        /// </summary>
        public CartsTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обновляет информацию в элементах.
        /// </summary>
        public void RefreshData()
        {
            CustomerCartComboBox.Text = "";
            AmountNumberLabel.Text = "0";
            ItemsCartListBox.Items.Clear();
            CustomerCartComboBox.Items.Clear();
            CartListBox.Items.Clear();


            for (var i = 0; i < _items.Count; i++)
            {
                ItemsCartListBox.Items.Add(_items[i].Name);
            }

            foreach (var customer in _customers)
            {
                CustomerCartComboBox.Items.Add(customer.Fullname);
            }

            if (CustomerCartComboBox.SelectedIndex != -1)
            {
                AmountNumberLabel.Text =
                    Customers[CustomerCartComboBox.SelectedIndex].Cart.Amount.ToString();
            }
        }

        private void CustomerCartComboBox_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            CartListBox.Items.Clear();
            int selectedIndex = CustomerCartComboBox.SelectedIndex;
            var items = Customers[selectedIndex].Cart.Items;

            if (items != null)
            {
                for (var i = 0; i < items.Count; i++)
                {
                    CartListBox.Items.Add(items[i].Name);
                }
            }

            AmountNumberLabel.Text =
                Customers[selectedIndex].Cart.Amount.ToString();
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (CustomerCartComboBox.SelectedIndex != -1 &&
                ItemsCartListBox.SelectedIndex != -1)
            {
                var item = Items[ItemsCartListBox.SelectedIndex];
                var items =
                    Customers[CustomerCartComboBox.SelectedIndex].Cart.Items;
                items.Add(item);
                CartListBox.Items.Add(item.Name);
                CartListBox.SelectedIndex = CartListBox.Items.Count - 1;
                AmountNumberLabel.Text =
                    Customers[CustomerCartComboBox.SelectedIndex].Cart.Amount.ToString();
            }
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (CustomerCartComboBox.SelectedIndex != -1 && 
                CartListBox.SelectedIndex != -1)
            {
                int selectedIndex = CartListBox.SelectedIndex;
                var items =
                    Customers[CustomerCartComboBox.SelectedIndex].Cart.Items;
                items.RemoveAt(selectedIndex);
                CartListBox.Items.RemoveAt(selectedIndex);
                AmountNumberLabel.Text =
                    Customers[CustomerCartComboBox.SelectedIndex].Cart.Amount.ToString();

                if (items.Count != 0)
                {
                    CartListBox.SelectedIndex = selectedIndex - 1;
                }
            }
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (CustomerCartComboBox.SelectedIndex != -1 &&
                CartListBox.Items.Count != 0)
            {
                _currentCustomer = Customers[CustomerCartComboBox.SelectedIndex];

                var items = new List<Item>(_currentCustomer.Cart.Items);

                var amount = _currentCustomer.Cart.Amount;
                var date = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                var address = _currentCustomer.Address;
                var fullname = _currentCustomer.Fullname;
                var order = new Order(date, address, items, amount, fullname);
                _currentCustomer.Orders.Add(order);

                CartListBox.Items.Clear();
                AmountNumberLabel.Text = "0";
                _currentCustomer.Cart.Items.Clear();
            }
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            if (CustomerCartComboBox.SelectedIndex != -1)
            {
                CartListBox.Items.Clear();
                _currentCustomer = Customers[CustomerCartComboBox.SelectedIndex];
                _currentCustomer.Cart.Items.Clear();           
                AmountNumberLabel.Text =
                    Customers[CustomerCartComboBox.SelectedIndex].Cart.Amount.ToString();
            }
        }
    }
}
