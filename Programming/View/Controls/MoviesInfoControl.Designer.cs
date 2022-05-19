
namespace Programming.View.Controls
{
    partial class MoviesInfoControl
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
            this.RatingLabel = new System.Windows.Forms.Label();
            this.RatingTextBox = new System.Windows.Forms.TextBox();
            this.YearOfReleaseLabel = new System.Windows.Forms.Label();
            this.YearOfReleaseTextBox = new System.Windows.Forms.TextBox();
            this.MoviesButton = new System.Windows.Forms.Button();
            this.DurationInMinutesLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.DurationInMinutesTextBox = new System.Windows.Forms.TextBox();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MoviesListBox = new System.Windows.Forms.ListBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(168, 178);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(41, 13);
            this.RatingLabel.TabIndex = 23;
            this.RatingLabel.Text = "Rating:";
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Location = new System.Drawing.Point(168, 194);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(121, 20);
            this.RatingTextBox.TabIndex = 22;
            this.RatingTextBox.TextChanged += new System.EventHandler(this.RatingTextBox_TextChanged);
            // 
            // YearOfReleaseLabel
            // 
            this.YearOfReleaseLabel.AutoSize = true;
            this.YearOfReleaseLabel.Location = new System.Drawing.Point(168, 140);
            this.YearOfReleaseLabel.Name = "YearOfReleaseLabel";
            this.YearOfReleaseLabel.Size = new System.Drawing.Size(81, 13);
            this.YearOfReleaseLabel.TabIndex = 21;
            this.YearOfReleaseLabel.Text = "Year of release:";
            // 
            // YearOfReleaseTextBox
            // 
            this.YearOfReleaseTextBox.Location = new System.Drawing.Point(168, 156);
            this.YearOfReleaseTextBox.Name = "YearOfReleaseTextBox";
            this.YearOfReleaseTextBox.Size = new System.Drawing.Size(121, 20);
            this.YearOfReleaseTextBox.TabIndex = 20;
            this.YearOfReleaseTextBox.TextChanged += new System.EventHandler(this.YearOfReleaseTextBox_TextChanged);
            // 
            // MoviesButton
            // 
            this.MoviesButton.Location = new System.Drawing.Point(168, 312);
            this.MoviesButton.Name = "MoviesButton";
            this.MoviesButton.Size = new System.Drawing.Size(121, 20);
            this.MoviesButton.TabIndex = 19;
            this.MoviesButton.Text = "Find";
            this.MoviesButton.UseVisualStyleBackColor = true;
            this.MoviesButton.Click += new System.EventHandler(this.MoviesButton_Click);
            // 
            // DurationInMinutesLabel
            // 
            this.DurationInMinutesLabel.AutoSize = true;
            this.DurationInMinutesLabel.Location = new System.Drawing.Point(168, 102);
            this.DurationInMinutesLabel.Name = "DurationInMinutesLabel";
            this.DurationInMinutesLabel.Size = new System.Drawing.Size(100, 13);
            this.DurationInMinutesLabel.TabIndex = 18;
            this.DurationInMinutesLabel.Text = "Duration in minutes:";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(168, 64);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(39, 13);
            this.GenreLabel.TabIndex = 17;
            this.GenreLabel.Text = "Genre:";
            // 
            // DurationInMinutesTextBox
            // 
            this.DurationInMinutesTextBox.Location = new System.Drawing.Point(168, 117);
            this.DurationInMinutesTextBox.Name = "DurationInMinutesTextBox";
            this.DurationInMinutesTextBox.Size = new System.Drawing.Size(121, 20);
            this.DurationInMinutesTextBox.TabIndex = 16;
            this.DurationInMinutesTextBox.TextChanged += new System.EventHandler(this.DurationInMinutesTextBox_TextChanged);
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(168, 79);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(121, 20);
            this.GenreTextBox.TabIndex = 15;
            this.GenreTextBox.TextChanged += new System.EventHandler(this.GenreTextBox_TextChanged);
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(168, 19);
            this.TitleTextBox.Multiline = true;
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(121, 40);
            this.TitleTextBox.TabIndex = 14;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(168, 3);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(30, 13);
            this.TitleLabel.TabIndex = 13;
            this.TitleLabel.Text = "Title:";
            // 
            // MoviesListBox
            // 
            this.MoviesListBox.FormattingEnabled = true;
            this.MoviesListBox.Location = new System.Drawing.Point(3, 3);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesListBox.Size = new System.Drawing.Size(160, 329);
            this.MoviesListBox.TabIndex = 12;
            this.MoviesListBox.SelectedIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
            // 
            // MoviesInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RatingLabel);
            this.Controls.Add(this.RatingTextBox);
            this.Controls.Add(this.YearOfReleaseLabel);
            this.Controls.Add(this.YearOfReleaseTextBox);
            this.Controls.Add(this.MoviesButton);
            this.Controls.Add(this.DurationInMinutesLabel);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.DurationInMinutesTextBox);
            this.Controls.Add(this.GenreTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.MoviesListBox);
            this.Name = "MoviesInfoControl";
            this.Size = new System.Drawing.Size(297, 343);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.TextBox RatingTextBox;
        private System.Windows.Forms.Label YearOfReleaseLabel;
        private System.Windows.Forms.TextBox YearOfReleaseTextBox;
        private System.Windows.Forms.Button MoviesButton;
        private System.Windows.Forms.Label DurationInMinutesLabel;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.TextBox DurationInMinutesTextBox;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ListBox MoviesListBox;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}
