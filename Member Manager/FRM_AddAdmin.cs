using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Member_Manager
{
    public partial class FRM_AddAdmin : Form
    {
        public FRM_AddAdmin()
        {
            InitializeComponent();
        }

        private void BTN_AddAdmin_Click(object sender, EventArgs e)
        {
            ERR_Provider1.Clear(); //clear existing error messages

            #region remove whitespaces etc. from userinputs
            TBX_Username.Text = TBX_Username.Text.Trim();
            TBX_Password.Text = TBX_Password.Text.Trim();
            TBX_PasswordRepeated.Text = TBX_PasswordRepeated.Text.Trim();
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

            if (TBX_PasswordRepeated.TextLength < 3)
            {
                ERR_Provider1.SetError(TBX_PasswordRepeated, "Das Feld ist unzureichend gefüllt.");
                return;
            }

            if (TBX_Password.Text != TBX_PasswordRepeated.Text)
            {
                ERR_Provider1.SetError(TBX_PasswordRepeated, "Die Passwörter stimmen nicht überein.");
            }
            #endregion

            //
            // the code below will only be executet if the inputs are filled correctly.
            //

            #region check if user exists alerady
            try
            {
                MySqlConnection connection = new MySqlConnection(Properties.Resources.SqlConnection);

                MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM Admins WHERE Username=@username", connection);
                command.Parameters.Clear();
                _ = command.Parameters.AddWithValue("@username", TBX_Username.Text);

                connection.Open();

                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {
                    ERR_Provider1.SetError(TBX_Username, "Es existiert bereits ein Verwalter mit diesem Namen.");
                    return;
                }
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show($"Ein unerwarteter Fehler ist aufgetreten.\n{ex.Message}", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            #endregion

            //
            // the code below will only be executet if no user exists with these parameters.
            //

            #region add user to db
            try
            {
                MySqlConnection connection = new MySqlConnection(Properties.Resources.SqlConnection);

                MySqlCommand command = new MySqlCommand("INSERT INTO Admins (Username, Password, Login) VALUES (@username, @password, true);", connection);
                command.Parameters.Clear();
                _ = command.Parameters.AddWithValue("@username", TBX_Username.Text);
                _ = command.Parameters.AddWithValue("@password", Security.HashString(TBX_Password.Text));

                connection.Open();

                _ = command.ExecuteNonQuery();

                _ = MessageBox.Show("Verwalter erfolgreich hinzugefügt.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show($"Ein unerwarteter Fehler ist aufgetreten.\n{ex.Message}", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            #region show login form
            Hide();
            FRM_Login loginForm = new FRM_Login();
            _ = loginForm.ShowDialog();
            Application.Exit();
            #endregion
        }
    }
}