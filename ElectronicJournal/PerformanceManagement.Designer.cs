
namespace ElectronicJournal
{
    partial class PerformanceManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.PerformanceTabPage = new System.Windows.Forms.TabPage();
            this.RemovePerformanceButton = new System.Windows.Forms.Button();
            this.SelectPerformanceIDForDeletingComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AddNewRowButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaveChangeDataButton = new System.Windows.Forms.Button();
            this.DisciplineComboBox = new System.Windows.Forms.ComboBox();
            this.SearchFilterButton = new System.Windows.Forms.Button();
            this.ResetFilterButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.GroupComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CourseComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AssessmentComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StudentNumberPhoneTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PerformanceDataGridView = new System.Windows.Forms.DataGridView();
            this.PerformanceAnalisysTabPage = new System.Windows.Forms.TabPage();
            this.ResultPerformancesDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ShowAssessmentsInPercentCheckBox = new System.Windows.Forms.CheckBox();
            this.ResetFilterpButton = new System.Windows.Forms.Button();
            this.ShowResultButton = new System.Windows.Forms.Button();
            this.AllDisciplinesComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.AllSpecialtyComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.AllCoursesComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AllGroupsComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.StudentFullNameTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ClearFiltersButton = new System.Windows.Forms.Button();
            this.MainTabControl.SuspendLayout();
            this.PerformanceTabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PerformanceDataGridView)).BeginInit();
            this.PerformanceAnalisysTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultPerformancesDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.PerformanceTabPage);
            this.MainTabControl.Controls.Add(this.PerformanceAnalisysTabPage);
            this.MainTabControl.Location = new System.Drawing.Point(12, 12);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(685, 415);
            this.MainTabControl.TabIndex = 0;
            // 
            // PerformanceTabPage
            // 
            this.PerformanceTabPage.Controls.Add(this.RemovePerformanceButton);
            this.PerformanceTabPage.Controls.Add(this.SelectPerformanceIDForDeletingComboBox);
            this.PerformanceTabPage.Controls.Add(this.label6);
            this.PerformanceTabPage.Controls.Add(this.AddNewRowButton);
            this.PerformanceTabPage.Controls.Add(this.groupBox1);
            this.PerformanceTabPage.Controls.Add(this.PerformanceDataGridView);
            this.PerformanceTabPage.Location = new System.Drawing.Point(4, 24);
            this.PerformanceTabPage.Name = "PerformanceTabPage";
            this.PerformanceTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PerformanceTabPage.Size = new System.Drawing.Size(677, 387);
            this.PerformanceTabPage.TabIndex = 0;
            this.PerformanceTabPage.Text = "Успеваемость";
            this.PerformanceTabPage.UseVisualStyleBackColor = true;
            // 
            // RemovePerformanceButton
            // 
            this.RemovePerformanceButton.Location = new System.Drawing.Point(590, 207);
            this.RemovePerformanceButton.Name = "RemovePerformanceButton";
            this.RemovePerformanceButton.Size = new System.Drawing.Size(75, 23);
            this.RemovePerformanceButton.TabIndex = 17;
            this.RemovePerformanceButton.Text = "Удалить";
            this.RemovePerformanceButton.UseVisualStyleBackColor = true;
            this.RemovePerformanceButton.Click += new System.EventHandler(this.RemovePerformanceButton_Click);
            // 
            // SelectPerformanceIDForDeletingComboBox
            // 
            this.SelectPerformanceIDForDeletingComboBox.FormattingEnabled = true;
            this.SelectPerformanceIDForDeletingComboBox.Location = new System.Drawing.Point(525, 177);
            this.SelectPerformanceIDForDeletingComboBox.Name = "SelectPerformanceIDForDeletingComboBox";
            this.SelectPerformanceIDForDeletingComboBox.Size = new System.Drawing.Size(140, 23);
            this.SelectPerformanceIDForDeletingComboBox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(525, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Выберите успеваемость";
            // 
            // AddNewRowButton
            // 
            this.AddNewRowButton.Location = new System.Drawing.Point(6, 162);
            this.AddNewRowButton.Name = "AddNewRowButton";
            this.AddNewRowButton.Size = new System.Drawing.Size(107, 23);
            this.AddNewRowButton.TabIndex = 2;
            this.AddNewRowButton.Text = "Добавить строку";
            this.AddNewRowButton.UseVisualStyleBackColor = true;
            this.AddNewRowButton.Click += new System.EventHandler(this.AddNewRowButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClearFiltersButton);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.StudentFullNameTextBox);
            this.groupBox1.Controls.Add(this.SaveChangeDataButton);
            this.groupBox1.Controls.Add(this.DisciplineComboBox);
            this.groupBox1.Controls.Add(this.SearchFilterButton);
            this.groupBox1.Controls.Add(this.ResetFilterButton);
            this.groupBox1.Controls.Add(this.CloseButton);
            this.groupBox1.Controls.Add(this.GroupComboBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CourseComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.AssessmentComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.StudentNumberPhoneTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 141);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск по";
            // 
            // SaveChangeDataButton
            // 
            this.SaveChangeDataButton.Location = new System.Drawing.Point(338, 112);
            this.SaveChangeDataButton.Name = "SaveChangeDataButton";
            this.SaveChangeDataButton.Size = new System.Drawing.Size(75, 23);
            this.SaveChangeDataButton.TabIndex = 14;
            this.SaveChangeDataButton.Text = "Сохранить";
            this.SaveChangeDataButton.UseVisualStyleBackColor = true;
            this.SaveChangeDataButton.Click += new System.EventHandler(this.SaveChangeDataButton_Click);
            // 
            // DisciplineComboBox
            // 
            this.DisciplineComboBox.FormattingEnabled = true;
            this.DisciplineComboBox.Location = new System.Drawing.Point(238, 42);
            this.DisciplineComboBox.Name = "DisciplineComboBox";
            this.DisciplineComboBox.Size = new System.Drawing.Size(83, 23);
            this.DisciplineComboBox.TabIndex = 13;
            // 
            // SearchFilterButton
            // 
            this.SearchFilterButton.Location = new System.Drawing.Point(419, 112);
            this.SearchFilterButton.Name = "SearchFilterButton";
            this.SearchFilterButton.Size = new System.Drawing.Size(75, 23);
            this.SearchFilterButton.TabIndex = 12;
            this.SearchFilterButton.Text = "Поиск";
            this.SearchFilterButton.UseVisualStyleBackColor = true;
            this.SearchFilterButton.Click += new System.EventHandler(this.SearchFilterButton_Click);
            // 
            // ResetFilterButton
            // 
            this.ResetFilterButton.Location = new System.Drawing.Point(500, 112);
            this.ResetFilterButton.Name = "ResetFilterButton";
            this.ResetFilterButton.Size = new System.Drawing.Size(75, 23);
            this.ResetFilterButton.TabIndex = 11;
            this.ResetFilterButton.Text = "Сброс";
            this.ResetFilterButton.UseVisualStyleBackColor = true;
            this.ResetFilterButton.Click += new System.EventHandler(this.ResetFilterButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(581, 112);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 10;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // GroupComboBox
            // 
            this.GroupComboBox.FormattingEnabled = true;
            this.GroupComboBox.Location = new System.Drawing.Point(443, 42);
            this.GroupComboBox.Name = "GroupComboBox";
            this.GroupComboBox.Size = new System.Drawing.Size(46, 23);
            this.GroupComboBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(443, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Группа";
            // 
            // CourseComboBox
            // 
            this.CourseComboBox.FormattingEnabled = true;
            this.CourseComboBox.Location = new System.Drawing.Point(401, 42);
            this.CourseComboBox.Name = "CourseComboBox";
            this.CourseComboBox.Size = new System.Drawing.Size(32, 23);
            this.CourseComboBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Курс";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Оценка";
            // 
            // AssessmentComboBox
            // 
            this.AssessmentComboBox.FormattingEnabled = true;
            this.AssessmentComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.AssessmentComboBox.Location = new System.Drawing.Point(338, 42);
            this.AssessmentComboBox.Name = "AssessmentComboBox";
            this.AssessmentComboBox.Size = new System.Drawing.Size(48, 23);
            this.AssessmentComboBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дисциплинна";
            // 
            // StudentNumberPhoneTextBox
            // 
            this.StudentNumberPhoneTextBox.Location = new System.Drawing.Point(7, 42);
            this.StudentNumberPhoneTextBox.Name = "StudentNumberPhoneTextBox";
            this.StudentNumberPhoneTextBox.Size = new System.Drawing.Size(100, 23);
            this.StudentNumberPhoneTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Студент(номер)";
            // 
            // PerformanceDataGridView
            // 
            this.PerformanceDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PerformanceDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.PerformanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PerformanceDataGridView.Location = new System.Drawing.Point(3, 3);
            this.PerformanceDataGridView.Name = "PerformanceDataGridView";
            this.PerformanceDataGridView.RowHeadersVisible = false;
            this.PerformanceDataGridView.RowTemplate.Height = 25;
            this.PerformanceDataGridView.Size = new System.Drawing.Size(668, 152);
            this.PerformanceDataGridView.TabIndex = 0;
            // 
            // PerformanceAnalisysTabPage
            // 
            this.PerformanceAnalisysTabPage.Controls.Add(this.ResultPerformancesDataGridView);
            this.PerformanceAnalisysTabPage.Controls.Add(this.groupBox2);
            this.PerformanceAnalisysTabPage.Location = new System.Drawing.Point(4, 24);
            this.PerformanceAnalisysTabPage.Name = "PerformanceAnalisysTabPage";
            this.PerformanceAnalisysTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PerformanceAnalisysTabPage.Size = new System.Drawing.Size(677, 387);
            this.PerformanceAnalisysTabPage.TabIndex = 1;
            this.PerformanceAnalisysTabPage.Text = "Анализ успеваемости";
            this.PerformanceAnalisysTabPage.UseVisualStyleBackColor = true;
            // 
            // ResultPerformancesDataGridView
            // 
            this.ResultPerformancesDataGridView.AllowUserToAddRows = false;
            this.ResultPerformancesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ResultPerformancesDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ResultPerformancesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultPerformancesDataGridView.Location = new System.Drawing.Point(224, 16);
            this.ResultPerformancesDataGridView.Name = "ResultPerformancesDataGridView";
            this.ResultPerformancesDataGridView.RowHeadersVisible = false;
            this.ResultPerformancesDataGridView.Size = new System.Drawing.Size(447, 150);
            this.ResultPerformancesDataGridView.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ShowAssessmentsInPercentCheckBox);
            this.groupBox2.Controls.Add(this.ResetFilterpButton);
            this.groupBox2.Controls.Add(this.ShowResultButton);
            this.groupBox2.Controls.Add(this.AllDisciplinesComboBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.AllSpecialtyComboBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.AllCoursesComboBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.AllGroupsComboBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(7, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 374);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фильтры";
            // 
            // ShowAssessmentsInPercentCheckBox
            // 
            this.ShowAssessmentsInPercentCheckBox.AutoSize = true;
            this.ShowAssessmentsInPercentCheckBox.Location = new System.Drawing.Point(6, 245);
            this.ShowAssessmentsInPercentCheckBox.Name = "ShowAssessmentsInPercentCheckBox";
            this.ShowAssessmentsInPercentCheckBox.Size = new System.Drawing.Size(204, 19);
            this.ShowAssessmentsInPercentCheckBox.TabIndex = 10;
            this.ShowAssessmentsInPercentCheckBox.Text = "Показывать оценки в процентах";
            this.ShowAssessmentsInPercentCheckBox.UseVisualStyleBackColor = true;
            // 
            // ResetFilterpButton
            // 
            this.ResetFilterpButton.Location = new System.Drawing.Point(6, 345);
            this.ResetFilterpButton.Name = "ResetFilterpButton";
            this.ResetFilterpButton.Size = new System.Drawing.Size(75, 23);
            this.ResetFilterpButton.TabIndex = 9;
            this.ResetFilterpButton.Text = "Сброс";
            this.ResetFilterpButton.UseVisualStyleBackColor = true;
            this.ResetFilterpButton.Click += new System.EventHandler(this.ResetFilterpButton_Click);
            // 
            // ShowResultButton
            // 
            this.ShowResultButton.Location = new System.Drawing.Point(130, 345);
            this.ShowResultButton.Name = "ShowResultButton";
            this.ShowResultButton.Size = new System.Drawing.Size(75, 23);
            this.ShowResultButton.TabIndex = 8;
            this.ShowResultButton.Text = "Показать";
            this.ShowResultButton.UseVisualStyleBackColor = true;
            this.ShowResultButton.Click += new System.EventHandler(this.ShowResultButton_Click);
            // 
            // AllDisciplinesComboBox
            // 
            this.AllDisciplinesComboBox.FormattingEnabled = true;
            this.AllDisciplinesComboBox.Location = new System.Drawing.Point(7, 206);
            this.AllDisciplinesComboBox.Name = "AllDisciplinesComboBox";
            this.AllDisciplinesComboBox.Size = new System.Drawing.Size(92, 23);
            this.AllDisciplinesComboBox.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "Предмет";
            // 
            // AllSpecialtyComboBox
            // 
            this.AllSpecialtyComboBox.FormattingEnabled = true;
            this.AllSpecialtyComboBox.Location = new System.Drawing.Point(7, 154);
            this.AllSpecialtyComboBox.Name = "AllSpecialtyComboBox";
            this.AllSpecialtyComboBox.Size = new System.Drawing.Size(92, 23);
            this.AllSpecialtyComboBox.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "Специальность";
            // 
            // AllCoursesComboBox
            // 
            this.AllCoursesComboBox.FormattingEnabled = true;
            this.AllCoursesComboBox.Location = new System.Drawing.Point(7, 94);
            this.AllCoursesComboBox.Name = "AllCoursesComboBox";
            this.AllCoursesComboBox.Size = new System.Drawing.Size(95, 23);
            this.AllCoursesComboBox.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Курс";
            // 
            // AllGroupsComboBox
            // 
            this.AllGroupsComboBox.FormattingEnabled = true;
            this.AllGroupsComboBox.Location = new System.Drawing.Point(7, 42);
            this.AllGroupsComboBox.Name = "AllGroupsComboBox";
            this.AllGroupsComboBox.Size = new System.Drawing.Size(95, 23);
            this.AllGroupsComboBox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Группа";
            // 
            // StudentFullNameTextBox
            // 
            this.StudentFullNameTextBox.Location = new System.Drawing.Point(122, 42);
            this.StudentFullNameTextBox.Name = "StudentFullNameTextBox";
            this.StudentFullNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.StudentFullNameTextBox.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(119, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 15);
            this.label11.TabIndex = 16;
            this.label11.Text = "Студент(ФИО)";
            // 
            // ClearFiltersButton
            // 
            this.ClearFiltersButton.Location = new System.Drawing.Point(7, 71);
            this.ClearFiltersButton.Name = "ClearFiltersButton";
            this.ClearFiltersButton.Size = new System.Drawing.Size(75, 23);
            this.ClearFiltersButton.TabIndex = 17;
            this.ClearFiltersButton.Text = "Очистить";
            this.ClearFiltersButton.UseVisualStyleBackColor = true;
            this.ClearFiltersButton.Click += new System.EventHandler(this.ClearFiltersButton_Click);
            // 
            // PerformanceManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 432);
            this.Controls.Add(this.MainTabControl);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "PerformanceManagement";
            this.Text = "Управление успеваемостью";
            this.MainTabControl.ResumeLayout(false);
            this.PerformanceTabPage.ResumeLayout(false);
            this.PerformanceTabPage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PerformanceDataGridView)).EndInit();
            this.PerformanceAnalisysTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResultPerformancesDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage PerformanceTabPage;
        private System.Windows.Forms.DataGridView PerformanceDataGridView;
        private System.Windows.Forms.TabPage PerformanceAnalisysTabPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox GroupComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CourseComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox AssessmentComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StudentNumberPhoneTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button SearchFilterButton;
        private System.Windows.Forms.Button ResetFilterButton;
        private System.Windows.Forms.ComboBox DisciplineComboBox;
        private System.Windows.Forms.Button SaveChangeDataButton;
        private System.Windows.Forms.Button AddNewRowButton;
        private System.Windows.Forms.Button RemovePerformanceButton;
        private System.Windows.Forms.ComboBox SelectPerformanceIDForDeletingComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ResetFilterpButton;
        private System.Windows.Forms.Button ShowResultButton;
        private System.Windows.Forms.ComboBox AllDisciplinesComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox AllSpecialtyComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox AllCoursesComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox AllGroupsComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView ResultPerformancesDataGridView;
        private System.Windows.Forms.CheckBox ShowAssessmentsInPercentCheckBox;
        private System.Windows.Forms.TextBox StudentFullNameTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button ClearFiltersButton;
    }
}