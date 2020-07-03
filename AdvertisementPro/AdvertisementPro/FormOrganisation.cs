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
    public partial class FormOrganisation : Form
    {
        void ShowOrganisation()
        {
            listViewOrganisation.Items.Clear();
            foreach (OrganisationsSet organisationsSet in Program.bdad.OrganisationsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    organisationsSet.Id.ToString(),
                    organisationsSet.Name.ToString(),
                    organisationsSet.Adress.ToString(),
                    organisationsSet.Phone.ToString()
                }); 
                item.Tag = organisationsSet;
                listViewOrganisation.Items.Add(item);
            }
            listViewOrganisation.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        public FormOrganisation()
        {
            InitializeComponent();
            ShowOrganisation();
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void listViewOrganisation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewOrganisation.SelectedItems.Count == 1)
            {
                OrganisationsSet organisationsSet = listViewOrganisation.SelectedItems[0].Tag as OrganisationsSet;
                textBoxName.Text = organisationsSet.Name;
                textBoxAdress.Text = organisationsSet.Adress;
                textBoxPhone.Text = organisationsSet.Phone;
            }
            else
            {
                textBoxName.Text = "";
                textBoxAdress.Text = "";
                textBoxPhone.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            OrganisationsSet organisationsSet = new OrganisationsSet();
            organisationsSet.Name = textBoxName.Text;
            organisationsSet.Adress = textBoxAdress.Text;
            organisationsSet.Phone = textBoxPhone.Text;
            Program.bdad.OrganisationsSet.Add(organisationsSet);
            Program.bdad.SaveChanges();
            ShowOrganisation();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewOrganisation.SelectedItems.Count == 1)
            {
                OrganisationsSet organisationsSet = listViewOrganisation.SelectedItems[0].Tag as OrganisationsSet;
                organisationsSet.Name = textBoxName.Text;
                organisationsSet.Adress = textBoxAdress.Text;
                organisationsSet.Phone = textBoxPhone.Text;
                Program.bdad.SaveChanges();
                ShowOrganisation();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewOrganisation.SelectedItems.Count == 1)
                {
                    OrganisationsSet organisationsSet = listViewOrganisation.SelectedItems[0].Tag as OrganisationsSet;
                    Program.bdad.OrganisationsSet.Remove(organisationsSet);
                    Program.bdad.SaveChanges();
                    ShowOrganisation();
                }
                textBoxName.Text = "";
                textBoxAdress.Text = "";
                textBoxPhone.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
