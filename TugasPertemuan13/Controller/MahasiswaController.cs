using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TugasPertemuan13.Model;

namespace TugasPertemuan13.Controller
{
    internal class MahasiswaController : Model.Connection
    {
        //Menampilkan Data Mahasiswa
        public DataTable selectStudent(MySqlCommand command)
        {
            DataTable data = new DataTable();
            try
            {
                string show = "SELECT * FROM mahasiswa";
                da = new MySqlConnector.MySqlDataAdapter(show, GetConn());
                da.Fill(data);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }
        //Menambah Data Mahasiswa
        public void insertStudent(string nim, string name, DateTime tanggalLahir, byte[] photo)
        {
            string tambah = "INSERT INTO mahasiswa VALUES (" + "@NIM,@Nama,@Tanggal_lahir,@Photo)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@NIM", MySqlConnector.MySqlDbType.VarChar).Value = nim;
                cmd.Parameters.Add("@Nama", MySqlConnector.MySqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("@Tanggal_lahir", MySqlConnector.MySqlDbType.VarChar).Value = tanggalLahir;
                cmd.Parameters.Add("@Photo", MySqlConnector.MySqlDbType.VarChar).Value = photo;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add Student Data Failed!" + ex.Message);
            }
        }
        //Menghapus Data Mahasiswa Berdasarkan NIM

        public void deleteStudent(string NIM)
        {
            string delete = "DELETE FROM mahasiswa WHERE NIM=" + NIM;

            try
            {
                cmd = new MySqlConnector.MySqlCommand(delete, GetConn());
                cmd.Parameters.Add("@NIM", MySqlConnector.MySqlDbType.VarChar).Value = NIM;
                cmd.ExecuteNonQuery();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Delete Student Data Failed!" + ex.Message);
            }
        }


    }
}
