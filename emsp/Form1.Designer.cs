namespace emsp
{
    partial class Form1
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
            this.b_login = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.p_minimize = new System.Windows.Forms.PictureBox();
            this.p_close = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // b_login
            // 
            this.b_login.BackColor = System.Drawing.Color.Transparent;
            this.b_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_login.Location = new System.Drawing.Point(282, 287);
            this.b_login.Name = "b_login";
            this.b_login.Size = new System.Drawing.Size(112, 44);
            this.b_login.TabIndex = 4;
            this.b_login.Text = "LOGIN";
            this.b_login.UseVisualStyleBackColor = false;
            this.b_login.Click += new System.EventHandler(this.b_login_Click);
            // 
            // tb_id
            // 
            this.tb_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.Location = new System.Drawing.Point(280, 176);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(146, 28);
            this.tb_id.TabIndex = 5;
            this.tb_id.Tag = "";
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(251, 226);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(175, 29);
            this.tb_password.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::emsp.Properties.Resources.round_tb;
            this.pictureBox3.Location = new System.Drawing.Point(256, 163);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(194, 54);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::emsp.Properties.Resources.e_msp_logo;
            this.pictureBox4.Location = new System.Drawing.Point(244, 71);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(189, 76);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // p_minimize
            // 
            this.p_minimize.Image = global::emsp.Properties.Resources.min;
            this.p_minimize.Location = new System.Drawing.Point(608, 12);
            this.p_minimize.Name = "p_minimize";
            this.p_minimize.Size = new System.Drawing.Size(25, 25);
            this.p_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_minimize.TabIndex = 7;
            this.p_minimize.TabStop = false;
            // 
            // p_close
            // 
            this.p_close.Image = global::emsp.Properties.Resources.close;
            this.p_close.Location = new System.Drawing.Point(639, 12);
            this.p_close.Name = "p_close";
            this.p_close.Size = new System.Drawing.Size(25, 25);
            this.p_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_close.TabIndex = 7;
            this.p_close.TabStop = false;
            this.p_close.Click += new System.EventHandler(this.p_close_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::emsp.Properties.Resources.password;
            this.pictureBox2.Location = new System.Drawing.Point(215, 225);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::emsp.Properties.Resources.id;
            this.pictureBox1.Location = new System.Drawing.Point(215, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(676, 392);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.p_minimize);
            this.Controls.Add(this.p_close);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.b_login);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "`";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button b_login;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.PictureBox p_close;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox p_minimize;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

