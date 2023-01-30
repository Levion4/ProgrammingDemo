namespace ObjectOrientedPractics.View.Tabs
{
    partial class DiscountsTab
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
            this.CalculateButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.ProductsAmountNumberLabel = new System.Windows.Forms.Label();
            this.ProductsAmountLabel = new System.Windows.Forms.Label();
            this.DiscountAmountNumberLabel = new System.Windows.Forms.Label();
            this.DiscountAmountLabel = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.InfoDiscountLabel = new System.Windows.Forms.Label();
            this.InfoDiscountPercentLabel = new System.Windows.Forms.Label();
            this.InfoPercentLabel = new System.Windows.Forms.Label();
            this.DiscountAmountPercentNumberLabel = new System.Windows.Forms.Label();
            this.DiscountAmountPercentLabel = new System.Windows.Forms.Label();
            this.CalculatePercentButton = new System.Windows.Forms.Button();
            this.UpdatePercentButton = new System.Windows.Forms.Button();
            this.ApplyPercentButton = new System.Windows.Forms.Button();
            this.ProductsAmountPercentNumberLabel = new System.Windows.Forms.Label();
            this.ProductsAmountPercentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(3, 67);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(101, 50);
            this.CalculateButton.TabIndex = 70;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(217, 67);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(101, 50);
            this.UpdateButton.TabIndex = 69;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(110, 67);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(101, 50);
            this.ApplyButton.TabIndex = 68;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // ProductsAmountNumberLabel
            // 
            this.ProductsAmountNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductsAmountNumberLabel.Location = new System.Drawing.Point(378, 64);
            this.ProductsAmountNumberLabel.Name = "ProductsAmountNumberLabel";
            this.ProductsAmountNumberLabel.Size = new System.Drawing.Size(111, 29);
            this.ProductsAmountNumberLabel.TabIndex = 67;
            this.ProductsAmountNumberLabel.Text = "0";
            this.ProductsAmountNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProductsAmountLabel
            // 
            this.ProductsAmountLabel.AutoSize = true;
            this.ProductsAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductsAmountLabel.Location = new System.Drawing.Point(362, 48);
            this.ProductsAmountLabel.Name = "ProductsAmountLabel";
            this.ProductsAmountLabel.Size = new System.Drawing.Size(127, 16);
            this.ProductsAmountLabel.TabIndex = 66;
            this.ProductsAmountLabel.Text = "Products Amount:";
            // 
            // DiscountAmountNumberLabel
            // 
            this.DiscountAmountNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountAmountNumberLabel.Location = new System.Drawing.Point(378, 109);
            this.DiscountAmountNumberLabel.Name = "DiscountAmountNumberLabel";
            this.DiscountAmountNumberLabel.Size = new System.Drawing.Size(111, 29);
            this.DiscountAmountNumberLabel.TabIndex = 72;
            this.DiscountAmountNumberLabel.Text = "0";
            this.DiscountAmountNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DiscountAmountLabel
            // 
            this.DiscountAmountLabel.AutoSize = true;
            this.DiscountAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountAmountLabel.Location = new System.Drawing.Point(362, 93);
            this.DiscountAmountLabel.Name = "DiscountAmountLabel";
            this.DiscountAmountLabel.Size = new System.Drawing.Size(126, 16);
            this.DiscountAmountLabel.TabIndex = 71;
            this.DiscountAmountLabel.Text = "Discount Amount:";
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLabel.Location = new System.Drawing.Point(3, 48);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(36, 16);
            this.InfoLabel.TabIndex = 73;
            this.InfoLabel.Text = "Info:";
            // 
            // InfoDiscountLabel
            // 
            this.InfoDiscountLabel.AutoSize = true;
            this.InfoDiscountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoDiscountLabel.Location = new System.Drawing.Point(45, 48);
            this.InfoDiscountLabel.Name = "InfoDiscountLabel";
            this.InfoDiscountLabel.Size = new System.Drawing.Size(201, 16);
            this.InfoDiscountLabel.TabIndex = 74;
            this.InfoDiscountLabel.Text = "Накопительная - 0 баллов";
            // 
            // InfoDiscountPercentLabel
            // 
            this.InfoDiscountPercentLabel.AutoSize = true;
            this.InfoDiscountPercentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoDiscountPercentLabel.Location = new System.Drawing.Point(45, 187);
            this.InfoDiscountPercentLabel.Name = "InfoDiscountPercentLabel";
            this.InfoDiscountPercentLabel.Size = new System.Drawing.Size(212, 16);
            this.InfoDiscountPercentLabel.TabIndex = 83;
            this.InfoDiscountPercentLabel.Text = "Процентная Категория - 1%";
            // 
            // InfoPercentLabel
            // 
            this.InfoPercentLabel.AutoSize = true;
            this.InfoPercentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoPercentLabel.Location = new System.Drawing.Point(3, 187);
            this.InfoPercentLabel.Name = "InfoPercentLabel";
            this.InfoPercentLabel.Size = new System.Drawing.Size(36, 16);
            this.InfoPercentLabel.TabIndex = 82;
            this.InfoPercentLabel.Text = "Info:";
            // 
            // DiscountAmountPercentNumberLabel
            // 
            this.DiscountAmountPercentNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountAmountPercentNumberLabel.Location = new System.Drawing.Point(378, 248);
            this.DiscountAmountPercentNumberLabel.Name = "DiscountAmountPercentNumberLabel";
            this.DiscountAmountPercentNumberLabel.Size = new System.Drawing.Size(111, 29);
            this.DiscountAmountPercentNumberLabel.TabIndex = 81;
            this.DiscountAmountPercentNumberLabel.Text = "0";
            this.DiscountAmountPercentNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DiscountAmountPercentLabel
            // 
            this.DiscountAmountPercentLabel.AutoSize = true;
            this.DiscountAmountPercentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountAmountPercentLabel.Location = new System.Drawing.Point(362, 232);
            this.DiscountAmountPercentLabel.Name = "DiscountAmountPercentLabel";
            this.DiscountAmountPercentLabel.Size = new System.Drawing.Size(126, 16);
            this.DiscountAmountPercentLabel.TabIndex = 80;
            this.DiscountAmountPercentLabel.Text = "Discount Amount:";
            // 
            // CalculatePercentButton
            // 
            this.CalculatePercentButton.Location = new System.Drawing.Point(3, 206);
            this.CalculatePercentButton.Name = "CalculatePercentButton";
            this.CalculatePercentButton.Size = new System.Drawing.Size(101, 50);
            this.CalculatePercentButton.TabIndex = 79;
            this.CalculatePercentButton.Text = "Calculate";
            this.CalculatePercentButton.UseVisualStyleBackColor = true;
            this.CalculatePercentButton.Click += new System.EventHandler(this.CalculatePercentButton_Click);
            // 
            // UpdatePercentButton
            // 
            this.UpdatePercentButton.Location = new System.Drawing.Point(217, 206);
            this.UpdatePercentButton.Name = "UpdatePercentButton";
            this.UpdatePercentButton.Size = new System.Drawing.Size(101, 50);
            this.UpdatePercentButton.TabIndex = 78;
            this.UpdatePercentButton.Text = "Update";
            this.UpdatePercentButton.UseVisualStyleBackColor = true;
            this.UpdatePercentButton.Click += new System.EventHandler(this.UpdatePercentButton_Click);
            // 
            // ApplyPercentButton
            // 
            this.ApplyPercentButton.Location = new System.Drawing.Point(110, 206);
            this.ApplyPercentButton.Name = "ApplyPercentButton";
            this.ApplyPercentButton.Size = new System.Drawing.Size(101, 50);
            this.ApplyPercentButton.TabIndex = 77;
            this.ApplyPercentButton.Text = "Apply";
            this.ApplyPercentButton.UseVisualStyleBackColor = true;
            this.ApplyPercentButton.Click += new System.EventHandler(this.ApplyPercentButton_Click);
            // 
            // ProductsAmountPercentNumberLabel
            // 
            this.ProductsAmountPercentNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductsAmountPercentNumberLabel.Location = new System.Drawing.Point(378, 203);
            this.ProductsAmountPercentNumberLabel.Name = "ProductsAmountPercentNumberLabel";
            this.ProductsAmountPercentNumberLabel.Size = new System.Drawing.Size(111, 29);
            this.ProductsAmountPercentNumberLabel.TabIndex = 76;
            this.ProductsAmountPercentNumberLabel.Text = "0";
            this.ProductsAmountPercentNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProductsAmountPercentLabel
            // 
            this.ProductsAmountPercentLabel.AutoSize = true;
            this.ProductsAmountPercentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductsAmountPercentLabel.Location = new System.Drawing.Point(362, 187);
            this.ProductsAmountPercentLabel.Name = "ProductsAmountPercentLabel";
            this.ProductsAmountPercentLabel.Size = new System.Drawing.Size(127, 16);
            this.ProductsAmountPercentLabel.TabIndex = 75;
            this.ProductsAmountPercentLabel.Text = "Products Amount:";
            // 
            // DiscountsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InfoDiscountPercentLabel);
            this.Controls.Add(this.InfoPercentLabel);
            this.Controls.Add(this.DiscountAmountPercentNumberLabel);
            this.Controls.Add(this.DiscountAmountPercentLabel);
            this.Controls.Add(this.CalculatePercentButton);
            this.Controls.Add(this.UpdatePercentButton);
            this.Controls.Add(this.ApplyPercentButton);
            this.Controls.Add(this.ProductsAmountPercentNumberLabel);
            this.Controls.Add(this.ProductsAmountPercentLabel);
            this.Controls.Add(this.InfoDiscountLabel);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.DiscountAmountNumberLabel);
            this.Controls.Add(this.DiscountAmountLabel);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.ProductsAmountNumberLabel);
            this.Controls.Add(this.ProductsAmountLabel);
            this.Name = "DiscountsTab";
            this.Size = new System.Drawing.Size(507, 296);
            this.Load += new System.EventHandler(this.DiscountsTab_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Label ProductsAmountNumberLabel;
        private System.Windows.Forms.Label ProductsAmountLabel;
        private System.Windows.Forms.Label DiscountAmountNumberLabel;
        private System.Windows.Forms.Label DiscountAmountLabel;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Label InfoDiscountLabel;
        private System.Windows.Forms.Label InfoDiscountPercentLabel;
        private System.Windows.Forms.Label InfoPercentLabel;
        private System.Windows.Forms.Label DiscountAmountPercentNumberLabel;
        private System.Windows.Forms.Label DiscountAmountPercentLabel;
        private System.Windows.Forms.Button CalculatePercentButton;
        private System.Windows.Forms.Button UpdatePercentButton;
        private System.Windows.Forms.Button ApplyPercentButton;
        private System.Windows.Forms.Label ProductsAmountPercentNumberLabel;
        private System.Windows.Forms.Label ProductsAmountPercentLabel;
    }
}
