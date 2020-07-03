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
    public partial class FormAdvertisement : Form
    {
        void ShowOrganisation()
        {
            comboBoxOrganisation.Items.Clear();
            foreach (OrganisationsSet organisationsSet in Program.bdad.OrganisationsSet)
            {
                string[] item = { organisationsSet.Id.ToString() + ".", organisationsSet.Name, organisationsSet.Phone, organisationsSet.Adress };
                comboBoxOrganisation.Items.Add(string.Join(" ", item));
            }
        }
        void ShowNewspaaper()
        {
            comboBoxNewspaper.Items.Clear();
            foreach (NewspapersSet newspapersSet in Program.bdad.NewspapersSet)
            {
                string[] item = { newspapersSet.Id.ToString() + ".", newspapersSet.Name, newspapersSet.Phone, newspapersSet.Price };
                comboBoxNewspaper.Items.Add(string.Join(" ", item));
            }
        }
        public FormAdvertisement()
        {
            InitializeComponent();
            ShowOrganisation();
            ShowNewspaaper();
        }

        private void FormAdvertisement_Load(object sender, EventArgs e)
        {

        }

        private void listViewNewsPaper_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAdvertisement.SelectedItems.Count == 1)
            {
                AdsSet adsSet = listViewAdvertisement.SelectedItems[0].Tag as AdsSet;
                comboBoxNewspaper.SelectedIndex = comboBoxNewspaper.FindString(adsSet.Id_Newspaper.ToString());
                comboBoxOrganisation.SelectedIndex = comboBoxOrganisation.FindString(adsSet.Id_Organisation.ToString());
                textBoxNewspaperNumber.Text = adsSet.Number.ToString();
                textBoxAdvertisementSize.Text = adsSet.Size.ToString();
            }
            else
            {
                comboBoxNewspaper.SelectedItem = null;
                comboBoxOrganisation.SelectedItem = null;
                textBoxNewspaperNumber.Text = "";
                textBoxAdvertisementSize.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxNewspaper.SelectedItem != null && comboBoxOrganisation != null && textBoxNewspaperNumber.Text != "" )
            {
                AdsSet adsSet = new AdsSet();
                adsSet.Id_Newspaper = Convert.ToInt32(comboBoxNewspaper.SelectedItem.ToString().Split('.')[0]);
                adsSet.Id_Organisation = Convert.ToInt32(comboBoxOrganisation.SelectedItem.ToString().Split('.')[0]);
                adsSet.Number = (textBoxNewspaperNumber.Text);
                adsSet.Size = (textBoxAdvertisementSize.Text);
                Program.bdad.AdsSet.Add(adsSet);
                Program.bdad.SaveChanges();
                ShowAdvertisement();
            }
            else MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        void ShowAdvertisement()
        {
            listViewAdvertisement.Items.Clear();
            foreach (AdsSet adsSet in Program.bdad.AdsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    adsSet.Id.ToString(),
                    adsSet.OrganisationsSet.Name+""+adsSet.OrganisationsSet.Phone+""+adsSet.OrganisationsSet.Adress,
                    adsSet.NewspapersSet.Name+""+adsSet.NewspapersSet.Phone+""+adsSet.NewspapersSet.Price,
                    adsSet.Number,
                    adsSet.Size
                });
                item.Tag = adsSet;
                listViewAdvertisement.Items.Add(item);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewAdvertisement.SelectedItems.Count == 1)
            {
                AdsSet adsSet = listViewAdvertisement.SelectedItems[0].Tag as AdsSet;
                adsSet.Number = (textBoxNewspaperNumber.Text);
                adsSet.Size = (textBoxAdvertisementSize.Text);
                Program.bdad.SaveChanges();
                ShowAdvertisement();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewAdvertisement.SelectedItems.Count == 1)
                {
                    AdsSet adsSet = listViewAdvertisement.SelectedItems[0].Tag as AdsSet;
                    Program.bdad.AdsSet.Remove(adsSet);
                    Program.bdad.SaveChanges();
                    ShowAdvertisement();
                }
                comboBoxNewspaper.SelectedItem = null;
                comboBoxOrganisation.SelectedItem = null;
                textBoxNewspaperNumber.Text = "";
                textBoxAdvertisementSize.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
