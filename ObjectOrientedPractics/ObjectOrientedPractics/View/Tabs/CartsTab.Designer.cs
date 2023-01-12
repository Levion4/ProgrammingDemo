namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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
            this.CustomerCartComboBox = new System.Windows.Forms.ComboBox();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.CustomerCartLabel = new System.Windows.Forms.Label();
            this.CreateOrderButton = new System.Windows.Forms.Button();
            this.CartLabel = new System.Windows.Forms.Label();
            this.ItemsCartListBox = new System.Windows.Forms.ListBox();
            this.ItemsCartLabel = new System.Windows.Forms.Label();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.ClearCartButton = new System.Windows.Forms.Button();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.AmountNumberLabel = new System.Windows.Forms.Label();
            this.CartListBox = new System.Windows.Forms.ListBox();
            this.DiscountsLabel = new System.Windows.Forms.Label();
            this.DiscountAmountNumberLabel = new System.Windows.Forms.Label();
            this.DiscountAmountLabel = new System.Windows.Forms.Label();
            this.DiscountsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.TOTALNumberLabel = new System.Windows.Forms.Label();
            this.TOTALLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CustomerCartComboBox
            // 
            this.CustomerCartComboBox.FormattingEnabled = true;
            this.CustomerCartComboBox.Location = new System.Drawing.Point(406, 31);
            this.CustomerCartComboBox.Name = "CustomerCartComboBox";
            this.CustomerCartComboBox.Size = new System.Drawing.Size(462, 24);
            this.CustomerCartComboBox.TabIndex = 27;
            this.CustomerCartComboBox.SelectedIndexChanged += new System.EventHandler(this.CustomerCartComboBox_SelectedIndexChanged);
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Location = new System.Drawing.Point(660, 282);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(101, 50);
            this.RemoveItemButton.TabIndex = 25;
            this.RemoveItemButton.Text = "Remove Item";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // CustomerCartLabel
            // 
            this.CustomerCartLabel.AutoSize = true;
            this.CustomerCartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomerCartLabel.Location = new System.Drawing.Point(324, 34);
            this.CustomerCartLabel.Name = "CustomerCartLabel";
            this.CustomerCartLabel.Size = new System.Drawing.Size(76, 16);
            this.CustomerCartLabel.TabIndex = 12;
            this.CustomerCartLabel.Text = "Customer:";
            // 
            // CreateOrderButton
            // 
            this.CreateOrderButton.Location = new System.Drawing.Point(327, 282);
            this.CreateOrderButton.Name = "CreateOrderButton";
            this.CreateOrderButton.Size = new System.Drawing.Size(101, 50);
            this.CreateOrderButton.TabIndex = 19;
            this.CreateOrderButton.Text = "Create Order";
            this.CreateOrderButton.UseVisualStyleBackColor = true;
            this.CreateOrderButton.Click += new System.EventHandler(this.CreateOrderButton_Click);
            // 
            // CartLabel
            // 
            this.CartLabel.AutoSize = true;
            this.CartLabel.Location = new System.Drawing.Point(324, 64);
            this.CartLabel.Name = "CartLabel";
            this.CartLabel.Size = new System.Drawing.Size(34, 16);
            this.CartLabel.TabIndex = 20;
            this.CartLabel.Text = "Cart:";
            // 
            // ItemsCartListBox
            // 
            this.ItemsCartListBox.FormattingEnabled = true;
            this.ItemsCartListBox.ItemHeight = 16;
            this.ItemsCartListBox.Location = new System.Drawing.Point(3, 31);
            this.ItemsCartListBox.Name = "ItemsCartListBox";
            this.ItemsCartListBox.Size = new System.Drawing.Size(315, 404);
            this.ItemsCartListBox.TabIndex = 13;
            // 
            // ItemsCartLabel
            // 
            this.ItemsCartLabel.AutoSize = true;
            this.ItemsCartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemsCartLabel.Location = new System.Drawing.Point(3, 12);
            this.ItemsCartLabel.Name = "ItemsCartLabel";
            this.ItemsCartLabel.Size = new System.Drawing.Size(44, 16);
            this.ItemsCartLabel.TabIndex = 15;
            this.ItemsCartLabel.Text = "Items";
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.Location = new System.Drawing.Point(3, 441);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(101, 50);
            this.AddToCartButton.TabIndex = 18;
            this.AddToCartButton.Text = "Add To Cart";
            this.AddToCartButton.UseVisualStyleBackColor = true;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // ClearCartButton
            // 
            this.ClearCartButton.Location = new System.Drawing.Point(767, 282);
            this.ClearCartButton.Name = "ClearCartButton";
            this.ClearCartButton.Size = new System.Drawing.Size(101, 50);
            this.ClearCartButton.TabIndex = 28;
            this.ClearCartButton.Text = "Clear Cart";
            this.ClearCartButton.UseVisualStyleBackColor = true;
            this.ClearCartButton.Click += new System.EventHandler(this.ClearCartButton_Click);
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountLabel.Location = new System.Drawing.Point(796, 234);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(62, 16);
            this.AmountLabel.TabIndex = 29;
            this.AmountLabel.Text = "Amount:";
            // 
            // AmountNumberLabel
            // 
            this.AmountNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountNumberLabel.Location = new System.Drawing.Point(747, 250);
            this.AmountNumberLabel.Name = "AmountNumberLabel";
            this.AmountNumberLabel.Size = new System.Drawing.Size(111, 29);
            this.AmountNumberLabel.TabIndex = 30;
            this.AmountNumberLabel.Text = "0";
            this.AmountNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CartListBox
            // 
            this.CartListBox.FormattingEnabled = true;
            this.CartListBox.ItemHeight = 16;
            this.CartListBox.Location = new System.Drawing.Point(327, 83);
            this.CartListBox.Name = "CartListBox";
            this.CartListBox.Size = new System.Drawing.Size(541, 148);
            this.CartListBox.TabIndex = 31;
            // 
            // DiscountsLabel
            // 
            this.DiscountsLabel.AutoSize = true;
            this.DiscountsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountsLabel.Location = new System.Drawing.Point(324, 345);
            this.DiscountsLabel.Name = "DiscountsLabel";
            this.DiscountsLabel.Size = new System.Drawing.Size(79, 16);
            this.DiscountsLabel.TabIndex = 32;
            this.DiscountsLabel.Text = "Discounts:";
            // 
            // DiscountAmountNumberLabel
            // 
            this.DiscountAmountNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountAmountNumberLabel.Location = new System.Drawing.Point(747, 364);
            this.DiscountAmountNumberLabel.Name = "DiscountAmountNumberLabel";
            this.DiscountAmountNumberLabel.Size = new System.Drawing.Size(111, 29);
            this.DiscountAmountNumberLabel.TabIndex = 34;
            this.DiscountAmountNumberLabel.Text = "0";
            this.DiscountAmountNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DiscountAmountLabel
            // 
            this.DiscountAmountLabel.AutoSize = true;
            this.DiscountAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountAmountLabel.Location = new System.Drawing.Point(732, 345);
            this.DiscountAmountLabel.Name = "DiscountAmountLabel";
            this.DiscountAmountLabel.Size = new System.Drawing.Size(126, 16);
            this.DiscountAmountLabel.TabIndex = 33;
            this.DiscountAmountLabel.Text = "Discount Amount:";
            // 
            // DiscountsCheckedListBox
            // 
            this.DiscountsCheckedListBox.BackColor = System.Drawing.SystemColors.Window;
            this.DiscountsCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DiscountsCheckedListBox.CheckOnClick = true;
            this.DiscountsCheckedListBox.FormattingEnabled = true;
            this.DiscountsCheckedListBox.Location = new System.Drawing.Point(327, 364);
            this.DiscountsCheckedListBox.Name = "DiscountsCheckedListBox";
            this.DiscountsCheckedListBox.Size = new System.Drawing.Size(345, 119);
            this.DiscountsCheckedListBox.TabIndex = 35;
            this.DiscountsCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.DiscountsCheckedListBox_SelectedIndexChanged);
            // 
            // TOTALNumberLabel
            // 
            this.TOTALNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TOTALNumberLabel.Location = new System.Drawing.Point(747, 462);
            this.TOTALNumberLabel.Name = "TOTALNumberLabel";
            this.TOTALNumberLabel.Size = new System.Drawing.Size(111, 29);
            this.TOTALNumberLabel.TabIndex = 37;
            this.TOTALNumberLabel.Text = "0";
            this.TOTALNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TOTALLabel
            // 
            this.TOTALLabel.AutoSize = true;
            this.TOTALLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TOTALLabel.Location = new System.Drawing.Point(798, 446);
            this.TOTALLabel.Name = "TOTALLabel";
            this.TOTALLabel.Size = new System.Drawing.Size(60, 16);
            this.TOTALLabel.TabIndex = 36;
            this.TOTALLabel.Text = "TOTAL:";
            // 
            // CartsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TOTALNumberLabel);
            this.Controls.Add(this.TOTALLabel);
            this.Controls.Add(this.DiscountsCheckedListBox);
            this.Controls.Add(this.DiscountAmountNumberLabel);
            this.Controls.Add(this.DiscountAmountLabel);
            this.Controls.Add(this.DiscountsLabel);
            this.Controls.Add(this.CartListBox);
            this.Controls.Add(this.AmountNumberLabel);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.ClearCartButton);
            this.Controls.Add(this.CustomerCartComboBox);
            this.Controls.Add(this.RemoveItemButton);
            this.Controls.Add(this.CustomerCartLabel);
            this.Controls.Add(this.CreateOrderButton);
            this.Controls.Add(this.CartLabel);
            this.Controls.Add(this.ItemsCartListBox);
            this.Controls.Add(this.ItemsCartLabel);
            this.Controls.Add(this.AddToCartButton);
            this.Name = "CartsTab";
            this.Size = new System.Drawing.Size(871, 494);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CustomerCartComboBox;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.Label CustomerCartLabel;
        private System.Windows.Forms.Button CreateOrderButton;
        private System.Windows.Forms.Label CartLabel;
        private System.Windows.Forms.ListBox ItemsCartListBox;
        private System.Windows.Forms.Label ItemsCartLabel;
        private System.Windows.Forms.Button AddToCartButton;
        private System.Windows.Forms.Button ClearCartButton;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label AmountNumberLabel;
        private System.Windows.Forms.ListBox CartListBox;
        private System.Windows.Forms.Label DiscountsLabel;
        private System.Windows.Forms.Label DiscountAmountNumberLabel;
        private System.Windows.Forms.Label DiscountAmountLabel;
        private System.Windows.Forms.CheckedListBox DiscountsCheckedListBox;
        private System.Windows.Forms.Label TOTALNumberLabel;
        private System.Windows.Forms.Label TOTALLabel;
    }
}
