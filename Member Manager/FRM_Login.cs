using MySql.Data.MySqlClient;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace Member_Manager
{
    public partial class FRM_Login : Form
    {
        public FRM_Login()
        {
            InitializeComponent();
        }

        private void BTN_AddAdmin_Click(object sender, EventArgs e)
        {
            ERR_Provider1.Clear(); //clear existing error messages

            #region remove whitespaces etc. from userinputs
            TBX_Username.Text = TBX_Username.Text.Trim();
            TBX_Password.Text = TBX_Password.Text.Trim();
            #endregion

            #region check userinputs
            if (TBX_Username.TextLength < 3)
            {
                ERR_Provider1.SetError(TBX_Username, "Das Feld ist unzureichend gefüllt.");
                return;
            }

            if (TBX_Password.TextLength < 3)
            {
                ERR_Provider1.SetError(TBX_Password, "Das Feld ist unzureichend gefüllt.");
                return;
            }
            #endregion

            //
            // the code below will only be executet if the inputs are filled correctly.
            //

            #region check if user exists
            try
            {
                MySqlConnection connection = new MySqlConnection(Properties.Resources.SqlConnection);

                MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM Admins WHERE Username=@username AND Password=@password AND Login=true", connection);
                command.Parameters.Clear();
                _ = command.Parameters.AddWithValue("@username", TBX_Username.Text);
                _ = command.Parameters.AddWithValue("@password", Security.HashString(TBX_Password.Text));

                connection.Open();

                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {
                    #region show dashboard
                    Hide();
                    FRM_Dashboard dashboardForm = new FRM_Dashboard(TBX_Username.Text);
                    _ = dashboardForm.ShowDialog();
                    Application.Exit();
                    #endregion
                }
                else
                {
                    _ = MessageBox.Show("Die eingegebenen Daten sind inkorrekt, oder der Login ist deaktiviert.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show($"Ein unerwarteter Fehler ist aufgetreten.\n{ex.Message}", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            #endregion
        }

        private void FRM_Login_Load(object sender, EventArgs e)
        {
            LBL_VersionAndCopyright.Text = $"Version: {Assembly.GetExecutingAssembly().GetName().Version}   ©Marcello Fülber";
        }
    }
}