using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ElectronicJournal
{
    public partial class CollegeManagement : Form
    {
        public CollegeManagement()
        {
            InitializeComponent();
            Icon = new Icon("..\\..\\res\\ico.ico");

            FillComboBoxGroupsNumbersFromDataBase();
            FillComboBoxSpecialtyNamesFromDataBase();
            FillComboBoxCoursesFromDataBase();
            FillComboBoxDisciplinesFromDataBase();
        }

        private void FillComboBoxGroupsNumbersFromDataBase()
        {
            SelectGroupComboBox.Items.Clear();

            try
            {
                SqlDataReader reader = Authorization.DataBase.GetDataReaderQuery("SELECT * FROM Groups");

                while (reader.Read())
                {
                    SelectGroupComboBox.Items.Add(reader.GetValue(0).ToString());
                }

                reader.Close();
            }

            catch(SqlException sqlException)
            {
                MessageBox.Show(sqlException.Message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FillComboBoxSpecialtyNamesFromDataBase()
        {
            SelectSpecialtyComboBox.Items.Clear();

            try
            {
                SqlDataReader reader = Authorization.DataBase.GetDataReaderQuery("SELECT * FROM Specialty");

                while (reader.Read())
                {
                    SelectSpecialtyComboBox.Items.Add(reader.GetValue(0).ToString());
                }

                reader.Close();
            }

            catch (SqlException sqlException)
            {
                MessageBox.Show(sqlException.Message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FillComboBoxCoursesFromDataBase()
        {
            SelectCourseForChangeAndDeleteComboBox.Items.Clear();

            try
            {
                SqlDataReader reader = Authorization.DataBase.GetDataReaderQuery("SELECT * FROM Courses");

                while (reader.Read())
                {
                    SelectCourseForChangeAndDeleteComboBox.Items.Add(reader.GetValue(0).ToString());
                }

                reader.Close();
            }

            catch (SqlException sqlException)
            {
                MessageBox.Show(sqlException.Message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FillComboBoxDisciplinesFromDataBase()
        {
            SelectDisciplineComboBox.Items.Clear();

            try
            {
                SqlDataReader reader = Authorization.DataBase.GetDataReaderQuery("SELECT * FROM Disciplines");

                while (reader.Read())
                {
                    SelectDisciplineComboBox.Items.Add(reader.GetValue(0).ToString());
                }

                reader.Close();
            }

            catch (SqlException sqlException)
            {
                MessageBox.Show(sqlException.Message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddGroupButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<Parametr> parametrs = new List<Parametr>();
                parametrs.Add(new Parametr("@groupnumber", GroupNumberForAddingTextBox.Text));

                Authorization.DataBase.ExecuteQuery("INSERT INTO Groups VALUES(@groupnumber)", parametrs);

                MessageBox.Show("Группа добавлена!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FillComboBoxGroupsNumbersFromDataBase();
            }

            catch(SqlException sqlException)
            {
                MessageBox.Show(sqlException.Message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SelectGroupComboBox_TextChanged(object sender, EventArgs e)
        {
            SpecialtyNameForChangeOrDeleteTextBox.Text = SelectGroupComboBox.Text;
        }

        private void ChangeGroupNumberButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<Parametr> parametrs = new List<Parametr>();
                parametrs.Add(new Parametr("@oldgroupnumber", SelectGroupComboBox.Text));
                parametrs.Add(new Parametr("@newgroupnumber", SpecialtyNameForChangeOrDeleteTextBox.Text));

                Authorization.DataBase.ExecuteQuery("UPDATE Groups SET GroupNumber = @newgroupnumber WHERE GroupNumber = @oldgroupnumber", parametrs);

                SpecialtyNameForChangeOrDeleteTextBox.Text = "";
                SelectGroupComboBox.Text = "";

                FillComboBoxGroupsNumbersFromDataBase();

                MessageBox.Show("Номер группы успешно изменен!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (SqlException sqlException)
            {
                MessageBox.Show(sqlException.Message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteGroupButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<Parametr> parametrs = new List<Parametr>();
                parametrs.Add(new Parametr("@groupnumber", SelectGroupComboBox.Text));

                Authorization.DataBase.ExecuteQuery("DELETE FROM Groups WHERE GroupNumber = @groupnumber", parametrs);

                SpecialtyNameForChangeOrDeleteTextBox.Text = "";
                SelectGroupComboBox.Text = "";

                FillComboBoxGroupsNumbersFromDataBase();

                MessageBox.Show("Группа успешно удалена!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (SqlException sqlException)
            {
                MessageBox.Show(sqlException.Message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddSpecialtyButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<Parametr> parametrs = new List<Parametr>();
                parametrs.Add(new Parametr("@specialty", SpecialtyNameForAddingTextBox.Text));

                Authorization.DataBase.ExecuteQuery("INSERT INTO Specialty VALUES(@specialty)", parametrs);

                MessageBox.Show("Специальность добавлена!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FillComboBoxSpecialtyNamesFromDataBase();
            }

            catch (SqlException sqlException)
            {
                MessageBox.Show(sqlException.Message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SelectSpecialtyComboBox_TextChanged(object sender, EventArgs e)
        {
            SpecialtyNameForChangeAndDeleteTextBox.Text = SelectSpecialtyComboBox.Text;
        }

        private void ChangeSpecialtyNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<Parametr> parametrs = new List<Parametr>();
                parametrs.Add(new Parametr("@oldspecialty", SelectSpecialtyComboBox.Text));
                parametrs.Add(new Parametr("@newspecialty", SpecialtyNameForChangeAndDeleteTextBox.Text));

                Authorization.DataBase.ExecuteQuery("UPDATE Specialty SET SpecialtyName = @newspecialty WHERE SpecialtyName = @oldspecialty", parametrs);

                SpecialtyNameForChangeAndDeleteTextBox.Text = "";
                SelectSpecialtyComboBox.Text = "";

                FillComboBoxSpecialtyNamesFromDataBase();

                MessageBox.Show("Название специальности успешно изменено!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (SqlException sqlException)
            {
                MessageBox.Show(sqlException.Message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteSpecialtyButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<Parametr> parametrs = new List<Parametr>();
                parametrs.Add(new Parametr("@specialty", SelectSpecialtyComboBox.Text));

                Authorization.DataBase.ExecuteQuery("DELETE FROM Specialty WHERE SpecialtyName = @specialty", parametrs);

                SpecialtyNameForChangeAndDeleteTextBox.Text = "";
                SelectSpecialtyComboBox.Text = "";

                FillComboBoxSpecialtyNamesFromDataBase();

                MessageBox.Show("Специальность успешно удалена!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (SqlException sqlException)
            {
                MessageBox.Show(sqlException.Message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SelectCourseForChangeAndDeleteComboBox_TextChanged(object sender, EventArgs e)
        {
            CourseNumberTextBox.Text = SelectCourseForChangeAndDeleteComboBox.Text;
        }

        private void AddCourseButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<Parametr> parametrs = new List<Parametr>();
                parametrs.Add(new Parametr("@course", CourseNumberForAddingTextBox.Text));

                Authorization.DataBase.ExecuteQuery("INSERT INTO Courses VALUES(@course)", parametrs);

                MessageBox.Show("Курс добавлен!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FillComboBoxCoursesFromDataBase();
            }

            catch (SqlException sqlException)
            {
                MessageBox.Show(sqlException.Message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ChangeCourseNumberButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<Parametr> parametrs = new List<Parametr>();
                parametrs.Add(new Parametr("@oldcourse", SelectCourseForChangeAndDeleteComboBox.Text));
                parametrs.Add(new Parametr("@newcourse", CourseNumberTextBox.Text));

                Authorization.DataBase.ExecuteQuery("UPDATE Courses SET CourseNumber = @newcourse WHERE CourseNumber = @oldcourse", parametrs);

                CourseNumberTextBox.Text = "";
                SelectCourseForChangeAndDeleteComboBox.Text = "";

                FillComboBoxCoursesFromDataBase();

                MessageBox.Show("Номер курса успешно изменен!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (SqlException sqlException)
            {
                MessageBox.Show(sqlException.Message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteCourseButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<Parametr> parametrs = new List<Parametr>();
                parametrs.Add(new Parametr("@course", SelectCourseForChangeAndDeleteComboBox.Text));

                Authorization.DataBase.ExecuteQuery("DELETE FROM Courses WHERE CourseNumber = @course", parametrs);

                CourseNumberTextBox.Text = "";
                SelectCourseForChangeAndDeleteComboBox.Text = "";

                FillComboBoxCoursesFromDataBase();

                MessageBox.Show("Курс успешно удален!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (SqlException sqlException)
            {
                MessageBox.Show(sqlException.Message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SelectDisciplineComboBox_TextChanged(object sender, EventArgs e)
        {
            DisciplineNameTextBox.Text = SelectDisciplineComboBox.Text;
        }

        private void AddDisciplineButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<Parametr> parametrs = new List<Parametr>();
                parametrs.Add(new Parametr("@discipline", DisciplineNameForAddingTextBox.Text));

                Authorization.DataBase.ExecuteQuery("INSERT INTO Disciplines VALUES(@discipline)", parametrs);

                MessageBox.Show("Дисциплинна добавлена!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FillComboBoxCoursesFromDataBase();
            }

            catch (SqlException sqlException)
            {
                MessageBox.Show(sqlException.Message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            FillComboBoxDisciplinesFromDataBase();
        }

        private void ChangeDisciplineButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<Parametr> parametrs = new List<Parametr>();
                parametrs.Add(new Parametr("@olddiscipline", SelectDisciplineComboBox.Text));
                parametrs.Add(new Parametr("@newdiscipline", DisciplineNameTextBox.Text));

                Authorization.DataBase.ExecuteQuery("UPDATE Disciplines SET Discipline = @newdiscipline WHERE Discipline = @olddiscipline", parametrs);

                DisciplineNameTextBox.Text = "";
                SelectDisciplineComboBox.Text = "";

                FillComboBoxDisciplinesFromDataBase();

                MessageBox.Show("Название дисциплинны успешно измененно!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (SqlException sqlException)
            {
                MessageBox.Show(sqlException.Message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteDisciplineButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<Parametr> parametrs = new List<Parametr>();
                parametrs.Add(new Parametr("@discipline", SelectDisciplineComboBox.Text));

                Authorization.DataBase.ExecuteQuery("DELETE FROM Disciplines WHERE Discipline = @discipline", parametrs);

                DisciplineNameTextBox.Text = "";
                SelectDisciplineComboBox.Text = "";

                FillComboBoxDisciplinesFromDataBase();

                MessageBox.Show("Дисциплинна успешно удалена!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (SqlException sqlException)
            {
                MessageBox.Show(sqlException.Message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
