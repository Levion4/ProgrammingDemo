using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model.Classes;
using Rectangle = Programming.Model.Classes.Rectangle;

namespace Programming.View.Controls
{
    /// <summary>
    /// Предоставляет методы для обработки данных о прямоугольниках.
    /// </summary>
    public partial class RectanglesInfoControl : UserControl
    {
        /// <summary>
        /// Массив прямоугольников.
        /// </summary>
        private Rectangle[] _rectangles;

        /// <summary>
        /// Текущий прямоугольник.
        /// </summary>
        private Rectangle _currentRectangle = new Rectangle();

        /// <summary>
        /// Создает экземпляр класса <see cref="RectanglesInfoControl"/>.
        /// </summary>
        public RectanglesInfoControl()
        {
            InitializeComponent();
            InitRectangles();
            RectanglesListBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Инициализирует прямоугольники.
        /// </summary>
        private void InitRectangles()
        {
            _rectangles = new Rectangle[5];
            for (var i = 0; i < 5; i++)
            {
                _rectangles[i] = RectangleFactory.Randomize(300, 300);
                RectanglesListBox.Items.Add($"Rectangle {i + 1}");
            }
        }

        /// <summary>
        /// Ищет прямоугольник с максимальной шириной.
        /// </summary>
        /// <param name="rectangles">Массив прямоугольников.</param>
        /// <returns>Возвращает индекс прямоугольника с максимальной шириной.</returns>
        private int FindRectangleWithMaxWidth(Model.Classes.Rectangle[] rectangles)
        {
            var maxIndex = 0;
            var maxValues = rectangles[maxIndex].Width;
            for (var i = 0; i < rectangles.Length; i++)
            {
                if (rectangles[i].Width > maxValues)
                {
                    maxValues = rectangles[i].Width;
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
            LengthTextBox.Text = _currentRectangle.Length.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color;
            CenterXTextBox.Text = _currentRectangle.Center.X.ToString();
            CenterYTextBox.Text = _currentRectangle.Center.Y.ToString();
            IdTextBox.Text = _currentRectangle.Id.ToString();
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Length = Convert.ToInt32(LengthTextBox.Text);
                LengthTextBox.BackColor = AppColors.NormalColor;
                ToolTip.SetToolTip(LengthTextBox, "");
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(LengthTextBox, exception.Message);
                LengthTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = Convert.ToInt32(WidthTextBox.Text);
                WidthTextBox.BackColor = AppColors.NormalColor;
                ToolTip.SetToolTip(WidthTextBox, "");
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(WidthTextBox, exception.Message);
                WidthTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Color = ColorTextBox.Text;
                ColorTextBox.BackColor = AppColors.NormalColor;
                ToolTip.SetToolTip(ColorTextBox, "");
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(ColorTextBox, exception.Message);
                ColorTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void RectanglesButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }
    }
}
