using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View
{
    public partial class AddDiscountForm : Form
    {
        /// <summary>
        /// Возвращает и задает скидку в процентах.
        /// </summary>
        public PercentDiscount PercentDiscount { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="AddDiscountForm"/>.
        /// </summary>
        public AddDiscountForm()
        {
            InitializeComponent();
        }

        private void AddDiscountForm_Load(object sender, EventArgs e)
        {
            var categories = Enum.GetValues(typeof(Category));

            foreach(Category category in categories)
            {
                CategoryComboBox.Items.Add(category);
            }

            CategoryComboBox.SelectedIndex = 0;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            PercentDiscount = new PercentDiscount(
                (Category)CategoryComboBox.SelectedItem);
            Close();
        }
    }
}
