
namespace Programming.View.Controls
{
    partial class SeasonsHandleControl
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
            this.SeasonHandleСomboBox = new System.Windows.Forms.ComboBox();
            this.SeasonHandleLabel = new System.Windows.Forms.Label();
            this.SeasonHandleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SeasonHandleСomboBox
            // 
            this.SeasonHandleСomboBox.FormattingEnabled = true;
            this.SeasonHandleСomboBox.Location = new System.Drawing.Point(3, 21);
            this.SeasonHandleСomboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeasonHandleСomboBox.Name = "SeasonHandleСomboBox";
            this.SeasonHandleСomboBox.Size = new System.Drawing.Size(211, 21);
            this.SeasonHandleСomboBox.TabIndex = 9;
            // 
            // SeasonHandleLabel
            // 
            this.SeasonHandleLabel.AutoSize = true;
            this.SeasonHandleLabel.Location = new System.Drawing.Point(3, 6);
            this.SeasonHandleLabel.Name = "SeasonHandleLabel";
            this.SeasonHandleLabel.Size = new System.Drawing.Size(83, 13);
            this.SeasonHandleLabel.TabIndex = 8;
            this.SeasonHandleLabel.Text = "Choose season:";
            // 
            // SeasonHandleButton
            // 
            this.SeasonHandleButton.Location = new System.Drawing.Point(217, 20);
            this.SeasonHandleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeasonHandleButton.Name = "SeasonHandleButton";
            this.SeasonHandleButton.Size = new System.Drawing.Size(70, 19);
            this.SeasonHandleButton.TabIndex = 7;
            this.SeasonHandleButton.Text = "Go!";
            this.SeasonHandleButton.UseVisualStyleBackColor = true;
            this.SeasonHandleButton.Click += new System.EventHandler(this.SeasonHandleButton_Click);
            // 
            // SeasonsHandleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SeasonHandleСomboBox);
            this.Controls.Add(this.SeasonHandleLabel);
            this.Controls.Add(this.SeasonHandleButton);
            this.Name = "SeasonsHandleControl";
            this.Size = new System.Drawing.Size(294, 69);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SeasonHandleСomboBox;
        private System.Windows.Forms.Label SeasonHandleLabel;
        private System.Windows.Forms.Button SeasonHandleButton;
    }
}
