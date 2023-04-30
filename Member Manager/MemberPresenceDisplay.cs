using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Member_Manager
{
    public partial class MemberPresenceDisplay : UserControl
    {
        #region Properties
        public int PresenceID { get; set; }
        public int MemberID { get; set; }
        private DateTime _dateOfPresence { get; set; }
        #endregion

        public MemberPresenceDisplay()
        {
            InitializeComponent();
        }

        public void UpdateDisplay()
        {
            MySqlConnection connection = new MySqlConnection(Properties.Resources.SqlConnection);
            MySqlCommand command = new MySqlCommand(@"SELECT * FROM Presence WHERE PresenceID=@id;", connection);
            _ = command.Parameters.AddWithValue("@id", PresenceID);

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter() { SelectCommand = command };

            DataTable dataTable = new DataTable();

            try
            {
                _ = dataAdapter.Fill(dataTable);

                LBL_PresenceDate.Text = Convert.ToDateTime(dataTable.Rows[0]["DateOfPresence"]).ToString("dd.MM.yyyy");
                _dateOfPresence = Convert.ToDateTime(dataTable.Rows[0]["DateOfPresence"]);
            }
            catch (IndexOutOfRangeException)
            {
                //Presence was deleted.
                Hide();
                return;
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show($"Ein unerwarteter Fehler ist aufgetreten.\n{ex.Message}", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void BTN_EditPresence_Click(object sender, EventArgs e)
        {
            FRM_EditMemberPresenceDate editMemberPresenceForm = new FRM_EditMemberPresenceDate() { PresenceID = PresenceID, DateOfPresence = _dateOfPresence, MemberID = MemberID };
            _ = editMemberPresenceForm.ShowDialog();
            UpdateDisplay();
        }
    }
}