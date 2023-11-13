using TugasPertemuan13.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasPertemuan13.View
{
    public partial class Form_Login : Form
    {
        LoginController LCtrl;
        Validation val;
        public Form_Login()
        {
            LCtrl = new LoginController();
            val = new Validation();
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (val.valUsername(txtUsername.Text) && val.valPassword(txtPassword.Text))
            {
                try
                {
                    string name = txtUsername.Text;
                    string password = txtPassword.Text;
                    DataTable table = LCtrl.getList(new MySqlConnector.MySqlCommand
                        ("SELECT * FROM admin WHERE username = '" + name + "' AND pw ='" + password + "'"));

                    if (table.Rows.Count > 0)
                    {
                        MessageBox.Show("Login Success!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormMahasiswa fm = new FormMahasiswa();
                        this.Hide();
                        fm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Your admin and password are not exist", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void labelRegister_Click(object sender, EventArgs e)
        {
            Form_Registrasi fr = new Form_Registrasi();
            this.Hide();
            fr.Show();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            txtUsername.MaxLength = 25;
            txtPassword.MaxLength = 12;

        }
    }
}
