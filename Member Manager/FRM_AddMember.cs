using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Member_Manager
{
    public partial class FRM_AddMember : Form
    {
        public FRM_AddMember()
        {
            InitializeComponent();
        }

        private void BTN_AddMember_Click(object sender, EventArgs e)
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

            #region check userinputs
            #region MemberProperties
            if (!TBX_Forename.Text.All(char.IsLetter) || TBX_Forename.TextLength == 0)
            {
                ERR_Provider1.SetError(BTN_AddMember, "Der Vorname darf nur mit Buchstaben gefüllt sein.");
                return;
            }

            if (!TBX_Surname.Text.All(char.IsLetter) || TBX_Surname.TextLength == 0)
            {
                ERR_Provider1.SetError(BTN_AddMember, "Der Nachname darf nur mit Buchstaben gefüllt sein.");
                return;
            }
            #endregion

            #region Adress
            if (TBX_Street.Text.Any(char.IsNumber) || TBX_Street.Text.Any(char.IsSymbol) || TBX_Street.TextLength == 0)
            {
                ERR_Provider1.SetError(BTN_AddMember, "Die Straße darf nur mit Buchstaben gefüllt sein.");
                return;
            }

            string pattern = @"^[0-9]{1,}$|^[0-9]{1,}[a-z]?$";
            Regex regex = new Regex(pattern);
            if (!regex.IsMatch(TBX_Housenumber.Text) || TBX_Housenumber.TextLength == 0)
            {
                ERR_Provider1.SetError(BTN_AddMember, "Hausnummern müssen mit Zahlen starten und dürfen maximal einen Buchstabe, am Ende, enthalten.");
                return;
            }

            if (!TBX_Zipcode.Text.All(char.IsNumber) || TBX_Street.TextLength == 0)
            {
                ERR_Provider1.SetError(BTN_AddMember, "Die Postleitzahl darf nur mit Zahlen gefüllt sein.");
                return;
            }

            if (TBX_Town.Text.Any(char.IsNumber) || TBX_Town.Text.Any(char.IsSymbol) || TBX_Street.TextLength == 0)
            {
                ERR_Provider1.SetError(BTN_AddMember, "Der Ort darf nur mit Buchstaben und Leerzeichen gefüllt sein.");
                return;
            }
            #endregion
            #endregion

            //
            // the code below will only be executet if all userinputs are valid
            //

            #region check if member exists
            MySqlConnection connection = new MySqlConnection(Properties.Resources.SqlConnection);
            MySqlCommand commandCheckIfExists = new MySqlCommand(@"SELECT COUNT(*) FROM Members WHERE Forename=@forename AND Surname=@surname AND DateOfBirth=@dateofbirth;", connection);
            _ = commandCheckIfExists.Parameters.AddWithValue("@forename", TBX_Forename.Text);
            _ = commandCheckIfExists.Parameters.AddWithValue("@surname", TBX_Surname.Text);
            _ = commandCheckIfExists.Parameters.AddWithValue("@dateofbirth", DTP_DateOfBirth.Value);

            try
            {
                connection.Open();

                int count = Convert.ToInt32(commandCheckIfExists.ExecuteScalar());

                if (count > 0)
                {
                    ERR_Provider1.SetError(BTN_AddMember, "Dieses Mitglied existiert bereits!");
                    return;
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show($"Leider ist die Datenbank nicht erreichbar.\n{ex.Message}", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            //
            // the code below will only be executet if no member exists
            //

            #region add member to db

            #region insert member
            MySqlCommand commandInsertMember = new MySqlCommand(@"INSERT INTO Members (Forename, Surname, Street, Housenumber, Zipcode, Town, DateOfBirth, EntryDate, Active) VALUES (@forename, @surname, @street, @housenumber, @zipcode, @town, @dateofbirth, @entrydate, true);", connection);
            commandInsertMember.Parameters.Clear();
            _ = commandInsertMember.Parameters.AddWithValue("@forename", TBX_Forename.Text);
            _ = commandInsertMember.Parameters.AddWithValue("@surname", TBX_Surname.Text);
            _ = commandInsertMember.Parameters.AddWithValue("@street", TBX_Street.Text);
            _ = commandInsertMember.Parameters.AddWithValue("@housenumber", TBX_Housenumber.Text);
            _ = commandInsertMember.Parameters.AddWithValue("@zipcode", Convert.ToInt32(TBX_Zipcode.Text));
            _ = commandInsertMember.Parameters.AddWithValue("@town", TBX_Town.Text);
            _ = commandInsertMember.Parameters.AddWithValue("@dateofbirth", DTP_DateOfBirth.Value);
            _ = commandInsertMember.Parameters.AddWithValue("@entrydate", DTP_EntryDate.Value);
            #endregion

            #region select memberid
            MySqlCommand commandGetMemberID = new MySqlCommand(@"SELECT MemberID FROM Members WHERE Forename=@forename AND Surname=@surname AND DateOfBirth=@dateofbirth;", connection);
            _ = commandGetMemberID.Parameters.AddWithValue("@forename", TBX_Forename.Text);
            _ = commandGetMemberID.Parameters.AddWithValue("@surname", TBX_Surname.Text);
            _ = commandGetMemberID.Parameters.AddWithValue("@dateofbirth", DTP_DateOfBirth.Value);

            DataTable dataSetDepartments = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter() { SelectCommand = commandGetMemberID };
            #endregion

            #region insert department
            MySqlCommand commandInsertDepartment = new MySqlCommand(@"INSERT INTO Departments (MemberID, Bow, AirPressureWeapons, FireWeapons) VALUES (@memberid, @bow, @airpruessureweapons, @fireweapons);", connection);
            _ = commandInsertDepartment.Parameters.AddWithValue("@bow", CBX_Bow.Checked);
            _ = commandInsertDepartment.Parameters.AddWithValue("@airpruessureweapons", CBX_AirPressureWeapons.Checked);
            _ = commandInsertDepartment.Parameters.AddWithValue("@fireweapons", CBX_FireWeapons.Checked);
            #endregion

            try
            {
                connection.Open();

                _ = commandInsertMember.ExecuteNonQuery(); // insert member

                _ = dataAdapter.Fill(dataSetDepartments); // get memberid


                _ = commandInsertDepartment.Parameters.AddWithValue("@memberid", dataSetDepartments.Rows[0]["MemberID"]); // add memberid to insert
                _ = commandInsertDepartment.ExecuteNonQuery(); // insert departments


                _ = MessageBox.Show("Das Mitglied wurde erfolgreich hinzugefügt.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                connection.Close();
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show($"Leider ist die Datenbank nicht erreichbar.\n{ex.Message}", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            //
            // the code below will only be executet if the member was added successfully
            //

            #region clear userinputs
            TBX_Forename.Clear();
            TBX_Surname.Clear();
            DTP_DateOfBirth.Value = DateTime.Today;
            DTP_EntryDate.Value = DateTime.Today;
            TBX_Street.Clear();
            TBX_Housenumber.Clear();
            TBX_Zipcode.Clear();
            TBX_Town.Clear();
            CBX_Bow.Checked = false;
            CBX_AirPressureWeapons.Checked = false;
            CBX_FireWeapons.Checked = false;
            #endregion
        }

        private void FRM_AddMember_Load(object sender, EventArgs e)
        {
            // selecting current dates in entrydate and dateofbirth
            DTP_DateOfBirth.Value = DateTime.Today.Date;
            DTP_DateOfBirth.MaxDate = DateTime.Today;
            DTP_EntryDate.Value = DateTime.Today.Date;
        }
    }
}