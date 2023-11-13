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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
using System.Drawing.Printing;
using System.IO;

namespace TugasPertemuan13
{
    public partial class FormMahasiswa : Form
    {
        private MahasiswaController mahasiswaController;
        public FormMahasiswa()
        {
            mahasiswaController = new MahasiswaController();
            InitializeComponent();
        }
        //Menampilkan Data-Data yang ada pada tabel mahasiswa
        bool showStudent()
        {
            DataGridView_mahasiswa.DataSource = mahasiswaController.selectStudent(new MySqlConnector.MySqlCommand("SELECT * FROM mahasiswa"));
            DataGridView_mahasiswa.RowTemplate.Height = 80;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_mahasiswa.Columns[3];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            return true;
        }
        //Validasi agar inputan tidak kosong
        bool verify()
        {
            if((txtNIM.Text == "") || (txtNama.Text == "") || (pictureBox_mahasiswa.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //Membuat batas inputan di form load
        private void FormMahasiswa_Load(object sender, EventArgs e)
        {
            txtNIM.MaxLength = 10;
            txtNama.MaxLength = 25;
            showStudent();
        }

        private void btnBersih_Click(object sender, EventArgs e)
        {
            txtNIM.Clear();
            txtNama.Clear();
            DateTimePicker_tanggal_lahir.Value = DateTime.Now;
            pictureBox_mahasiswa.Image = null;
        }
        //Button Simpan
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            int born_year = DateTimePicker_tanggal_lahir.Value.Year;
            int this_year = DateTime.Now.Year;
            if((this_year - born_year) <= 17 || (this_year - born_year) >= 25)
            {
                MessageBox.Show("Umur harus diantara 17 s/d 25", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verify())
            {
                try
                {
                    MemoryStream memori = new MemoryStream();
                    pictureBox_mahasiswa.Image.Save(memori, pictureBox_mahasiswa.Image.RawFormat);
                    byte[] img = memori.ToArray();
                    mahasiswaController.insertStudent(txtNIM.Text, txtNama.Text, DateTimePicker_tanggal_lahir.Value, img);
                    MessageBox.Show("Penambahan data baru berhasil", "Simpan data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showStudent();
                    txtNIM.Focus();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Inputan kosong", "Tambah data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Button Upload
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo(*.jpg;*.png;*.gif|*.jpg;*.png;*.gif;";

            if(opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox_mahasiswa.Image = Image.FromFile(opf.FileName);
            }
        }
        //Hapus Data Mahasiswa
        private void DataGridView_mahasiswa_Click(object sender, EventArgs e)
        {
            txtNIM.Text = DataGridView_mahasiswa.CurrentRow.Cells[0].Value.ToString();
            txtNama.Text = DataGridView_mahasiswa.CurrentRow.Cells[1].Value.ToString();
            DateTimePicker_tanggal_lahir.Value = (DateTime)DataGridView_mahasiswa.CurrentRow.Cells[2].Value;
            byte[] img = (byte[])DataGridView_mahasiswa.CurrentRow.Cells[3].Value;
            MemoryStream gambar = new MemoryStream(img);
            pictureBox_mahasiswa.Image = Image.FromStream(gambar);

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (verify())
            {
                try
                {
                    mahasiswaController.deleteStudent(txtNIM.Text);
                    showStudent();
                    btnBersih.PerformClick();
                    MessageBox.Show("Hapus data berhasil", "Hapus data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNIM.Focus();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hapus data error", "Hapus data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
