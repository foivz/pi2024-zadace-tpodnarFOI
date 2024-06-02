using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VŽBUS_
{
    public partial class FrmManageStations : Form
    {
        private string connectionString = "Data Source=31.147.206.65;Initial Catalog=PI2324_tpodnar22_DB;User Id=PI2324_tpodnar22_User;Password=%K^{YcZ(";

        public FrmManageStations()
        {
            InitializeComponent();
        }

        private void FrmManageStations_Load(object sender, EventArgs e)
        {
            LoadStations();
        }

        private void LoadStations()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Stanica";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvStations.DataSource = dataTable;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Stanica (Naziv, Lokacija) VALUES (@Naziv, @Lokacija)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Naziv", txtName.Text);
                command.Parameters.AddWithValue("@Lokacija", txtLocation.Text);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            LoadStations();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvStations.SelectedRows.Count > 0)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Stanica SET Naziv = @Naziv, Lokacija = @Lokacija WHERE ID_stanice = @ID_stanice";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID_stanice", (int)dgvStations.SelectedRows[0].Cells["ID_stanice"].Value);
                    command.Parameters.AddWithValue("@Naziv", txtName.Text);
                    command.Parameters.AddWithValue("@Lokacija", txtLocation.Text);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadStations();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStations.SelectedRows.Count > 0)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Stanica WHERE ID_stanice = @ID_stanice";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID_stanice", (int)dgvStations.SelectedRows[0].Cells["ID_stanice"].Value);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadStations();
            }
        }

        private void dgvStations_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStations.SelectedRows.Count > 0)
            {
                txtName.Text = dgvStations.SelectedRows[0].Cells["Naziv"].Value.ToString();
                txtLocation.Text = dgvStations.SelectedRows[0].Cells["Lokacija"].Value.ToString();
            }
        }
    }
}
