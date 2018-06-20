namespace emsp
{
    partial class Menu_Penilaian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Penilaian));
            this.minimize_b = new System.Windows.Forms.PictureBox();
            this.close_b = new System.Windows.Forms.PictureBox();
            this.nama_l = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.matkul_cob = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menu_mahasiswa_b = new System.Windows.Forms.Button();
            this.menu_pengajar_b = new System.Windows.Forms.Button();
            this.menu_penilaian_b = new System.Windows.Forms.Button();
            this.menu_kehadiran_b = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.batal_b = new System.Windows.Forms.Button();
            this.simpan_b = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.id_nama_mahasiswa_l = new System.Windows.Forms.Label();
            this.tugas_teori_t = new System.Windows.Forms.TextBox();
            this.uas_teori_t = new System.Windows.Forms.TextBox();
            this.uts_teori_t = new System.Windows.Forms.TextBox();
            this.uts_praktek_t = new System.Windows.Forms.TextBox();
            this.uas_praktek_t = new System.Windows.Forms.TextBox();
            this.tugas_praktek_t = new System.Windows.Forms.TextBox();
            this.daftar_mahasiswa_lb = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // minimize_b
            // 
            this.minimize_b.BackColor = System.Drawing.Color.Transparent;
            this.minimize_b.Image = ((System.Drawing.Image)(resources.GetObject("minimize_b.Image")));
            this.minimize_b.InitialImage = ((System.Drawing.Image)(resources.GetObject("minimize_b.InitialImage")));
            this.minimize_b.Location = new System.Drawing.Point(702, 12);
            this.minimize_b.Name = "minimize_b";
            this.minimize_b.Size = new System.Drawing.Size(25, 25);
            this.minimize_b.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimize_b.TabIndex = 10;
            this.minimize_b.TabStop = false;
            this.minimize_b.Click += new System.EventHandler(this.minimize_b_Click);
            // 
            // close_b
            // 
            this.close_b.BackColor = System.Drawing.Color.Transparent;
            this.close_b.Image = ((System.Drawing.Image)(resources.GetObject("close_b.Image")));
            this.close_b.InitialImage = ((System.Drawing.Image)(resources.GetObject("close_b.InitialImage")));
            this.close_b.Location = new System.Drawing.Point(733, 12);
            this.close_b.Name = "close_b";
            this.close_b.Size = new System.Drawing.Size(25, 25);
            this.close_b.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close_b.TabIndex = 11;
            this.close_b.TabStop = false;
            this.close_b.Click += new System.EventHandler(this.close_b_Click);
            this.close_b.MouseEnter += new System.EventHandler(this.close_b_MouseEnter);
            this.close_b.MouseLeave += new System.EventHandler(this.close_b_MouseLeave);
            // 
            // nama_l
            // 
            this.nama_l.AutoSize = true;
            this.nama_l.BackColor = System.Drawing.Color.Transparent;
            this.nama_l.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama_l.ForeColor = System.Drawing.Color.DarkGray;
            this.nama_l.Location = new System.Drawing.Point(26, 83);
            this.nama_l.Name = "nama_l";
            this.nama_l.Size = new System.Drawing.Size(0, 19);
            this.nama_l.TabIndex = 23;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.DarkGray;
            this.label.Location = new System.Drawing.Point(26, 57);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(129, 20);
            this.label.TabIndex = 22;
            this.label.Text = "Selamat datang, ";
            // 
            // matkul_cob
            // 
            this.matkul_cob.BackColor = System.Drawing.Color.DarkGray;
            this.matkul_cob.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matkul_cob.FormattingEnabled = true;
            this.matkul_cob.Location = new System.Drawing.Point(334, 86);
            this.matkul_cob.Name = "matkul_cob";
            this.matkul_cob.Size = new System.Drawing.Size(423, 24);
            this.matkul_cob.TabIndex = 30;
            this.matkul_cob.SelectedIndexChanged += new System.EventHandler(this.matkul_cob_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(228, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "Mata Kuliah :";
            // 
            // menu_mahasiswa_b
            // 
            this.menu_mahasiswa_b.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menu_mahasiswa_b.BackgroundImage")));
            this.menu_mahasiswa_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu_mahasiswa_b.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menu_mahasiswa_b.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_mahasiswa_b.Location = new System.Drawing.Point(20, 442);
            this.menu_mahasiswa_b.Name = "menu_mahasiswa_b";
            this.menu_mahasiswa_b.Size = new System.Drawing.Size(160, 90);
            this.menu_mahasiswa_b.TabIndex = 35;
            this.menu_mahasiswa_b.UseVisualStyleBackColor = true;
            this.menu_mahasiswa_b.Click += new System.EventHandler(this.menu_mahasiswa_b_Click);
            // 
            // menu_pengajar_b
            // 
            this.menu_pengajar_b.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menu_pengajar_b.BackgroundImage")));
            this.menu_pengajar_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu_pengajar_b.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menu_pengajar_b.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_pengajar_b.ForeColor = System.Drawing.Color.Transparent;
            this.menu_pengajar_b.Location = new System.Drawing.Point(20, 337);
            this.menu_pengajar_b.Name = "menu_pengajar_b";
            this.menu_pengajar_b.Size = new System.Drawing.Size(160, 90);
            this.menu_pengajar_b.TabIndex = 34;
            this.menu_pengajar_b.UseVisualStyleBackColor = true;
            this.menu_pengajar_b.Click += new System.EventHandler(this.menu_pengajar_b_Click);
            // 
            // menu_penilaian_b
            // 
            this.menu_penilaian_b.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menu_penilaian_b.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menu_penilaian_b.BackgroundImage")));
            this.menu_penilaian_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu_penilaian_b.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menu_penilaian_b.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_penilaian_b.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu_penilaian_b.Location = new System.Drawing.Point(20, 232);
            this.menu_penilaian_b.Name = "menu_penilaian_b";
            this.menu_penilaian_b.Size = new System.Drawing.Size(160, 90);
            this.menu_penilaian_b.TabIndex = 33;
            this.menu_penilaian_b.UseVisualStyleBackColor = false;
            // 
            // menu_kehadiran_b
            // 
            this.menu_kehadiran_b.BackColor = System.Drawing.Color.White;
            this.menu_kehadiran_b.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menu_kehadiran_b.BackgroundImage")));
            this.menu_kehadiran_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu_kehadiran_b.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menu_kehadiran_b.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_kehadiran_b.Location = new System.Drawing.Point(20, 127);
            this.menu_kehadiran_b.Name = "menu_kehadiran_b";
            this.menu_kehadiran_b.Size = new System.Drawing.Size(160, 90);
            this.menu_kehadiran_b.TabIndex = 32;
            this.menu_kehadiran_b.UseVisualStyleBackColor = false;
            this.menu_kehadiran_b.Click += new System.EventHandler(this.menu_kehadiran_b_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(192, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 493);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // batal_b
            // 
            this.batal_b.BackColor = System.Drawing.Color.DarkOrange;
            this.batal_b.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.batal_b.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batal_b.ForeColor = System.Drawing.SystemColors.Control;
            this.batal_b.Location = new System.Drawing.Point(552, 505);
            this.batal_b.Name = "batal_b";
            this.batal_b.Size = new System.Drawing.Size(100, 33);
            this.batal_b.TabIndex = 38;
            this.batal_b.Text = "Batal";
            this.batal_b.UseVisualStyleBackColor = false;
            this.batal_b.Click += new System.EventHandler(this.batal_b_Click);
            // 
            // simpan_b
            // 
            this.simpan_b.BackColor = System.Drawing.Color.DarkOrange;
            this.simpan_b.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.simpan_b.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpan_b.ForeColor = System.Drawing.SystemColors.Control;
            this.simpan_b.Location = new System.Drawing.Point(658, 505);
            this.simpan_b.Name = "simpan_b";
            this.simpan_b.Size = new System.Drawing.Size(100, 33);
            this.simpan_b.TabIndex = 37;
            this.simpan_b.Text = "Simpan";
            this.simpan_b.UseVisualStyleBackColor = false;
            this.simpan_b.Click += new System.EventHandler(this.simpan_b_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(228, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 19);
            this.label6.TabIndex = 51;
            this.label6.Text = "Nilai:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(308, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 52;
            this.label1.Text = "UTS Teori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(509, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 53;
            this.label2.Text = "UAS Praktek";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(509, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 54;
            this.label4.Text = "Tugas Praktek";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(308, 452);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 55;
            this.label5.Text = "UAS Teori";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(308, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 56;
            this.label7.Text = "Tugas Teori";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkGray;
            this.label8.Location = new System.Drawing.Point(509, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 57;
            this.label8.Text = "UTS Praktek";
            // 
            // id_nama_mahasiswa_l
            // 
            this.id_nama_mahasiswa_l.AutoSize = true;
            this.id_nama_mahasiswa_l.BackColor = System.Drawing.Color.Transparent;
            this.id_nama_mahasiswa_l.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_nama_mahasiswa_l.ForeColor = System.Drawing.Color.DarkGray;
            this.id_nama_mahasiswa_l.Location = new System.Drawing.Point(260, 337);
            this.id_nama_mahasiswa_l.Name = "id_nama_mahasiswa_l";
            this.id_nama_mahasiswa_l.Size = new System.Drawing.Size(187, 19);
            this.id_nama_mahasiswa_l.TabIndex = 58;
            this.id_nama_mahasiswa_l.Text = "ID dan Nama Mahasiswa:";
            // 
            // tugas_teori_t
            // 
            this.tugas_teori_t.BackColor = System.Drawing.Color.DarkGray;
            this.tugas_teori_t.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tugas_teori_t.Location = new System.Drawing.Point(391, 374);
            this.tugas_teori_t.Name = "tugas_teori_t";
            this.tugas_teori_t.Size = new System.Drawing.Size(73, 23);
            this.tugas_teori_t.TabIndex = 59;
            this.tugas_teori_t.TextChanged += new System.EventHandler(this.tugas_teori_t_TextChanged);
            // 
            // uas_teori_t
            // 
            this.uas_teori_t.BackColor = System.Drawing.Color.DarkGray;
            this.uas_teori_t.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uas_teori_t.Location = new System.Drawing.Point(391, 450);
            this.uas_teori_t.Name = "uas_teori_t";
            this.uas_teori_t.Size = new System.Drawing.Size(73, 23);
            this.uas_teori_t.TabIndex = 60;
            this.uas_teori_t.TextChanged += new System.EventHandler(this.uas_teori_t_TextChanged);
            // 
            // uts_teori_t
            // 
            this.uts_teori_t.BackColor = System.Drawing.Color.DarkGray;
            this.uts_teori_t.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uts_teori_t.Location = new System.Drawing.Point(391, 412);
            this.uts_teori_t.Name = "uts_teori_t";
            this.uts_teori_t.Size = new System.Drawing.Size(73, 23);
            this.uts_teori_t.TabIndex = 61;
            this.uts_teori_t.TextChanged += new System.EventHandler(this.uts_teori_t_TextChanged);
            // 
            // uts_praktek_t
            // 
            this.uts_praktek_t.BackColor = System.Drawing.Color.DarkGray;
            this.uts_praktek_t.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uts_praktek_t.Location = new System.Drawing.Point(610, 412);
            this.uts_praktek_t.Name = "uts_praktek_t";
            this.uts_praktek_t.Size = new System.Drawing.Size(73, 23);
            this.uts_praktek_t.TabIndex = 62;
            this.uts_praktek_t.TextChanged += new System.EventHandler(this.uts_praktek_t_TextChanged);
            // 
            // uas_praktek_t
            // 
            this.uas_praktek_t.BackColor = System.Drawing.Color.DarkGray;
            this.uas_praktek_t.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uas_praktek_t.Location = new System.Drawing.Point(610, 450);
            this.uas_praktek_t.Name = "uas_praktek_t";
            this.uas_praktek_t.Size = new System.Drawing.Size(73, 23);
            this.uas_praktek_t.TabIndex = 63;
            this.uas_praktek_t.TextChanged += new System.EventHandler(this.uas_praktek_t_TextChanged);
            // 
            // tugas_praktek_t
            // 
            this.tugas_praktek_t.BackColor = System.Drawing.Color.DarkGray;
            this.tugas_praktek_t.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tugas_praktek_t.Location = new System.Drawing.Point(610, 374);
            this.tugas_praktek_t.Name = "tugas_praktek_t";
            this.tugas_praktek_t.Size = new System.Drawing.Size(73, 23);
            this.tugas_praktek_t.TabIndex = 64;
            this.tugas_praktek_t.TextChanged += new System.EventHandler(this.tugas_praktek_t_TextChanged);
            // 
            // daftar_mahasiswa_lb
            // 
            this.daftar_mahasiswa_lb.BackColor = System.Drawing.Color.Silver;
            this.daftar_mahasiswa_lb.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daftar_mahasiswa_lb.FormattingEnabled = true;
            this.daftar_mahasiswa_lb.ItemHeight = 14;
            this.daftar_mahasiswa_lb.Location = new System.Drawing.Point(228, 127);
            this.daftar_mahasiswa_lb.Name = "daftar_mahasiswa_lb";
            this.daftar_mahasiswa_lb.ScrollAlwaysVisible = true;
            this.daftar_mahasiswa_lb.Size = new System.Drawing.Size(530, 158);
            this.daftar_mahasiswa_lb.TabIndex = 65;
            this.daftar_mahasiswa_lb.SelectedIndexChanged += new System.EventHandler(this.daftar_mahasiswa_lb_SelectedIndexChanged);
            // 
            // Menu_Penilaian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(770, 550);
            this.Controls.Add(this.daftar_mahasiswa_lb);
            this.Controls.Add(this.tugas_praktek_t);
            this.Controls.Add(this.uas_praktek_t);
            this.Controls.Add(this.uts_praktek_t);
            this.Controls.Add(this.uts_teori_t);
            this.Controls.Add(this.uas_teori_t);
            this.Controls.Add(this.tugas_teori_t);
            this.Controls.Add(this.id_nama_mahasiswa_l);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.batal_b);
            this.Controls.Add(this.simpan_b);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menu_mahasiswa_b);
            this.Controls.Add(this.menu_pengajar_b);
            this.Controls.Add(this.menu_penilaian_b);
            this.Controls.Add(this.menu_kehadiran_b);
            this.Controls.Add(this.matkul_cob);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nama_l);
            this.Controls.Add(this.label);
            this.Controls.Add(this.minimize_b);
            this.Controls.Add(this.close_b);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu_Penilaian";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Menu_Penilaian_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Menu_Penilaian_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Menu_Penilaian_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Menu_Penilaian_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.minimize_b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox minimize_b;
        private System.Windows.Forms.PictureBox close_b;
        private System.Windows.Forms.Label nama_l;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox matkul_cob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button menu_mahasiswa_b;
        private System.Windows.Forms.Button menu_pengajar_b;
        private System.Windows.Forms.Button menu_penilaian_b;
        private System.Windows.Forms.Button menu_kehadiran_b;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button batal_b;
        private System.Windows.Forms.Button simpan_b;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label id_nama_mahasiswa_l;
        private System.Windows.Forms.TextBox tugas_teori_t;
        private System.Windows.Forms.TextBox uas_teori_t;
        private System.Windows.Forms.TextBox uts_teori_t;
        private System.Windows.Forms.TextBox uts_praktek_t;
        private System.Windows.Forms.TextBox uas_praktek_t;
        private System.Windows.Forms.TextBox tugas_praktek_t;
        private System.Windows.Forms.ListBox daftar_mahasiswa_lb;
    }
}