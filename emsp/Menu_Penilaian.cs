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
    public partial class Menu_Penilaian : Form //PENILAIAN
    {
        //CLASS DAFTAR MATKUL
        class daftar_matkul
        {
            public string id_matkul     { get; set; }
            public string nama_matkul   { get; set; }
            public daftar_matkul(string id_matkul, string nama_matkul)
            {
                this.id_matkul      = id_matkul;
                this.nama_matkul    = nama_matkul;
            }
        }

        //CLASS DAFTAR MAHASISWA
        class daftar_mahasiswa
        {
            public string id_mahasiswa      { get; set; }
            public string nama_mahasiswa    { get; set; }
            public daftar_mahasiswa(string id_mahasiswa, string nama_mahasiswa)
            {
                this.id_mahasiswa   = id_mahasiswa;
                this.nama_mahasiswa = nama_mahasiswa;
            }
        }

        //CLASS NILAI
        class nilai
        {
            public string id_mahasiswa      { get; set; }
            public string nama_mahasiswa    { get; set; }
            public int nilai_tugas_teori    { get; set; }
            public int nilai_tugas_praktek  { get; set; }
            public int nilai_uts_teori      { get; set; }
            public int nilai_uts_praktek    { get; set; }
            public int nilai_uas_teori      { get; set; }
            public int nilai_uas_praktek    { get; set; }
            public nilai(string id_mahasiswa, string nama_mahasiswa, int nilai_tugas_teori, int nilai_tugas_praktek, int nilai_uts_teori, int nilai_uts_praktek, int nilai_uas_teori, int nilai_uas_praktek)
            {
                this.id_mahasiswa           = id_mahasiswa;
                this.nama_mahasiswa         = nama_mahasiswa;
                this.nilai_tugas_teori      = nilai_tugas_teori;
                this.nilai_tugas_praktek    = nilai_tugas_praktek;
                this.nilai_uts_teori        = nilai_uts_teori;
                this.nilai_uts_praktek      = nilai_uts_praktek;
                this.nilai_uas_teori        = nilai_uas_teori;
                this.nilai_uas_praktek      = nilai_uas_praktek;
            }
        }

        //INIT
        string id = Login.id;
        private List<daftar_matkul> daftar_matkul_gue = new List<daftar_matkul>();
        private List<daftar_mahasiswa> daftar_mahasiswa_gue = new List<daftar_mahasiswa>();
        private List<nilai> nilai_gue = new List<nilai>();
        public Menu_Penilaian()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        private void Menu_Penilaian_Load(object sender, EventArgs e)
        {
            //SET PROPERTY TEXTBOX
            tugas_teori_t.Enabled   = false;
            tugas_praktek_t.Enabled = false;
            uts_teori_t.Enabled     = false;
            uts_praktek_t.Enabled   = false;
            uas_teori_t.Enabled     = false;
            uas_praktek_t.Enabled   = false;
            //SET PROPERTY TOMBOL
            batal_b.Enabled = false;
            simpan_b.Enabled = false;
            //ISI NAMA DOSEN
            if (mysqlconnection())
            {
                sqlquery = connect.CreateCommand();
                sqlquery.CommandText = "SELECT nama FROM dosen WHERE id_dosen = '" + id + "'";
                MySqlDataReader data1 = sqlquery.ExecuteReader();
                while (data1.Read()) nama_l.Text = data1.GetString("nama");
                //ISI DAFTAR MAKTUL (COMBOBOX)
                mysqlconnection();
                sqlquery = connect.CreateCommand();
                sqlquery.CommandText = "SELECT matkul.id_matkul, matkul.nama_matkul FROM kelas, matkul WHERE kelas.id_dosen LIKE '" + id + "' AND matkul.id_matkul = kelas.id_matkul";
                MySqlDataReader data2 = sqlquery.ExecuteReader();
                for(int a = 0; data2.Read(); a++) {
                    daftar_matkul_gue.Add(new daftar_matkul(data2.GetString("id_matkul"), data2.GetString("nama_matkul")));
                    matkul_cob.Items.Add(daftar_matkul_gue[a].id_matkul + " - " + daftar_matkul_gue[a].nama_matkul);
                } 
                matkul_cob.DropDownStyle = ComboBoxStyle.DropDownList;
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
        private void matkul_cob_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ISI DAFTAR MAHASISWA
            if (mysqlconnection())
            {
                sqlquery = connect.CreateCommand();
                sqlquery.CommandText = "SELECT m.id_mahasiswa, m.nama_depan, m.nama_belakang FROM mahasiswa AS m, mahasiswa_matkul AS mm WHERE mm.id_matkul LIKE '" + daftar_matkul_gue[matkul_cob.SelectedIndex].id_matkul + "' AND m.id_mahasiswa = mm.id_mahasiswa;";
                MySqlDataReader data2 = sqlquery.ExecuteReader();
                daftar_mahasiswa_gue.Clear();
                daftar_mahasiswa_lb.Items.Clear();
                daftar_mahasiswa_lb.BeginUpdate();
                for (int a = 0; data2.Read(); a++)
                {
                    daftar_mahasiswa_gue.Add(new daftar_mahasiswa(data2.GetString("id_mahasiswa"), data2.GetString("nama_depan") + " " + data2.GetString("nama_belakang")));
                    daftar_mahasiswa_lb.Items.Add(String.Format("{0} - {1}", daftar_mahasiswa_gue[a].id_mahasiswa, daftar_mahasiswa_gue[a].nama_mahasiswa));
                    daftar_mahasiswa_lb.SetSelected(a, true);
                }
                daftar_mahasiswa_lb.EndUpdate();
            }
            else MessageBox.Show("Gagal terhubung dengan database");
        }

        //SAAT DAFTAR MAHASISWA DIPILIH ITEMNYA
        private void daftar_mahasiswa_lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SET PROPERTY TEXTBOX
            tugas_teori_t.Enabled   = true;
            tugas_praktek_t.Enabled = true;
            uts_teori_t.Enabled     = true;
            uts_praktek_t.Enabled   = true;
            uas_teori_t.Enabled     = true;
            uas_praktek_t.Enabled   = true;
            //SET PROPERTY TOMBOL
            batal_b.Enabled = true;
            simpan_b.Enabled = true;
            //ISI NILAI
            if (mysqlconnection())
            {
                sqlquery = connect.CreateCommand();
                sqlquery.CommandText = "SELECT m.id_mahasiswa, nama_depan, nama_belakang, nilai_tugas_teori, nilai_tugas_praktek, nilai_uts_teori, nilai_uts_praktek, nilai_uas_teori, nilai_uas_praktek FROM mahasiswa_matkul AS mm, mahasiswa AS m WHERE mm.id_mahasiswa LIKE '" + daftar_mahasiswa_gue[daftar_mahasiswa_lb.SelectedIndex].id_mahasiswa + "' AND mm.id_matkul LIKE '" + daftar_matkul_gue[matkul_cob.SelectedIndex].id_matkul + "' AND m.id_mahasiswa = mm.id_mahasiswa";
                MySqlDataReader data3 = sqlquery.ExecuteReader();
                nilai_gue.Clear();
                while (data3.Read()) nilai_gue.Add(new nilai(data3.GetString("id_mahasiswa"), data3.GetString("nama_depan") + " " + data3.GetString("nama_belakang"), data3.GetInt16("nilai_tugas_teori"), data3.GetInt16("nilai_tugas_praktek"), data3.GetInt16("nilai_uts_teori"), data3.GetInt16("nilai_uts_praktek"), data3.GetInt16("nilai_uas_teori"), data3.GetInt16("nilai_uas_praktek")));
                id_nama_mahasiswa_l.Text    = nilai_gue[0].id_mahasiswa + " - " + nilai_gue[0].nama_mahasiswa;
                tugas_teori_t.Text          = nilai_gue[0].nilai_tugas_teori.ToString();
                tugas_praktek_t.Text        = nilai_gue[0].nilai_tugas_praktek.ToString();
                uts_teori_t.Text            = nilai_gue[0].nilai_uts_teori.ToString();
                uts_praktek_t.Text          = nilai_gue[0].nilai_uts_praktek.ToString();
                uas_teori_t.Text            = nilai_gue[0].nilai_uas_teori.ToString();
                uas_praktek_t.Text          = nilai_gue[0].nilai_uas_praktek.ToString();
                double nilai_akhir = 0.3 * (0.67 * nilai_gue[0].nilai_tugas_teori + 0.33 * nilai_gue[0].nilai_tugas_praktek) + 0.3 * (0.67 * nilai_gue[0].nilai_uts_teori + 0.33 * nilai_gue[0].nilai_uts_praktek) + 0.4 * (0.67 * nilai_gue[0].nilai_uas_teori + 0.33 * nilai_gue[0].nilai_uas_praktek);
                string huruf_akhir = "";
                if (nilai_akhir >= 85) huruf_akhir = "A";
                else if (nilai_akhir >= 80) huruf_akhir = "A-";
                else if (nilai_akhir >= 75) huruf_akhir = "B+";
                else if (nilai_akhir >= 70) huruf_akhir = "B";
                else if (nilai_akhir >= 65) huruf_akhir = "B-";
                else if (nilai_akhir >= 60) huruf_akhir = "C+";
                else if (nilai_akhir >= 55) huruf_akhir = "C";
                else if (nilai_akhir >= 50) huruf_akhir = "D";
                else huruf_akhir = "E";
                total_nilai_l.Text = String.Format("{0} - {1}", nilai_akhir, huruf_akhir);
            }
            else MessageBox.Show("Gagal terhubung dengan database");
        }

        //FUNGSI CEK INPUTAN NILAI
        private void cek_nilai(TextBox textbox, int awal)
        {
            Int16 a;
            Int16.TryParse(textbox.Text, out a);
            if (a < 0 || a > 100)
            {
                MessageBox.Show("Input angka yang benar");
                textbox.Text = awal.ToString();
            }
        }

        //SAAT INPUT NILAI TUGAS TEORI
        private void tugas_teori_t_TextChanged(object sender, EventArgs e)      { cek_nilai(tugas_teori_t, nilai_gue[0].nilai_tugas_teori); }

        //SAAT INPUT NILAI TUGAS PRAKTEK
        private void tugas_praktek_t_TextChanged(object sender, EventArgs e)    { cek_nilai(tugas_teori_t, nilai_gue[0].nilai_tugas_praktek); }

        //SAAT INPUT NILAI UTS TEORI
        private void uts_teori_t_TextChanged(object sender, EventArgs e)        { cek_nilai(uts_teori_t  , nilai_gue[0].nilai_uts_teori); }

        //SAAT INPUT NILAI UTS PRAKTEK
        private void uts_praktek_t_TextChanged(object sender, EventArgs e)      { cek_nilai(uts_praktek_t, nilai_gue[0].nilai_uts_praktek); }

        //SAAT INPUT NILAI UAS TEORI
        private void uas_teori_t_TextChanged(object sender, EventArgs e)        { cek_nilai(uas_teori_t  , nilai_gue[0].nilai_uas_teori); }

        //SAAT INPUT NILAI UAS PRAKTEK
        private void uas_praktek_t_TextChanged(object sender, EventArgs e)      { cek_nilai(uas_praktek_t, nilai_gue[0].nilai_uas_praktek); }

        //TOMBOL SIMPAN
        private void simpan_b_Click(object sender, EventArgs e)
        {
            if (mysqlconnection())
            {
                Int16 tugas_teori_nilai, tugas_praktek_nilai, uts_teori_nilai, uts_praktek_nilai, uas_teori_nilai, uas_praktek_nilai;
                Int16.TryParse(tugas_teori_t.Text, out tugas_teori_nilai);
                Int16.TryParse(tugas_praktek_t.Text, out tugas_praktek_nilai);
                Int16.TryParse(uts_teori_t.Text, out uts_teori_nilai);
                Int16.TryParse(uts_praktek_t.Text, out uts_praktek_nilai);
                Int16.TryParse(uas_teori_t.Text, out uas_teori_nilai);
                Int16.TryParse(uas_praktek_t.Text, out uas_praktek_nilai);
                sqlquery = connect.CreateCommand();
                sqlquery.CommandText = "UPDATE mahasiswa_matkul SET nilai_tugas_teori = " + tugas_teori_nilai+ ", nilai_tugas_praktek = " + tugas_praktek_nilai + ", nilai_uts_teori = " + uts_teori_nilai + ", nilai_uts_praktek = " + uts_praktek_nilai + ", nilai_uas_teori = " + uas_teori_nilai + ", nilai_uas_praktek = " + uas_praktek_nilai + " WHERE id_mahasiswa LIKE '" + daftar_mahasiswa_gue[daftar_mahasiswa_lb.SelectedIndex].id_mahasiswa + "' AND id_matkul LIKE '" + daftar_matkul_gue[matkul_cob.SelectedIndex].id_matkul + "'";
                int num_rows_updated = sqlquery.ExecuteNonQuery();
                sqlquery.Dispose();
                MessageBox.Show("Data berhasil disimpan");
                object sender2 = new object();
                EventArgs e2 = new EventArgs();
                daftar_mahasiswa_lb_SelectedIndexChanged(sender2, e2);
            }
            else MessageBox.Show("Gagal terhubung dengan database");
        }

        //TOMBOL BATAL
        private void batal_b_Click(object sender, EventArgs e)
        {
            tugas_teori_t.Text      = nilai_gue[0].nilai_tugas_teori.ToString();
            tugas_praktek_t.Text    = nilai_gue[0].nilai_tugas_praktek.ToString();
            uts_teori_t.Text        = nilai_gue[0].nilai_uts_teori.ToString();
            uts_praktek_t.Text      = nilai_gue[0].nilai_uts_praktek.ToString();
            uas_teori_t.Text        = nilai_gue[0].nilai_uas_teori.ToString();
            uas_praktek_t.Text      = nilai_gue[0].nilai_uas_praktek.ToString();
        }

        //TOMBOL MENU KEHADIRAN
        private void menu_kehadiran_b_Click(object sender, EventArgs e)
        {
            Menu_Kehadiran menu_kehadiran = new Menu_Kehadiran();
            menu_kehadiran.StartPosition = FormStartPosition.CenterScreen;
            menu_kehadiran.Show();
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
        private void Menu_Penilaian_MouseDown(object sender, MouseEventArgs e)
        {
            Tog = 1;
            SX = e.X;
            SY = e.Y;
        }
        private void Menu_Penilaian_MouseMove(object sender, MouseEventArgs e)
        {
            if (Tog == 1) this.SetDesktopLocation(MousePosition.X - SX, MousePosition.Y - SY);
        }
        private void Menu_Penilaian_MouseUp(object sender, MouseEventArgs e)
        {
            Tog = 0;
        }
    }
}
