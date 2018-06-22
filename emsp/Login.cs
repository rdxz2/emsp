using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Diagnostics;

namespace emsp
{
    public partial class Login : Form 
    {
        //INIT
        public static string id = "";
        public Login()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        private void Login_Load(object sender, EventArgs e)
        {
            id_t.Focus();
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

        //MD5 HASHING
        public static string MD5(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));
            for (int i = 0; i < bytes.Length; i++) hash.Append(bytes[i].ToString("x2"));
            return hash.ToString();
        }
        //TOMBOL LOGIN
        private void masuk_b_Click(object sender, EventArgs e)
        {
            if (mysqlconnection())
            {
                string password = password_t.Text;
                bool ada = false;
                id = id_t.Text;
                sqlquery = connect.CreateCommand();
                sqlquery.CommandText = "SELECT password FROM dosen WHERE id_dosen = '" + id + "'";
                MySqlDataReader data = sqlquery.ExecuteReader();
                while (data.Read())
                {
                    ada = true;
                    if (data.GetString("password") == MD5(password))
                    {
                        Menu_Kehadiran menu_kehadiran = new Menu_Kehadiran();
                        menu_kehadiran.StartPosition = FormStartPosition.CenterScreen;
                        menu_kehadiran.Show();
                        Hide();
                    }
                    else MessageBox.Show("ID atau password salah");
                }
                if(!ada) MessageBox.Show("ID atau password salah");
            }
            else MessageBox.Show("Gagal terhubung dengan database");
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
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            Tog = 1;
            SX = e.X;
            SY = e.Y;
        }
        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (Tog == 1) this.SetDesktopLocation(MousePosition.X - SX, MousePosition.Y - SY);
        }
        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            Tog = 0;
        }

    }
}
