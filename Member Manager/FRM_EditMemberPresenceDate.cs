using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Member_Manager
{
    public partial class FRM_EditMemberPresenceDate : Form
    {
        #region Properties
        public DateTime DateOfPresence { get; set; }
        public int PresenceID { get; set; }
        public int MemberID { get; set; }
        #endregion

        public FRM_EditMemberPresenceDate()
        {
            InitializeComponent();
        }

        private void FRM_EditMemberPresenceDate_Load(object sender, EventArgs e)
        {
            DTP_DateOfPresence.Value = DateOfPresence;
            DTP_DateOfPresence.MaxDate = DateTime.Today;
        }

        private void BTN_SaveDateOfPresence_Click(object sender, EventArgs e)
        {
            ERR_Provider1.Clear();

            #region check if presence exists
            if (PresenceExists(MemberID, DTP_DateOfPresence.Value))
            {
                ERR_Provider1.SetError(BTN_DeleteDateOfPresence, "Diese Anwesenheit ist bereits hinterlegt.");
                return;
            }
            #endregion

            #region save changes in db
            MySqlConnection connection = new MySqlConnection(Properties.Resources.SqlConnection);
            MySqlCommand command = new MySqlCommand(@"UPDATE Presence SET DateOfPresence=@date WHERE PresenceID=@id;", connection);
            _ = command.Parameters.AddWithValue("@date", DTP_DateOfPresence.Value);
            _ = command.Parameters.AddWithValue("@id", PresenceID);

            try
            {
                connection.Open();

                _ = command.ExecuteNonQuery();

                _ = MessageBox.Show("Anwesenheit erfolgreich geändert.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();

                connection.Close();
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show($"Ein unerwarteter Fehler ist aufgetreten.\n{ex.Message}", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion
        }

        private void BTN_DeleteDateOfPresence_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Soll diese Anwesenheit gelöscht werden?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }

            MySqlConnection connection = new MySqlConnection(Properties.Resources.SqlConnection);
            MySqlCommand command = new MySqlCommand(@"DELETE FROM Presence WHERE PresenceID=@id", connection);
            _ = command.Parameters.AddWithValue("@id", PresenceID);

            try
            {
                connection.Open();

                _ = command.ExecuteNonQuery();

                _ = MessageBox.Show("Anwesenheit erfolgreich entfernt.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();

                connection.Close();
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show($"Ein unerwarteter Fehler ist aufgetreten.\n{ex.Message}", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private bool PresenceExists(int memberID, DateTime dateOfPresence)
        {
            MySqlConnection connection = new MySqlConnection(Properties.Resources.SqlConnection);
            MySqlCommand command = new MySqlCommand(@"SELECT COUNT(*) FROM Presence WHERE MemberID=@memberid AND DateOfPresence=@date;", connection);
            _ = command.Parameters.AddWithValue("@memberid", memberID);
            _ = command.Parameters.AddWithValue("@date", dateOfPresence.ToString("yyyy-MM-dd"));

            try
            {
                connection.Open();

                int count = Convert.ToInt32(command.ExecuteScalar());

                return count == 1;

            }
            catch (Exception ex)
            {
                _ = MessageBox.Show($"Ein unerwarteter Fehler ist aufgetreten.\n{ex.Message}", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}