using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VŽBUS_
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void btnShowBusLines_Click(object sender, EventArgs e)
        {
            FrmBusLines frmBusLines = new FrmBusLines();
            frmBusLines.ShowDialog();
        }

        private void btnManageBuses_Click(object sender, EventArgs e)
        {
            FrmManageBuses frmManageBuses = new FrmManageBuses();
            frmManageBuses.ShowDialog(); 
        }

        private void btnManagePassengers_Click(object sender, EventArgs e)
        {
            FrmPassengers frmPassengers = new FrmPassengers();
            frmPassengers.ShowDialog(); 
        }

        private void btnManageLines_Click(object sender, EventArgs e)
        {
            FrmManageLines frmManageLines = new FrmManageLines();
            frmManageLines.ShowDialog(); 
        }

        private void btnManageReservations_Click(object sender, EventArgs e)
        {
            FrmManageReservations frmManageReservations = new FrmManageReservations();
            frmManageReservations.ShowDialog(); 
        }

        private void btnManageStations_Click(object sender, EventArgs e)
        {
            FrmManageStations frmManageStations = new FrmManageStations();
            frmManageStations.ShowDialog(); 
        }

        private void btnManageTickets_Click(object sender, EventArgs e)
        {
            FrmManageTickets frmManageTickets = new FrmManageTickets();
            frmManageTickets.ShowDialog(); 
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
