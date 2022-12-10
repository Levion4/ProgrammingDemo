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
    /// Предоставляет методы для управления заказами.
    /// </summary>
    public partial class OrdersTab : UserControl
    {
        /// <summary>
        /// Текущий заказ.
        /// </summary>
        private Order _currentOrder = new Order();

        /// <summary>
        /// Список заказов.
        /// </summary>
        private List<Order> _orders = new List<Order>();

        /// <summary>
        /// Возвращает и задает список покупателей.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Customer> OrderCustomers { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="OrdersTab"/>.
        /// </summary>
        public OrdersTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Очищает элементы.
        /// </summary>
        private void ClearOrderInfo()
        {
            IDTextBox.Clear();
            CreatedTextBox.Clear();
            StatusComboBox.SelectedIndex = -1;
            AddressControl.ClearAddressInfo();
            OrderItemsListBox.Items.Clear();
            AmountOrderNumberLabel.Text = "0";
        }

        /// <summary>
        /// Обновляет информацию в элементах.
        /// </summary>
        public void RefreshData()
        {
            OrdersDataGridView.Rows.Clear();
            OrdersDataGridView.Refresh();
            _orders.Clear();

            if (OrderCustomers.Count != 0)
            {
                for (int i = 0; i < OrderCustomers.Count; i++)
                {
                    for (int j = 0; j < OrderCustomers[i].Orders.Count; j++)
                    {
                        _orders.Add(OrderCustomers[i].Orders[j]);
                    }
                }

                for (int i = 0; i < _orders.Count; i++)
                {
                    OrdersDataGridView.Rows.Add();
                    var currentAddress = _orders[i].Address;
                    var address = currentAddress.Index.ToString() + ", " +
                        currentAddress.Country + ", " + currentAddress.City +
                        ", " + currentAddress.Street + ", " + currentAddress.Building +
                        ", " + currentAddress.Apartment;

                    var currentRow = OrdersDataGridView.Rows[i];
                    currentRow.Cells[
                        "IdColumn"].Value = _orders[i].Id;
                    currentRow.Cells[
                        "CreatedColumn"].Value = _orders[i].Date;
                    currentRow.Cells[
                        "OrderStatusColumn"].Value = _orders[i].OrderStatus;
                    currentRow.Cells[
                        "CustomerFullNameColumn"].Value = _orders[i].Fullname;
                    currentRow.Cells[
                        "AmountColumn"].Value = _orders[i].Amount;
                    currentRow.Cells[
                        "AddressColumn"].Value = address;
                }
            }
            else
            {
                ClearOrderInfo();
            }
        }

        private void OrdersTab_Load(object sender, EventArgs e)
        {
            AddressControl.ChangeAccessToChangeElements(true);
            OrdersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            foreach (var value in Enum.GetValues(typeof(OrderStatus)))
            {
                StatusComboBox.Items.Add(value.ToString());
            }

            StatusComboBox.SelectedIndex = -1;
        }

        private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in OrdersDataGridView.SelectedRows)
            {
                _currentOrder = _orders[
                    Convert.ToInt32(row.Index)];

                IDTextBox.Text = _currentOrder.Id.ToString();
                CreatedTextBox.Text = _currentOrder.Date;
                StatusComboBox.Text = _currentOrder.OrderStatus.ToString();
                AddressControl.Address = _currentOrder.Address;
                AddressControl.UpdateAddressInfo();

                OrderItemsListBox.Items.Clear();

                for (var i = 0; i < _currentOrder.Items.Count; i++)
                {
                    OrderItemsListBox.Items.Add(_currentOrder.Items[i].Name);
                }

                AmountOrderNumberLabel.Text = _currentOrder.Amount.ToString();
            }
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in OrdersDataGridView.SelectedRows)
            {
                _currentOrder = _orders[
                    Convert.ToInt32(row.Index)];
                Enum.TryParse(StatusComboBox.Text, out OrderStatus orderStatus);
                _currentOrder.OrderStatus = orderStatus;
                row.Cells["OrderStatusColumn"].Value = _currentOrder.OrderStatus;
            }
        }
    }
}
