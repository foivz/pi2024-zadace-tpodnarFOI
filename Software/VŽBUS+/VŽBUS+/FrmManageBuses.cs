using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VŽBUS_
{
    public partial class FrmManageBuses : Form
    {
        private string connectionString = "Data Source=31.147.206.65;Initial Catalog=PI2324_tpodnar22_DB;User Id=PI2324_tpodnar22_User;Password=%K^{YcZ(";

        public FrmManageBuses()
        {
            InitializeComponent();
        }

        private void FrmManageBuses_Load(object sender, EventArgs e)
        {
            LoadBuses();
        }

        private void LoadBuses()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Autobus";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvBuses.DataSource = dataTable;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Autobus (Registracijski_broj, Kapacitet) VALUES (@Registracijski_broj, @Kapacitet)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Registracijski_broj", txtRegistrationNumber.Text);
                command.Parameters.AddWithValue("@Kapacitet", int.Parse(txtCapacity.Text));
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            LoadBuses();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvBuses.SelectedRows.Count > 0)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Autobus SET Registracijski_broj = @Registracijski_broj, Kapacitet = @Kapacitet WHERE ID_autobusa = @ID_autobusa";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID_autobusa", (int)dgvBuses.SelectedRows[0].Cells["ID_autobusa"].Value);
                    command.Parameters.AddWithValue("@Registracijski_broj", txtRegistrationNumber.Text);
                    command.Parameters.AddWithValue("@Kapacitet", int.Parse(txtCapacity.Text));
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadBuses();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBuses.SelectedRows.Count > 0)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Autobus WHERE ID_autobusa = @ID_autobusa";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID_autobusa", (int)dgvBuses.SelectedRows[0].Cells["ID_autobusa"].Value);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadBuses();
            }
        }

        private void dgvBuses_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBuses.SelectedRows.Count > 0)
            {
                txtRegistrationNumber.Text = dgvBuses.SelectedRows[0].Cells["Registracijski_broj"].Value.ToString();
                txtCapacity.Text = dgvBuses.SelectedRows[0].Cells["Kapacitet"].Value.ToString();
            }
        }
    }
}
