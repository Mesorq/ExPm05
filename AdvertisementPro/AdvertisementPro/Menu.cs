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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonOrganisation_Click(object sender, EventArgs e)
        {
            Form formOrganisation = new FormOrganisation();
            formOrganisation.Show();
        }

        private void buttonNewspaper_Click(object sender, EventArgs e)
        {
            Form formNewspaper = new FormNewspaper();
            formNewspaper.Show();
        }

        private void buttonAdvertisement_Click(object sender, EventArgs e)
        {
            Form formAdvertisement = new FormAdvertisement();
            formAdvertisement.Show();
        }
    }
}
