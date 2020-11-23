
namespace ElectronicJournal
{
    partial class CollegeManagement
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
            this.GroupsTabPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ChangeGroupNumberButton = new System.Windows.Forms.Button();
            this.DeleteGroupButton = new System.Windows.Forms.Button();
            this.SpecialtyNameForChangeOrDeleteTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SelectGroupComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddGroupButton = new System.Windows.Forms.Button();
            this.GroupNumberForAddingTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SpecialtyTabPage = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ChangeSpecialtyNameButton = new System.Windows.Forms.Button();
            this.DeleteSpecialtyButton = new System.Windows.Forms.Button();
            this.SpecialtyNameForChangeAndDeleteTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SelectSpecialtyComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.AddSpecialtyButton = new System.Windows.Forms.Button();
            this.SpecialtyNameForAddingTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CoursesTabPage = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ChangeCourseNumberButton = new System.Windows.Forms.Button();
            this.DeleteCourseButton = new System.Windows.Forms.Button();
            this.CourseNumberTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SelectCourseForChangeAndDeleteComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.AddCourseButton = new System.Windows.Forms.Button();
            this.CourseNumberForAddingTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DisciplinesTabPage = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.ChangeDisciplineButton = new System.Windows.Forms.Button();
            this.DeleteDisciplineButton = new System.Windows.Forms.Button();
            this.DisciplineNameTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SelectDisciplineComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.AddDisciplineButton = new System.Windows.Forms.Button();
            this.DisciplineNameForAddingTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.MainTabControl.SuspendLayout();
            this.GroupsTabPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SpecialtyTabPage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.CoursesTabPage.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.DisciplinesTabPage.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTabControl.Controls.Add(this.GroupsTabPage);
            this.MainTabControl.Controls.Add(this.SpecialtyTabPage);
            this.MainTabControl.Controls.Add(this.CoursesTabPage);
            this.MainTabControl.Controls.Add(this.DisciplinesTabPage);
            this.MainTabControl.Location = new System.Drawing.Point(12, 12);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(595, 173);
            this.MainTabControl.TabIndex = 0;
            // 
            // GroupsTabPage
            // 
            this.GroupsTabPage.Controls.Add(this.groupBox2);
            this.GroupsTabPage.Controls.Add(this.groupBox1);
            this.GroupsTabPage.Location = new System.Drawing.Point(4, 24);
            this.GroupsTabPage.Name = "GroupsTabPage";
            this.GroupsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.GroupsTabPage.Size = new System.Drawing.Size(587, 145);
            this.GroupsTabPage.TabIndex = 0;
            this.GroupsTabPage.Text = "Группы";
            this.GroupsTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ChangeGroupNumberButton);
            this.groupBox2.Controls.Add(this.DeleteGroupButton);
            this.groupBox2.Controls.Add(this.SpecialtyNameForChangeOrDeleteTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.SelectGroupComboBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(337, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 110);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Удаление/Изменение";
            // 
            // ChangeGroupNumberButton
            // 
            this.ChangeGroupNumberButton.Location = new System.Drawing.Point(76, 77);
            this.ChangeGroupNumberButton.Name = "ChangeGroupNumberButton";
            this.ChangeGroupNumberButton.Size = new System.Drawing.Size(75, 23);
            this.ChangeGroupNumberButton.TabIndex = 6;
            this.ChangeGroupNumberButton.Text = "Изменить";
            this.ChangeGroupNumberButton.UseVisualStyleBackColor = true;
            this.ChangeGroupNumberButton.Click += new System.EventHandler(this.ChangeGroupNumberButton_Click);
            // 
            // DeleteGroupButton
            // 
            this.DeleteGroupButton.Location = new System.Drawing.Point(157, 77);
            this.DeleteGroupButton.Name = "DeleteGroupButton";
            this.DeleteGroupButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteGroupButton.TabIndex = 5;
            this.DeleteGroupButton.Text = "Удалить";
            this.DeleteGroupButton.UseVisualStyleBackColor = true;
            this.DeleteGroupButton.Click += new System.EventHandler(this.DeleteGroupButton_Click);
            // 
            // SpecialtyNameForChangeOrDeleteTextBox
            // 
            this.SpecialtyNameForChangeOrDeleteTextBox.Location = new System.Drawing.Point(126, 42);
            this.SpecialtyNameForChangeOrDeleteTextBox.Name = "SpecialtyNameForChangeOrDeleteTextBox";
            this.SpecialtyNameForChangeOrDeleteTextBox.Size = new System.Drawing.Size(89, 23);
            this.SpecialtyNameForChangeOrDeleteTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Номер группы";
            // 
            // SelectGroupComboBox
            // 
            this.SelectGroupComboBox.FormattingEnabled = true;
            this.SelectGroupComboBox.Location = new System.Drawing.Point(7, 42);
            this.SelectGroupComboBox.Name = "SelectGroupComboBox";
            this.SelectGroupComboBox.Size = new System.Drawing.Size(102, 23);
            this.SelectGroupComboBox.TabIndex = 1;
            this.SelectGroupComboBox.TextChanged += new System.EventHandler(this.SelectGroupComboBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Выберите группу";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddGroupButton);
            this.groupBox1.Controls.Add(this.GroupNumberForAddingTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить";
            // 
            // AddGroupButton
            // 
            this.AddGroupButton.Location = new System.Drawing.Point(149, 77);
            this.AddGroupButton.Name = "AddGroupButton";
            this.AddGroupButton.Size = new System.Drawing.Size(75, 23);
            this.AddGroupButton.TabIndex = 2;
            this.AddGroupButton.Text = "Добавить";
            this.AddGroupButton.UseVisualStyleBackColor = true;
            this.AddGroupButton.Click += new System.EventHandler(this.AddGroupButton_Click);
            // 
            // GroupNumberForAddingTextBox
            // 
            this.GroupNumberForAddingTextBox.Location = new System.Drawing.Point(7, 42);
            this.GroupNumberForAddingTextBox.Name = "GroupNumberForAddingTextBox";
            this.GroupNumberForAddingTextBox.Size = new System.Drawing.Size(133, 23);
            this.GroupNumberForAddingTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите номер группы";
            // 
            // SpecialtyTabPage
            // 
            this.SpecialtyTabPage.Controls.Add(this.groupBox3);
            this.SpecialtyTabPage.Controls.Add(this.groupBox4);
            this.SpecialtyTabPage.Location = new System.Drawing.Point(4, 24);
            this.SpecialtyTabPage.Name = "SpecialtyTabPage";
            this.SpecialtyTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SpecialtyTabPage.Size = new System.Drawing.Size(587, 139);
            this.SpecialtyTabPage.TabIndex = 1;
            this.SpecialtyTabPage.Text = "Специальности";
            this.SpecialtyTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ChangeSpecialtyNameButton);
            this.groupBox3.Controls.Add(this.DeleteSpecialtyButton);
            this.groupBox3.Controls.Add(this.SpecialtyNameForChangeAndDeleteTextBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.SelectSpecialtyComboBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(255, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(317, 110);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Удаление/Изменение";
            // 
            // ChangeSpecialtyNameButton
            // 
            this.ChangeSpecialtyNameButton.Location = new System.Drawing.Point(155, 81);
            this.ChangeSpecialtyNameButton.Name = "ChangeSpecialtyNameButton";
            this.ChangeSpecialtyNameButton.Size = new System.Drawing.Size(75, 23);
            this.ChangeSpecialtyNameButton.TabIndex = 6;
            this.ChangeSpecialtyNameButton.Text = "Изменить";
            this.ChangeSpecialtyNameButton.UseVisualStyleBackColor = true;
            this.ChangeSpecialtyNameButton.Click += new System.EventHandler(this.ChangeSpecialtyNameButton_Click);
            // 
            // DeleteSpecialtyButton
            // 
            this.DeleteSpecialtyButton.Location = new System.Drawing.Point(236, 81);
            this.DeleteSpecialtyButton.Name = "DeleteSpecialtyButton";
            this.DeleteSpecialtyButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteSpecialtyButton.TabIndex = 5;
            this.DeleteSpecialtyButton.Text = "Удалить";
            this.DeleteSpecialtyButton.UseVisualStyleBackColor = true;
            this.DeleteSpecialtyButton.Click += new System.EventHandler(this.DeleteSpecialtyButton_Click);
            // 
            // SpecialtyNameForChangeAndDeleteTextBox
            // 
            this.SpecialtyNameForChangeAndDeleteTextBox.Location = new System.Drawing.Point(174, 42);
            this.SpecialtyNameForChangeAndDeleteTextBox.Name = "SpecialtyNameForChangeAndDeleteTextBox";
            this.SpecialtyNameForChangeAndDeleteTextBox.Size = new System.Drawing.Size(133, 23);
            this.SpecialtyNameForChangeAndDeleteTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Название специальности";
            // 
            // SelectSpecialtyComboBox
            // 
            this.SelectSpecialtyComboBox.FormattingEnabled = true;
            this.SelectSpecialtyComboBox.Location = new System.Drawing.Point(7, 42);
            this.SelectSpecialtyComboBox.Name = "SelectSpecialtyComboBox";
            this.SelectSpecialtyComboBox.Size = new System.Drawing.Size(147, 23);
            this.SelectSpecialtyComboBox.TabIndex = 1;
            this.SelectSpecialtyComboBox.TextChanged += new System.EventHandler(this.SelectSpecialtyComboBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Выберите специальность";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.AddSpecialtyButton);
            this.groupBox4.Controls.Add(this.SpecialtyNameForAddingTextBox);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(230, 110);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Добавить";
            // 
            // AddSpecialtyButton
            // 
            this.AddSpecialtyButton.Location = new System.Drawing.Point(149, 77);
            this.AddSpecialtyButton.Name = "AddSpecialtyButton";
            this.AddSpecialtyButton.Size = new System.Drawing.Size(75, 23);
            this.AddSpecialtyButton.TabIndex = 2;
            this.AddSpecialtyButton.Text = "Добавить";
            this.AddSpecialtyButton.UseVisualStyleBackColor = true;
            this.AddSpecialtyButton.Click += new System.EventHandler(this.AddSpecialtyButton_Click);
            // 
            // SpecialtyNameForAddingTextBox
            // 
            this.SpecialtyNameForAddingTextBox.Location = new System.Drawing.Point(7, 42);
            this.SpecialtyNameForAddingTextBox.Name = "SpecialtyNameForAddingTextBox";
            this.SpecialtyNameForAddingTextBox.Size = new System.Drawing.Size(133, 23);
            this.SpecialtyNameForAddingTextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Введите название специальности";
            // 
            // CoursesTabPage
            // 
            this.CoursesTabPage.Controls.Add(this.groupBox5);
            this.CoursesTabPage.Controls.Add(this.groupBox6);
            this.CoursesTabPage.Location = new System.Drawing.Point(4, 24);
            this.CoursesTabPage.Name = "CoursesTabPage";
            this.CoursesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CoursesTabPage.Size = new System.Drawing.Size(587, 139);
            this.CoursesTabPage.TabIndex = 2;
            this.CoursesTabPage.Text = "Курсы";
            this.CoursesTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ChangeCourseNumberButton);
            this.groupBox5.Controls.Add(this.DeleteCourseButton);
            this.groupBox5.Controls.Add(this.CourseNumberTextBox);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.SelectCourseForChangeAndDeleteComboBox);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(299, 14);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(264, 110);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Удаление/Изменение";
            // 
            // ChangeCourseNumberButton
            // 
            this.ChangeCourseNumberButton.Location = new System.Drawing.Point(94, 81);
            this.ChangeCourseNumberButton.Name = "ChangeCourseNumberButton";
            this.ChangeCourseNumberButton.Size = new System.Drawing.Size(75, 23);
            this.ChangeCourseNumberButton.TabIndex = 6;
            this.ChangeCourseNumberButton.Text = "Изменить";
            this.ChangeCourseNumberButton.UseVisualStyleBackColor = true;
            this.ChangeCourseNumberButton.Click += new System.EventHandler(this.ChangeCourseNumberButton_Click);
            // 
            // DeleteCourseButton
            // 
            this.DeleteCourseButton.Location = new System.Drawing.Point(178, 81);
            this.DeleteCourseButton.Name = "DeleteCourseButton";
            this.DeleteCourseButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteCourseButton.TabIndex = 5;
            this.DeleteCourseButton.Text = "Удалить";
            this.DeleteCourseButton.UseVisualStyleBackColor = true;
            this.DeleteCourseButton.Click += new System.EventHandler(this.DeleteCourseButton_Click);
            // 
            // CourseNumberTextBox
            // 
            this.CourseNumberTextBox.Location = new System.Drawing.Point(174, 42);
            this.CourseNumberTextBox.Name = "CourseNumberTextBox";
            this.CourseNumberTextBox.Size = new System.Drawing.Size(79, 23);
            this.CourseNumberTextBox.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Номер курса";
            // 
            // SelectCourseForChangeAndDeleteComboBox
            // 
            this.SelectCourseForChangeAndDeleteComboBox.FormattingEnabled = true;
            this.SelectCourseForChangeAndDeleteComboBox.Location = new System.Drawing.Point(7, 42);
            this.SelectCourseForChangeAndDeleteComboBox.Name = "SelectCourseForChangeAndDeleteComboBox";
            this.SelectCourseForChangeAndDeleteComboBox.Size = new System.Drawing.Size(133, 23);
            this.SelectCourseForChangeAndDeleteComboBox.TabIndex = 1;
            this.SelectCourseForChangeAndDeleteComboBox.TextChanged += new System.EventHandler(this.SelectCourseForChangeAndDeleteComboBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Выберите номер курса";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.AddCourseButton);
            this.groupBox6.Controls.Add(this.CourseNumberForAddingTextBox);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Location = new System.Drawing.Point(13, 14);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(230, 110);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Добавить";
            // 
            // AddCourseButton
            // 
            this.AddCourseButton.Location = new System.Drawing.Point(149, 77);
            this.AddCourseButton.Name = "AddCourseButton";
            this.AddCourseButton.Size = new System.Drawing.Size(75, 23);
            this.AddCourseButton.TabIndex = 2;
            this.AddCourseButton.Text = "Добавить";
            this.AddCourseButton.UseVisualStyleBackColor = true;
            this.AddCourseButton.Click += new System.EventHandler(this.AddCourseButton_Click);
            // 
            // CourseNumberForAddingTextBox
            // 
            this.CourseNumberForAddingTextBox.Location = new System.Drawing.Point(7, 42);
            this.CourseNumberForAddingTextBox.Name = "CourseNumberForAddingTextBox";
            this.CourseNumberForAddingTextBox.Size = new System.Drawing.Size(133, 23);
            this.CourseNumberForAddingTextBox.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Введите номер курса";
            // 
            // DisciplinesTabPage
            // 
            this.DisciplinesTabPage.Controls.Add(this.groupBox7);
            this.DisciplinesTabPage.Controls.Add(this.groupBox8);
            this.DisciplinesTabPage.Location = new System.Drawing.Point(4, 24);
            this.DisciplinesTabPage.Name = "DisciplinesTabPage";
            this.DisciplinesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DisciplinesTabPage.Size = new System.Drawing.Size(587, 139);
            this.DisciplinesTabPage.TabIndex = 3;
            this.DisciplinesTabPage.Text = "Дисциплинны";
            this.DisciplinesTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.ChangeDisciplineButton);
            this.groupBox7.Controls.Add(this.DeleteDisciplineButton);
            this.groupBox7.Controls.Add(this.DisciplineNameTextBox);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.SelectDisciplineComboBox);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Location = new System.Drawing.Point(261, 13);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(320, 110);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Удаление/Изменение";
            // 
            // ChangeDisciplineButton
            // 
            this.ChangeDisciplineButton.Location = new System.Drawing.Point(155, 81);
            this.ChangeDisciplineButton.Name = "ChangeDisciplineButton";
            this.ChangeDisciplineButton.Size = new System.Drawing.Size(75, 23);
            this.ChangeDisciplineButton.TabIndex = 6;
            this.ChangeDisciplineButton.Text = "Изменить";
            this.ChangeDisciplineButton.UseVisualStyleBackColor = true;
            this.ChangeDisciplineButton.Click += new System.EventHandler(this.ChangeDisciplineButton_Click);
            // 
            // DeleteDisciplineButton
            // 
            this.DeleteDisciplineButton.Location = new System.Drawing.Point(238, 81);
            this.DeleteDisciplineButton.Name = "DeleteDisciplineButton";
            this.DeleteDisciplineButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteDisciplineButton.TabIndex = 5;
            this.DeleteDisciplineButton.Text = "Удалить";
            this.DeleteDisciplineButton.UseVisualStyleBackColor = true;
            this.DeleteDisciplineButton.Click += new System.EventHandler(this.DeleteDisciplineButton_Click);
            // 
            // DisciplineNameTextBox
            // 
            this.DisciplineNameTextBox.Location = new System.Drawing.Point(174, 42);
            this.DisciplineNameTextBox.Name = "DisciplineNameTextBox";
            this.DisciplineNameTextBox.Size = new System.Drawing.Size(139, 23);
            this.DisciplineNameTextBox.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(174, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "Название дисциплинны";
            // 
            // SelectDisciplineComboBox
            // 
            this.SelectDisciplineComboBox.FormattingEnabled = true;
            this.SelectDisciplineComboBox.Location = new System.Drawing.Point(7, 42);
            this.SelectDisciplineComboBox.Name = "SelectDisciplineComboBox";
            this.SelectDisciplineComboBox.Size = new System.Drawing.Size(138, 23);
            this.SelectDisciplineComboBox.TabIndex = 1;
            this.SelectDisciplineComboBox.TextChanged += new System.EventHandler(this.SelectDisciplineComboBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Выберите дисциплинну";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.AddDisciplineButton);
            this.groupBox8.Controls.Add(this.DisciplineNameForAddingTextBox);
            this.groupBox8.Controls.Add(this.label12);
            this.groupBox8.Location = new System.Drawing.Point(12, 13);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(230, 110);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Добавить";
            // 
            // AddDisciplineButton
            // 
            this.AddDisciplineButton.Location = new System.Drawing.Point(149, 77);
            this.AddDisciplineButton.Name = "AddDisciplineButton";
            this.AddDisciplineButton.Size = new System.Drawing.Size(75, 23);
            this.AddDisciplineButton.TabIndex = 2;
            this.AddDisciplineButton.Text = "Добавить";
            this.AddDisciplineButton.UseVisualStyleBackColor = true;
            this.AddDisciplineButton.Click += new System.EventHandler(this.AddDisciplineButton_Click);
            // 
            // DisciplineNameForAddingTextBox
            // 
            this.DisciplineNameForAddingTextBox.Location = new System.Drawing.Point(7, 42);
            this.DisciplineNameForAddingTextBox.Name = "DisciplineNameForAddingTextBox";
            this.DisciplineNameForAddingTextBox.Size = new System.Drawing.Size(182, 23);
            this.DisciplineNameForAddingTextBox.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(183, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Введите название дисциплинны";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(522, 191);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // CollegeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 222);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.MainTabControl);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CollegeManagement";
            this.Text = "Управление колледжом";
            this.MainTabControl.ResumeLayout(false);
            this.GroupsTabPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.SpecialtyTabPage.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.CoursesTabPage.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.DisciplinesTabPage.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage GroupsTabPage;
        private System.Windows.Forms.TabPage SpecialtyTabPage;
        private System.Windows.Forms.TabPage CoursesTabPage;
        private System.Windows.Forms.TabPage DisciplinesTabPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddGroupButton;
        private System.Windows.Forms.TextBox GroupNumberForAddingTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ChangeGroupNumberButton;
        private System.Windows.Forms.Button DeleteGroupButton;
        private System.Windows.Forms.TextBox SpecialtyNameForChangeOrDeleteTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SelectGroupComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ChangeSpecialtyNameButton;
        private System.Windows.Forms.Button DeleteSpecialtyButton;
        private System.Windows.Forms.TextBox SpecialtyNameForChangeAndDeleteTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SelectSpecialtyComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button AddSpecialtyButton;
        private System.Windows.Forms.TextBox SpecialtyNameForAddingTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ele;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button ChangeCourseNumberButton;
        private System.Windows.Forms.Button DeleteCourseButton;
        private System.Windows.Forms.TextBox CourseNumberTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox SelectCourseForChangeAndDeleteComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button AddCourseButton;
        private System.Windows.Forms.TextBox CourseNumberForAddingTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox our;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button ChangeDisciplineButton;
        private System.Windows.Forms.Button DeleteDisciplineButton;
        private System.Windows.Forms.TextBox DisciplineNameTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox SelectDisciplineComboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button AddDisciplineButton;
        private System.Windows.Forms.TextBox DisciplineNameForAddingTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox e;
        private System.Windows.Forms.Button CloseButton;
    }
}