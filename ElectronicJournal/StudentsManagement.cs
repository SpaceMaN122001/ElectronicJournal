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
    public partial class StudentsManagement : Form
    {
        public StudentsManagement()
        {
            InitializeComponent();
            Icon = new Icon("..\\..\\res\\ico.ico");

            StudentsDataGridView.ColumnCount = 6;
            StudentsDataGridView.RowCount = 2;

            StudentsDataGridView.Columns[0].HeaderText = "Номер телефона";
            StudentsDataGridView.Columns[1].HeaderText = "ФИО";
            StudentsDataGridView.Columns[2].HeaderText = "Дата рождения";
            StudentsDataGridView.Columns[3].HeaderText = "Группа";
            StudentsDataGridView.Columns[4].HeaderText = "Специальность";
            StudentsDataGridView.Columns[5].HeaderText = "Курс";

            FillAllStudentsFromDataBase();

            for (int i = 0; i < StudentsDataGridView.RowCount; i++)
            {
                if(StudentsDataGridView.Rows[i].Cells[0].Value != null)
                {
                    StudentsDataGridView.Rows[i].Cells[0].ReadOnly = true;
                }
            }

            try
            {
                SqlDataReader reader = Authorization.DataBase.GetDataReaderQuery("SELECT * FROM Groups");

                while (reader.Read())
                {
                    GroupComboBox.Items.Add(reader.GetValue(0).ToString());
                }

                reader.Close();

                reader = Authorization.DataBase.GetDataReaderQuery("SELECT * FROM Courses");

                while (reader.Read())
                {
                    CourseComboBox.Items.Add(reader.GetValue(0).ToString());
                }

                reader.Close();

                reader = Authorization.DataBase.GetDataReaderQuery("SELECT * FROM Specialty");

                while (reader.Read())
                {
                    SpecialtyComboBox.Items.Add(reader.GetValue(0).ToString());
                }

                reader.Close();
            }

            catch (SqlException sqlException)
            {
                MessageBox.Show(sqlException.Message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FillAllStudentsFromDataBase()
        {
            StudentsDataGridView.Rows.Clear();
            SelectSutdentForDeletingComboBox.Items.Clear();

            try
            {
                SqlDataReader reader = Authorization.DataBase.GetDataReaderQuery("SELECT * FROM Students");

                while (reader.Read())
                {
                    SelectSutdentForDeletingComboBox.Items.Add(reader.GetValue(0).ToString());

                    StudentsDataGridView.Rows.Add(reader.GetValue(0).ToString(), reader.GetValue(1).ToString(), reader.GetValue(2).ToString(),
                        reader.GetValue(3).ToString(), reader.GetValue(4).ToString(), reader.GetValue(5).ToString());
                }

                reader.Close();
            }

            catch (SqlException sqlException)
            {
                MessageBox.Show(sqlException.Message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //StudentsDataGridView.AllowUserToAddRows = false;
        }

        private void ApplyFilterButton_Click(object sender, EventArgs e)
        {
            string numberPhone = NumberPhoneTextBox.Text;
            string fullName = FullNameTextBox.Text;
            string dateOfBirth = DateOfBirthTextBox.Text;
            string group = GroupComboBox.Text;
            string course = CourseComboBox.Text;
            string specialty = SpecialtyComboBox.Text;

            StudentsDataGridView.Rows.Clear();

            try
            {
                SqlDataReader reader = Authorization.DataBase.GetDataReaderQuery("SELECT * FROM Students");

                while (reader.Read())
                {
                    if (reader.GetValue(0).ToString().Contains(numberPhone) && reader.GetValue(1).ToString().Contains(fullName) && reader.GetValue(2).ToString().Contains(dateOfBirth) && reader.GetValue(3).ToString().Contains(group)
                        && reader.GetValue(4).ToString().Contains(specialty) && reader.GetValue(5).ToString().Contains(course))
                    {
                        StudentsDataGridView.Rows.Add(reader.GetValue(0).ToString(), reader.GetValue(1).ToString(), reader.GetValue(2).ToString(),
                        reader.GetValue(3).ToString(), reader.GetValue(4).ToString(), reader.GetValue(5).ToString());
                    }
                }

                reader.Close();
            }

            catch (SqlException sqlException)
            {
                MessageBox.Show(sqlException.Message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ResetFilterComboBox_Click(object sender, EventArgs e)
        {
            FillAllStudentsFromDataBase();
        }

        private void SaveChangeDataStudentButton_Click(object sender, EventArgs e)
        {
            string numberPhone = "";
            string fullName = "";
            string dateOfBirth = "";
            string group = "";
            string course = "";
            string specialty = "";

            for (int i = 0; i < StudentsDataGridView.RowCount - 1; i++)
            {
                for (int k = 0; k < StudentsDataGridView.ColumnCount; k++)
                {
                    if (StudentsDataGridView.Rows[i].Cells[k].Value == null)
                    {
                        MessageBox.Show("Заполнены не все ячейки!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return;
                    }
                        //StudentsDataGridView.Rows[i].Cells[k].Value = "null";
                }
            }

            for (int j = 0; j < StudentsDataGridView.RowCount - 1; j++)
            {
                numberPhone = StudentsDataGridView.Rows[j].Cells[0].Value.ToString();
                fullName = StudentsDataGridView.Rows[j].Cells[1].Value.ToString();
                dateOfBirth = StudentsDataGridView.Rows[j].Cells[2].Value.ToString();
                group = StudentsDataGridView.Rows[j].Cells[3].Value.ToString();
                specialty = StudentsDataGridView.Rows[j].Cells[4].Value.ToString();
                course = StudentsDataGridView.Rows[j].Cells[5].Value.ToString();

                try
                {
                    List<Parametr> parametrs = new List<Parametr>();
                    parametrs.Add(new Parametr("@numerphone", numberPhone));
                    parametrs.Add(new Parametr("@fullname", fullName));
                    parametrs.Add(new Parametr("@dateofbirth", dateOfBirth));
                    parametrs.Add(new Parametr("@groupnumber", group));
                    parametrs.Add(new Parametr("@specialty", specialty));
                    parametrs.Add(new Parametr("@course", course));

                    object number = Authorization.DataBase.GetOneValueQuery("SELECT * FROM Students WHERE NumerPhone = @numerphone", 0, parametrs);

                    if (number != null)
                    {
                        Authorization.DataBase.ExecuteQuery("UPDATE Students SET NumerPhone = @numerphone, FullName = @fullname, DateOfBirth = @dateofbirth, GroupNumber = @groupnumber, Specialty = @specialty," +
                    " Course = @course WHERE NumerPhone = @numerphone", parametrs);
                    }

                    else if(number == null)
                    {
                        Authorization.DataBase.ExecuteQuery("INSERT INTO Students VALUES(@numerphone, @fullname, @dateofbirth, @groupnumber, @specialty, @course)", parametrs);
                    }
                }

                catch (SqlException sqlException)
                {
                    MessageBox.Show(sqlException.Message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            for (int i = 0; i < StudentsDataGridView.RowCount; i++)
            {
                if (StudentsDataGridView.Rows[i].Cells[0].Value != null)
                {
                    StudentsDataGridView.Rows[i].Cells[0].ReadOnly = true;
                }
            }

            MessageBox.Show("Данные успешно изменены и добавлены!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RemoveStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<Parametr> parametrs = new List<Parametr>();
                parametrs.Add(new Parametr("@numberphone", SelectSutdentForDeletingComboBox.Text));

                Authorization.DataBase.ExecuteQuery("DELETE FROM Students WHERE NumerPhone = @numberphone", parametrs);

                FillAllStudentsFromDataBase();

                MessageBox.Show("Студент удален!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (SqlException sqlException)
            {
                MessageBox.Show(sqlException.Message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearFiltersButton_Click(object sender, EventArgs e)
        {
            NumberPhoneTextBox.Text = "";
            FullNameTextBox.Text = "";
            DateOfBirthTextBox.Text = "";
            GroupComboBox.Text = "";
            CourseComboBox.Text = "";
            SpecialtyComboBox.Text = "";
        }
    }
}
