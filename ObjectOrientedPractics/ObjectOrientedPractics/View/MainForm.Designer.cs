﻿namespace ObjectOrientedPractics
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.PriorityOrdersTab = new ObjectOrientedPractics.View.Tabs.PriorityOrdersTab();
            this.OrdersTabPage = new System.Windows.Forms.TabPage();
            this.OrdersTab = new ObjectOrientedPractics.View.Tabs.OrdersTab();
            this.CartsTabPage = new System.Windows.Forms.TabPage();
            this.CartsTab = new ObjectOrientedPractics.View.Tabs.CartsTab();
            this.CustomersTabPage = new System.Windows.Forms.TabPage();
            this.CustomersTab = new ObjectOrientedPractics.View.Tabs.CustomersTab();
            this.ItemsTabPage = new System.Windows.Forms.TabPage();
            this.ItemsTab = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            this.ItemsTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.OrdersTabPage.SuspendLayout();
            this.CartsTabPage.SuspendLayout();
            this.CustomersTabPage.SuspendLayout();
            this.ItemsTabPage.SuspendLayout();
            this.ItemsTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.PriorityOrdersTab);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(877, 500);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Test Priority Order";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // PriorityOrdersTab
            // 
            this.PriorityOrdersTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriorityOrdersTab.Location = new System.Drawing.Point(3, 3);
            this.PriorityOrdersTab.Name = "PriorityOrdersTab";
            this.PriorityOrdersTab.Size = new System.Drawing.Size(871, 494);
            this.PriorityOrdersTab.TabIndex = 0;
            // 
            // OrdersTabPage
            // 
            this.OrdersTabPage.Controls.Add(this.OrdersTab);
            this.OrdersTabPage.Location = new System.Drawing.Point(4, 25);
            this.OrdersTabPage.Name = "OrdersTabPage";
            this.OrdersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.OrdersTabPage.Size = new System.Drawing.Size(877, 500);
            this.OrdersTabPage.TabIndex = 3;
            this.OrdersTabPage.Text = "Orders";
            this.OrdersTabPage.UseVisualStyleBackColor = true;
            // 
            // OrdersTab
            // 
            this.OrdersTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdersTab.Location = new System.Drawing.Point(3, 3);
            this.OrdersTab.Name = "OrdersTab";
            this.OrdersTab.Size = new System.Drawing.Size(871, 494);
            this.OrdersTab.TabIndex = 0;
            // 
            // CartsTabPage
            // 
            this.CartsTabPage.Controls.Add(this.CartsTab);
            this.CartsTabPage.Location = new System.Drawing.Point(4, 25);
            this.CartsTabPage.Name = "CartsTabPage";
            this.CartsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CartsTabPage.Size = new System.Drawing.Size(877, 500);
            this.CartsTabPage.TabIndex = 2;
            this.CartsTabPage.Text = "Carts";
            this.CartsTabPage.UseVisualStyleBackColor = true;
            // 
            // CartsTab
            // 
            this.CartsTab.Customers = null;
            this.CartsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartsTab.Items = null;
            this.CartsTab.Location = new System.Drawing.Point(3, 3);
            this.CartsTab.Name = "CartsTab";
            this.CartsTab.Size = new System.Drawing.Size(871, 494);
            this.CartsTab.TabIndex = 0;
            // 
            // CustomersTabPage
            // 
            this.CustomersTabPage.Controls.Add(this.CustomersTab);
            this.CustomersTabPage.Location = new System.Drawing.Point(4, 25);
            this.CustomersTabPage.Name = "CustomersTabPage";
            this.CustomersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CustomersTabPage.Size = new System.Drawing.Size(877, 500);
            this.CustomersTabPage.TabIndex = 1;
            this.CustomersTabPage.Text = "Customers";
            this.CustomersTabPage.UseVisualStyleBackColor = true;
            // 
            // CustomersTab
            // 
            this.CustomersTab.Customers = null;
            this.CustomersTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersTab.Location = new System.Drawing.Point(3, 3);
            this.CustomersTab.Name = "CustomersTab";
            this.CustomersTab.Size = new System.Drawing.Size(871, 494);
            this.CustomersTab.TabIndex = 0;
            // 
            // ItemsTabPage
            // 
            this.ItemsTabPage.Controls.Add(this.ItemsTab);
            this.ItemsTabPage.Location = new System.Drawing.Point(4, 25);
            this.ItemsTabPage.Name = "ItemsTabPage";
            this.ItemsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ItemsTabPage.Size = new System.Drawing.Size(877, 500);
            this.ItemsTabPage.TabIndex = 0;
            this.ItemsTabPage.Text = "Items";
            this.ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // ItemsTab
            // 
            this.ItemsTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsTab.Items = null;
            this.ItemsTab.Location = new System.Drawing.Point(3, 3);
            this.ItemsTab.Name = "ItemsTab";
            this.ItemsTab.Size = new System.Drawing.Size(871, 494);
            this.ItemsTab.TabIndex = 0;
            // 
            // ItemsTabControl
            // 
            this.ItemsTabControl.Controls.Add(this.ItemsTabPage);
            this.ItemsTabControl.Controls.Add(this.CustomersTabPage);
            this.ItemsTabControl.Controls.Add(this.CartsTabPage);
            this.ItemsTabControl.Controls.Add(this.OrdersTabPage);
            this.ItemsTabControl.Controls.Add(this.tabPage1);
            this.ItemsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsTabControl.Location = new System.Drawing.Point(0, 0);
            this.ItemsTabControl.Name = "ItemsTabControl";
            this.ItemsTabControl.SelectedIndex = 0;
            this.ItemsTabControl.Size = new System.Drawing.Size(885, 529);
            this.ItemsTabControl.TabIndex = 0;
            this.ItemsTabControl.SelectedIndexChanged += new System.EventHandler(this.ItemsTabControl_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 529);
            this.Controls.Add(this.ItemsTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Object Oriented Practics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tabPage1.ResumeLayout(false);
            this.OrdersTabPage.ResumeLayout(false);
            this.CartsTabPage.ResumeLayout(false);
            this.CustomersTabPage.ResumeLayout(false);
            this.ItemsTabPage.ResumeLayout(false);
            this.ItemsTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private View.Tabs.PriorityOrdersTab PriorityOrdersTab;
        private System.Windows.Forms.TabPage OrdersTabPage;
        private View.Tabs.OrdersTab OrdersTab;
        private System.Windows.Forms.TabPage CartsTabPage;
        private View.Tabs.CartsTab CartsTab;
        private System.Windows.Forms.TabPage CustomersTabPage;
        private View.Tabs.CustomersTab CustomersTab;
        private System.Windows.Forms.TabPage ItemsTabPage;
        private View.Tabs.ItemsTab ItemsTab;
        private System.Windows.Forms.TabControl ItemsTabControl;
    }
}

