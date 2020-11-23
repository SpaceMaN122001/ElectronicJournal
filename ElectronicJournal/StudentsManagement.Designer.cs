
namespace ElectronicJournal
{
    partial class StudentsManagement
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
            this.StudentsDataGridView = new System.Windows.Forms.DataGridView();
            this.NumberPhoneTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DateOfBirthTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ApplyFilterButton = new System.Windows.Forms.Button();
            this.ResetFilterComboBox = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SaveChangeDataStudentButton = new System.Windows.Forms.Button();
            this.SpecialtyComboBox = new System.Windows.Forms.ComboBox();
            this.CourseComboBox = new System.Windows.Forms.ComboBox();
            this.GroupComboBox = new System.Windows.Forms.ComboBox();
            this.RemoveStudentButton = new System.Windows.Forms.Button();
            this.SelectSutdentForDeletingComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearFiltersButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentsDataGridView
            // 
            this.StudentsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentsDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.StudentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.StudentsDataGridView.Name = "StudentsDataGridView";
            this.StudentsDataGridView.RowHeadersVisible = false;
            this.StudentsDataGridView.RowTemplate.Height = 25;
            this.StudentsDataGridView.Size = new System.Drawing.Size(692, 195);
            this.StudentsDataGridView.TabIndex = 0;
            // 
            // NumberPhoneTextBox
            // 
            this.NumberPhoneTextBox.Location = new System.Drawing.Point(6, 40);
            this.NumberPhoneTextBox.Name = "NumberPhoneTextBox";
            this.NumberPhoneTextBox.Size = new System.Drawing.Size(101, 23);
            this.NumberPhoneTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Номер телефона";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "ФИО";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(113, 40);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(101, 23);
            this.FullNameTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Дата рождения";
            // 
            // DateOfBirthTextBox
            // 
            this.DateOfBirthTextBox.Location = new System.Drawing.Point(220, 40);
            this.DateOfBirthTextBox.Name = "DateOfBirthTextBox";
            this.DateOfBirthTextBox.Size = new System.Drawing.Size(90, 23);
            this.DateOfBirthTextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Группа";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(407, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Специальность";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(367, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Курс";
            // 
            // ApplyFilterButton
            // 
            this.ApplyFilterButton.Location = new System.Drawing.Point(370, 78);
            this.ApplyFilterButton.Name = "ApplyFilterButton";
            this.ApplyFilterButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyFilterButton.TabIndex = 14;
            this.ApplyFilterButton.Text = "Поиск";
            this.ApplyFilterButton.UseVisualStyleBackColor = true;
            this.ApplyFilterButton.Click += new System.EventHandler(this.ApplyFilterButton_Click);
            // 
            // ResetFilterComboBox
            // 
            this.ResetFilterComboBox.Location = new System.Drawing.Point(530, 78);
            this.ResetFilterComboBox.Name = "ResetFilterComboBox";
            this.ResetFilterComboBox.Size = new System.Drawing.Size(75, 23);
            this.ResetFilterComboBox.TabIndex = 15;
            this.ResetFilterComboBox.Text = "Сброс";
            this.ResetFilterComboBox.UseVisualStyleBackColor = true;
            this.ResetFilterComboBox.Click += new System.EventHandler(this.ResetFilterComboBox_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClearFiltersButton);
            this.groupBox1.Controls.Add(this.CloseButton);
            this.groupBox1.Controls.Add(this.SaveChangeDataStudentButton);
            this.groupBox1.Controls.Add(this.SpecialtyComboBox);
            this.groupBox1.Controls.Add(this.CourseComboBox);
            this.groupBox1.Controls.Add(this.GroupComboBox);
            this.groupBox1.Controls.Add(this.NumberPhoneTextBox);
            this.groupBox1.Controls.Add(this.ResetFilterComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ApplyFilterButton);
            this.groupBox1.Controls.Add(this.FullNameTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DateOfBirthTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(14, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 108);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск по";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(611, 78);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 20;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SaveChangeDataStudentButton
            // 
            this.SaveChangeDataStudentButton.Location = new System.Drawing.Point(451, 78);
            this.SaveChangeDataStudentButton.Name = "SaveChangeDataStudentButton";
            this.SaveChangeDataStudentButton.Size = new System.Drawing.Size(75, 23);
            this.SaveChangeDataStudentButton.TabIndex = 19;
            this.SaveChangeDataStudentButton.Text = "Сохранить";
            this.SaveChangeDataStudentButton.UseVisualStyleBackColor = true;
            this.SaveChangeDataStudentButton.Click += new System.EventHandler(this.SaveChangeDataStudentButton_Click);
            // 
            // SpecialtyComboBox
            // 
            this.SpecialtyComboBox.FormattingEnabled = true;
            this.SpecialtyComboBox.Location = new System.Drawing.Point(407, 40);
            this.SpecialtyComboBox.Name = "SpecialtyComboBox";
            this.SpecialtyComboBox.Size = new System.Drawing.Size(91, 23);
            this.SpecialtyComboBox.TabIndex = 18;
            // 
            // CourseComboBox
            // 
            this.CourseComboBox.FormattingEnabled = true;
            this.CourseComboBox.Location = new System.Drawing.Point(367, 40);
            this.CourseComboBox.Name = "CourseComboBox";
            this.CourseComboBox.Size = new System.Drawing.Size(33, 23);
            this.CourseComboBox.TabIndex = 17;
            // 
            // GroupComboBox
            // 
            this.GroupComboBox.FormattingEnabled = true;
            this.GroupComboBox.Location = new System.Drawing.Point(317, 38);
            this.GroupComboBox.Name = "GroupComboBox";
            this.GroupComboBox.Size = new System.Drawing.Size(45, 23);
            this.GroupComboBox.TabIndex = 16;
            // 
            // RemoveStudentButton
            // 
            this.RemoveStudentButton.Location = new System.Drawing.Point(631, 228);
            this.RemoveStudentButton.Name = "RemoveStudentButton";
            this.RemoveStudentButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveStudentButton.TabIndex = 20;
            this.RemoveStudentButton.Text = "Удалить";
            this.RemoveStudentButton.UseVisualStyleBackColor = true;
            this.RemoveStudentButton.Click += new System.EventHandler(this.RemoveStudentButton_Click);
            // 
            // SelectSutdentForDeletingComboBox
            // 
            this.SelectSutdentForDeletingComboBox.FormattingEnabled = true;
            this.SelectSutdentForDeletingComboBox.Location = new System.Drawing.Point(485, 230);
            this.SelectSutdentForDeletingComboBox.Name = "SelectSutdentForDeletingComboBox";
            this.SelectSutdentForDeletingComboBox.Size = new System.Drawing.Size(140, 23);
            this.SelectSutdentForDeletingComboBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(485, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Выберите студента";
            // 
            // ClearFiltersButton
            // 
            this.ClearFiltersButton.Location = new System.Drawing.Point(6, 78);
            this.ClearFiltersButton.Name = "ClearFiltersButton";
            this.ClearFiltersButton.Size = new System.Drawing.Size(75, 23);
            this.ClearFiltersButton.TabIndex = 21;
            this.ClearFiltersButton.Text = "Очистить";
            this.ClearFiltersButton.UseVisualStyleBackColor = true;
            this.ClearFiltersButton.Click += new System.EventHandler(this.ClearFiltersButton_Click);
            // 
            // StudentsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 378);
            this.Controls.Add(this.RemoveStudentButton);
            this.Controls.Add(this.SelectSutdentForDeletingComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StudentsDataGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StudentsManagement";
            this.Text = "Управление студентами";
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentsDataGridView;
        private System.Windows.Forms.TextBox NumberPhoneTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DateOfBirthTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ApplyFilterButton;
        private System.Windows.Forms.Button ResetFilterComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox SpecialtyComboBox;
        private System.Windows.Forms.ComboBox CourseComboBox;
        private System.Windows.Forms.ComboBox GroupComboBox;
        private System.Windows.Forms.Button SaveChangeDataStudentButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button RemoveStudentButton;
        private System.Windows.Forms.ComboBox SelectSutdentForDeletingComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClearFiltersButton;
    }
}