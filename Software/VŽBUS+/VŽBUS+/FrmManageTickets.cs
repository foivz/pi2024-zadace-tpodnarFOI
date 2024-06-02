using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VŽBUS_
{
    public partial class FrmManageTickets : Form
    {
        private string connectionString = "Data Source=31.147.206.65;Initial Catalog=PI2324_tpodnar22_DB;User Id=PI2324_tpodnar22_User;Password=%K^{YcZ(";

        public FrmManageTickets()
        {
            InitializeComponent();
        }

        private void FrmManageTickets_Load(object sender, EventArgs e)
        {
            LoadTickets();
        }

        private void LoadTickets()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Karta";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvTickets.DataSource = dataTable;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Karta (ID_korisnika, ID_linije, Datum_izdavanja, Vrijeme_izdavanja, Sjedalo) VALUES (@ID_korisnika, @ID_linije, @Datum_izdavanja, @Vrijeme_izdavanja, @Sjedalo)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_korisnika", int.Parse(txtUserId.Text));
                command.Parameters.AddWithValue("@ID_linije", int.Parse(txtLineId.Text));
                command.Parameters.AddWithValue("@Datum_izdavanja", DateTime.Parse(txtIssueDate.Text));
                command.Parameters.AddWithValue("@Vrijeme_izdavanja", TimeSpan.Parse(txtIssueTime.Text));
                command.Parameters.AddWithValue("@Sjedalo", txtSeat.Text);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            LoadTickets();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvTickets.SelectedRows.Count > 0)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Karta SET ID_korisnika = @ID_korisnika, ID_linije = @ID_linije, Datum_izdavanja = @Datum_izdavanja, Vrijeme_izdavanja = @Vrijeme_izdavanja, Sjedalo = @Sjedalo WHERE ID_karte = @ID_karte";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID_karte", (int)dgvTickets.SelectedRows[0].Cells["ID_karte"].Value);
                    command.Parameters.AddWithValue("@ID_korisnika", int.Parse(txtUserId.Text));
                    command.Parameters.AddWithValue("@ID_linije", int.Parse(txtLineId.Text));
                    command.Parameters.AddWithValue("@Datum_izdavanja", DateTime.Parse(txtIssueDate.Text));
                    command.Parameters.AddWithValue("@Vrijeme_izdavanja", TimeSpan.Parse(txtIssueTime.Text));
                    command.Parameters.AddWithValue("@Sjedalo", txtSeat.Text);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadTickets();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTickets.SelectedRows.Count > 0)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Karta WHERE ID_karte = @ID_karte";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID_karte", (int)dgvTickets.SelectedRows[0].Cells["ID_karte"].Value);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadTickets();
            }
        }

        private void dgvTickets_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTickets.SelectedRows.Count > 0)
            {
                txtUserId.Text = dgvTickets.SelectedRows[0].Cells["ID_korisnika"].Value.ToString();
                txtLineId.Text = dgvTickets.SelectedRows[0].Cells["ID_linije"].Value.ToString();
                txtIssueDate.Text = dgvTickets.SelectedRows[0].Cells["Datum_izdavanja"].Value.ToString();
                txtIssueTime.Text = dgvTickets.SelectedRows[0].Cells["Vrijeme_izdavanja"].Value.ToString();
                txtSeat.Text = dgvTickets.SelectedRows[0].Cells["Sjedalo"].Value.ToString();
            }
        }
    }
}
