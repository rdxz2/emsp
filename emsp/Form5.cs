using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emsp
{
    public partial class Form5 : Form //MENU MAHASISWA
    {
        //CLASS DAFTAR MAHASISWA
        class daftar_mahasiswa
        {
            public string id_mahasiswa      { get; set; }
            public string nama_mahasiswa    { get; set; }
            public string ttl               { get; set; }
            public string alamat            { get; set; }
            public string email             { get; set; }
            public string jenis_kelamin     { get; set; }
            public string jurusan           { get; set; }
            public string no_hp             { get; set; }
            public string angkatan          { get; set; }
            public daftar_mahasiswa(string id_mahasiswa, string nama_mahasiswa, string ttl, string alamat, string email, string jenis_kelamin, string jurusan, string no_hp, string angkatan)
            {
                this.id_mahasiswa       = id_mahasiswa;
                this.nama_mahasiswa     = nama_mahasiswa;
                this.ttl                = ttl;
                this.alamat             = alamat;
                this.email              = email;
                this.jenis_kelamin      = jenis_kelamin;
                this.jurusan            = jurusan;
                this.no_hp              = no_hp;
                this.angkatan           = angkatan;
            }
        }

        //CLASS MATKUL DIAMBIL
        class matkul_diambil
        {
            public int No               { get; set; }
            public string ID_Matkul     { get; set; }
            public string Nama_Matkul   { get; set; }
            public int SKS              { get; set; }
            public matkul_diambil(int No, string ID_Matkul, string Nama_Matkul, int SKS)
            {
                this.No             = No;
                this.ID_Matkul      = ID_Matkul;
                this.Nama_Matkul    = Nama_Matkul;
                this.SKS            = SKS;
            }
        }

        //INIT
        private string id = Form1.id;
        private List<daftar_mahasiswa> daftar_mahasiswa_gue = new List<daftar_mahasiswa>();
        private List<matkul_diambil> matkul_diambil_gue = new List<matkul_diambil>();
        public Form5()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            //ISI NAMA DOSEN
            mysqlconnection();
            sqlquery = connect.CreateCommand();
            sqlquery.CommandText = "SELECT nama FROM dosen WHERE id_dosen = '" + id + "'";
            MySqlDataReader data1 = sqlquery.ExecuteReader();
            while (data1.Read()) nama_l.Text = data1.GetString("nama");
            //ISI DAFTAR MAHASISWA
            mysqlconnection();
            sqlquery = connect.CreateCommand();
            sqlquery.CommandText = "SELECT * FROM mahasiswa";
            MySqlDataReader data2 = sqlquery.ExecuteReader();
            daftar_mahasiswa_lb.BeginUpdate();
            for (int a = 0; data2.Read(); a++)
            {
                daftar_mahasiswa_gue.Add(new daftar_mahasiswa(data2.GetString("id_mahasiswa"), data2.GetString("nama_depan") + " " + data2.GetString("nama_belakang"), data2.GetString("tempat_lahir") + " " + data2.GetString("tanggal_lahir"), data2.GetString("alamat"), data2.GetString("email"), data2.GetString("jenis_kelamin"), data2.GetString("id_jurusan"), data2.GetString("hp"), data2.GetString("angkatan")));
                daftar_mahasiswa_lb.Items.Add(String.Format("{0} - {1} - {2}", a + 1, daftar_mahasiswa_gue[a].id_mahasiswa, daftar_mahasiswa_gue[a].nama_mahasiswa));
                daftar_mahasiswa_lb.SetSelected(a, true);
            }
            daftar_mahasiswa_lb.EndUpdate();
            daftar_mahasiswa_lb.SelectedIndex = 0;
        }

        //KONEKSI MYSQL
        private string conn;
        private MySqlConnection connect;
        MySqlCommand sqlquery;
        private void mysqlconnection()
        {
            try
            {
                conn = "Server=localhost;Database=emsp_db;Uid=root;Pwd=;";
                connect = new MySqlConnection(conn);
                connect.Open();
            }
            catch (MySqlException e)
            {
                throw;
            }
        }

        //ROUNDED EDGE
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        //SAAT DAFTAR MAHASISWA DIPILIH ITEMNYA
        private void daftar_mahasiswa_lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ISI INFORMASI MAHASISWA
            id_mahasiswa_l.Text     = ": " + daftar_mahasiswa_gue[daftar_mahasiswa_lb.SelectedIndex].id_mahasiswa;
            nama_mahasiswa_l.Text   = ": " + daftar_mahasiswa_gue[daftar_mahasiswa_lb.SelectedIndex].nama_mahasiswa;
            ttl_l.Text              = ": " + daftar_mahasiswa_gue[daftar_mahasiswa_lb.SelectedIndex].ttl;
            alamat_l.Text           = ": " + daftar_mahasiswa_gue[daftar_mahasiswa_lb.SelectedIndex].alamat;
            email_l.Text            = ": " + daftar_mahasiswa_gue[daftar_mahasiswa_lb.SelectedIndex].email;
            jenis_kelamin_l.Text    = ": " + daftar_mahasiswa_gue[daftar_mahasiswa_lb.SelectedIndex].jenis_kelamin;
            jurusan_l.Text          = ": " + daftar_mahasiswa_gue[daftar_mahasiswa_lb.SelectedIndex].jurusan;
            no_hp_l.Text            = ": " + daftar_mahasiswa_gue[daftar_mahasiswa_lb.SelectedIndex].no_hp;
            angkatan_l.Text         = ": " + daftar_mahasiswa_gue[daftar_mahasiswa_lb.SelectedIndex].angkatan;
            //ISI MATA KULIAH YANG SEDANG DIAMBIL
            mysqlconnection();
            sqlquery = connect.CreateCommand();
            sqlquery.CommandText = "SELECT m_m.id_matkul, m.nama_matkul, m.jumlah_sks FROM mahasiswa_matkul AS m_m, matkul AS m WHERE m_m.id_mahasiswa LIKE '" + daftar_mahasiswa_gue[daftar_mahasiswa_lb.SelectedIndex].id_mahasiswa + "' AND m_m.id_matkul = m.id_matkul";
            MySqlDataReader data3 = sqlquery.ExecuteReader();
            matkul_diambil_gue.Clear();
            for (int a = 0; data3.Read(); a++) matkul_diambil_gue.Add(new matkul_diambil(a + 1, data3.GetString("id_matkul"), data3.GetString("nama_matkul"), data3.GetInt16("jumlah_sks")));
            matkul_diambil_dg.DataSource = typeof(List<matkul_diambil>);
            matkul_diambil_dg.DataSource = matkul_diambil_gue;
            matkul_diambil_dg.DefaultCellStyle.Font = new Font("Bahnschrift SemiBold", 12, GraphicsUnit.Pixel);
            //STYLE PER KOLOM
            DataGridViewColumn column0 = matkul_diambil_dg.Columns[0]; column0.Width = 20;  column0.DefaultCellStyle.BackColor = Color.Silver;
            DataGridViewColumn column1 = matkul_diambil_dg.Columns[1]; column1.Width = 60; column1.DefaultCellStyle.BackColor = Color.Silver;
            DataGridViewColumn column2 = matkul_diambil_dg.Columns[2];                      column2.DefaultCellStyle.BackColor = Color.Silver;
            DataGridViewColumn column3 = matkul_diambil_dg.Columns[3]; column3.Width = 40;  column3.DefaultCellStyle.BackColor = Color.Silver; column3.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        //TOMBOL MENU KEHADIRAN
        private void menu_kehadiran_b_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            Hide();
        }

        //TOMBOL MENU PENILAIAN
        private void menu_penilaian_b_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            Hide();
        }

        //TOMBOL MENU PENGAJAR
        private void menu_pengajar_b_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            Hide();
        }

        ////TOMBOL MINIMIZE
        private void minimize_b_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //TOMBOL CLOSE
        private void close_b_MouseEnter(object sender, EventArgs e)
        {
            this.close_b.Load(AppDomain.CurrentDomain.BaseDirectory + "/asset/closed.png");
        }
        private void close_b_MouseLeave(object sender, EventArgs e)
        {
            this.close_b.Load(AppDomain.CurrentDomain.BaseDirectory + "/asset/close.png");
        }
        private void close_b_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //DRAG WINDOW
        int Tog;
        int SX, SY;
        private void Form5_MouseDown(object sender, MouseEventArgs e)
        {
            Tog = 1;
            SX = e.X;
            SY = e.Y;
        }
        private void Form5_MouseMove(object sender, MouseEventArgs e)
        {
            if (Tog == 1)
            {
                this.SetDesktopLocation(MousePosition.X - SX, MousePosition.Y - SY);
            }
        }
        private void Form5_MouseUp(object sender, MouseEventArgs e)
        {
            Tog = 0;
        }
    }
}
