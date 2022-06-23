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

    public partial class FormCaptcha : Form
    {
        public FormCaptcha()
        {
            InitializeComponent();
            //Captcha();
            for (int i = 0; i < 4; i++)
            {
                letters.Add(ENG[rnd.Next(0, ENG.Length - 1)]);
                captcha = String.Join("", letters);
                labelCaptcha.Text = captcha;
            }
        }
        public string Cap;
        string ENG = "ABCDEFGHIGKLMNOPQRSTUVWXYZ1234567890";
        string captcha;
        Random rnd = new Random();
        List<char> letters = new List<char>();

        /* public void Captcha()
         {
             for (int i = 0; i<4; i++)
             {
                 letters.Add(ENG[rnd.Next(0, ENG.Length - 1)]);
                 captcha = String.Join(" ", letters);
                 labelCaptcha.Text = captcha;
             }
         }*/
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (labelCaptcha.Text==textBoxCaptcha.Text)
            {
                MessageBox.Show("Капча введена верно", "Выполнено",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Капча введена неверно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
