namespace TugasPertemuan13
{
    partial class FormMahasiswa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBG = new System.Windows.Forms.Panel();
            this.pictureBox_mahasiswa = new System.Windows.Forms.PictureBox();
            this.btnUpload = new Guna.UI2.WinForms.Guna2Button();
            this.btnSimpan = new Guna.UI2.WinForms.Guna2Button();
            this.btnHapus = new Guna.UI2.WinForms.Guna2Button();
            this.btnBersih = new Guna.UI2.WinForms.Guna2Button();
            this.DateTimePicker_tanggal_lahir = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtNama = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNIM = new Guna.UI2.WinForms.Guna2TextBox();
            this.DataGridView_mahasiswa = new Guna.UI2.WinForms.Guna2DataGridView();
            this.labelJudul = new System.Windows.Forms.Label();
            this.labelNIM = new System.Windows.Forms.Label();
            this.label_tanggal_lahir = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.panelBG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mahasiswa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_mahasiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBG
            // 
            this.panelBG.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelBG.Controls.Add(this.labelNama);
            this.panelBG.Controls.Add(this.label_tanggal_lahir);
            this.panelBG.Controls.Add(this.labelNIM);
            this.panelBG.Controls.Add(this.pictureBox_mahasiswa);
            this.panelBG.Controls.Add(this.btnUpload);
            this.panelBG.Controls.Add(this.btnSimpan);
            this.panelBG.Controls.Add(this.btnHapus);
            this.panelBG.Controls.Add(this.btnBersih);
            this.panelBG.Controls.Add(this.DateTimePicker_tanggal_lahir);
            this.panelBG.Controls.Add(this.txtNama);
            this.panelBG.Controls.Add(this.txtNIM);
            this.panelBG.Controls.Add(this.DataGridView_mahasiswa);
            this.panelBG.Controls.Add(this.labelJudul);
            this.panelBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBG.Location = new System.Drawing.Point(0, 0);
            this.panelBG.Name = "panelBG";
            this.panelBG.Size = new System.Drawing.Size(895, 523);
            this.panelBG.TabIndex = 0;
            // 
            // pictureBox_mahasiswa
            // 
            this.pictureBox_mahasiswa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_mahasiswa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox_mahasiswa.Location = new System.Drawing.Point(779, 303);
            this.pictureBox_mahasiswa.Name = "pictureBox_mahasiswa";
            this.pictureBox_mahasiswa.Size = new System.Drawing.Size(104, 96);
            this.pictureBox_mahasiswa.TabIndex = 12;
            this.pictureBox_mahasiswa.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpload.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnUpload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Location = new System.Drawing.Point(779, 399);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(104, 33);
            this.btnUpload.TabIndex = 11;
            this.btnUpload.Text = "Upload";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSimpan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSimpan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSimpan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSimpan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSimpan.FillColor = System.Drawing.Color.Green;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(779, 469);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(104, 33);
            this.btnSimpan.TabIndex = 10;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHapus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHapus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHapus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHapus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHapus.FillColor = System.Drawing.Color.Red;
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Location = new System.Drawing.Point(659, 469);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(104, 33);
            this.btnHapus.TabIndex = 9;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnBersih
            // 
            this.btnBersih.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBersih.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBersih.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBersih.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBersih.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBersih.FillColor = System.Drawing.Color.Goldenrod;
            this.btnBersih.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBersih.ForeColor = System.Drawing.Color.White;
            this.btnBersih.Location = new System.Drawing.Point(538, 469);
            this.btnBersih.Name = "btnBersih";
            this.btnBersih.Size = new System.Drawing.Size(104, 33);
            this.btnBersih.TabIndex = 8;
            this.btnBersih.Text = "Bersihkan";
            this.btnBersih.Click += new System.EventHandler(this.btnBersih_Click);
            // 
            // DateTimePicker_tanggal_lahir
            // 
            this.DateTimePicker_tanggal_lahir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DateTimePicker_tanggal_lahir.Checked = true;
            this.DateTimePicker_tanggal_lahir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimePicker_tanggal_lahir.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimePicker_tanggal_lahir.Location = new System.Drawing.Point(188, 390);
            this.DateTimePicker_tanggal_lahir.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePicker_tanggal_lahir.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker_tanggal_lahir.Name = "DateTimePicker_tanggal_lahir";
            this.DateTimePicker_tanggal_lahir.Size = new System.Drawing.Size(255, 22);
            this.DateTimePicker_tanggal_lahir.TabIndex = 7;
            this.DateTimePicker_tanggal_lahir.Value = new System.DateTime(2023, 11, 13, 2, 59, 52, 403);
            // 
            // txtNama
            // 
            this.txtNama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNama.DefaultText = "";
            this.txtNama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNama.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNama.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNama.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNama.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNama.Location = new System.Drawing.Point(188, 346);
            this.txtNama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNama.Name = "txtNama";
            this.txtNama.PasswordChar = '\0';
            this.txtNama.PlaceholderText = "";
            this.txtNama.SelectedText = "";
            this.txtNama.Size = new System.Drawing.Size(255, 23);
            this.txtNama.TabIndex = 6;
            // 
            // txtNIM
            // 
            this.txtNIM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNIM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNIM.DefaultText = "";
            this.txtNIM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNIM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNIM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNIM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNIM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNIM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNIM.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNIM.Location = new System.Drawing.Point(188, 303);
            this.txtNIM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.PasswordChar = '\0';
            this.txtNIM.PlaceholderText = "";
            this.txtNIM.SelectedText = "";
            this.txtNIM.Size = new System.Drawing.Size(229, 23);
            this.txtNIM.TabIndex = 5;
            // 
            // DataGridView_mahasiswa
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.DataGridView_mahasiswa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridView_mahasiswa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_mahasiswa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridView_mahasiswa.ColumnHeadersHeight = 4;
            this.DataGridView_mahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_mahasiswa.DefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridView_mahasiswa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_mahasiswa.Location = new System.Drawing.Point(12, 67);
            this.DataGridView_mahasiswa.Name = "DataGridView_mahasiswa";
            this.DataGridView_mahasiswa.RowHeadersVisible = false;
            this.DataGridView_mahasiswa.RowHeadersWidth = 51;
            this.DataGridView_mahasiswa.RowTemplate.Height = 24;
            this.DataGridView_mahasiswa.Size = new System.Drawing.Size(871, 218);
            this.DataGridView_mahasiswa.TabIndex = 1;
            this.DataGridView_mahasiswa.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_mahasiswa.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_mahasiswa.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_mahasiswa.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_mahasiswa.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_mahasiswa.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_mahasiswa.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_mahasiswa.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_mahasiswa.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_mahasiswa.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_mahasiswa.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_mahasiswa.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_mahasiswa.ThemeStyle.HeaderStyle.Height = 4;
            this.DataGridView_mahasiswa.ThemeStyle.ReadOnly = false;
            this.DataGridView_mahasiswa.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_mahasiswa.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_mahasiswa.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_mahasiswa.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_mahasiswa.ThemeStyle.RowsStyle.Height = 24;
            this.DataGridView_mahasiswa.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_mahasiswa.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_mahasiswa.Click += new System.EventHandler(this.DataGridView_mahasiswa_Click);
            // 
            // labelJudul
            // 
            this.labelJudul.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelJudul.AutoSize = true;
            this.labelJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.Location = new System.Drawing.Point(320, 9);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(289, 29);
            this.labelJudul.TabIndex = 0;
            this.labelJudul.Text = "Pendaftaran Mahasiswa";
            // 
            // labelNIM
            // 
            this.labelNIM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNIM.AutoSize = true;
            this.labelNIM.Location = new System.Drawing.Point(12, 310);
            this.labelNIM.Name = "labelNIM";
            this.labelNIM.Size = new System.Drawing.Size(31, 16);
            this.labelNIM.TabIndex = 13;
            this.labelNIM.Text = "NIM";
            // 
            // label_tanggal_lahir
            // 
            this.label_tanggal_lahir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_tanggal_lahir.AutoSize = true;
            this.label_tanggal_lahir.Location = new System.Drawing.Point(12, 390);
            this.label_tanggal_lahir.Name = "label_tanggal_lahir";
            this.label_tanggal_lahir.Size = new System.Drawing.Size(90, 16);
            this.label_tanggal_lahir.TabIndex = 14;
            this.label_tanggal_lahir.Text = "Tanggal Lahir";
            // 
            // labelNama
            // 
            this.labelNama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(12, 353);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(44, 16);
            this.labelNama.TabIndex = 15;
            this.labelNama.Text = "Nama";
            // 
            // FormMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 523);
            this.Controls.Add(this.panelBG);
            this.Name = "FormMahasiswa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Utama";
            this.Load += new System.EventHandler(this.FormMahasiswa_Load);
            this.panelBG.ResumeLayout(false);
            this.panelBG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mahasiswa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_mahasiswa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBG;
        private System.Windows.Forms.PictureBox pictureBox_mahasiswa;
        private Guna.UI2.WinForms.Guna2Button btnUpload;
        private Guna.UI2.WinForms.Guna2Button btnSimpan;
        private Guna.UI2.WinForms.Guna2Button btnHapus;
        private Guna.UI2.WinForms.Guna2Button btnBersih;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePicker_tanggal_lahir;
        private Guna.UI2.WinForms.Guna2TextBox txtNama;
        private Guna.UI2.WinForms.Guna2TextBox txtNIM;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_mahasiswa;
        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label label_tanggal_lahir;
        private System.Windows.Forms.Label labelNIM;
    }
}

