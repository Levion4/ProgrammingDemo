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
    public partial class WeekdayParsingControl : UserControl
    {
        public WeekdayParsingControl()
        {
            InitializeComponent();
        }

        private void WeekdayParsingButton_Click(object sender, EventArgs e)
        {
            Weekday weekday;
            if (Enum.TryParse(WeekdayParsingTextBox.Text, true, out weekday))
            {
                ResultParseTextBox.Text = $"Это день недели ({weekday} = {(int)weekday})";
            }
            else
            {
                ResultParseTextBox.Text = $"Нет такого дня недели";
            }
        }
    }
}
