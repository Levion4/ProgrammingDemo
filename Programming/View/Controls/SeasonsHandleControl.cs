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
using Programming.Model.Classes;

namespace Programming.View.Controls
{
    /// <summary>
    /// Предоставляет методы для обработки событий.
    /// </summary>
    public partial class SeasonsHandleControl : UserControl
    {
        /// <summary>
        /// Создает экземпляр класса <see cref="SeasonsHandleControl"/>.
        /// </summary>
        public SeasonsHandleControl()
        {
            InitializeComponent();
            foreach (var value in Enum.GetValues(typeof(TimeOfYear)))
            {
                SeasonHandleСomboBox.Items.Add(value);
            }
            SeasonHandleСomboBox.SelectedIndex = 0;
        }

        private void SeasonHandleButton_Click(object sender, EventArgs e)
        {
            var item = SeasonHandleСomboBox.SelectedItem;
            var value = (TimeOfYear)item;
            switch (value)
            {
                case TimeOfYear.Winter:
                    SeasonHandleButton.BackColor = AppColors.WinterColor;
                    MessageBox.Show($"Зима уже наступила!");
                    break;
                case TimeOfYear.Spring:
                    SeasonHandleButton.BackColor = AppColors.SpringColor;
                    MessageBox.Show($"Зима уже прошла!");
                    break;
                case TimeOfYear.Summer:
                    SeasonHandleButton.BackColor = AppColors.SummerColor;
                    MessageBox.Show($"До зимы еще далеко!");
                    break;
                case TimeOfYear.Autumn:
                    SeasonHandleButton.BackColor = AppColors.AutumnColor;
                    MessageBox.Show($"Зима близко!");
                    break;
            }
        }
    }
}
