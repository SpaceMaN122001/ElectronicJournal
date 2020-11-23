using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ElectronicJournal
{
    public partial class JournalManagement : Form
    {
        public JournalManagement()
        {
            InitializeComponent();
            Icon = new Icon("..\\..\\res\\ico.ico");
            pictureBox1.Image = Image.FromFile("..\\..\\res\\performance.png");
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CollegeManagementButon_Click(object sender, EventArgs e)
        {
            CollegeManagement collegeManagement = new CollegeManagement();
            collegeManagement.ShowDialog();
        }

        private void StudentsManagementButton_Click(object sender, EventArgs e)
        {
            StudentsManagement studentsManagement = new StudentsManagement();
            studentsManagement.ShowDialog();
        }

        private void PerformanceManagementButton_Click(object sender, EventArgs e)
        {
            PerformanceManagement performanceManagement = new PerformanceManagement();
            performanceManagement.ShowDialog();
        }
    }
}
