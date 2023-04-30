using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Member_Manager
{
    internal class Sql
    {
        public static bool CheckDBAvailabillity()
        {
            MySqlConnection connection = new MySqlConnection(Properties.Resources.SqlConnection);

            try
            {
                connection.Open();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show($"Leider ist die Datenbank nicht erreichbar.\n{ex.Message}", "Member Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        } // check if a connection to the db is possible
    }
}