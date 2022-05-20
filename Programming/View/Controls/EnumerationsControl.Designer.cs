
namespace Programming.View.Controls
{
    partial class EnumerationsControl
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
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.ValuesLabel = new System.Windows.Forms.Label();
            this.EnumerationLabel = new System.Windows.Forms.Label();
            this.IntValueTextBox = new System.Windows.Forms.TextBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumerationListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(332, 9);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(51, 13);
            this.IntValueLabel.TabIndex = 11;
            this.IntValueLabel.Text = "Int value:";
            // 
            // ValuesLabel
            // 
            this.ValuesLabel.AutoSize = true;
            this.ValuesLabel.Location = new System.Drawing.Point(168, 9);
            this.ValuesLabel.Name = "ValuesLabel";
            this.ValuesLabel.Size = new System.Drawing.Size(75, 13);
            this.ValuesLabel.TabIndex = 10;
            this.ValuesLabel.Text = "Choose value:";
            // 
            // EnumerationLabel
            // 
            this.EnumerationLabel.AutoSize = true;
            this.EnumerationLabel.Location = new System.Drawing.Point(3, 9);
            this.EnumerationLabel.Name = "EnumerationLabel";
            this.EnumerationLabel.Size = new System.Drawing.Size(107, 13);
            this.EnumerationLabel.TabIndex = 9;
            this.EnumerationLabel.Text = "Choose enumeration:";
            // 
            // IntValueTextBox
            // 
            this.IntValueTextBox.Location = new System.Drawing.Point(332, 25);
            this.IntValueTextBox.Name = "IntValueTextBox";
            this.IntValueTextBox.Size = new System.Drawing.Size(86, 20);
            this.IntValueTextBox.TabIndex = 8;
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.Location = new System.Drawing.Point(168, 25);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.ScrollAlwaysVisible = true;
            this.ValuesListBox.Size = new System.Drawing.Size(160, 199);
            this.ValuesListBox.TabIndex = 7;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumerationListBox
            // 
            this.EnumerationListBox.FormattingEnabled = true;
            this.EnumerationListBox.Items.AddRange(new object[] {
            "Color",
            "Genre",
            "SmartphoneManufacturers",
            "StudentsFormOfStudy",
            "TimeOfYear",
            "Weekday"});
            this.EnumerationListBox.Location = new System.Drawing.Point(3, 25);
            this.EnumerationListBox.Name = "EnumerationListBox";
            this.EnumerationListBox.ScrollAlwaysVisible = true;
            this.EnumerationListBox.Size = new System.Drawing.Size(160, 199);
            this.EnumerationListBox.TabIndex = 6;
            this.EnumerationListBox.SelectedIndexChanged += new System.EventHandler(this.EnumerationListBox_SelectedIndexChanged);
            // 
            // EnumerationsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.IntValueLabel);
            this.Controls.Add(this.ValuesLabel);
            this.Controls.Add(this.EnumerationLabel);
            this.Controls.Add(this.IntValueTextBox);
            this.Controls.Add(this.ValuesListBox);
            this.Controls.Add(this.EnumerationListBox);
            this.Name = "EnumerationsControl";
            this.Size = new System.Drawing.Size(429, 244);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IntValueLabel;
        private System.Windows.Forms.Label ValuesLabel;
        private System.Windows.Forms.Label EnumerationLabel;
        private System.Windows.Forms.TextBox IntValueTextBox;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.ListBox EnumerationListBox;
    }
}
