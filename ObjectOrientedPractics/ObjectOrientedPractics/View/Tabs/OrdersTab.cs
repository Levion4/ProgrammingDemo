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
using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.Model.Enums;
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
        private Order _currentOrder;

        /// <summary>
        /// Текущий приоритетный заказ.
        /// </summary>
        private PriorityOrder _currentPriorityOrder = new PriorityOrder();

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
            DeliveryTimeComboBox.SelectedIndex = -1;
            AddressControl.ClearAddressInfo();
            OrderItemsListBox.Items.Clear();
            AmountOrderNumberLabel.Text = "0";
            TotalNumberLabel.Text = "0";
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
                    currentRow.Cells[
                        "TotalColumn"].Value = _orders[i].Total;
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

            foreach (var value in _currentPriorityOrder.TimeRanges)
            {
                DeliveryTimeComboBox.Items.Add(value);
            }

            StatusComboBox.SelectedIndex = -1;
        }

        private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in OrdersDataGridView.SelectedRows)
            {
                if (_orders[Convert.ToInt32(row.Index)] is PriorityOrder priority)
                {
                    _currentOrder = priority;
                    _currentPriorityOrder = priority;
                    PriorityOptionsPanel.Visible = true;
                    DeliveryTimeComboBox.Text = _currentPriorityOrder.DesiredDeliveryTime;
                }
                else
                {
                    _currentOrder = _orders[
                    Convert.ToInt32(row.Index)];
                    _currentPriorityOrder = null;
                    PriorityOptionsPanel.Visible = false;
                }

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
                TotalNumberLabel.Text = _currentOrder.Total.ToString();
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

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in OrdersDataGridView.SelectedRows)
            {
                if (_orders[Convert.ToInt32(row.Index)] is PriorityOrder priority)
                {
                    _currentPriorityOrder = priority;
                    var orderDeliveryTime = DeliveryTimeComboBox.Text;
                    _currentPriorityOrder.DesiredDeliveryTime = orderDeliveryTime;
                }
            }
        }
    }
}
