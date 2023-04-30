using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Member_Manager
{
    public partial class FRM_MemberPresenceList : Form
    {
        #region Properties
        public int MemberID { get; set; }
        public string MemberForename { get; set; }
        public string MemberSurame { get; set; }
        #endregion

        public FRM_MemberPresenceList()
        {
            InitializeComponent();
        }

        private void FRM_MemberPresenceList_Load(object sender, EventArgs e)
        {
            DTP_YearOfPresence.Value = DateTime.Today;
            UpdatePresenceList();
        }

        private void BTN_AddDateOfPresence_Click(object sender, EventArgs e)
        {
            FRM_AddMemberPresenceDate addMemberPresenceForm = new FRM_AddMemberPresenceDate() { MemberID = MemberID };
            _ = addMemberPresenceForm.ShowDialog();
            UpdatePresenceList();
        }

        private void DTP_YearOfPresence_ValueChanged(object sender, EventArgs e)
        {
            UpdatePresenceList();
        }

        private void BTN_UpdateList_Click(object sender, EventArgs e)
        {
            UpdatePresenceList();
        }

        public void UpdatePresenceList()
        {
            LBL_MemberFullName.Text = MemberForename + ", " + MemberSurame;

            FLP_LayoutMain.Controls.Clear();

            MySqlConnection connection = new MySqlConnection(Properties.Resources.SqlConnection);
            MySqlCommand command = new MySqlCommand(@"SELECT * FROM Presence WHERE MemberID=@id AND DateOfPresence LIKE @date ORDER BY DateOfPresence DESC;", connection);
            _ = command.Parameters.AddWithValue("@id", MemberID);
            _ = command.Parameters.AddWithValue("@date", $"{DTP_YearOfPresence.Value.Year}-%");

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter() { SelectCommand = command };

            DataTable dataTable = new DataTable();

            try
            {
                _ = dataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show($"Ein unerwarteter Fehler ist aufgetreten.\n{ex.Message}", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (DataRow row in dataTable.Rows)
            {
                MemberPresenceDisplay memberPresenceDisplay = new MemberPresenceDisplay() { PresenceID = Convert.ToInt32(row["PresenceID"]), MemberID = MemberID };
                FLP_LayoutMain.Controls.Add(memberPresenceDisplay);
                memberPresenceDisplay.UpdateDisplay();
            }
        }
    }
}