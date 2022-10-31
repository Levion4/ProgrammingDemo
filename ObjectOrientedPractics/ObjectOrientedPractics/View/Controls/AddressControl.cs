using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Controls
{
    /// <summary>
    /// Предоставляет методы для обработки адресов.
    /// </summary>
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Адрес.
        /// </summary>
        private Address _address = new Address();

        /// <summary>
        /// Возращает и задает адрес.
        /// </summary>
        public Address Address 
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="AddressControl"/>.
        /// </summary>
        public AddressControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обновляет информацию о адресе в текстовых полях.
        /// </summary>
        public void UpdateAddressInfo()
        {
            PostIndexTextBox.Text = Address.Index.ToString();
            CountryTextBox.Text = Address.Country;
            CityTextBox.Text = Address.City;
            StreetTextBox.Text = Address.Street;
            BuildingTextBox.Text = Address.Building;
            ApartmentTextBox.Text = Address.Apartment;
        }

        /// <summary>
        /// Очищает текстовые поля.
        /// </summary>
        public void ClearAddressInfo()
        {
            PostIndexTextBox.Clear();
            CountryTextBox.Clear();
            CityTextBox.Clear();
            StreetTextBox.Clear();
            BuildingTextBox.Clear();
            ApartmentTextBox.Clear();
            PostIndexTextBox.BackColor = AppColors.NormalColor;
            CountryTextBox.BackColor = AppColors.NormalColor;
            CityTextBox.BackColor = AppColors.NormalColor;
            StreetTextBox.BackColor = AppColors.NormalColor;
            BuildingTextBox.BackColor = AppColors.NormalColor;
            ApartmentTextBox.BackColor = AppColors.NormalColor;
        }

        /// <summary>
        /// Меняет доступ к редактированию элементов.
        /// </summary>
        public void ChangeAccessToChangeElements(bool value)
        {
            PostIndexTextBox.ReadOnly = value;
            CountryTextBox.ReadOnly = value;
            CityTextBox.ReadOnly = value;
            StreetTextBox.ReadOnly = value;
            BuildingTextBox.ReadOnly = value;
            ApartmentTextBox.ReadOnly = value;
        }

        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Address.Index = Convert.ToInt32(PostIndexTextBox.Text);
                PostIndexTextBox.BackColor = AppColors.NormalColor;
                ToolTip.SetToolTip(PostIndexTextBox, "");
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(PostIndexTextBox, exception.Message);
                PostIndexTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Address.Country = CountryTextBox.Text;
                CountryTextBox.BackColor = AppColors.NormalColor;
                ToolTip.SetToolTip(CountryTextBox, "");
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(CountryTextBox, exception.Message);
                CountryTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Address.City = CityTextBox.Text;
                CityTextBox.BackColor = AppColors.NormalColor;
                ToolTip.SetToolTip(CityTextBox, "");
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(CityTextBox, exception.Message);
                CityTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Address.Street = StreetTextBox.Text;
                StreetTextBox.BackColor = AppColors.NormalColor;
                ToolTip.SetToolTip(StreetTextBox, "");
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(StreetTextBox, exception.Message);
                StreetTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Address.Building = BuildingTextBox.Text;
                BuildingTextBox.BackColor = AppColors.NormalColor;
                ToolTip.SetToolTip(BuildingTextBox, "");
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(BuildingTextBox, exception.Message);
                BuildingTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Address.Apartment = ApartmentTextBox.Text;
                ApartmentTextBox.BackColor = AppColors.NormalColor;
                ToolTip.SetToolTip(ApartmentTextBox, "");
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(ApartmentTextBox, exception.Message);
                ApartmentTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }
    }
}
