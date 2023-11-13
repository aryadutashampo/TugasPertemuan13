using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TugasPertemuan13.Controller;
using TugasPertemuan13.Model;

namespace TugasPertemuan13.View
{
    public partial class Form_Registrasi : Form
    {
        RegistController RCtrl;
        Validation val;
        public Form_Registrasi()
        {
            RCtrl = new RegistController();
            val = new Validation();
            InitializeComponent();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            Form_Login fl = new Form_Login();
            this.Hide();
            fl.Show();
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            if(val.valUsername(txtUsernameREG.Text) && val.valPassword(txtPasswordREG.Text)){
                try
                {
                    RCtrl.tambahAdmin(txtUsernameREG.Text, txtPasswordREG.Text);
                    this.Controls.Clear();
                    this.InitializeComponent();
                    txtUsernameREG.Focus();
                    MessageBox.Show("Data Admin ditambahkan");

                    Form_Login fl = new Form_Login();
                    this.Hide();
                    fl.Show();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
          
        }

        private void Form_Registrasi_Load(object sender, EventArgs e)
        {
            txtUsernameREG.MaxLength = 25;
            txtPasswordREG.MaxLength = 12;
        }
    }
}
