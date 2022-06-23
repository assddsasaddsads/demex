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
    public partial class FormPatients : Form
    {
        public FormPatients()
        {
            InitializeComponent();
            SowPatients();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text != "" && textBoxLastName.Text != "" && textBoxSeriesP.Text != "" &&
                textBoxNumberP.Text != "" && textBoxPhone.Text != "" && textBoxEmail.Text != "" && textBoxPolicy.Text != "")
            {
                DateOfPatients dateOfPatients = new DateOfPatients();
                dateOfPatients.FirstName = textBoxFirstName.Text;
                dateOfPatients.LastName = textBoxLastName.Text;
                dateOfPatients.SeriesP = Convert.ToInt32(textBoxSeriesP.Text);
                dateOfPatients.NumberP = Convert.ToInt32(textBoxNumberP.Text);
                dateOfPatients.Phone = Convert.ToInt32(textBoxPhone.Text);
                dateOfPatients.Email = textBoxEmail.Text;
                dateOfPatients.Policy = Convert.ToInt32(textBoxPolicy.Text);
                Program.mylabex.DateOfPatients.Add(dateOfPatients);
                Program.mylabex.SaveChanges();
                SowPatients();
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if(listViewPatients.SelectedItems.Count==1)
            {
                DateOfPatients dateOfPatients = listViewPatients.SelectedItems[0].Tag as DateOfPatients;
                dateOfPatients.FirstName = textBoxFirstName.Text;
                dateOfPatients.LastName = textBoxLastName.Text;
                dateOfPatients.SeriesP = Convert.ToInt32(textBoxSeriesP.Text);
                dateOfPatients.NumberP = Convert.ToInt32(textBoxNumberP.Text);
                dateOfPatients.Phone = Convert.ToInt32(textBoxPhone.Text);
                dateOfPatients.Email = textBoxEmail.Text;
                dateOfPatients.Policy = Convert.ToInt32(textBoxPolicy.Text);
                Program.mylabex.SaveChanges();
                SowPatients();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if(listViewPatients.SelectedItems.Count==1)
                {
                    DateOfPatients dateOfPatients = listViewPatients.SelectedItems[0].Tag as DateOfPatients;
                    Program.mylabex.DateOfPatients.Remove(dateOfPatients);
                    Program.mylabex.SaveChanges();
                    SowPatients();
                }
                else
                {
                    textBoxFirstName.Text = "";
                    textBoxLastName.Text = "";
                    textBoxSeriesP.Text = "";
                    textBoxNumberP.Text = "";
                    textBoxPhone.Text = "";
                    textBoxEmail.Text = "";
                    textBoxPolicy.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить данные! ", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewPatients.SelectedItems.Count==1)
            {
                DateOfPatients dateOfPatients = listViewPatients.SelectedItems[0].Tag as DateOfPatients;
                textBoxFirstName.Text = dateOfPatients.FirstName;
                textBoxLastName.Text = dateOfPatients.LastName;
                textBoxSeriesP.Text = dateOfPatients.SeriesP.ToString();
                textBoxNumberP.Text = dateOfPatients.NumberP.ToString();
                textBoxPhone.Text = dateOfPatients.Phone.ToString();
                textBoxEmail.Text = dateOfPatients.Email.ToString();
                textBoxPolicy.Text = dateOfPatients.Policy.ToString();
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxSeriesP.Text = "";
                textBoxNumberP.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
                textBoxPolicy.Text = "";
            }
        }
        void SowPatients()
        {
            listViewPatients.Items.Clear();
            foreach(DateOfPatients dateOfPatients in Program.mylabex.DateOfPatients)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    dateOfPatients.Id.ToString(), dateOfPatients.FirstName, dateOfPatients.LastName,
                    dateOfPatients.SeriesP.ToString(), dateOfPatients.NumberP.ToString(), dateOfPatients.Phone.ToString(),
                    dateOfPatients.Email, dateOfPatients.Policy.ToString()
                });
                item.Tag = dateOfPatients;
                listViewPatients.Items.Add(item);
            }
            listViewPatients.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
