using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Member_Manager
{
    public partial class FRM_EditMember : Form
    {
        #region Properties
        public int ID { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string Street { get; set; }
        public string Housenumber { get; set; }
        public int Zipcode { get; set; }
        public string Town { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime EntryDate { get; set; }
        public bool Active { get; set; }
        public bool Bow { get; set; }
        public bool AirPressureWeapons { get; set; }
        public bool FireWeapons { get; set; }
        #endregion

        public FRM_EditMember()
        {
            InitializeComponent();
        }

        private void BTN_SaveMember_Click(object sender, EventArgs e)
        {
            ERR_Provider1.Clear(); //clear existing errors

            #region remove whitespaces etc from userinput
            TBX_Forename.Text = TBX_Forename.Text.Trim();
            TBX_Surname.Text = TBX_Surname.Text.Trim();
            TBX_Street.Text = TBX_Street.Text.Trim();
            TBX_Housenumber.Text = TBX_Housenumber.Text.Trim();
            TBX_Zipcode.Text = TBX_Zipcode.Text.Trim();
            TBX_Town.Text = TBX_Town.Text.Trim();
            #endregion

            #region update data in db
            try
            {
                MySqlConnection connection = new MySqlConnection(Properties.Resources.SqlConnection);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder();

                #region update member table
                MySqlCommand updateCommand = new MySqlCommand(@"SELECT * FROM Members WHERE MemberID=@id;", connection);
                _ = updateCommand.Parameters.AddWithValue("@id", ID);

                dataAdapter.SelectCommand = updateCommand;
                commandBuilder.DataAdapter = dataAdapter;

                DataTable memberDataTable = new DataTable();
                _ = dataAdapter.Fill(memberDataTable);

                foreach (DataRow row in memberDataTable.Rows)
                {
                    row["Forename"] = TBX_Forename.Text;
                    row["Surname"] = TBX_Surname.Text;
                    row["Street"] = TBX_Street.Text;
                    row["Housenumber"] = TBX_Housenumber.Text;
                    row["Zipcode"] = Convert.ToInt32(TBX_Zipcode.Text);
                    row["Town"] = TBX_Town.Text;
                    row["DateOfBirth"] = DTP_DateOfBirth.Value;
                    row["EntryDate"] = DTP_EntryDate.Value;
                    row["Active"] = CBX_MemberIsActive.Checked;
                }

                _ = dataAdapter.Update(memberDataTable);
                #endregion

                #region update department table
                updateCommand.CommandText = @"SELECT * FROM Departments WHERE MemberID=@id;";

                DataTable departmentDataTable = new DataTable();

                dataAdapter = new MySqlDataAdapter() { SelectCommand = updateCommand };
                commandBuilder = new MySqlCommandBuilder() { DataAdapter = dataAdapter };
                _ = dataAdapter.Fill(departmentDataTable);

                foreach (DataRow row in departmentDataTable.Rows)
                {
                    row["Bow"] = CBX_Bow.Checked;
                    row["AirPressureWeapons"] = CBX_AirPressureWeapons.Checked;
                    row["FireWeapons"] = CBX_FireWeapons.Checked;
                }

                _ = dataAdapter.Update(departmentDataTable);
                #endregion
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show($"Ein unerwarteter Fehler ist aufgetreten.\n{ex.Message}", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            //
            // the code below only executes if tables are updated successfully
            //

            _ = MessageBox.Show("Das Mitglied wurde erfolgreich geändert.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void FRM_EditMember_Load(object sender, EventArgs e)
        {
            TBX_Forename.Text = Forename;
            TBX_Surname.Text = Surname;
            DTP_DateOfBirth.Value = DateOfBirth;
            DTP_DateOfBirth.MaxDate = DateTime.Today;
            DTP_EntryDate.Value = EntryDate;
            CBX_MemberIsActive.Checked = Active;

            TBX_Street.Text = Street;
            TBX_Housenumber.Text = Housenumber;
            TBX_Zipcode.Text = Zipcode.ToString();
            TBX_Town.Text = Town;

            CBX_Bow.Checked = Bow;
            CBX_AirPressureWeapons.Checked = AirPressureWeapons;
            CBX_FireWeapons.Checked = FireWeapons;
        }

        private void BTN_RemoveMember_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ACHTUNG! Aus Buchhalterischen Gründen wird es empfohlen, das Mitglied zu deaktivieren und nicht zu löschen!\nDennoch fortfahren?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    MySqlConnection connection = new MySqlConnection(Properties.Resources.SqlConnection);
                    MySqlCommand command = new MySqlCommand(@"DELETE FROM Members WHERE MemberID=@id;", connection);
                    _ = command.Parameters.AddWithValue("@id", ID);

                    connection.Open();

                    _ = command.ExecuteNonQuery(); // remove from members

                    command.CommandText = @"DELETE FROM Departments WHERE MemberID=@id;";
                    _ = command.ExecuteNonQuery(); // remove from departments

                    _ = MessageBox.Show("Das Mitglied wurde erfolgreich gelöscht.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();
                }
                catch (Exception ex)
                {
                    _ = MessageBox.Show($"Ein unerwarteter Fehler ist aufgetreten.\n{ex.Message}", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}