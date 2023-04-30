using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Member_Manager
{
    public partial class FRM_AddMemberPresenceDate : Form
    {
        #region Properties
        public int MemberID { get; set; }
        #endregion

        public FRM_AddMemberPresenceDate()
        {
            InitializeComponent();
        }

        private void BTN_SaveDateOfPresence_Click(object sender, EventArgs e)
        {
            ERR_Provider1.Clear();

            #region check if presence exists
            if (PresenceExists(MemberID, DTP_DateOfPresence.Value))
            {
                ERR_Provider1.SetError(BTN_SaveDateOfPresence, "Diese Anwesenheit ist bereits hinterlegt.");
                return;
            }
            #endregion

            #region add presence to db
            MySqlConnection connection = new MySqlConnection(Properties.Resources.SqlConnection);
            MySqlCommand command = new MySqlCommand(@"INSERT INTO Presence (MemberID, DateOfPresence) VALUES (@memberid, @date)", connection);
            _ = command.Parameters.AddWithValue("@memberid", MemberID);
            _ = command.Parameters.AddWithValue("@date", DTP_DateOfPresence.Value);

            try
            {
                connection.Open();

                _ = command.ExecuteNonQuery();

                _ = MessageBox.Show("Anwesenheit erfolgreich hinzugefügt.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void FRM_AddMemberPresenceDate_Load(object sender, EventArgs e)
        {
            DTP_DateOfPresence.Value = DateTime.Today;
            DTP_DateOfPresence.MaxDate = DateTime.Today;
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

                return count != 0;

            }
            catch (Exception ex)
            {
                _ = MessageBox.Show($"Ein unerwarteter Fehler ist aufgetreten.\n{ex.Message}", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}