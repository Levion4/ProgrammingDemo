
namespace Programming.View
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.EnumsTabPage = new System.Windows.Forms.TabPage();
            this.SeasonHandleGroupBox = new System.Windows.Forms.GroupBox();
            this.WeekdayParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.EnumerationsGroupBox = new System.Windows.Forms.GroupBox();
            this.EnamsTabControl = new System.Windows.Forms.TabControl();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.MoviesGroupBox = new System.Windows.Forms.GroupBox();
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.RectanglesTabPage = new System.Windows.Forms.TabPage();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SeasonsHandleControl = new Programming.View.Controls.SeasonsHandleControl();
            this.WeekdayParsingControl = new Programming.View.Controls.WeekdayParsingControl();
            this.EnumerationsControl = new Programming.View.Controls.EnumerationsControl();
            this.MoviesInfoControl = new Programming.View.Controls.MoviesInfoControl();
            this.RectanglesInfoControl = new Programming.View.Controls.RectanglesInfoControl();
            this.RectanglesCollisionControl = new Programming.View.Controls.RectanglesCollisionControl();
            this.EnumsTabPage.SuspendLayout();
            this.SeasonHandleGroupBox.SuspendLayout();
            this.WeekdayParsingGroupBox.SuspendLayout();
            this.EnumerationsGroupBox.SuspendLayout();
            this.EnamsTabControl.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.MoviesGroupBox.SuspendLayout();
            this.RectanglesGroupBox.SuspendLayout();
            this.RectanglesTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumsTabPage
            // 
            this.EnumsTabPage.Controls.Add(this.SeasonHandleGroupBox);
            this.EnumsTabPage.Controls.Add(this.WeekdayParsingGroupBox);
            this.EnumsTabPage.Controls.Add(this.EnumerationsGroupBox);
            this.EnumsTabPage.Location = new System.Drawing.Point(4, 22);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnumsTabPage.Size = new System.Drawing.Size(654, 382);
            this.EnumsTabPage.TabIndex = 0;
            this.EnumsTabPage.Text = "Enums";
            this.EnumsTabPage.UseVisualStyleBackColor = true;
            // 
            // SeasonHandleGroupBox
            // 
            this.SeasonHandleGroupBox.Controls.Add(this.SeasonsHandleControl);
            this.SeasonHandleGroupBox.Location = new System.Drawing.Point(330, 257);
            this.SeasonHandleGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            this.SeasonHandleGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeasonHandleGroupBox.Size = new System.Drawing.Size(318, 120);
            this.SeasonHandleGroupBox.TabIndex = 5;
            this.SeasonHandleGroupBox.TabStop = false;
            this.SeasonHandleGroupBox.Text = "Season Handle ";
            // 
            // WeekdayParsingGroupBox
            // 
            this.WeekdayParsingGroupBox.Controls.Add(this.WeekdayParsingControl);
            this.WeekdayParsingGroupBox.Location = new System.Drawing.Point(7, 257);
            this.WeekdayParsingGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            this.WeekdayParsingGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WeekdayParsingGroupBox.Size = new System.Drawing.Size(320, 120);
            this.WeekdayParsingGroupBox.TabIndex = 4;
            this.WeekdayParsingGroupBox.TabStop = false;
            this.WeekdayParsingGroupBox.Text = "Weekday Parsing";
            // 
            // EnumerationsGroupBox
            // 
            this.EnumerationsGroupBox.Controls.Add(this.EnumerationsControl);
            this.EnumerationsGroupBox.Location = new System.Drawing.Point(7, 5);
            this.EnumerationsGroupBox.Name = "EnumerationsGroupBox";
            this.EnumerationsGroupBox.Size = new System.Drawing.Size(641, 248);
            this.EnumerationsGroupBox.TabIndex = 3;
            this.EnumerationsGroupBox.TabStop = false;
            this.EnumerationsGroupBox.Text = "Enumerations";
            // 
            // EnamsTabControl
            // 
            this.EnamsTabControl.Controls.Add(this.EnumsTabPage);
            this.EnamsTabControl.Controls.Add(this.ClassesTabPage);
            this.EnamsTabControl.Controls.Add(this.RectanglesTabPage);
            this.EnamsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnamsTabControl.Location = new System.Drawing.Point(0, 0);
            this.EnamsTabControl.Name = "EnamsTabControl";
            this.EnamsTabControl.SelectedIndex = 0;
            this.EnamsTabControl.Size = new System.Drawing.Size(662, 408);
            this.EnamsTabControl.TabIndex = 0;
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.MoviesGroupBox);
            this.ClassesTabPage.Controls.Add(this.RectanglesGroupBox);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 22);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClassesTabPage.Size = new System.Drawing.Size(654, 382);
            this.ClassesTabPage.TabIndex = 1;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // MoviesGroupBox
            // 
            this.MoviesGroupBox.Controls.Add(this.MoviesInfoControl);
            this.MoviesGroupBox.Location = new System.Drawing.Point(330, 5);
            this.MoviesGroupBox.Name = "MoviesGroupBox";
            this.MoviesGroupBox.Size = new System.Drawing.Size(318, 372);
            this.MoviesGroupBox.TabIndex = 1;
            this.MoviesGroupBox.TabStop = false;
            this.MoviesGroupBox.Text = "Movies";
            // 
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.Controls.Add(this.RectanglesInfoControl);
            this.RectanglesGroupBox.Location = new System.Drawing.Point(7, 5);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Size = new System.Drawing.Size(318, 372);
            this.RectanglesGroupBox.TabIndex = 0;
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Text = "Rectangles";
            // 
            // RectanglesTabPage
            // 
            this.RectanglesTabPage.Controls.Add(this.RectanglesCollisionControl);
            this.RectanglesTabPage.Location = new System.Drawing.Point(4, 22);
            this.RectanglesTabPage.Name = "RectanglesTabPage";
            this.RectanglesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RectanglesTabPage.Size = new System.Drawing.Size(654, 382);
            this.RectanglesTabPage.TabIndex = 2;
            this.RectanglesTabPage.Text = "Rectangles";
            this.RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // SeasonsHandleControl
            // 
            this.SeasonsHandleControl.Location = new System.Drawing.Point(6, 18);
            this.SeasonsHandleControl.Name = "SeasonsHandleControl";
            this.SeasonsHandleControl.Size = new System.Drawing.Size(294, 69);
            this.SeasonsHandleControl.TabIndex = 0;
            // 
            // WeekdayParsingControl
            // 
            this.WeekdayParsingControl.Location = new System.Drawing.Point(6, 18);
            this.WeekdayParsingControl.Name = "WeekdayParsingControl";
            this.WeekdayParsingControl.Size = new System.Drawing.Size(294, 69);
            this.WeekdayParsingControl.TabIndex = 0;
            // 
            // EnumerationsControl
            // 
            this.EnumerationsControl.Location = new System.Drawing.Point(6, 11);
            this.EnumerationsControl.Name = "EnumerationsControl";
            this.EnumerationsControl.Size = new System.Drawing.Size(429, 231);
            this.EnumerationsControl.TabIndex = 0;
            // 
            // MoviesInfoControl
            // 
            this.MoviesInfoControl.Location = new System.Drawing.Point(6, 23);
            this.MoviesInfoControl.Name = "MoviesInfoControl";
            this.MoviesInfoControl.Size = new System.Drawing.Size(312, 343);
            this.MoviesInfoControl.TabIndex = 0;
            // 
            // RectanglesInfoControl
            // 
            this.RectanglesInfoControl.Location = new System.Drawing.Point(6, 23);
            this.RectanglesInfoControl.Name = "RectanglesInfoControl";
            this.RectanglesInfoControl.Size = new System.Drawing.Size(306, 343);
            this.RectanglesInfoControl.TabIndex = 0;
            // 
            // RectanglesCollisionControl
            // 
            this.RectanglesCollisionControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectanglesCollisionControl.Location = new System.Drawing.Point(3, 3);
            this.RectanglesCollisionControl.Name = "RectanglesCollisionControl";
            this.RectanglesCollisionControl.Size = new System.Drawing.Size(648, 376);
            this.RectanglesCollisionControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 408);
            this.Controls.Add(this.EnamsTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Programming";
            this.EnumsTabPage.ResumeLayout(false);
            this.SeasonHandleGroupBox.ResumeLayout(false);
            this.WeekdayParsingGroupBox.ResumeLayout(false);
            this.EnumerationsGroupBox.ResumeLayout(false);
            this.EnamsTabControl.ResumeLayout(false);
            this.ClassesTabPage.ResumeLayout(false);
            this.MoviesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.ResumeLayout(false);
            this.RectanglesTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage EnumsTabPage;
        private System.Windows.Forms.GroupBox EnumerationsGroupBox;
        private System.Windows.Forms.TabControl EnamsTabControl;
        private System.Windows.Forms.GroupBox WeekdayParsingGroupBox;
        private System.Windows.Forms.GroupBox SeasonHandleGroupBox;
        private System.Windows.Forms.TabPage ClassesTabPage;
        private System.Windows.Forms.GroupBox RectanglesGroupBox;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.GroupBox MoviesGroupBox;
        private System.Windows.Forms.TabPage RectanglesTabPage;
        private Controls.RectanglesCollisionControl RectanglesCollisionControl;
        private Controls.EnumerationsControl EnumerationsControl;
        private Controls.WeekdayParsingControl WeekdayParsingControl;
        private Controls.SeasonsHandleControl SeasonsHandleControl;
        private Controls.MoviesInfoControl MoviesInfoControl;
        private Controls.RectanglesInfoControl RectanglesInfoControl;
    }
}