using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Member_Manager
{
    public partial class FRM_MemberOverview : Form
    {
        public FRM_MemberOverview()
        {
            InitializeComponent();
        }

        private void FRM_MemberOverview_Load(object sender, EventArgs e)
        {
            UpdateOverView();
        }

        private void BTN_FilterDisplays_Click(object sender, EventArgs e)
        {
            ERR_Provider1.Clear(); // clear existing errors

            #region remove whitespaces etc. from userinput
            TBX_FilterDisplayInput.Text = TBX_FilterDisplayInput.Text.Trim();
            #endregion

            FLP_MainLayout.Controls.Clear();
            try
            {
                if (RBT_FilterDisplayForename.Checked)
                {
                    MySqlConnection connection = new MySqlConnection(Properties.Resources.SqlConnection);
                    MySqlCommand command = new MySqlCommand(@"SELECT Members.*, Departments.* FROM Members INNER JOIN Departments ON Members.MemberID=Departments.MemberID WHERE Forename LIKE @forename AND Active=true;", connection);
                    command.Parameters.Clear();
                    _ = command.Parameters.AddWithValue("@forename", TBX_FilterDisplayInput.Text + "%");

                    if (CBX_FilterDisplayNotActive.Checked)
                    {
                        command.CommandText = @"SELECT Members.*, Departments.* FROM Members INNER JOIN Departments ON Members.MemberID=Departments.MemberID WHERE Forename LIKE @forename;";
                    }

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter() { SelectCommand = command };

                    DataTable dataTable = new DataTable();

                    _ = dataAdapter.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        MemberDisplay memberDisplay = new MemberDisplay()
                        {
                            ID = Convert.ToInt32(row["MemberID"]),
                            Forename = (string)row["Forename"],
                            Surname = (string)row["Surname"],
                            Street = (string)row["Street"],
                            Housenumber = (string)row["Housenumber"],
                            Zipcode = Convert.ToInt32(row["Zipcode"]),
                            Town = (string)row["Town"],
                            DateOfBirth = (DateTime)row["DateOfBirth"],
                            EntryDate = (DateTime)row["EntryDate"],
                            Active = (bool)row["active"],
                            Bow = (bool)row["Bow"],
                            AirPressureWeapons = (bool)row["AirPressureWeapons"],
                            FireWeapons = (bool)row["FireWeapons"],
                            AuthorizedYear = DTP_YearOfPresence.Value
                        };

                        FLP_MainLayout.Controls.Add(memberDisplay);

                        memberDisplay.UpdateDisplay();
                    }
                } // filter forename
                else if (RBT_FilterDisplaySurname.Checked)
                {
                    MySqlConnection connection = new MySqlConnection(Properties.Resources.SqlConnection);
                    MySqlCommand command = new MySqlCommand(@"SELECT Members.*, Departments.* FROM Members INNER JOIN Departments ON Members.MemberID=Departments.MemberID WHERE Surname LIKE @surname AND Active=true;", connection);
                    command.Parameters.Clear();
                    _ = command.Parameters.AddWithValue("@surname", TBX_FilterDisplayInput.Text + "%");

                    if (CBX_FilterDisplayNotActive.Checked)
                    {
                        command.CommandText = @"SELECT Members.*, Departments.* FROM Members INNER JOIN Departments ON Members.MemberID=Departments.MemberID WHERE Surname LIKE @surname;";
                    }

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter() { SelectCommand = command };

                    DataTable dataTable = new DataTable();

                    _ = dataAdapter.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        MemberDisplay memberDisplay = new MemberDisplay()
                        {
                            ID = Convert.ToInt32(row["MemberID"]),
                            Forename = (string)row["Forename"],
                            Surname = (string)row["Surname"],
                            Street = (string)row["Street"],
                            Housenumber = (string)row["Housenumber"],
                            Zipcode = Convert.ToInt32(row["Zipcode"]),
                            Town = (string)row["Town"],
                            DateOfBirth = (DateTime)row["DateOfBirth"],
                            EntryDate = (DateTime)row["EntryDate"],
                            Active = (bool)row["active"],
                            Bow = (bool)row["Bow"],
                            AirPressureWeapons = (bool)row["AirPressureWeapons"],
                            FireWeapons = (bool)row["FireWeapons"],
                            AuthorizedYear = DTP_YearOfPresence.Value
                        };

                        FLP_MainLayout.Controls.Add(memberDisplay);

                        memberDisplay.UpdateDisplay();
                    }
                } // filter surname
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show($"Ein unerwarteter Fehler ist aufgetreten.\n{ex.Message}", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void DTP_YearOfPresence_ValueChanged(object sender, EventArgs e)
        {
            UpdateOverView();
        }

        private void BTN_AddMember_Click(object sender, EventArgs e)
        {
            FRM_AddMember addMemberForm = new FRM_AddMember();
            _ = addMemberForm.ShowDialog();
            UpdateOverView();
        }

        private void UpdateOverView()
        {
            FLP_MainLayout.Controls.Clear();

            MySqlConnection connection = new MySqlConnection(Properties.Resources.SqlConnection);
            MySqlCommand command = new MySqlCommand(@"SELECT Members.*, Departments.* FROM Members INNER JOIN Departments ON Members.MemberID=Departments.MemberID WHERE Active=true;", connection);

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
                MemberDisplay memberDisplay = new MemberDisplay()
                {
                    ID = Convert.ToInt32(row["MemberID"]),
                    Forename = (string)row["Forename"],
                    Surname = (string)row["Surname"],
                    Street = (string)row["Street"],
                    Housenumber = (string)row["Housenumber"],
                    Zipcode = Convert.ToInt32(row["Zipcode"]),
                    Town = (string)row["Town"],
                    DateOfBirth = (DateTime)row["DateOfBirth"],
                    EntryDate = (DateTime)row["EntryDate"],
                    Active = (bool)row["active"],
                    Bow = (bool)row["Bow"],
                    AirPressureWeapons = (bool)row["AirPressureWeapons"],
                    FireWeapons = (bool)row["FireWeapons"],
                    AuthorizedYear = DTP_YearOfPresence.Value
                };

                FLP_MainLayout.Controls.Add(memberDisplay);

                memberDisplay.UpdateDisplay();
            }
        }
    }
}