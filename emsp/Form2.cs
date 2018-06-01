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
    public partial class Form2 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        int no;
        String nim, nama, jurusan, email, hp;
        private String koneksi;
        MySqlConnection konek;
        MySqlCommand sqlquery;

        public Form2()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            TampilData();
        }

        void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void TampilDataMahasiswa()
        {
            try
            {
                connect_mysql();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * from mahasiswa_kehadiran", konek);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dttblmahasiswa.DataSource = ds.Tables[0];
                konek.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

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
    }
}
