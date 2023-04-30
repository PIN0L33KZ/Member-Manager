using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Member_Manager
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            #region check if db is available
            if (Sql.CheckDBAvailabillity() == false)
            {
                Application.Exit();
            }
            #endregion

            //
            // the code below will only be executet if a connection to the db is possible.
            //

            #region check if any admin exists
            try
            {
                MySqlConnection connection = new MySqlConnection(Properties.Resources.SqlConnection);

                MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM Admins", connection);

                connection.Open();

                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {
                    Application.Run(new FRM_Login());
                }
                else
                {
                    Application.Run(new FRM_AddAdmin());
                }
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show($"Ein unerwarteter Fehler ist aufgetreten.\n{ex.Message}", "Member Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion
        }
    }
}