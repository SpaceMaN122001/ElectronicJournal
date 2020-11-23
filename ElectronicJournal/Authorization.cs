using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ElectronicJournal
{
    public partial class Authorization : Form
    {
        //строка подключения к бд
        public static QDataBase DataBase = new QDataBase(@"Data Source=.\SQLEXPRESS;Initial Catalog=ElectronicJournal;Integrated Security=True");

        public Authorization()
        {
            InitializeComponent();
            Icon = new Icon("..\\..\\res\\ico.ico");
        }

        //выход из приложения
        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            string login = AuthLoginTextBox.Text;
            string password = AuthPasswordTextBox.Text;
            bool isOk = false;

            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Заполнены не все поля!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            SqlDataReader reader = DataBase.GetDataReaderQuery("SELECT * FROM Teachers");

            while (reader.Read())
            {
                if(reader.GetValue(0).ToString() == login && reader.GetValue(1).ToString() == password)
                {
                    isOk = true;
                }
            }

            reader.Close();

            if (isOk)
            {
                MessageBox.Show("Вход выполнен!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                JournalManagement journalManagement = new JournalManagement();
                journalManagement.ShowDialog();
            }

            else if (!isOk)
            {
                MessageBox.Show("Вход не выполнен!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.ShowDialog();
        }
    }
}
