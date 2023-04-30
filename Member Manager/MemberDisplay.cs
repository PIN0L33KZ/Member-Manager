using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Member_Manager
{
    public partial class MemberDisplay : UserControl
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
        public DateTime AuthorizedYear { get; set; }
        #endregion

        public MemberDisplay()
        {
            InitializeComponent();
        }

        public void UpdateDisplay()
        {
            LBL_MemberFullName.Text = Forename + ", " + Surname;
            LBL_MemberAdress.Text = $"{Street} {Housenumber}\n{Zipcode} {Town}";
            LBL_MemberBirthday.Text = "Geboren: " + DateOfBirth.ToString("dd.MM.yyyy");
            LBL_MemberEntryDate.Text = "Eintritt: " + EntryDate.ToString("dd.MM.yyyy");
            LBL_MemberCosts.Text = "Mitgliedsbeitrag:: " + GetMemberCosts().ToString() + "€/mtl.";
            PBX_Archer.Visible = Bow;
            PBX_AirPressureWeapon.Visible = AirPressureWeapons;
            PBX_FireWeapon.Visible = FireWeapons;

            if (MemberIsAuthorized())
            {
                LBL_LicenceAuthorized.Text = "Erwerbsberechtigt";
                TTP_1.SetToolTip(LBL_LicenceAuthorized, $"Das Mitglied war/ist im Jahr {AuthorizedYear.Year} berechtigt einen Waffenschein zu erwerben.");
                LBL_LicenceAuthorized.ForeColor = Color.FromArgb(76, 209, 55);
            }
            else
            {
                LBL_LicenceAuthorized.Text = "Nicht erwerbsberechtigt";
                TTP_1.SetToolTip(LBL_LicenceAuthorized, $"Das Mitglied war/ist im Jahr {AuthorizedYear.Year} nicht berechtigt einen Waffenschein zu erwerben.");
                LBL_LicenceAuthorized.ForeColor = Color.FromArgb(232, 65, 24);
            }

            if (Active)
            {
                LBL_MemberIsActive.Text = "Aktiv";
                LBL_MemberIsActive.ForeColor = Color.FromArgb(76, 209, 55);
            }
            else
            {
                LBL_MemberIsActive.Text = "Inaktiv";
                LBL_MemberIsActive.ForeColor = Color.FromArgb(232, 65, 24);
            }
        }

        private decimal GetMemberCosts()
        {
            decimal costs = 0;
            int DepartmentsCount = 0;

            if (Bow)
            {
                costs = 8;
                DepartmentsCount++;
            }

            if (AirPressureWeapons)
            {
                costs = 10;
                DepartmentsCount++;
            }

            if (FireWeapons)
            {
                costs = 15;
                DepartmentsCount++;
            }

            if (DepartmentsCount > 1)
            {
                costs = 20;
            }

            return costs;
        }

        private bool MemberIsAuthorized()
        {
            MySqlConnection connection = new MySqlConnection(Properties.Resources.SqlConnection);
            MySqlCommand command = new MySqlCommand(@"SELECT * FROM Presence WHERE MemberID=@memberid AND DateOfPresence LIKE @year;", connection);
            _ = command.Parameters.AddWithValue("@memberid", ID);
            _ = command.Parameters.AddWithValue("@year", $"{AuthorizedYear.Year}-%");

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter() { SelectCommand = command };

            DataTable dataTable = new DataTable();

            try
            {
                _ = dataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show($"Ein unerwarteter Fehler ist aufgetreten.\n{ex.Message}", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (dataTable.Rows.Count >= 18)
            {
                return true; //Member was present at least 18 times in the given year
            }

            int count = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                for (int i = 1; i < 13; i++)
                {
                    command.CommandText = @"SELECT Count(*) FROM Presence WHERE MemberID=@memberid AND DateOfPresence LIKE @monthandyear;";
                    command.Connection = connection;
                    command.Parameters.Clear();
                    _ = command.Parameters.AddWithValue("memberid", ID);
                    _ = command.Parameters.AddWithValue("@monthandyear", $"{AuthorizedYear.Year}-{new DateTime(2000, i, 1):MM}-%");

                    try
                    {
                        connection.Open();
                        int currentCount = Convert.ToInt32(command.ExecuteScalar());
                        connection.Close();

                        if (currentCount > 0)
                        {
                            count++;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        _ = MessageBox.Show($"Ein unerwarteter Fehler ist aufgetreten.\n{ex.Message}", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                if (count == 12)
                {
                    return true;
                }
            }

            return false;
        }

        private void BTN_EditMember_Click(object sender, EventArgs e)
        {
            FRM_EditMember editMemberForm = new FRM_EditMember()
            {
                ID = ID,
                Forename = Forename,
                Surname = Surname,
                Street = Street,
                Housenumber = Housenumber,
                Zipcode = Zipcode,
                Town = Town,
                DateOfBirth = DateOfBirth,
                EntryDate = EntryDate,
                Active = Active,
                Bow = Bow,
                AirPressureWeapons = AirPressureWeapons,
                FireWeapons = FireWeapons
            };
            _ = editMemberForm.ShowDialog();
            UpdateDisplay();
        }

        private void BTN_EditPresence_Click(object sender, EventArgs e)
        {
            FRM_MemberPresenceList memberPresenceForm = new FRM_MemberPresenceList() { MemberID = ID, MemberForename = Forename, MemberSurame = Surname };
            _ = memberPresenceForm.ShowDialog();
        }
    }
}