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
    public partial class Menu_Kehadiran : Form //MENU KEHADIRAN
    {
        //CLASSA DAFTAR KELAS
        class daftar_kelas
        {
            public string id_kelas      { get; set; }
            public string id_matkul     { get; set; }
            public string nama_matkul   { get; set; }
            public string id_ruangan    { get; set; }
            public string tanggal       { get; set; }
            public string waktu         { get; set; }
            public daftar_kelas(string id_kelas, string id_matkul, string nama_matkul, string id_ruangan, string tanggal, string waktu)
            {
                this.id_kelas       = id_kelas;
                this.id_matkul      = id_matkul;
                this.nama_matkul    = nama_matkul;
                this.id_ruangan     = id_ruangan;
                this.tanggal        = tanggal;
                this.waktu          = waktu;
            }
        }

        //CLASS KEHADIRAN
        class kehadiran
        {
            public int No       { get; set; }
            public string ID    { get; set; }
            public string Nama  { get; set; }
            public bool Hadir   { get; set; }
            public kehadiran(int No, string ID, string Nama, bool Hadir)
            {
                this.No     = No;
                this.ID     = ID;
                this.Nama   = Nama;
                this.Hadir  = Hadir;
            }
        }

        //INIT
        private string id = Login.id;
        private List<daftar_kelas> daftar_kelas_gue = new List<daftar_kelas>();
        private List<kehadiran> kehadiran_gue = new List<kehadiran>();
        public Menu_Kehadiran()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        private void Menu_Kehadiran_Load(object sender, EventArgs e)
        {
            //ISI NAMA DOSEN
            if (mysqlconnection())
            {
                sqlquery = connect.CreateCommand();
                sqlquery.CommandText = "SELECT nama FROM dosen WHERE id_dosen = '" + id + "'";
                MySqlDataReader data1 = sqlquery.ExecuteReader();
                while (data1.Read()) nama_l.Text = data1.GetString("nama");
                //ISI DAFTAR KELAS
                mysqlconnection();
                sqlquery = connect.CreateCommand();
                sqlquery.CommandText = "SELECT k.id_kelas, m.id_matkul, m.nama_matkul, k.id_ruangan, k.tanggal, k.waktu FROM kelas AS k, matkul AS m WHERE id_dosen = '" + id + "' AND k.id_matkul = m.id_matkul";
                MySqlDataReader data2 = sqlquery.ExecuteReader();
                daftar_kelas_lb.BeginUpdate();
                for (int a = 0; data2.Read(); a++)
                {
                    daftar_kelas_gue.Add(new daftar_kelas(data2.GetString("id_kelas"), data2.GetString("id_matkul"), data2.GetString("nama_matkul"), data2.GetString("id_ruangan"), data2.GetString("tanggal").Substring(0, 10), data2.GetString("waktu")));
                    daftar_kelas_lb.Items.Add(String.Format("{0} - {1} - {2} - {3} - {4} - {5}", daftar_kelas_gue[a].id_kelas, daftar_kelas_gue[a].id_matkul, daftar_kelas_gue[a].nama_matkul, daftar_kelas_gue[a].id_ruangan, daftar_kelas_gue[a].tanggal, daftar_kelas_gue[a].waktu));
                    daftar_kelas_lb.SetSelected(a, true);
                }
                daftar_kelas_lb.EndUpdate();
                daftar_kelas_lb.SelectedIndex = 0;
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

        //SAAT DAFTAR KELAS DIPILIH ITEMNYA
        private void daftar_kelas_lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ISI KEHADIRAN
            if (mysqlconnection())
            {
                sqlquery = connect.CreateCommand();
                sqlquery.CommandText = "SELECT m.id_mahasiswa, m.nama_depan, m.nama_belakang, mk.kehadiran FROM mahasiswa_kehadiran AS mk, mahasiswa AS m WHERE id_kelas = '" + daftar_kelas_gue[daftar_kelas_lb.SelectedIndex].id_kelas + "' AND m.id_mahasiswa = mk.id_mahasiswa";
                MySqlDataReader data3 = sqlquery.ExecuteReader();
                kehadiran_gue.Clear();
                for (int a = 0; data3.Read(); a++) kehadiran_gue.Add(new kehadiran(a + 1, data3.GetString("id_mahasiswa"), data3.GetString("nama_depan") + " " + data3.GetString("nama_belakang"), data3.GetString("kehadiran").Equals("hadir") ? true : false));
                kehadiran_dg.DataSource = typeof(List<kehadiran>);
                kehadiran_dg.DataSource = kehadiran_gue;
                kehadiran_dg.DefaultCellStyle.Font = new Font("Bahnschrift SemiBold", 12, GraphicsUnit.Pixel);
                //STYLE PER KOLOM
                DataGridViewColumn column0 = kehadiran_dg.Columns[0]; column0.Width = 20;   column0.DefaultCellStyle.BackColor = Color.Silver; column0.ReadOnly = true;
                DataGridViewColumn column1 = kehadiran_dg.Columns[1]; column1.Width = 60;   column1.DefaultCellStyle.BackColor = Color.Silver; column1.ReadOnly = true;
                DataGridViewColumn column2 = kehadiran_dg.Columns[2];                       column2.DefaultCellStyle.BackColor = Color.Silver; column2.ReadOnly = true;
                DataGridViewColumn column3 = kehadiran_dg.Columns[3]; column3.Width = 60;   column3.DefaultCellStyle.BackColor = Color.Silver; column3.ReadOnly = false;
            }
            else MessageBox.Show("Gagal terhubung dengan database");
        }

        //TOMBOL SIMPAN
        private void simpan_b_Click(object sender, EventArgs e)
        {
            if (mysqlconnection())
            {
                string kehadiran;
                int a = 0;
                foreach (DataGridViewRow row in kehadiran_dg.Rows)
                {
                    kehadiran = row.Cells[3].Value.ToString().Equals("True") ? "hadir" : "absen";
                    sqlquery = connect.CreateCommand();
                    if(kehadiran == "hadir") sqlquery.CommandText = "UPDATE mahasiswa_kehadiran SET kehadiran = '" + kehadiran + "' WHERE id_mahasiswa LIKE '" + kehadiran_gue[a].ID + "' AND id_kelas LIKE '" + daftar_kelas_gue[daftar_kelas_lb.SelectedIndex].id_kelas + "'";
                    else sqlquery.CommandText = "UPDATE mahasiswa_kehadiran SET kehadiran = '" + kehadiran + "', terlambat = null, waktu_datang = null WHERE id_mahasiswa LIKE '" + kehadiran_gue[a].ID + "' AND id_kelas LIKE '" + daftar_kelas_gue[daftar_kelas_lb.SelectedIndex].id_kelas + "'";
                    int num_rows_updated = sqlquery.ExecuteNonQuery();
                    sqlquery.Dispose();
                    a++;
                }
                MessageBox.Show("Data berhasil disimpan");
            }
            else MessageBox.Show("Gagal terhubung dengan database");
        }

        //TOMBOL BATAL
        private void batal_b_Click(object sender, EventArgs e)
        {
            object sender2 = new object();
            EventArgs e2 = new EventArgs();
            daftar_kelas_lb_SelectedIndexChanged(sender2, e);
        }

        //TOMBOL MENU PENILAIAN
        private void menu_penilaian_b_Click(object sender, EventArgs e)
        {
            Menu_Penilaian menu_penilaian = new Menu_Penilaian();
            menu_penilaian.StartPosition = FormStartPosition.CenterScreen;
            menu_penilaian.Show();
            Hide();
        }

        //TOMBOL MENU PENGAJAR
        private void menu_pengajar_b_Click(object sender, EventArgs e)
        {
            Menu_Pengajar menu_pengajar = new Menu_Pengajar();
            menu_pengajar.StartPosition = FormStartPosition.CenterScreen;
            menu_pengajar.Show();
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
        private void Menu_Kehadiran_MouseDown(object sender, MouseEventArgs e)
        {
            Tog = 1;
            SX = e.X;
            SY = e.Y;
        }
        private void Menu_Kehadiran_MouseMove(object sender, MouseEventArgs e)
        {
            if (Tog == 1) this.SetDesktopLocation(MousePosition.X - SX, MousePosition.Y - SY);
        }
        private void Menu_Kehadiran_MouseUp(object sender, MouseEventArgs e)
        {
            Tog = 0;
        }
    }
}
