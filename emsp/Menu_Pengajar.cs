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
    public partial class Menu_Pengajar : Form
    {
        //CLASS DOSEN
        class dosen
        {
            public string nama          { get; set; }
            public string ttl           { get; set; }
            public string jenis_kelamin { get; set; }
            public string email         { get; set; }
            public string no_hp         { get; set; }
            public dosen(string nama, string ttl, string jenis_kelamin, string email, string no_hp)
            {
                this.nama           = nama;
                this.ttl            = ttl;
                this.jenis_kelamin  = jenis_kelamin;
                this.email          = email;
                this.no_hp          = no_hp;
            }
        }
        
        //CLASS MATKUL DIAJAR
        class matkul_diajar
        {
            public int no               { get; set; }
            public string id_matkul     { get; set; }
            public string nama_matkul   { get; set; }
            public string id_ruangan    { get; set; }
            public string tanggal       { get; set; }
            public string waktu         { get; set; }
            public int sks              { get; set; }
            public matkul_diajar(int no, string id_matkul, string nama_matkul, string id_ruangan, string tanggal, string waktu, int sks)
            {
                this.no             = no;
                this.id_matkul      = id_matkul;
                this.nama_matkul    = nama_matkul;
                this.id_ruangan     = id_ruangan;
                this.tanggal        = tanggal;
                this.waktu          = waktu;
                this.sks            = sks;
            }
        }

        //INIT
        private string id = Login.id;
        private dosen dosen_gue;
        private List<matkul_diajar> matkul_diajar_gue = new List<matkul_diajar>();
        public Menu_Pengajar()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        private void Menu_Pengajar_Load(object sender, EventArgs e)
        {
            //ISI NAMA DOSEN
            if (mysqlconnection())
            {
                sqlquery = connect.CreateCommand();
                sqlquery.CommandText = "SELECT nama FROM dosen WHERE id_dosen = '" + id + "'";
                MySqlDataReader data1 = sqlquery.ExecuteReader();
                while (data1.Read()) nama_l.Text = data1.GetString("nama");
                //ISI DAFTAR MAHASISWA
                mysqlconnection();
                sqlquery = connect.CreateCommand();
                sqlquery.CommandText = "SELECT * FROM dosen WHERE id_dosen = '" + id + "'";
                MySqlDataReader data2 = sqlquery.ExecuteReader();
                while (data2.Read()) dosen_gue = new dosen(data2.GetString("nama"), data2.GetString("tempat_lahir") + ", " + data2.GetString("tanggal_lahir").Substring(0, 10), data2.GetString("jenis_kelamin"), data2.GetString("email"), data2.GetString("hp"));
                id_dosen_l.Text         = id;
                nama_dosen_l.Text       = dosen_gue.nama;
                ttl_l.Text              = dosen_gue.ttl;
                jenis_kelamin_l.Text    = dosen_gue.jenis_kelamin;
                email_l.Text            = dosen_gue.email;
                no_hp_l.Text            = dosen_gue.no_hp;
                //ISI DAFTAR MATKUL YANG DIAJAR
                mysqlconnection();
                sqlquery = connect.CreateCommand();
                sqlquery.CommandText = "SELECT k.id_matkul, m.nama_matkul, k.id_ruangan, k.tanggal, k.waktu, m.jumlah_sks FROM kelas AS k, matkul AS m WHERE k.id_dosen LIKE '" + id + "' AND k.id_matkul = m.id_matkul";
                MySqlDataReader data3 = sqlquery.ExecuteReader();
                matkul_diajar_gue.Clear();
                for (int a = 0; data3.Read(); a++) matkul_diajar_gue.Add(new matkul_diajar(a + 1, data3.GetString("id_matkul"), data3.GetString("nama_matkul"), data3.GetString("id_ruangan"), data3.GetString("tanggal").Substring(0, 10), data3.GetString("waktu"), data3.GetInt16("jumlah_sks")));
                matkul_diajar_dg.DataSource = typeof(List<matkul_diajar>);
                matkul_diajar_dg.DataSource = matkul_diajar_gue;
                matkul_diajar_dg.DefaultCellStyle.Font = new Font("Bahnschrift SemiBold", 12, GraphicsUnit.Pixel);
                //STYLE PER KOLOM
                DataGridViewColumn column0 = matkul_diajar_dg.Columns[0]; column0.Width = 25;   column0.DefaultCellStyle.BackColor = Color.Silver;
                DataGridViewColumn column1 = matkul_diajar_dg.Columns[1]; column1.Width = 60;   column1.DefaultCellStyle.BackColor = Color.Silver;
                DataGridViewColumn column2 = matkul_diajar_dg.Columns[2]; column2.Width = 150;  column2.DefaultCellStyle.BackColor = Color.Silver;
                DataGridViewColumn column3 = matkul_diajar_dg.Columns[3]; column3.Width = 60;   column3.DefaultCellStyle.BackColor = Color.Silver;
                DataGridViewColumn column4 = matkul_diajar_dg.Columns[4];                       column4.DefaultCellStyle.BackColor = Color.Silver;
                DataGridViewColumn column5 = matkul_diajar_dg.Columns[5];                       column5.DefaultCellStyle.BackColor = Color.Silver;
                DataGridViewColumn column6 = matkul_diajar_dg.Columns[6]; column6.Width = 40;   column6.DefaultCellStyle.BackColor = Color.Silver; column6.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            else MessageBox.Show("Gagal terhubung dengan database");
        }

        //KONEKSI MYSQL
        private string conn;
        private MySqlConnection connect;
        MySqlCommand sqlquery;
        private bool mysqlconnection()
        {
            try
            {
                conn = "Server=localhost;Database=emsp_db;Uid=root;Pwd=;";
                connect = new MySqlConnection(conn);
                connect.Open();
                return true;
            }
            catch (MySqlException e)
            {
                return false;
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

        //TOMBOL MENU KEHADIRAN
        private void menu_kehadiran_b_Click(object sender, EventArgs e)
        {
            Menu_Kehadiran menu_kehadiran = new Menu_Kehadiran();
            menu_kehadiran.StartPosition = FormStartPosition.CenterScreen;
            menu_kehadiran.Show();
            Hide();
        }

        //TOMBOL MENU PENILAIAN
        private void menu_penilaian_b_Click(object sender, EventArgs e)
        {
            Menu_Penilaian menu_penilaian = new Menu_Penilaian();
            menu_penilaian.StartPosition = FormStartPosition.CenterScreen;
            menu_penilaian.Show();
            Hide();
        }

        //TOMBOL MENU MAHASISWA
        private void menu_mahasiswa_b_Click(object sender, EventArgs e)
        {
            Menu_Mahasiswa menu_mahasiswa = new Menu_Mahasiswa();
            menu_mahasiswa.StartPosition = FormStartPosition.CenterScreen;
            menu_mahasiswa.Show();
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
        private void Menu_Pengajar_MouseDown(object sender, MouseEventArgs e)
        {
            Tog = 1;
            SX = e.X;
            SY = e.Y;
        }
        private void Menu_Pengajar_MouseMove(object sender, MouseEventArgs e)
        {
            if (Tog == 1) this.SetDesktopLocation(MousePosition.X - SX, MousePosition.Y - SY);
        }
        private void Menu_Pengajar_MouseUp(object sender, MouseEventArgs e)
        {
            Tog = 0;
        }
    }
}
