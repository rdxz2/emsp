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

namespace emsp
{
    public partial class Form1 : Form
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
        
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            id_t.Focus();
        }

        int Tog;
        int SX, SY;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Tog = 1;
            SX = e.X;
            SY = e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Tog == 1)
            {
                this.SetDesktopLocation(MousePosition.X - SX, MousePosition.Y - SY);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Tog = 0;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_b_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void masuk_b_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            Hide();
        }

        private void close_b_MouseEnter(object sender, EventArgs e)
        {
            this.close_b.Load(AppDomain.CurrentDomain.BaseDirectory + "/asset/closed.png");
        }

        private void close_b_MouseLeave(object sender, EventArgs e)
        {
            this.close_b.Load(AppDomain.CurrentDomain.BaseDirectory + "/asset/close.png");
        }


        private void p_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }

    //public class RoundButton : Button
    //{
    //    protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
    //    {
    //        GraphicsPath grPath = new GraphicsPath();
    //        grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
    //        this.Region = new System.Drawing.Region(grPath);
    //        base.OnPaint(e);
    //    }
    //}
    
}
