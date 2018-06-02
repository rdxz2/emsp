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

        public Form2()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        void Form2_Load(object sender, EventArgs e)
        {

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

        private void menu_penilaian_b_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            Hide();
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            Tog = 0;
        }
    }
}
