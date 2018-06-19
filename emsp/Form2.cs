using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emsp
{
    public partial class Form2 : Form //MENU KEHADIRAN
    {
        //CLASSA DAFTAR KELAS
        class daftar_kelas
        {
            public string id_kelas      { get; set; }
            public string id_matkul     { get; set; }
            public string id_ruangan    { get; set; }
            public string tanggal       { get; set; }
            public string waktu         { get; set; }
            public daftar_kelas(string id_kelas, string id_matkul, string id_ruangan, string tanggal, string waktu)
            {
                this.id_kelas   = id_kelas;
                this.id_matkul  = id_matkul;
                this.id_ruangan = id_ruangan;
                this.tanggal    = tanggal;
                this.waktu      = waktu;
            }
        }

        //CLASS KEHADIRAN
        class kehadiran
        {
            public int No       { get; set; }
            public string Nama  { get; set; }
            public bool Hadir   { get; set; }
            public kehadiran(int No, string Nama, bool Hadir)
            {
                this.No     = No;
                this.Nama   = Nama;
                this.Hadir  = Hadir;
            }
        }

        //INIT
        private string id = Form1.id;
        private List<daftar_kelas> daftar_kelas_gue = new List<daftar_kelas>();
        private List<kehadiran> kehadiran_gue = new List<kehadiran>();
        public Form2()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        void Form2_Load(object sender, EventArgs e)
        {
            //ISI NAMA DOSEN
            mysqlconnection();
            sqlquery = connect.CreateCommand();
            sqlquery.CommandText = "SELECT nama FROM dosen WHERE id_dosen = '" + id + "'";
            MySqlDataReader data1 = sqlquery.ExecuteReader();
            while (data1.Read()) nama_l.Text = data1.GetString("nama");
            //ISI DAFTAR KELAS
            mysqlconnection();
            sqlquery = connect.CreateCommand();
            sqlquery.CommandText = "SELECT * FROM kelas WHERE id_dosen = '" + id + "'";
            MySqlDataReader data2 = sqlquery.ExecuteReader();
            daftar_kelas_lb.BeginUpdate();
            for (int a = 0; data2.Read(); a++)
            {
                daftar_kelas_gue.Add(new daftar_kelas(data2.GetString("id_kelas"), data2.GetString("id_matkul"), data2.GetString("id_ruangan"), data2.GetString("tanggal").Substring(0, 10), data2.GetString("waktu")));
                daftar_kelas_lb.Items.Add(String.Format("{0} - {1} - {2} - {3} - {4}", daftar_kelas_gue[a].id_kelas, daftar_kelas_gue[a].id_matkul, daftar_kelas_gue[a].id_ruangan, daftar_kelas_gue[a].tanggal, daftar_kelas_gue[a].waktu));
                daftar_kelas_lb.SetSelected(a, true);
            }
            daftar_kelas_lb.EndUpdate();
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

        //SAAT DAFTAR KELAS DIPILIH ITEMNYA
        private void daftar_kelas_lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ISI KEHADIRAN
            mysqlconnection();
            sqlquery = connect.CreateCommand();
            sqlquery.CommandText = "SELECT * FROM mahasiswa_kehadiran WHERE id_kelas = '" + daftar_kelas_gue[daftar_kelas_lb.SelectedIndex].id_kelas + "'";
            MySqlDataReader data3 = sqlquery.ExecuteReader();
            kehadiran_gue.Clear();
            for (int a = 0; data3.Read(); a++) kehadiran_gue.Add(new kehadiran(a + 1, data3.GetString("id_mahasiswa"), data3.GetString("kehadiran").Equals("hadir") ? true : false));
            kehadiran_dg.DataSource = typeof(List<kehadiran>);
            kehadiran_dg.DataSource = kehadiran_gue;
            kehadiran_dg.DefaultCellStyle.Font = new Font("Bahnschrift SemiBold", 12, GraphicsUnit.Pixel);
            //STYLE PER KOLOM
            DataGridViewColumn column0 = kehadiran_dg.Columns[0]; column0.Width = 20; column0.DefaultCellStyle.BackColor = Color.Silver; column0.ReadOnly = true;
            DataGridViewColumn column1 = kehadiran_dg.Columns[1];                     column1.DefaultCellStyle.BackColor = Color.Silver; column1.ReadOnly = true;
            DataGridViewColumn column2 = kehadiran_dg.Columns[2]; column2.Width = 60; column2.DefaultCellStyle.BackColor = Color.Silver; column2.ReadOnly = false;
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

        //TOMBOL MENU MAHASISWA
        private void menu_mahasiswa_b_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            Hide();
        }

        //TOMBOL MINIMIZE
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
        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            Tog = 1;
            SX = e.X;
            SY = e.Y;
        }
        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (Tog == 1)
            {
                this.SetDesktopLocation(MousePosition.X - SX, MousePosition.Y - SY);
            }
        }
        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            Tog = 0;
        }
    }
}
