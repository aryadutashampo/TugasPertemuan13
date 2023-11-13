using MySqlConnector;
using TugasPertemuan13.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasPertemuan13.Controller
{
    internal class LoginController : Model.Connection
    {
        Connection Koneksi = new Connection();
        public DataTable getList(MySqlCommand command)
        {
            command.Connection = Koneksi.GetConn();
            DataTable table = new DataTable();
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return table;
        }
    }
}
