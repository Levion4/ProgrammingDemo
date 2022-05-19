
namespace Programming.View.Controls
{
    partial class RectanglesCollisionControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.RectanglesPanel = new System.Windows.Forms.Panel();
            this.HeightRectanglePanelTextBox = new System.Windows.Forms.TextBox();
            this.WidthRectanglePanelTextBox = new System.Windows.Forms.TextBox();
            this.YRectanglePanelTextBox = new System.Windows.Forms.TextBox();
            this.XRectanglePanelTextBox = new System.Windows.Forms.TextBox();
            this.IdRectanglePanelTextBox = new System.Windows.Forms.TextBox();
            this.HeightRectanglePanelLabel = new System.Windows.Forms.Label();
            this.WidthRectanglePanelLabel = new System.Windows.Forms.Label();
            this.YRectanglePanelLable = new System.Windows.Forms.Label();
            this.XRectanglePanelLabel = new System.Windows.Forms.Label();
            this.IdRectanglePanelLabel = new System.Windows.Forms.Label();
            this.SelectedRectangleLabel = new System.Windows.Forms.Label();
            this.RemoveRectanglesButton = new System.Windows.Forms.Button();
            this.AddRectanglesButton = new System.Windows.Forms.Button();
            this.RectanglesPanelLabel = new System.Windows.Forms.Label();
            this.RectanglesPanelListBox = new System.Windows.Forms.ListBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // RectanglesPanel
            // 
            this.RectanglesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RectanglesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RectanglesPanel.Location = new System.Drawing.Point(245, 3);
            this.RectanglesPanel.Name = "RectanglesPanel";
            this.RectanglesPanel.Size = new System.Drawing.Size(420, 413);
            this.RectanglesPanel.TabIndex = 31;
            // 
            // HeightRectanglePanelTextBox
            // 
            this.HeightRectanglePanelTextBox.Location = new System.Drawing.Point(50, 334);
            this.HeightRectanglePanelTextBox.Name = "HeightRectanglePanelTextBox";
            this.HeightRectanglePanelTextBox.Size = new System.Drawing.Size(86, 20);
            this.HeightRectanglePanelTextBox.TabIndex = 30;
            this.HeightRectanglePanelTextBox.TextChanged += new System.EventHandler(this.HeightRectanglePanelTextBox_TextChanged);
            // 
            // WidthRectanglePanelTextBox
            // 
            this.WidthRectanglePanelTextBox.Location = new System.Drawing.Point(50, 308);
            this.WidthRectanglePanelTextBox.Name = "WidthRectanglePanelTextBox";
            this.WidthRectanglePanelTextBox.Size = new System.Drawing.Size(86, 20);
            this.WidthRectanglePanelTextBox.TabIndex = 29;
            this.WidthRectanglePanelTextBox.TextChanged += new System.EventHandler(this.WidthRectanglePanelTextBox_TextChanged);
            // 
            // YRectanglePanelTextBox
            // 
            this.YRectanglePanelTextBox.Location = new System.Drawing.Point(50, 283);
            this.YRectanglePanelTextBox.Name = "YRectanglePanelTextBox";
            this.YRectanglePanelTextBox.Size = new System.Drawing.Size(86, 20);
            this.YRectanglePanelTextBox.TabIndex = 28;
            this.YRectanglePanelTextBox.TextChanged += new System.EventHandler(this.YRectanglePanelTextBox_TextChanged);
            // 
            // XRectanglePanelTextBox
            // 
            this.XRectanglePanelTextBox.Location = new System.Drawing.Point(50, 258);
            this.XRectanglePanelTextBox.Name = "XRectanglePanelTextBox";
            this.XRectanglePanelTextBox.Size = new System.Drawing.Size(86, 20);
            this.XRectanglePanelTextBox.TabIndex = 27;
            this.XRectanglePanelTextBox.TextChanged += new System.EventHandler(this.XRectanglePanelTextBox_TextChanged);
            // 
            // IdRectanglePanelTextBox
            // 
            this.IdRectanglePanelTextBox.Location = new System.Drawing.Point(50, 233);
            this.IdRectanglePanelTextBox.Name = "IdRectanglePanelTextBox";
            this.IdRectanglePanelTextBox.ReadOnly = true;
            this.IdRectanglePanelTextBox.Size = new System.Drawing.Size(86, 20);
            this.IdRectanglePanelTextBox.TabIndex = 26;
            // 
            // HeightRectanglePanelLabel
            // 
            this.HeightRectanglePanelLabel.AutoSize = true;
            this.HeightRectanglePanelLabel.Location = new System.Drawing.Point(5, 337);
            this.HeightRectanglePanelLabel.Name = "HeightRectanglePanelLabel";
            this.HeightRectanglePanelLabel.Size = new System.Drawing.Size(41, 13);
            this.HeightRectanglePanelLabel.TabIndex = 25;
            this.HeightRectanglePanelLabel.Text = "Height:";
            // 
            // WidthRectanglePanelLabel
            // 
            this.WidthRectanglePanelLabel.AutoSize = true;
            this.WidthRectanglePanelLabel.Location = new System.Drawing.Point(9, 311);
            this.WidthRectanglePanelLabel.Name = "WidthRectanglePanelLabel";
            this.WidthRectanglePanelLabel.Size = new System.Drawing.Size(38, 13);
            this.WidthRectanglePanelLabel.TabIndex = 24;
            this.WidthRectanglePanelLabel.Text = "Width:";
            // 
            // YRectanglePanelLable
            // 
            this.YRectanglePanelLable.AutoSize = true;
            this.YRectanglePanelLable.Location = new System.Drawing.Point(30, 285);
            this.YRectanglePanelLable.Name = "YRectanglePanelLable";
            this.YRectanglePanelLable.Size = new System.Drawing.Size(17, 13);
            this.YRectanglePanelLable.TabIndex = 23;
            this.YRectanglePanelLable.Text = "Y:";
            // 
            // XRectanglePanelLabel
            // 
            this.XRectanglePanelLabel.AutoSize = true;
            this.XRectanglePanelLabel.Location = new System.Drawing.Point(30, 260);
            this.XRectanglePanelLabel.Name = "XRectanglePanelLabel";
            this.XRectanglePanelLabel.Size = new System.Drawing.Size(17, 13);
            this.XRectanglePanelLabel.TabIndex = 22;
            this.XRectanglePanelLabel.Text = "X:";
            // 
            // IdRectanglePanelLabel
            // 
            this.IdRectanglePanelLabel.AutoSize = true;
            this.IdRectanglePanelLabel.Location = new System.Drawing.Point(28, 235);
            this.IdRectanglePanelLabel.Name = "IdRectanglePanelLabel";
            this.IdRectanglePanelLabel.Size = new System.Drawing.Size(19, 13);
            this.IdRectanglePanelLabel.TabIndex = 21;
            this.IdRectanglePanelLabel.Text = "Id:";
            // 
            // SelectedRectangleLabel
            // 
            this.SelectedRectangleLabel.AutoSize = true;
            this.SelectedRectangleLabel.Location = new System.Drawing.Point(3, 214);
            this.SelectedRectangleLabel.Name = "SelectedRectangleLabel";
            this.SelectedRectangleLabel.Size = new System.Drawing.Size(104, 13);
            this.SelectedRectangleLabel.TabIndex = 20;
            this.SelectedRectangleLabel.Text = "Selected Rectangle:";
            // 
            // RemoveRectanglesButton
            // 
            this.RemoveRectanglesButton.BackgroundImage = global::Programming.Properties.Resources.rectangle_remove_24x24_uncolor;
            this.RemoveRectanglesButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.RemoveRectanglesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveRectanglesButton.Location = new System.Drawing.Point(117, 180);
            this.RemoveRectanglesButton.Name = "RemoveRectanglesButton";
            this.RemoveRectanglesButton.Size = new System.Drawing.Size(26, 26);
            this.RemoveRectanglesButton.TabIndex = 19;
            this.RemoveRectanglesButton.UseVisualStyleBackColor = true;
            this.RemoveRectanglesButton.Click += new System.EventHandler(this.RemoveRectanglesButton_Click);
            // 
            // AddRectanglesButton
            // 
            this.AddRectanglesButton.BackgroundImage = global::Programming.Properties.Resources.rectangle_add_24x24_uncolor;
            this.AddRectanglesButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddRectanglesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRectanglesButton.Location = new System.Drawing.Point(36, 180);
            this.AddRectanglesButton.Name = "AddRectanglesButton";
            this.AddRectanglesButton.Size = new System.Drawing.Size(26, 26);
            this.AddRectanglesButton.TabIndex = 18;
            this.AddRectanglesButton.UseVisualStyleBackColor = true;
            this.AddRectanglesButton.Click += new System.EventHandler(this.AddRectanglesButton_Click);
            // 
            // RectanglesPanelLabel
            // 
            this.RectanglesPanelLabel.AutoSize = true;
            this.RectanglesPanelLabel.Location = new System.Drawing.Point(3, 12);
            this.RectanglesPanelLabel.Name = "RectanglesPanelLabel";
            this.RectanglesPanelLabel.Size = new System.Drawing.Size(64, 13);
            this.RectanglesPanelLabel.TabIndex = 17;
            this.RectanglesPanelLabel.Text = "Rectangles:";
            // 
            // RectanglesPanelListBox
            // 
            this.RectanglesPanelListBox.FormattingEnabled = true;
            this.RectanglesPanelListBox.Location = new System.Drawing.Point(3, 28);
            this.RectanglesPanelListBox.Name = "RectanglesPanelListBox";
            this.RectanglesPanelListBox.Size = new System.Drawing.Size(237, 147);
            this.RectanglesPanelListBox.TabIndex = 16;
            this.RectanglesPanelListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesPanelListBox_SelectedIndexChanged);
            // 
            // RectanglesCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RectanglesPanel);
            this.Controls.Add(this.HeightRectanglePanelTextBox);
            this.Controls.Add(this.WidthRectanglePanelTextBox);
            this.Controls.Add(this.YRectanglePanelTextBox);
            this.Controls.Add(this.XRectanglePanelTextBox);
            this.Controls.Add(this.IdRectanglePanelTextBox);
            this.Controls.Add(this.HeightRectanglePanelLabel);
            this.Controls.Add(this.WidthRectanglePanelLabel);
            this.Controls.Add(this.YRectanglePanelLable);
            this.Controls.Add(this.XRectanglePanelLabel);
            this.Controls.Add(this.IdRectanglePanelLabel);
            this.Controls.Add(this.SelectedRectangleLabel);
            this.Controls.Add(this.RemoveRectanglesButton);
            this.Controls.Add(this.AddRectanglesButton);
            this.Controls.Add(this.RectanglesPanelLabel);
            this.Controls.Add(this.RectanglesPanelListBox);
            this.Name = "RectanglesCollisionControl";
            this.Size = new System.Drawing.Size(668, 419);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel RectanglesPanel;
        private System.Windows.Forms.TextBox HeightRectanglePanelTextBox;
        private System.Windows.Forms.TextBox WidthRectanglePanelTextBox;
        private System.Windows.Forms.TextBox YRectanglePanelTextBox;
        private System.Windows.Forms.TextBox XRectanglePanelTextBox;
        private System.Windows.Forms.TextBox IdRectanglePanelTextBox;
        private System.Windows.Forms.Label HeightRectanglePanelLabel;
        private System.Windows.Forms.Label WidthRectanglePanelLabel;
        private System.Windows.Forms.Label YRectanglePanelLable;
        private System.Windows.Forms.Label XRectanglePanelLabel;
        private System.Windows.Forms.Label IdRectanglePanelLabel;
        private System.Windows.Forms.Label SelectedRectangleLabel;
        private System.Windows.Forms.Button RemoveRectanglesButton;
        private System.Windows.Forms.Button AddRectanglesButton;
        private System.Windows.Forms.Label RectanglesPanelLabel;
        private System.Windows.Forms.ListBox RectanglesPanelListBox;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}
