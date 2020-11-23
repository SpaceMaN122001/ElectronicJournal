using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace ElectronicJournal
{
    public partial class PerformanceManagement : Form
    {
        public PerformanceManagement()
        {
            InitializeComponent();
            Icon = new Icon("..\\..\\res\\ico.ico");

            PerformanceDataGridView.ColumnCount = 7;
            PerformanceDataGridView.RowCount = 2;
            PerformanceDataGridView.Columns[0].HeaderText = "Id";
            PerformanceDataGridView.Columns[1].HeaderText = "ФИО студента";
            PerformanceDataGridView.Columns[2].HeaderText = "Номер студента";
            PerformanceDataGridView.Columns[3].HeaderText = "Курс";
            PerformanceDataGridView.Columns[4].HeaderText = "Группа";
            PerformanceDataGridView.Columns[5].HeaderText = "Дисциплинна";
            PerformanceDataGridView.Columns[6].HeaderText = "Оценка";
            PerformanceDataGridView.AllowUserToAddRows = false;

            ResultPerformancesDataGridView.ColumnCount = 4;
            ResultPerformancesDataGridView.RowCount = 1;
            ResultPerformancesDataGridView.Columns[0].HeaderText = "2";
            ResultPerformancesDataGridView.Columns[1].HeaderText = "3";
            ResultPerformancesDataGridView.Columns[2].HeaderText = "4";
            ResultPerformancesDataGridView.Columns[3].HeaderText = "5";

            FillAllPerformancesFromDataBase();
            DisableColumns();

            try
            {
                SqlDataReader reader = Authorization.DataBase.GetDataReaderQuery("SELECT * FROM Groups");

                while (reader.Read())
                {
                    GroupComboBox.Items.Add(reader.GetValue(0).ToString());
                    AllGroupsComboBox.Items.Add(reader.GetValue(0).ToString());
                }

                reader.Close();

                reader = Authorization.DataBase.GetDataReaderQuery("SELECT * FROM Courses");

                while (reader.Read())
                {
                    CourseComboBox.Items.Add(reader.GetValue(0).ToString());
                    AllCoursesComboBox.Items.Add(reader.GetValue(0).ToString());
                }

                reader.Close();

                reader = Authorization.DataBase.GetDataReaderQuery("SELECT * FROM Disciplines");

                while (reader.Read())
                {
                    DisciplineComboBox.Items.Add(reader.GetValue(0).ToString());
                    AllDisciplinesComboBox.Items.Add(reader.GetValue(0).ToString());
                }

                reader.Close();

                reader = Authorization.DataBase.GetDataReaderQuery("SELECT * FROM Specialty");

                while (reader.Read())
                {
                    AllSpecialtyComboBox.Items.Add(reader.GetValue(0).ToString());
                }

                reader.Close();
            }

            catch (SqlException sqlException)
            {
                MessageBox.Show(sqlException.Message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DisableColumns()
        {
            for (int i = 0; i < PerformanceDataGridView.RowCount; i++)
            {
                bool isOk = true;

                for (int j = 0; j <= 4; j++)
                {
                    if(PerformanceDataGridView.Rows[i].Cells[j].Value != null)
                    {
                        isOk = false;
                    }
                }

                for (int j = 0; j <= 4; j++)
                {
                    if (isOk)
                    {
                        if (j != 2)
                        {
                            PerformanceDataGridView.Rows[i].Cells[j].ReadOnly = true;
                            PerformanceDataGridView.Rows[i].Cells[0].Value = "0";
                        }
                    }

                    else if (!isOk)
                    {
                        PerformanceDataGridView.Rows[i].Cells[j].ReadOnly = true;
                    }
                }
            }
        }

        private void FillAllPerformancesFromDataBase()
        {
            PerformanceDataGridView.Rows.Clear();
            SelectPerformanceIDForDeletingComboBox.Items.Clear();

            try
            {
                SqlDataReader reader = Authorization.DataBase.GetDataReaderQuery("SELECT * FROM Performance");

                while (reader.Read())
                {
                    List<Parametr> parametrs = new List<Parametr>();
                    parametrs.Add(new Parametr("@numerphone", reader.GetValue(1).ToString()));

                    SelectPerformanceIDForDeletingComboBox.Items.Add(reader.GetValue(0).ToString());

                    string studentFullName = "";
                    string studentCourse = "";
                    string studentGroup = "";

                    using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=ElectronicJournal;Integrated Security=True"))
                    {
                        connection.Open();

                        SqlCommand command = new SqlCommand("SELECT * FROM Students WHERE NumerPhone = @numberphone", connection);
                        command.Parameters.AddWithValue("@numberphone", reader.GetValue(1).ToString());

                        SqlDataReader reader1 = command.ExecuteReader();

                        while (reader1.Read())
                        {
                            studentFullName = reader1.GetValue(1).ToString();
                            studentCourse = reader1.GetValue(5).ToString();
                            studentGroup = reader1.GetValue(3).ToString();

                            reader1.Close();

                            connection.Close();

                            break;
                        }
                    }

                        PerformanceDataGridView.Rows.Add(reader.GetValue(0).ToString(), studentFullName, reader.GetValue(1).ToString(), studentCourse, studentGroup.ToString(),
                            reader.GetValue(2).ToString(), reader.GetValue(3).ToString());
                }

                reader.Close();
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

        private void ResetFilterButton_Click(object sender, EventArgs e)
        {
            FillAllPerformancesFromDataBase();

            DisableColumns();
        }

        private void SearchFilterButton_Click(object sender, EventArgs e)
        {
            string student = StudentNumberPhoneTextBox.Text;
            string discipline = DisciplineComboBox.Text;
            string assessment = AssessmentComboBox.Text;
            string course = CourseComboBox.Text;
            string group = GroupComboBox.Text;
            string fullName = StudentFullNameTextBox.Text;

            PerformanceDataGridView.Rows.Clear();

            try
            {
                SqlDataReader reader = Authorization.DataBase.GetDataReaderQuery("SELECT * FROM Performance");

                while (reader.Read())
                {

                    string studentCourse = "";
                    string studentGroup = "";
                    string studentFullName = "";

                    using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=ElectronicJournal;Integrated Security=True"))
                    {
                        connection.Open();

                        SqlCommand command = new SqlCommand("SELECT * FROM Students WHERE NumerPhone = @numberphone", connection);
                        command.Parameters.AddWithValue("@numberphone", reader.GetValue(1).ToString());

                        SqlDataReader reader1 = command.ExecuteReader();

                        while (reader1.Read())
                        {
                            studentCourse = reader1.GetValue(5).ToString();
                            studentGroup = reader1.GetValue(3).ToString();
                            studentFullName = reader1.GetValue(1).ToString();

                            reader1.Close();

                            connection.Close();

                            break;
                        }
                    }


                    if (reader.GetValue(1).ToString().Contains(student) && studentFullName.Contains(fullName) && reader.GetValue(2).ToString().Contains(discipline) && reader.GetValue(3).ToString().Contains(assessment) 
                        && studentCourse.Contains(course) && studentGroup.Contains(group))
                    {
                        PerformanceDataGridView.Rows.Add(reader.GetValue(0).ToString(), studentFullName, reader.GetValue(1).ToString(), studentCourse, studentGroup, reader.GetValue(2).ToString(),
                            reader.GetValue(3).ToString());
                    }
                }

                reader.Close();
            }

            catch (SqlException sqlException)
            {
                MessageBox.Show(sqlException.Message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            DisableColumns();
        }

        private void SaveChangeDataButton_Click(object sender, EventArgs e)
        {
            //2 5 6
            for (int i = 0; i < PerformanceDataGridView.RowCount; i++)
            {
                for (int k = 0; k < PerformanceDataGridView.ColumnCount; k++)
                {
                    if (PerformanceDataGridView.Rows[i].Cells[k].Value == null)
                    {
                        MessageBox.Show("Заполнены не все ячейки!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return;
                    }
                }
            }

            string performanceID = "";
            string studentNumber = "";
            string discipline = "";
            string assessment = "";


            for (int j = 0; j < PerformanceDataGridView.RowCount; j++)
            {
                performanceID = PerformanceDataGridView.Rows[j].Cells[0].Value.ToString();
                studentNumber = PerformanceDataGridView.Rows[j].Cells[2].Value.ToString();
                discipline = PerformanceDataGridView.Rows[j].Cells[5].Value.ToString();
                assessment = PerformanceDataGridView.Rows[j].Cells[6].Value.ToString();

                try
                {
                    List<Parametr> parametrs = new List<Parametr>();
                    parametrs.Add(new Parametr("@performanceid", performanceID));
                    parametrs.Add(new Parametr("@studentnumber", studentNumber));
                    parametrs.Add(new Parametr("@discipline", discipline));
                    parametrs.Add(new Parametr("@assessment", assessment));

                    if (performanceID != null)
                    {
                        Authorization.DataBase.ExecuteQuery("UPDATE Performance SET Discipline = @discipline, Assessment = @assessment WHERE Id = @performanceid", parametrs);
                    }

                    if(performanceID == "0")
                    {
                        Authorization.DataBase.ExecuteQuery("INSERT INTO Performance VALUES(@studentnumber, @discipline, @assessment)", parametrs);
                    }
                }

                catch (SqlException sqlException)
                {
                    MessageBox.Show(sqlException.Message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            MessageBox.Show("Данные успешно изменены и добавлены!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FillAllPerformancesFromDataBase();
            DisableColumns();
        }

        private void AddNewRowButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < PerformanceDataGridView.RowCount; i++)
            {
                for (int k = 0; k < PerformanceDataGridView.ColumnCount; k++)
                {
                    if (PerformanceDataGridView.Rows[i].Cells[k].Value == null)
                    {
                        MessageBox.Show("Заполнены не все ячейки!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return;
                    }
                }
            }

            PerformanceDataGridView.Rows.Add();

            // 1 2 3

            PerformanceDataGridView.Rows[PerformanceDataGridView.RowCount - 1].Cells[0].Value = "0";
            PerformanceDataGridView.Rows[PerformanceDataGridView.RowCount - 1].Cells[1].Value = "null";
            PerformanceDataGridView.Rows[PerformanceDataGridView.RowCount - 1].Cells[3].Value = "null";
            PerformanceDataGridView.Rows[PerformanceDataGridView.RowCount - 1].Cells[4].Value = "null";

            DisableColumns();

            PerformanceDataGridView.Rows[PerformanceDataGridView.RowCount - 1].Cells[2].ReadOnly = false;
        }

        private void RemovePerformanceButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<Parametr> parametrs = new List<Parametr>();
                parametrs.Add(new Parametr("@performanceid", SelectPerformanceIDForDeletingComboBox.Text));

                Authorization.DataBase.ExecuteQuery("DELETE FROM Performance WHERE Id = @performanceid", parametrs);

                FillAllPerformancesFromDataBase();
                DisableColumns();

                MessageBox.Show("Успеваемость удалена!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (SqlException sqlException)
            {
                MessageBox.Show(sqlException.Message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ShowResultButton_Click(object sender, EventArgs e)
        {
            string searchGroup = AllGroupsComboBox.Text;
            string searchCourse = AllCoursesComboBox.Text;
            string searchSpecialty = AllSpecialtyComboBox.Text;
            string searchDiscipline = AllDisciplinesComboBox.Text;

            int numberOfTwos = 0;
            int numberOfTriplets = 0;
            int numberOfFours = 0;
            int numberOfFives = 0;
            int numberOfAssessment = 0;

            try
            {
                SqlDataReader reader = Authorization.DataBase.GetDataReaderQuery("SELECT * FROM Performance");

                while (reader.Read())
                {
                    string foundGroup = "";
                    string foundCourse = "";
                    string foundSpecialty = "";
                    string foundDiscipline = reader.GetValue(2).ToString();
                    int scoreReceived = Convert.ToInt32(reader.GetValue(3).ToString());

                    using (QDataBase db = new QDataBase(@"Data Source=.\SQLEXPRESS;Initial Catalog=ElectronicJournal;Integrated Security=True"))
                    {
                        List<Parametr> parametrs = new List<Parametr>();
                        parametrs.Add(new Parametr("@numberphone", reader.GetValue(1).ToString()));

                        foundGroup = db.GetOneValueQuery("SELECT * FROM Students WHERE NumerPhone = @numberphone", 3, parametrs).ToString();
                        foundCourse = db.GetOneValueQuery("SELECT * FROM Students WHERE NumerPhone = @numberphone", 5, parametrs).ToString();
                        foundSpecialty = db.GetOneValueQuery("SELECT * FROM Students WHERE NumerPhone = @numberphone", 4, parametrs).ToString();

                        db.SqlConnection.Close();
                    }

                    if(foundGroup.Contains(searchGroup) && foundCourse.Contains(searchCourse) && foundSpecialty.Contains(searchSpecialty) && foundDiscipline.Contains(searchDiscipline))
                    {
                        numberOfAssessment++;

                        if (scoreReceived == 2)
                            numberOfTwos++;

                        if (scoreReceived == 3)
                            numberOfTriplets++;

                        if (scoreReceived == 4)
                            numberOfFours++;

                        if (scoreReceived == 5)
                            numberOfFives++;
                    }
                }

                reader.Close();
            }

            catch (SqlException sqlException)
            {
                MessageBox.Show(sqlException.Message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            ResultPerformancesDataGridView.Rows[0].Cells[0].Value = numberOfTwos;
            ResultPerformancesDataGridView.Rows[0].Cells[1].Value = numberOfTriplets;
            ResultPerformancesDataGridView.Rows[0].Cells[2].Value = numberOfFours;
            ResultPerformancesDataGridView.Rows[0].Cells[3].Value = numberOfFives;


            double percentageTwos = 100 / Convert.ToDouble(numberOfAssessment) * Convert.ToDouble(numberOfTwos);
            double percentageTriplets = 100 / Convert.ToDouble(numberOfAssessment) * Convert.ToDouble(numberOfTriplets);
            double percentageFours = 100 / Convert.ToDouble(numberOfAssessment) * Convert.ToDouble(numberOfFours);
            double percentageFives = 100 / Convert.ToDouble(numberOfAssessment) * Convert.ToDouble(numberOfFives);

            if (ShowAssessmentsInPercentCheckBox.CheckState == CheckState.Checked)
            {
                ResultPerformancesDataGridView.Rows[0].Cells[0].Value = percentageTwos + "%";
                ResultPerformancesDataGridView.Rows[0].Cells[1].Value = percentageTriplets + "%";
                ResultPerformancesDataGridView.Rows[0].Cells[2].Value = percentageFours + "%";
                ResultPerformancesDataGridView.Rows[0].Cells[3].Value = percentageFives + "%";
            }
        }

        private void ResetFilterpButton_Click(object sender, EventArgs e)
        {
            AllGroupsComboBox.Text = "";
            AllCoursesComboBox.Text = "";
            AllSpecialtyComboBox.Text = "";
            AllDisciplinesComboBox.Text = "";
        }

        private void ClearFiltersButton_Click(object sender, EventArgs e)
        {
            StudentNumberPhoneTextBox.Text = "";
            StudentFullNameTextBox.Text = "";
            DisciplineComboBox.Text = "";
            AssessmentComboBox.Text = "";
            CourseComboBox.Text = "";
            GroupComboBox.Text = "";
        }
    }
}