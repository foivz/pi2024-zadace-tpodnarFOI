using System;
using System.Windows.Forms;

namespace VŽBUS_
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Nepotrebno je provjeravati korisničko ime i lozinku.
            FrmPassengers frmPassengers = new FrmPassengers();
            frmPassengers.Show();
            this.Hide();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
