using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Member_Manager
{
    public partial class FRM_Dashboard : Form
    {
        public FRM_Dashboard(string adminName)
        {
            InitializeComponent();
            LBL_AdminUserWelcomeText.Text = $"Sie sind angemeldet als: \"{adminName.ToLower()}\". Wir wünschen Ihnen einen erfolgreichen Tag!";
            UpdateBirthdayDisplay();
        }

        private void BTN_MemberOverview_Click(object sender, EventArgs e)
        {
            Hide();
            FRM_MemberOverview editMemberForm = new FRM_MemberOverview();
            _ = editMemberForm.ShowDialog();
            Show();
        }

        private void BTN_UpdateDashboard_Click(object sender, EventArgs e)
        {
            UpdateBirthdayDisplay();
        }

        private void UpdateBirthdayDisplay()
        {
            MySqlConnection connection = new MySqlConnection(Properties.Resources.SqlConnection);
            MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM Members WHERE DateOfBirth LIKE @today AND Active=true;", connection);
            command.Parameters.Clear();
            _ = command.Parameters.AddWithValue("@today", $"%-{DateTime.Today:MM-dd}");

            try
            {
                connection.Open();

                int count = Convert.ToInt32(command.ExecuteScalar()); //check if there are any birthdays today

                //if there are no birthdays
                if (count == 0)
                {
                    LBL_BirthdayMembers.Text = "Heute stehen keine Geburtstage an.";
                    return;
                }

                //
                // the code below will only execute if there are any birthdays today
                //

                command.CommandText = @"SELECT Forename, Surname, DateOfBirth FROM Members WHERE DateOfBirth LIKE @today;";

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter() { SelectCommand = command };
                DataSet dataSet = new DataSet();
                _ = dataAdapter.Fill(dataSet);

                #region build string for the ui
                StringBuilder birthdayMembersText = new StringBuilder();

                _ = birthdayMembersText.Append("Heute stehen Folgende Geburtstage an:\n");
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    _ = birthdayMembersText.Append($"{row["Forename"]} {row["Surname"]}, ");
                }
                _ = birthdayMembersText.Remove(birthdayMembersText.Length - 2, 2);
                #endregion

                LBL_BirthdayMembers.Text = birthdayMembersText.ToString();

                connection.Close();
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show($"Leider ist die Datenbank nicht erreichbar.\n{ex.Message}", "Member Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}