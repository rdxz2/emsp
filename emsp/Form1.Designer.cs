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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.password_t = new System.Windows.Forms.TextBox();
            this.id_t = new System.Windows.Forms.TextBox();
            this.masuk_b = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.minimize_b = new System.Windows.Forms.PictureBox();
            this.close_b = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // password_t
            // 
            this.password_t.BackColor = System.Drawing.Color.DarkGray;
            this.password_t.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_t.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_t.Location = new System.Drawing.Point(203, 207);
            this.password_t.Name = "password_t";
            this.password_t.PasswordChar = '*';
            this.password_t.Size = new System.Drawing.Size(209, 19);
            this.password_t.TabIndex = 6;
            // 
            // id_t
            // 
            this.id_t.BackColor = System.Drawing.Color.DarkGray;
            this.id_t.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id_t.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_t.Location = new System.Drawing.Point(203, 168);
            this.id_t.Name = "id_t";
            this.id_t.Size = new System.Drawing.Size(209, 19);
            this.id_t.TabIndex = 5;
            this.id_t.Tag = "";
            // 
            // masuk_b
            // 
            this.masuk_b.BackColor = System.Drawing.Color.DarkOrange;
            this.masuk_b.FlatAppearance.BorderSize = 0;
            this.masuk_b.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.masuk_b.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masuk_b.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.masuk_b.Location = new System.Drawing.Point(249, 250);
            this.masuk_b.Name = "masuk_b";
            this.masuk_b.Size = new System.Drawing.Size(117, 41);
            this.masuk_b.TabIndex = 9;
            this.masuk_b.Text = "MASUK";
            this.masuk_b.UseVisualStyleBackColor = false;
            this.masuk_b.Click += new System.EventHandler(this.masuk_b_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.InitialImage")));
            this.pictureBox4.Location = new System.Drawing.Point(203, 56);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(209, 82);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // minimize_b
            // 
            this.minimize_b.Image = ((System.Drawing.Image)(resources.GetObject("minimize_b.Image")));
            this.minimize_b.InitialImage = ((System.Drawing.Image)(resources.GetObject("minimize_b.InitialImage")));
            this.minimize_b.Location = new System.Drawing.Point(543, 12);
            this.minimize_b.Name = "minimize_b";
            this.minimize_b.Size = new System.Drawing.Size(25, 25);
            this.minimize_b.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimize_b.TabIndex = 7;
            this.minimize_b.TabStop = false;
            this.minimize_b.Click += new System.EventHandler(this.minimize_b_Click);
            // 
            // close_b
            // 
            this.close_b.Image = ((System.Drawing.Image)(resources.GetObject("close_b.Image")));
            this.close_b.InitialImage = ((System.Drawing.Image)(resources.GetObject("close_b.InitialImage")));
            this.close_b.Location = new System.Drawing.Point(574, 12);
            this.close_b.Name = "close_b";
            this.close_b.Size = new System.Drawing.Size(25, 25);
            this.close_b.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close_b.TabIndex = 7;
            this.close_b.TabStop = false;
            this.close_b.Click += new System.EventHandler(this.p_close_Click);
            this.close_b.MouseEnter += new System.EventHandler(this.close_b_MouseEnter);
            this.close_b.MouseLeave += new System.EventHandler(this.close_b_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(143, 199);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(143, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox3.Location = new System.Drawing.Point(197, 164);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(221, 27);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox5.Location = new System.Drawing.Point(197, 203);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(221, 27);
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(611, 370);
            this.Controls.Add(this.masuk_b);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.password_t);
            this.Controls.Add(this.id_t);
            this.Controls.Add(this.minimize_b);
            this.Controls.Add(this.close_b);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox5);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "`";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox password_t;
        private System.Windows.Forms.PictureBox close_b;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox minimize_b;
        private System.Windows.Forms.TextBox id_t;
        private System.Windows.Forms.Button masuk_b;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

