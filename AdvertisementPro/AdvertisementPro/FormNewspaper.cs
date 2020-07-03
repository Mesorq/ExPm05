using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvertisementPro
{
    public partial class FormNewspaper : Form
    {
        void ShowNewspaper()
        {
            listViewNewspaper.Items.Clear();
            foreach (NewspapersSet newspapersSet in Program.bdad.NewspapersSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                        newspapersSet.Id.ToString(), newspapersSet.Name.ToString(), newspapersSet.Phone.ToString(),
                        newspapersSet.Price.ToString()
                });
                item.Tag = newspapersSet;
                listViewNewspaper.Items.Add(item);
            }
            listViewNewspaper.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);    
        }
        public FormNewspaper()
        {
            InitializeComponent();
            ShowNewspaper();
        }

        private void listViewNewspaper_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewNewspaper.SelectedItems.Count == 1)
            {
                NewspapersSet newspapersSet = listViewNewspaper.SelectedItems[0].Tag as NewspapersSet;
                textBoxName.Text = newspapersSet.Name;
                textBoxPhone.Text = newspapersSet.Phone;
                textBoxAdvertisementPrice.Text = newspapersSet.Price;
            }
            else
            {
                textBoxName.Text = "";
                textBoxPhone.Text = "";
                textBoxAdvertisementPrice.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            NewspapersSet newspapersSet = new NewspapersSet();
            newspapersSet.Name = textBoxName.Text;
            newspapersSet.Phone = textBoxPhone.Text;
            newspapersSet.Price = textBoxAdvertisementPrice.Text;
            Program.bdad.NewspapersSet.Add(newspapersSet);
            Program.bdad.SaveChanges();
            ShowNewspaper();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewNewspaper.SelectedItems.Count == 1)
            {
                NewspapersSet newspapersSet = listViewNewspaper.SelectedItems[0].Tag as NewspapersSet;
                newspapersSet.Name = textBoxName.Text;
                newspapersSet.Phone = textBoxPhone.Text;
                newspapersSet.Price = textBoxAdvertisementPrice.Text;
                Program.bdad.SaveChanges();
                ShowNewspaper();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewNewspaper.SelectedItems.Count == 1)
                {
                    NewspapersSet newspapersSet = listViewNewspaper.SelectedItems[0].Tag as NewspapersSet;
                    Program.bdad.NewspapersSet.Remove(newspapersSet);
                    Program.bdad.SaveChanges();
                    ShowNewspaper();
                }
                textBoxName.Text = "";
                textBoxPhone.Text = "";
                textBoxAdvertisementPrice.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
