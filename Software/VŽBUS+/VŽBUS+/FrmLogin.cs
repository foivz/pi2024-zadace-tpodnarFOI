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
            ShowAllForms();
        }

        private void ShowAllForms()
        {
            FrmPassengers frmPassengers = new FrmPassengers();
            frmPassengers.Show();
            FrmBusLines frmBusLines = new FrmBusLines();
            frmBusLines.Show();
            FrmManageBuses frmManageBuses = new FrmManageBuses();
            frmManageBuses.Show();
            FrmManageLines frmManageLines = new FrmManageLines();
            frmManageLines.Show();
            FrmManageReservations frmManageReservations = new FrmManageReservations();
            frmManageReservations.Show();
            FrmManageStations frmManageStations = new FrmManageStations();
            frmManageStations.Show();
            FrmManageTickets frmManageTickets = new FrmManageTickets();
            frmManageTickets.Show();

            
            this.Hide();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
