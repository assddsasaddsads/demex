using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demex
{
    public partial class Form1 : Form
    {
        public string type;
        public Form1()
        {
            InitializeComponent();
            CheckUser();
            labelName.Text = FormAuthorization.curuser.name;
            labelType.Text = type;
        }
        public void CheckUser()//проверка пользователя
        {
            if(FormAuthorization.curuser.id_type==1)
            {
                type = "Администратор";
            }
            if(FormAuthorization.curuser.id_type==2)
            {
                buttonPatients.Visible = false;
                type = "Лаборант";
            }
        }

        private void buttonPatients_Click(object sender, EventArgs e)
        {
            FormPatients formPatients = new FormPatients();
            formPatients.Show();
        }

        private void buttonServices_Click(object sender, EventArgs e)
        {
            FormServices formServices = new FormServices();
            formServices.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
