using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VŽBUS_.Repositories;
using VŽBUS_.Models;

namespace VŽBUS_
{
    public partial class FrmPassengers : Form
    {
        public FrmPassengers()
        {
            InitializeComponent();
        }

        private void FrmPassengers_Load(object sender, EventArgs e)
        {
            ShowPassengers();
        }

        private void ShowPassengers()
        {
            List<Korisnik> korisnici = KorisnikRepository.GetKorisnici();
            dgvPassengers.DataSource = korisnici;
        }
    }
}
