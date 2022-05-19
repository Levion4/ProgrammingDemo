using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model.Enums;

namespace Programming.View.Controls
{
    public partial class EnumerationsControl : UserControl
    {
        public EnumerationsControl()
        {
            InitializeComponent();
            EnumsListBox.SelectedIndex = 0;
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            var item = EnumsListBox.SelectedItem;
            Array enumValues = null;
            switch (item)
            {
                case "Color":
                    enumValues = Enum.GetValues(typeof(Model.Enums.Color));
                    break;
                case "Genre":
                    enumValues = Enum.GetValues(typeof(Genre));
                    break;
                case "SmartphoneManufacturers":
                    enumValues = Enum.GetValues(typeof(SmartphoneManufactures));
                    break;
                case "StudentsFormOfStudy":
                    enumValues = Enum.GetValues(typeof(StudentsFormOfStudy));
                    break;
                case "TimeOfYear":
                    enumValues = Enum.GetValues(typeof(TimeOfYear));
                    break;
                case "Weekday":
                    enumValues = Enum.GetValues(typeof(Weekday));
                    break;
            }
            foreach (var value in enumValues)
            {
                ValuesListBox.Items.Add(value);
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntValueTextBox.Text = ((int)ValuesListBox.SelectedItem).ToString();
        }
    }
}
