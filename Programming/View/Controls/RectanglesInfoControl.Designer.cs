
namespace Programming.View.Controls
{
    partial class RectanglesInfoControl
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
            this.IdLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.CenterYLabel = new System.Windows.Forms.Label();
            this.CenterYTextBox = new System.Windows.Forms.TextBox();
            this.CenterXTextBox = new System.Windows.Forms.TextBox();
            this.CenterXLabel = new System.Windows.Forms.Label();
            this.RectanglesButton = new System.Windows.Forms.Button();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(168, 194);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(19, 13);
            this.IdLabel.TabIndex = 27;
            this.IdLabel.Text = "Id:";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(168, 209);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(121, 20);
            this.IdTextBox.TabIndex = 26;
            // 
            // CenterYLabel
            // 
            this.CenterYLabel.AutoSize = true;
            this.CenterYLabel.Location = new System.Drawing.Point(168, 156);
            this.CenterYLabel.Name = "CenterYLabel";
            this.CenterYLabel.Size = new System.Drawing.Size(51, 13);
            this.CenterYLabel.TabIndex = 25;
            this.CenterYLabel.Text = "Center Y:";
            // 
            // CenterYTextBox
            // 
            this.CenterYTextBox.Location = new System.Drawing.Point(168, 171);
            this.CenterYTextBox.Name = "CenterYTextBox";
            this.CenterYTextBox.ReadOnly = true;
            this.CenterYTextBox.Size = new System.Drawing.Size(122, 20);
            this.CenterYTextBox.TabIndex = 24;
            // 
            // CenterXTextBox
            // 
            this.CenterXTextBox.Location = new System.Drawing.Point(168, 133);
            this.CenterXTextBox.Name = "CenterXTextBox";
            this.CenterXTextBox.ReadOnly = true;
            this.CenterXTextBox.Size = new System.Drawing.Size(122, 20);
            this.CenterXTextBox.TabIndex = 23;
            // 
            // CenterXLabel
            // 
            this.CenterXLabel.AutoSize = true;
            this.CenterXLabel.Location = new System.Drawing.Point(168, 117);
            this.CenterXLabel.Name = "CenterXLabel";
            this.CenterXLabel.Size = new System.Drawing.Size(51, 13);
            this.CenterXLabel.TabIndex = 22;
            this.CenterXLabel.Text = "Center X:";
            // 
            // RectanglesButton
            // 
            this.RectanglesButton.Location = new System.Drawing.Point(168, 312);
            this.RectanglesButton.Name = "RectanglesButton";
            this.RectanglesButton.Size = new System.Drawing.Size(121, 20);
            this.RectanglesButton.TabIndex = 21;
            this.RectanglesButton.Text = "Find";
            this.RectanglesButton.UseVisualStyleBackColor = true;
            this.RectanglesButton.Click += new System.EventHandler(this.RectanglesButton_Click);
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(168, 79);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(34, 13);
            this.ColorLabel.TabIndex = 20;
            this.ColorLabel.Text = "Color:";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(168, 41);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(38, 13);
            this.WidthLabel.TabIndex = 19;
            this.WidthLabel.Text = "Width:";
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(168, 95);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(121, 20);
            this.ColorTextBox.TabIndex = 18;
            this.ColorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(168, 57);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(121, 20);
            this.WidthTextBox.TabIndex = 17;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(168, 19);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(121, 20);
            this.LengthTextBox.TabIndex = 16;
            this.LengthTextBox.TextChanged += new System.EventHandler(this.LengthTextBox_TextChanged);
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(168, 3);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(43, 13);
            this.LengthLabel.TabIndex = 15;
            this.LengthLabel.Text = "Length:";
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.Location = new System.Drawing.Point(3, 3);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(160, 329);
            this.RectanglesListBox.TabIndex = 14;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // RectanglesInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.CenterYLabel);
            this.Controls.Add(this.CenterYTextBox);
            this.Controls.Add(this.CenterXTextBox);
            this.Controls.Add(this.CenterXLabel);
            this.Controls.Add(this.RectanglesButton);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.ColorTextBox);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.LengthTextBox);
            this.Controls.Add(this.LengthLabel);
            this.Controls.Add(this.RectanglesListBox);
            this.Name = "RectanglesInfoControl";
            this.Size = new System.Drawing.Size(297, 343);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label CenterYLabel;
        private System.Windows.Forms.TextBox CenterYTextBox;
        private System.Windows.Forms.TextBox CenterXTextBox;
        private System.Windows.Forms.Label CenterXLabel;
        private System.Windows.Forms.Button RectanglesButton;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.ListBox RectanglesListBox;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}
