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
    /// Предоставляет методы для обработки покупателей.
    /// </summary>
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Текущий покупатель.
        /// </summary>
        private Customer _currentCustomer = new Customer();

        /// <summary>
        /// Список покупателей.
        /// </summary>
        public List<Customer> Customers = CustomersSerializer.LoadFromFile();

        /// <summary>
        /// Создает экземпляр класса <see cref="CustomersTab"/>
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обновляет информацию о покупателях в текстовых полях.
        /// </summary>
        /// <param name="customer"></param>
        private void UpdateCustomerInfo(Customer customer)
        {
            IDTextBox.Text = customer.Id.ToString();
            FullnameTextBox.Text = customer.Fullname;
            AddressTextBox.Text = customer.Address;
        }

        /// <summary>
        /// Очищает текстовые поля.
        /// </summary>
        private void ClearCustomerInfo()
        {
            IDTextBox.Clear();
            FullnameTextBox.Clear();
            AddressTextBox.Clear();
            FullnameTextBox.BackColor = AppColors.NormalColor;
            AddressTextBox.BackColor = AppColors.NormalColor;
        }

        /// <summary>
        /// Меняет доступ к редактированию элементов.
        /// </summary>
        private void ChangeAccessToChangeElements()
        {
            bool value = CustomersListBox.SelectedIndex == -1;
            FullnameTextBox.ReadOnly = value;
            AddressTextBox.ReadOnly = value;
        }

        private void CustomersListBox_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            try
            {
                var selectedIndex = CustomersListBox.SelectedIndex;

                if (selectedIndex >= 0)
                {
                    _currentCustomer = Customers[selectedIndex];
                    UpdateCustomerInfo(_currentCustomer);
                }

                ChangeAccessToChangeElements();
            }
            catch
            {
                ClearCustomerInfo();
                ChangeAccessToChangeElements();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var customer = new Customer("Full Name", "Address");
            Customers.Add(customer);
            CustomersListBox.Items.Add(customer.Fullname);
            CustomersListBox.SelectedIndex = CustomersListBox.Items.Count - 1;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                int selectedIndex = CustomersListBox.SelectedIndex;
                Customers.RemoveAt(selectedIndex);
                CustomersListBox.Items.RemoveAt(selectedIndex);

                if (Customers.Count != 0)
                {
                    CustomersListBox.SelectedIndex = selectedIndex - 1;
                }

                if (CustomersListBox.SelectedIndex == -1)
                {
                    ClearCustomerInfo();
                }
            }
        }

        private void FullnameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedIndex = CustomersListBox.SelectedIndex;
                _currentCustomer.Fullname = FullnameTextBox.Text;
                FullnameTextBox.BackColor = AppColors.NormalColor;
                ToolTip.SetToolTip(FullnameTextBox, "");
                CustomersListBox.Items[selectedIndex] =
                    _currentCustomer.Fullname;
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(FullnameTextBox, exception.Message);
                FullnameTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentCustomer.Address = AddressTextBox.Text;
                AddressTextBox.BackColor = AppColors.NormalColor;
                ToolTip.SetToolTip(AddressTextBox, "");
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(AddressTextBox, exception.Message);
                AddressTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void FullnameTextBox_Leave(object sender, EventArgs e)
        {
            CustomersListBox.Items.Clear();
            Customers = Customers.OrderBy(customer => customer.Fullname).ToList();

            foreach (var customer in Customers)
            {
                CustomersListBox.Items.Add(customer.Fullname);
            }

            CustomersListBox.SelectedIndex = CustomersListBox.Items.Count - 1;
        }

        private void CustomersTab_Load(object sender, EventArgs e)
        {
            ChangeAccessToChangeElements();
            for (var i = 0; i < Customers.Count; i++)
            {
                CustomersListBox.Items.Add(Customers[i].Fullname);
            }
        }

        private void RandomizeButton_Click(object sender, EventArgs e)
        {
            var customer = CustomerFactory.RandomCustomer();
            Customers.Add(customer);
            CustomersListBox.Items.Add(customer.Fullname);
            CustomersListBox.SelectedIndex = CustomersListBox.Items.Count - 1;
        }
    }
}
