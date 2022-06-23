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
    public partial class FormServices : Form
    {
        public FormServices()
        {
            InitializeComponent();
            ShowService();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
                textBoxcode.Clear();
                textBoxcode.Focus();
                Service service = new Service();
                service.Name = textBoxName.Text;
                service.Price = textBoxPrice.Text;
                service.Srok = textBoxSrok.Text;
                service.Code = Convert.ToInt32(textBoxcode.Text);
                Program.mylabex.Service.Add(service);
                Program.mylabex.SaveChanges();
                ShowService();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if(listViewService.SelectedItems.Count==1)
            {
                Service service = listViewService.SelectedItems[0].Tag as Service;
                service.Name = textBoxName.Text;
                service.Price = textBoxPrice.Text;
                service.Srok = textBoxSrok.Text;
                service.Code = Convert.ToInt32(textBoxcode.Text);
                Program.mylabex.SaveChanges();
                ShowService();
            }
            else
            {
                textBoxName.Text = "";
                textBoxPrice.Text = "";
                textBoxSrok.Text = "";
                textBoxcode.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try 
            {
                if(listViewService.SelectedItems.Count==1)
                {
                    Service service = listViewService.SelectedItems[0].Tag as Service;
                    Program.mylabex.Service.Remove(service);
                    Program.mylabex.SaveChanges();
                    ShowService();
                }
                else
                {
                    textBoxName.Text = "";
                    textBoxPrice.Text = "";
                    textBoxSrok.Text = "";
                    textBoxcode.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить данный!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewService.SelectedItems.Count==1)
            {
                Service service = listViewService.SelectedItems[0].Tag as Service;
                textBoxName.Text = service.Name;
                textBoxPrice.Text = service.Price;
                textBoxSrok.Text = service.Srok;
                textBoxcode.Text = service.Code.ToString();
            }
            else
            {
                textBoxName.Text = "";
                textBoxPrice.Text = "";
                textBoxSrok.Text = "";
                textBoxcode.Text = "";
            }
        }
        void ShowService()
        {
            listViewService.Items.Clear();
            foreach(Service service in Program.mylabex.Service)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    service.Id.ToString(), service.Name, service.Price, service.Srok,
                    service.Code.ToString()
                });
                item.Tag = service;
                listViewService.Items.Add(item);
            }
            listViewService.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
