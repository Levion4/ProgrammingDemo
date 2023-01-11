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
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Controls;

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
        private List<Customer> _customers;

        /// <summary>
        /// Возвращает и задает список покупателей.
        /// </summary>
        public List <Customer> Customers
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
                    CustomersListBox.Items.Clear();

                    for (var i = 0; i < _customers.Count; i++)
                    {
                        CustomersListBox.Items.Add(_customers[i].Fullname);
                    }
                }
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="CustomersTab"/>.
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обновляет информацию о покупателях в текстовых полях.
        /// </summary>
        /// <param name="customer">Покупатель,
        /// информация о котором обновляется.</param>
        private void UpdateCustomerInfo(Customer customer)
        {
            IDTextBox.Text = customer.Id.ToString();
            FullnameTextBox.Text = customer.Fullname;
            AddressControl.Address = customer.Address;
            AddressControl.UpdateAddressInfo();
            IsPriorityCheckBox.Checked = customer.IsPriority;
        }

        /// <summary>
        /// Обновляет информацию о скидках в списке.
        /// </summary>
        private void UpdateDiscountsListBox()
        {
            DiscountsListBox.Items.Clear();

            for (var i = 0; i < _currentCustomer.Discounts.Count; i++)
            {
                DiscountsListBox.Items.Add(
                    _currentCustomer.Discounts[i].Info);
            }
        }

        /// <summary>
        /// Очищает текстовые поля.
        /// </summary>
        private void ClearCustomerInfo()
        {
            IDTextBox.Clear();
            FullnameTextBox.Clear();
            FullnameTextBox.BackColor = AppColors.NormalColor;
            AddressControl.ClearAddressInfo();
            IsPriorityCheckBox.Checked = false;
            DiscountsListBox.Items.Clear();
        }

        /// <summary>
        /// Меняет доступ к редактированию элементов.
        /// </summary>
        private void ChangeAccessToChangeElements()
        {
            bool value = CustomersListBox.SelectedIndex == -1;
            FullnameTextBox.ReadOnly = value;
            AddressControl.ChangeAccessToChangeElements(value);
            IsPriorityCheckBox.AutoCheck = !value;
        }

        private void CustomersListBox_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            try
            {
                var selectedIndex = CustomersListBox.SelectedIndex;

                if (selectedIndex >= 0)
                {
                    _currentCustomer = _customers[selectedIndex];
                    UpdateCustomerInfo(_currentCustomer);
                    UpdateDiscountsListBox();
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
            var customer = new Customer("Full Name", 100000, "Country",
                "City", "Street", "Building", "Apartment");
            _customers.Add(customer);
            CustomersListBox.Items.Add(customer.Fullname);
            CustomersListBox.SelectedIndex = CustomersListBox.Items.Count - 1;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                int selectedIndex = CustomersListBox.SelectedIndex;
                _customers.RemoveAt(selectedIndex);
                CustomersListBox.Items.RemoveAt(selectedIndex);

                if (_customers.Count != 0)
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

        private void CustomersTab_Load(object sender, EventArgs e)
        {
            ChangeAccessToChangeElements();
        }

        private void RandomizeButton_Click(object sender, EventArgs e)
        {
            var customer = CustomerFactory.RandomCustomer();
            _customers.Add(customer);
            CustomersListBox.Items.Add(customer.Fullname);
            CustomersListBox.SelectedIndex = CustomersListBox.Items.Count - 1;
        }

        private void IsPriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _currentCustomer.IsPriority = IsPriorityCheckBox.Checked;
        }

        private void DiscountAddButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex >= 0)
            {
                AddDiscountForm addDiscountForm = new AddDiscountForm();

                if(addDiscountForm.ShowDialog() == DialogResult.OK)
                {
                    foreach(var discount in _currentCustomer.Discounts)
                    {
                        if(discount is PointsDiscount)
                        {
                            continue;
                        }

                        if (((PercentDiscount)discount).Category == 
                            addDiscountForm.PercentDiscount.Category)
                        {
                            return;
                        }
                    }

                    _currentCustomer.Discounts.Add(addDiscountForm.PercentDiscount);
                    UpdateDiscountsListBox();
                }
            }
        }

        private void DiscountRemoveButton_Click(object sender, EventArgs e)
        {
            if(CustomersListBox.SelectedIndex >= 0 &&
                DiscountsListBox.SelectedIndex >= 1)
            {
                int selectedIndex = DiscountsListBox.SelectedIndex;
                _currentCustomer.Discounts.RemoveAt(selectedIndex);
                DiscountsListBox.Items.RemoveAt(selectedIndex);

                if (_currentCustomer.Discounts.Count != 0)
                {
                    DiscountsListBox.SelectedIndex = selectedIndex - 1;
                }
            }
        }
    }
}
