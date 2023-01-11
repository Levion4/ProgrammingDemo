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
using ObjectOrientedPractics.View;
using ObjectOrientedPractics.View.Tabs;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Магазин.
        /// </summary>
        private Store _store;

        /// <summary>
        /// Создает экземпляр класса <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _store = new Store();
            _store = StoreSerializer.LoadFromFile();
            ItemsTab.Items = _store.Items;
            CustomersTab.Customers = _store.Customers;
            CartsTab.Customers = _store.Customers;
            CartsTab.Items = _store.Items;
            OrdersTab.OrderCustomers = _store.Customers;

            DiscountsTab.Items = _store.Items;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                StoreSerializer.SaveToFile(_store);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void ItemsTabControl_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            switch (ItemsTabControl.SelectedIndex)
            {
                case 2:
                {
                    CartsTab.Customers = _store.Customers;
                    CartsTab.Items = _store.Items;
                    CartsTab.RefreshData();
                    break;
                }
                case 3:
                {
                    OrdersTab.OrderCustomers = _store.Customers;
                    OrdersTab.RefreshData();
                    break;
                }
            }
        }
    }
}
