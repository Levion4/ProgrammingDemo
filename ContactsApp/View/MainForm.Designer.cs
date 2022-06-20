
namespace ContactsApp.View
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ContactsListBox = new System.Windows.Forms.ListBox();
            this.SelectedContactGroupBox = new System.Windows.Forms.GroupBox();
            this.VKTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.DateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.VKLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.RemoveContactButton = new System.Windows.Forms.Button();
            this.AddContactButton = new System.Windows.Forms.Button();
            this.SelectedContactGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContactsListBox
            // 
            this.ContactsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactsListBox.FormattingEnabled = true;
            this.ContactsListBox.Location = new System.Drawing.Point(12, 12);
            this.ContactsListBox.Name = "ContactsListBox";
            this.ContactsListBox.Size = new System.Drawing.Size(242, 394);
            this.ContactsListBox.TabIndex = 0;
            this.ContactsListBox.SelectedIndexChanged += new System.EventHandler(this.ContactsListBox_SelectedIndexChanged);
            // 
            // SelectedContactGroupBox
            // 
            this.SelectedContactGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedContactGroupBox.Controls.Add(this.VKTextBox);
            this.SelectedContactGroupBox.Controls.Add(this.PhoneTextBox);
            this.SelectedContactGroupBox.Controls.Add(this.DateOfBirthDateTimePicker);
            this.SelectedContactGroupBox.Controls.Add(this.FullNameTextBox);
            this.SelectedContactGroupBox.Controls.Add(this.VKLabel);
            this.SelectedContactGroupBox.Controls.Add(this.PhoneLabel);
            this.SelectedContactGroupBox.Controls.Add(this.DateOfBirthLabel);
            this.SelectedContactGroupBox.Controls.Add(this.FullNameLabel);
            this.SelectedContactGroupBox.Location = new System.Drawing.Point(260, 12);
            this.SelectedContactGroupBox.Name = "SelectedContactGroupBox";
            this.SelectedContactGroupBox.Size = new System.Drawing.Size(528, 123);
            this.SelectedContactGroupBox.TabIndex = 1;
            this.SelectedContactGroupBox.TabStop = false;
            this.SelectedContactGroupBox.Text = "Selected Contact";
            // 
            // VKTextBox
            // 
            this.VKTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.VKTextBox.Location = new System.Drawing.Point(81, 97);
            this.VKTextBox.Name = "VKTextBox";
            this.VKTextBox.Size = new System.Drawing.Size(200, 20);
            this.VKTextBox.TabIndex = 7;
            this.VKTextBox.TextChanged += new System.EventHandler(this.VKTextBox_TextChanged);
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.PhoneTextBox.Location = new System.Drawing.Point(81, 71);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.PhoneTextBox.TabIndex = 6;
            this.PhoneTextBox.TextChanged += new System.EventHandler(this.PhoneTextBox_TextChanged);
            // 
            // DateOfBirthDateTimePicker
            // 
            this.DateOfBirthDateTimePicker.Location = new System.Drawing.Point(81, 45);
            this.DateOfBirthDateTimePicker.Name = "DateOfBirthDateTimePicker";
            this.DateOfBirthDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DateOfBirthDateTimePicker.TabIndex = 5;
            this.DateOfBirthDateTimePicker.Value = new System.DateTime(2022, 6, 10, 0, 0, 0, 0);
            this.DateOfBirthDateTimePicker.ValueChanged += new System.EventHandler(this.DateOfBirthDateTimePicker_ValueChanged);
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.FullNameTextBox.Location = new System.Drawing.Point(81, 19);
            this.FullNameTextBox.MaxLength = 150;
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(441, 20);
            this.FullNameTextBox.TabIndex = 4;
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            this.FullNameTextBox.Leave += new System.EventHandler(this.FullNameTextBox_Leave);
            // 
            // VKLabel
            // 
            this.VKLabel.AutoSize = true;
            this.VKLabel.Location = new System.Drawing.Point(30, 100);
            this.VKLabel.Name = "VKLabel";
            this.VKLabel.Size = new System.Drawing.Size(45, 13);
            this.VKLabel.TabIndex = 3;
            this.VKLabel.Text = "vk.com:";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(34, 74);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(41, 13);
            this.PhoneLabel.TabIndex = 2;
            this.PhoneLabel.Text = "Phone:";
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(6, 48);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(69, 13);
            this.DateOfBirthLabel.TabIndex = 1;
            this.DateOfBirthLabel.Text = "Date of Birth:";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(18, 22);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FullNameLabel.TabIndex = 0;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // RemoveContactButton
            // 
            this.RemoveContactButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveContactButton.BackgroundImage = global::ContactsApp.Properties.Resources.contact_remove_24x24;
            this.RemoveContactButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.RemoveContactButton.FlatAppearance.BorderSize = 0;
            this.RemoveContactButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.RemoveContactButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.RemoveContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveContactButton.Location = new System.Drawing.Point(42, 412);
            this.RemoveContactButton.Name = "RemoveContactButton";
            this.RemoveContactButton.Size = new System.Drawing.Size(24, 24);
            this.RemoveContactButton.TabIndex = 3;
            this.RemoveContactButton.UseVisualStyleBackColor = true;
            this.RemoveContactButton.Click += new System.EventHandler(this.RemoveContactButton_Click);
            // 
            // AddContactButton
            // 
            this.AddContactButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddContactButton.BackgroundImage = global::ContactsApp.Properties.Resources.contact_add_24x24;
            this.AddContactButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddContactButton.FlatAppearance.BorderSize = 0;
            this.AddContactButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.AddContactButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.AddContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddContactButton.Location = new System.Drawing.Point(12, 412);
            this.AddContactButton.Name = "AddContactButton";
            this.AddContactButton.Size = new System.Drawing.Size(24, 24);
            this.AddContactButton.TabIndex = 2;
            this.AddContactButton.UseVisualStyleBackColor = true;
            this.AddContactButton.Click += new System.EventHandler(this.AddContactButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.RemoveContactButton);
            this.Controls.Add(this.AddContactButton);
            this.Controls.Add(this.SelectedContactGroupBox);
            this.Controls.Add(this.ContactsListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "ContactsApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SelectedContactGroupBox.ResumeLayout(false);
            this.SelectedContactGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ContactsListBox;
        private System.Windows.Forms.GroupBox SelectedContactGroupBox;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label VKLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.TextBox VKTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.DateTimePicker DateOfBirthDateTimePicker;
        private System.Windows.Forms.Button AddContactButton;
        private System.Windows.Forms.Button RemoveContactButton;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}

