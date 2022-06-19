using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp.Model;

namespace ContactsApp.View
{
    public partial class MainForm : Form
    {
        private Contact _currentContact = new Contact();

        private List<Contact> _contacts = new List<Contact>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void UpdateContactInfo(Contact contact)
        {
            FullNameTextBox.Text = contact.FullName;
            DateOfBirthDateTimePicker.Value = contact.DateOfBirth;
            PhoneTextBox.Text = contact.Phone;
            VKTextBox.Text = contact.VK;
        }

        private void ClearContactInfo()
        {
            FullNameTextBox.Clear();
            PhoneTextBox.Clear();
            VKTextBox.Clear();
            DateOfBirthDateTimePicker.Value = DateTime.Today;
            FullNameTextBox.BackColor = AppColors.NormalColor;
            PhoneTextBox.BackColor = AppColors.NormalColor;
            VKTextBox.BackColor = AppColors.NormalColor;
            DateOfBirthDateTimePicker.BackColor = AppColors.NormalColor;
        }

        private void ChangeAccessToChangeElements()
        {
            bool value = ContactsListBox.SelectedIndex == -1;
            FullNameTextBox.ReadOnly = value;
            VKTextBox.ReadOnly = value;
            PhoneTextBox.ReadOnly = value;
            DateOfBirthDateTimePicker.Enabled = !value;
        }

        private void AddContactButton_Click(object sender, EventArgs e)
        {
            var contact = new Contact("Full Name",
                DateTime.Today, "+70000000000", "https://vk.com/");
            _contacts.Add(contact);
            ContactsListBox.Items.Add(contact.FullName);
            ContactsListBox.SelectedIndex = ContactsListBox.Items.Count - 1;
        }

        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedIndex = ContactsListBox.SelectedIndex;
                if (selectedIndex >= 0)
                {
                    _currentContact = _contacts[selectedIndex];
                    UpdateContactInfo(_currentContact);
                }
                ChangeAccessToChangeElements();
            }
            catch
            {
                ClearContactInfo();
                ChangeAccessToChangeElements();
            }
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedIndex = ContactsListBox.SelectedIndex;
                _currentContact.FullName = FullNameTextBox.Text;
                FullNameTextBox.BackColor = AppColors.NormalColor;
                ToolTip.SetToolTip(FullNameTextBox, "");
                ContactsListBox.Items[selectedIndex] =
                    _currentContact.FullName;
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(FullNameTextBox,
                    exception.Message);
                FullNameTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void DateOfBirthDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _currentContact.DateOfBirth = DateOfBirthDateTimePicker.Value;
                DateOfBirthDateTimePicker.BackColor = AppColors.NormalColor;
                ToolTip.SetToolTip(DateOfBirthDateTimePicker, "");
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(DateOfBirthDateTimePicker,
                    exception.Message);
                DateOfBirthDateTimePicker.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentContact.Phone = PhoneTextBox.Text;
                PhoneTextBox.BackColor = AppColors.NormalColor;
                ToolTip.SetToolTip(FullNameTextBox, "");
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(PhoneTextBox,
                    exception.Message);
                PhoneTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void VKTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentContact.VK = VKTextBox.Text;
                VKTextBox.BackColor = AppColors.NormalColor;
                ToolTip.SetToolTip(VKTextBox, "");
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(VKTextBox,
                    exception.Message);
                VKTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void RemoveContactButton_Click(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex != -1)
            {
                int selectedIndex = ContactsListBox.SelectedIndex;
                _contacts.RemoveAt(selectedIndex);
                ContactsListBox.Items.RemoveAt(selectedIndex);
                if (_contacts.Count != 0)
                {
                    ContactsListBox.SelectedIndex = selectedIndex - 1;
                }
                if (ContactsListBox.SelectedIndex == -1)
                {
                    ClearContactInfo();
                }
            }
        }

        private void FullNameTextBox_Leave(object sender, EventArgs e)
        {
            ContactsListBox.Items.Clear();
            _contacts = _contacts.OrderBy(contact => contact.FullName).ToList();
            foreach (var contact in _contacts)
            {
                ContactsListBox.Items.Add(contact.FullName);
            }
            ContactsListBox.SelectedIndex = ContactsListBox.Items.Count - 1;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ChangeAccessToChangeElements();
            DateOfBirthDateTimePicker.Value = DateTime.Today;
            DateOfBirthDateTimePicker.MaxDate = DateTime.Today;
        }
    }
}
