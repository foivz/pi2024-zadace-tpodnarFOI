using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VŽBUS_
{
    public partial class FrmManageLines : Form
    {
        private string connectionString = "Data Source=31.147.206.65;Initial Catalog=PI2324_tpodnar22_DB;User Id=PI2324_tpodnar22_User;Password=%K^{YcZ(";

        public FrmManageLines()
        {
            InitializeComponent();
        }

        private void FrmManageLines_Load(object sender, EventArgs e)
        {
            LoadLines();
        }

        private void LoadLines()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Linija";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvLines.DataSource = dataTable;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Linija (Polazište, Odredište, Vrijeme_polaska, Vrijeme_dolaska) VALUES (@Polazište, @Odredište, @Vrijeme_polaska, @Vrijeme_dolaska)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Polazište", txtStart.Text);
                command.Parameters.AddWithValue("@Odredište", txtDestination.Text);
                command.Parameters.AddWithValue("@Vrijeme_polaska", TimeSpan.Parse(txtDepartureTime.Text));
                command.Parameters.AddWithValue("@Vrijeme_dolaska", TimeSpan.Parse(txtArrivalTime.Text));
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            LoadLines();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvLines.SelectedRows.Count > 0)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Linija SET Polazište = @Polazište, Odredište = @Odredište, Vrijeme_polaska = @Vrijeme_polaska, Vrijeme_dolaska = @Vrijeme_dolaska WHERE ID_linije = @ID_linije";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID_linije", (int)dgvLines.SelectedRows[0].Cells["ID_linije"].Value);
                    command.Parameters.AddWithValue("@Polazište", txtStart.Text);
                    command.Parameters.AddWithValue("@Odredište", txtDestination.Text);
                    command.Parameters.AddWithValue("@Vrijeme_polaska", TimeSpan.Parse(txtDepartureTime.Text));
                    command.Parameters.AddWithValue("@Vrijeme_dolaska", TimeSpan.Parse(txtArrivalTime.Text));
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadLines();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvLines.SelectedRows.Count > 0)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Linija WHERE ID_linije = @ID_linije";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID_linije", (int)dgvLines.SelectedRows[0].Cells["ID_linije"].Value);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadLines();
            }
        }

        private void dgvLines_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLines.SelectedRows.Count > 0)
            {
                txtStart.Text = dgvLines.SelectedRows[0].Cells["Polazište"].Value.ToString();
                txtDestination.Text = dgvLines.SelectedRows[0].Cells["Odredište"].Value.ToString();
                txtDepartureTime.Text = dgvLines.SelectedRows[0].Cells["Vrijeme_polaska"].Value.ToString();
                txtArrivalTime.Text = dgvLines.SelectedRows[0].Cells["Vrijeme_dolaska"].Value.ToString();
            }
        }
    }
}
