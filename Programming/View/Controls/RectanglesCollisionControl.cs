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
    /// Предоставляет методы для обработки и отрисовки прямоугольников.
    /// </summary>
    public partial class RectanglesCollisionControl : UserControl
    {
        /// <summary>
        /// Текущий прямоугольник.
        /// </summary>
        private Rectangle _currentRectangle = new Rectangle();

        /// <summary>
        /// Список прямоугольников.
        /// </summary>
        private List<Rectangle> _collisionRectangles = new List<Rectangle>();

        /// <summary>
        /// Список прямоугольников на панели.
        /// </summary>
        private List<Panel> _rectanglePanels = new List<Panel>();

        /// <summary>
        /// Создает экземпляр класса <see cref="RectanglesCollisionControl"/>.
        /// </summary>
        public RectanglesCollisionControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обновляет информацию о прямоугольниках в окне со списком.
        /// </summary>
        /// <param name="rectangle">Прямоугольник,
        /// информация о котором обновляестя.</param>
        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            IdRectanglePanelTextBox.Text = rectangle.Id.ToString();
            XRectanglePanelTextBox.Text = rectangle.Center.X.ToString();
            YRectanglePanelTextBox.Text = rectangle.Center.Y.ToString();
            WidthRectanglePanelTextBox.Text = rectangle.Length.ToString();
            HeightRectanglePanelTextBox.Text = rectangle.Width.ToString();
        }

        /// <summary>
        /// Очищает текстовые поля.
        /// </summary>
        private void ClearRectangleInfo()
        {
            IdRectanglePanelTextBox.Clear();
            XRectanglePanelTextBox.Clear();
            YRectanglePanelTextBox.Clear();
            WidthRectanglePanelTextBox.Clear();
            HeightRectanglePanelTextBox.Clear();
            XRectanglePanelTextBox.BackColor = AppColors.NormalColor;
            YRectanglePanelTextBox.BackColor = AppColors.NormalColor;
            WidthRectanglePanelTextBox.BackColor = AppColors.NormalColor;
            HeightRectanglePanelTextBox.BackColor = AppColors.NormalColor;
        }

        /// <summary>
        /// Добавляет прямоугольник в список.
        /// </summary>
        /// <returns>Возвращает созданный прямоугольник.</returns>
        private Rectangle AddRectangles()
        {
            var rectangle = RectangleFactory.Randomize
                (RectanglesPanel.Width, RectanglesPanel.Height);
            _collisionRectangles.Add(rectangle);
            return rectangle;
        }

        /// <summary>
        /// Передает информацию о прямоугольнике.
        /// </summary>
        /// <param name="rectangle">Прямоугольник.</param>
        /// <returns>Возвращает информацию о прямоугольнике.</returns>
        private string GetInfo(Rectangle rectangle)
        {
            return ($"{rectangle.Id}: (X= {rectangle.Center.X}; " +
                   $"Y= {rectangle.Center.Y}; W= {rectangle.Length}; " +
                   $"H= {rectangle.Width})");
        }

        /// <summary>
        /// Добавляет прямоугольник на панель.
        /// </summary>
        /// <param name="rectangle">Прямоугольник.</param>
        private void AddRectanglePanel(Rectangle rectangle)
        {
            var rectanglePanel = new Panel
            {
                Location = new Point(rectangle.Center.X, rectangle.Center.Y),
                Height = rectangle.Width,
                Width = rectangle.Length,
                BackColor = AppColors.NormalPanelColor
            };
            RectanglesPanel.Controls.Add(rectanglePanel);
            _rectanglePanels.Add(rectanglePanel);
        }

        /// <summary>
        /// Находит пересечения прямоугольников.
        /// </summary>
        private void FindCollisions()
        {
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                _rectanglePanels[i].BackColor = AppColors.NormalPanelColor;
            }
            for (int i = 0; i < _collisionRectangles.Count; i++)
            {
                for (int j = i + 1; j < _collisionRectangles.Count; j++)
                {
                    if (CollisionManager.IsCollision(_collisionRectangles[i], _collisionRectangles[j]))
                    {
                        _rectanglePanels[i].BackColor = AppColors.ErrorPanelColor;
                        _rectanglePanels[j].BackColor = AppColors.ErrorPanelColor;
                    }
                }
            }
        }

        private void AddRectanglesButton_Click(object sender, EventArgs e)
        {
            var rectangle = AddRectangles();
            RectanglesPanelListBox.Items.Add(GetInfo(rectangle));
            AddRectanglePanel(rectangle);
            FindCollisions();
        }

        private void RectanglesPanelListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle = _collisionRectangles[RectanglesPanelListBox.SelectedIndex];
                UpdateRectangleInfo(_currentRectangle);
            }
            catch
            {
                ClearRectangleInfo();
            }
        }

        private void RemoveRectanglesButton_Click(object sender, EventArgs e)
        {
            if (RectanglesPanelListBox.SelectedIndex != -1)
            {
                int selectedIndex = RectanglesPanelListBox.SelectedIndex;
                _collisionRectangles.RemoveAt(selectedIndex);
                RectanglesPanelListBox.Items.RemoveAt(selectedIndex);
                _rectanglePanels.RemoveAt(selectedIndex);
                RectanglesPanel.Controls.RemoveAt(selectedIndex);
                FindCollisions();
                if (_collisionRectangles.Count != 0)
                {
                    RectanglesPanelListBox.SelectedIndex = selectedIndex - 1;
                }
            }
        }

        private void XRectanglePanelTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedIndex = RectanglesPanelListBox.SelectedIndex;
                _currentRectangle.Center.X = Convert.ToInt32
                    (XRectanglePanelTextBox.Text);
                XRectanglePanelTextBox.BackColor = AppColors.NormalColor;
                ToolTip.SetToolTip(XRectanglePanelTextBox, "");
                RectanglesPanelListBox.Items[selectedIndex] =
                    GetInfo(_currentRectangle);
                _rectanglePanels[selectedIndex].Location =
                    new Point(_currentRectangle.Center.X,
                    _currentRectangle.Center.Y);
                FindCollisions();
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(XRectanglePanelTextBox,
                    exception.Message);
                XRectanglePanelTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void YRectanglePanelTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedIndex = RectanglesPanelListBox.SelectedIndex;
                _currentRectangle.Center.Y = Convert.ToInt32
                    (YRectanglePanelTextBox.Text);
                YRectanglePanelTextBox.BackColor = AppColors.NormalColor;
                ToolTip.SetToolTip(YRectanglePanelTextBox, "");
                RectanglesPanelListBox.Items[selectedIndex] =
                    GetInfo(_currentRectangle);
                _rectanglePanels[selectedIndex].Location =
                   new Point(_currentRectangle.Center.X,
                   _currentRectangle.Center.Y);
                FindCollisions();
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(YRectanglePanelTextBox,
                    exception.Message);
                YRectanglePanelTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void WidthRectanglePanelTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedIndex = RectanglesPanelListBox.SelectedIndex;
                _currentRectangle.Length = Convert.ToInt32
                    (WidthRectanglePanelTextBox.Text);
                WidthRectanglePanelTextBox.BackColor = AppColors.NormalColor;
                ToolTip.SetToolTip(WidthRectanglePanelTextBox, "");
                RectanglesPanelListBox.Items[selectedIndex] =
                    GetInfo(_currentRectangle);
                _rectanglePanels[selectedIndex].Width =
                    _currentRectangle.Length;
                FindCollisions();
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(WidthRectanglePanelTextBox,
                    exception.Message);
                WidthRectanglePanelTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void HeightRectanglePanelTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedIndex = RectanglesPanelListBox.SelectedIndex;
                _currentRectangle.Width = Convert.ToInt32
                    (HeightRectanglePanelTextBox.Text);
                HeightRectanglePanelTextBox.BackColor = AppColors.NormalColor;
                ToolTip.SetToolTip(HeightRectanglePanelTextBox, "");
                RectanglesPanelListBox.Items[selectedIndex] =
                    GetInfo(_currentRectangle);
                _rectanglePanels[selectedIndex].Height =
                    _currentRectangle.Width;
                FindCollisions();
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(HeightRectanglePanelTextBox,
                    exception.Message);
                HeightRectanglePanelTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }
    }
}
