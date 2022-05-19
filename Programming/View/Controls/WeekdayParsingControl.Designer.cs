
namespace Programming.View.Controls
{
    partial class WeekdayParsingControl
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
            this.ResultParseTextBox = new System.Windows.Forms.TextBox();
            this.WeekdayParsingButton = new System.Windows.Forms.Button();
            this.WeekdayParsingLabel = new System.Windows.Forms.Label();
            this.WeekdayParsingTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ResultParseTextBox
            // 
            this.ResultParseTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultParseTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ResultParseTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ResultParseTextBox.Location = new System.Drawing.Point(6, 43);
            this.ResultParseTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResultParseTextBox.Name = "ResultParseTextBox";
            this.ResultParseTextBox.Size = new System.Drawing.Size(237, 16);
            this.ResultParseTextBox.TabIndex = 7;
            // 
            // WeekdayParsingButton
            // 
            this.WeekdayParsingButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.WeekdayParsingButton.Location = new System.Drawing.Point(216, 21);
            this.WeekdayParsingButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WeekdayParsingButton.Name = "WeekdayParsingButton";
            this.WeekdayParsingButton.Size = new System.Drawing.Size(70, 19);
            this.WeekdayParsingButton.TabIndex = 6;
            this.WeekdayParsingButton.Text = "Parse";
            this.WeekdayParsingButton.UseVisualStyleBackColor = true;
            this.WeekdayParsingButton.Click += new System.EventHandler(this.WeekdayParsingButton_Click);
            // 
            // WeekdayParsingLabel
            // 
            this.WeekdayParsingLabel.AutoSize = true;
            this.WeekdayParsingLabel.Location = new System.Drawing.Point(2, 7);
            this.WeekdayParsingLabel.Name = "WeekdayParsingLabel";
            this.WeekdayParsingLabel.Size = new System.Drawing.Size(115, 13);
            this.WeekdayParsingLabel.TabIndex = 5;
            this.WeekdayParsingLabel.Text = "Type value for parsing:";
            // 
            // WeekdayParsingTextBox
            // 
            this.WeekdayParsingTextBox.Location = new System.Drawing.Point(3, 22);
            this.WeekdayParsingTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WeekdayParsingTextBox.Name = "WeekdayParsingTextBox";
            this.WeekdayParsingTextBox.Size = new System.Drawing.Size(211, 20);
            this.WeekdayParsingTextBox.TabIndex = 4;
            // 
            // WeekdayParsingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ResultParseTextBox);
            this.Controls.Add(this.WeekdayParsingButton);
            this.Controls.Add(this.WeekdayParsingLabel);
            this.Controls.Add(this.WeekdayParsingTextBox);
            this.Name = "WeekdayParsingControl";
            this.Size = new System.Drawing.Size(294, 69);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ResultParseTextBox;
        private System.Windows.Forms.Button WeekdayParsingButton;
        private System.Windows.Forms.Label WeekdayParsingLabel;
        private System.Windows.Forms.TextBox WeekdayParsingTextBox;
    }
}
