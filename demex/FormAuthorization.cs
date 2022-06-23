using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace demex
{
    public struct CurrentUser// структура для хранения данных
    {
        public string login;
        public string password;
        public string type;
        public int id_type;
        public string name;
    }
    public partial class FormAuthorization : Form
    {
        public static CurrentUser curuser = new CurrentUser();//переменная для хранения данных
        public FormAuthorization()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
           if(textBoxLogin.Text == "" && textBoxPassword.Text == "")//если не введены данные
            {
                MessageBox.Show("Введите данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {//если введены данные
                bool key = false;
                foreach(Users users in Program.mylabex.Users)
                {
                    if (textBoxLogin.Text == users.Login && textBoxPassword.Text == users.Password)
                    {
                        key = true;
                        curuser.id_type = users.Id_Type;
                        curuser.login = users.Login;
                        curuser.password = users.Password;
                        curuser.name = users.FirstName + " " + users.MiddleName + " " + users.LastName;
                    }
                }//если не нашли пользователя
                if(!key)
                {
                    MessageBox.Show("Повторите попытку через несколько секунд", "Пользователь не найден",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Thread.Sleep(2000);
                    FormCaptcha formCaptcha = new FormCaptcha();
                    formCaptcha.Show();
                    textBoxLogin.Text = "";
                    textBoxPassword.Text = "";
                }
                else//если нашли пользователя
                {
                    MessageBox.Show("Пользователь найден", "Выполнено!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                }
            }

        }
        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {//видимость пароля
            if(checkBoxPassword.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }
        private void buttonEx_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
