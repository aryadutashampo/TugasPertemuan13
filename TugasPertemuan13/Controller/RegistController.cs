using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TugasPertemuan13.Model;

namespace TugasPertemuan13.Controller
{
    internal class RegistController : Model.Connection
    {
        Connection Koneksi = new Connection();

        public void tambahAdmin(string username, string pw)
        {
            string tambah = "INSERT INTO admin VALUES(" + "@username,@pw)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@username", MySqlConnector.MySqlDbType.VarChar).Value = username;
                cmd.Parameters.Add("@pw", MySqlConnector.MySqlDbType.VarChar).Value = pw;
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Tambah Data Admin Gagal" + ex.Message);
            }
        }
    }
}
