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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            Icon = new Icon("..\\..\\res\\ico.ico");
        }

        //закрываем окно
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        //регитрация
        private void RegButton_Click(object sender, EventArgs e)
        {
            string login = RegLoginTextBox.Text;
            string password = RegPasswordTextBox.Text;
            string fullName = RegFullNameTextBox.Text;

            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(password) || String.IsNullOrEmpty(fullName))
            {
                MessageBox.Show("Заполнены не все поля!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            SqlDataReader reader = Authorization.DataBase.GetDataReaderQuery("SELECT * FROM Teachers");

            while (reader.Read())
            {
                if (reader.GetValue(0).ToString() == login || reader.GetValue(1).ToString() == password)
                {
                    MessageBox.Show("Такой пароль или логин уже существует!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    reader.Close();

                    return;
                }
            }

            reader.Close();

            List<Parametr> parametrs = new List<Parametr>();
            parametrs.Add(new Parametr("@login", login));
            parametrs.Add(new Parametr("@password", password));
            parametrs.Add(new Parametr("@fullname", fullName));

            Authorization.DataBase.ExecuteQuery("INSERT INTO Teachers VALUES(@login, @password, @fullname)", parametrs);

            MessageBox.Show("Вы зарегестрированы в системе!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
