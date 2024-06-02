using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VŽBUS_
{
    public partial class FrmManageReservations : Form
    {
        private string connectionString = "Data Source=31.147.206.65;Initial Catalog=PI2324_tpodnar22_DB;User Id=PI2324_tpodnar22_User;Password=%K^{YcZ(";

        public FrmManageReservations()
        {
            InitializeComponent();
        }

        private void FrmManageReservations_Load(object sender, EventArgs e)
        {
            LoadReservations();
        }

        private void LoadReservations()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Rezervacija";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvReservations.DataSource = dataTable;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Rezervacija (ID_korisnika, ID_linije, Datum_rezervacije, Vrijeme_rezervacije, Sjedalo) VALUES (@ID_korisnika, @ID_linije, @Datum_rezervacije, @Vrijeme_rezervacije, @Sjedalo)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_korisnika", int.Parse(txtUserId.Text));
                command.Parameters.AddWithValue("@ID_linije", int.Parse(txtLineId.Text));
                command.Parameters.AddWithValue("@Datum_rezervacije", DateTime.Parse(txtReservationDate.Text));
                command.Parameters.AddWithValue("@Vrijeme_rezervacije", TimeSpan.Parse(txtReservationTime.Text));
                command.Parameters.AddWithValue("@Sjedalo", txtSeat.Text);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            LoadReservations();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvReservations.SelectedRows.Count > 0)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Rezervacija SET ID_korisnika = @ID_korisnika, ID_linije = @ID_linije, Datum_rezervacije = @Datum_rezervacije, Vrijeme_rezervacije = @Vrijeme_rezervacije, Sjedalo = @Sjedalo WHERE ID_rezervacije = @ID_rezervacije";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID_rezervacije", (int)dgvReservations.SelectedRows[0].Cells["ID_rezervacije"].Value);
                    command.Parameters.AddWithValue("@ID_korisnika", int.Parse(txtUserId.Text));
                    command.Parameters.AddWithValue("@ID_linije", int.Parse(txtLineId.Text));
                    command.Parameters.AddWithValue("@Datum_rezervacije", DateTime.Parse(txtReservationDate.Text));
                    command.Parameters.AddWithValue("@Vrijeme_rezervacije", TimeSpan.Parse(txtReservationTime.Text));
                    command.Parameters.AddWithValue("@Sjedalo", txtSeat.Text);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadReservations();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvReservations.SelectedRows.Count > 0)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Rezervacija WHERE ID_rezervacije = @ID_rezervacije";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID_rezervacije", (int)dgvReservations.SelectedRows[0].Cells["ID_rezervacije"].Value);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadReservations();
            }
        }

        private void dgvReservations_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReservations.SelectedRows.Count > 0)
            {
                txtUserId.Text = dgvReservations.SelectedRows[0].Cells["ID_korisnika"].Value.ToString();
                txtLineId.Text = dgvReservations.SelectedRows[0].Cells["ID_linije"].Value.ToString();
                txtReservationDate.Text = dgvReservations.SelectedRows[0].Cells["Datum_rezervacije"].Value.ToString();
                txtReservationTime.Text = dgvReservations.SelectedRows[0].Cells["Vrijeme_rezervacije"].Value.ToString();
                txtSeat.Text = dgvReservations.SelectedRows[0].Cells["Sjedalo"].Value.ToString();
            }
        }
    }
}

