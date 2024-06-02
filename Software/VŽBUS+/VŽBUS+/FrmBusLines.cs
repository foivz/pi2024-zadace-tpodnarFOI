using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VŽBUS_.Models;
using VŽBUS_.Repositories;

namespace VŽBUS_
{
    public partial class FrmBusLines : Form
    {
        public FrmBusLines()
        {
            InitializeComponent();
        }

        private void FrmBusLines_Load(object sender, EventArgs e)
        {
            LoadBusLines();
        }

        private void LoadBusLines()
        {
            List<Linija> linije = LinijaRepository.GetLinije();
            dgvBusLines.DataSource = linije;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text;
            List<Linija> linije = LinijaRepository.SearchLinije(searchTerm);
            dgvBusLines.DataSource = linije;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
