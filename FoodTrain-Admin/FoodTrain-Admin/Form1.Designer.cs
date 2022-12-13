namespace FoodTrain_Admin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPesanan = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnMinuman = new System.Windows.Forms.Button();
            this.btnMakanan = new System.Windows.Forms.Button();
            this.thirdCustomControl1 = new FoodTrain_Admin.thirdCustomControl();
            this.secondCustomControl1 = new FoodTrain_Admin.secondCustomControl();
            this.firstCustomControl1 = new FoodTrain_Admin.firstCustomControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(221)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 26);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1059, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 23);
            this.btnClose.TabIndex = 21;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(534, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Edit Menu";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.btnPesanan);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.SidePanel);
            this.panel2.Controls.Add(this.btnMinuman);
            this.panel2.Controls.Add(this.btnMakanan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 564);
            this.panel2.TabIndex = 21;
            // 
            // btnPesanan
            // 
            this.btnPesanan.FlatAppearance.BorderSize = 0;
            this.btnPesanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesanan.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesanan.Location = new System.Drawing.Point(9, 154);
            this.btnPesanan.Name = "btnPesanan";
            this.btnPesanan.Size = new System.Drawing.Size(136, 44);
            this.btnPesanan.TabIndex = 23;
            this.btnPesanan.Text = "Pesanan";
            this.btnPesanan.UseVisualStyleBackColor = true;
            this.btnPesanan.Click += new System.EventHandler(this.btnPesanan_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(22, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(93, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(221)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 50);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 51);
            this.SidePanel.TabIndex = 3;
            // 
            // btnMinuman
            // 
            this.btnMinuman.FlatAppearance.BorderSize = 0;
            this.btnMinuman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinuman.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinuman.Location = new System.Drawing.Point(9, 104);
            this.btnMinuman.Name = "btnMinuman";
            this.btnMinuman.Size = new System.Drawing.Size(136, 44);
            this.btnMinuman.TabIndex = 1;
            this.btnMinuman.Text = "Minuman";
            this.btnMinuman.UseVisualStyleBackColor = true;
            this.btnMinuman.Click += new System.EventHandler(this.btnMinuman_Click);
            // 
            // btnMakanan
            // 
            this.btnMakanan.FlatAppearance.BorderSize = 0;
            this.btnMakanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakanan.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakanan.Location = new System.Drawing.Point(9, 54);
            this.btnMakanan.Name = "btnMakanan";
            this.btnMakanan.Size = new System.Drawing.Size(136, 44);
            this.btnMakanan.TabIndex = 0;
            this.btnMakanan.Text = "Makanan";
            this.btnMakanan.UseVisualStyleBackColor = true;
            this.btnMakanan.Click += new System.EventHandler(this.btnMakanan_Click);
            // 
            // thirdCustomControl1
            // 
            this.thirdCustomControl1.Location = new System.Drawing.Point(148, 63);
            this.thirdCustomControl1.Name = "thirdCustomControl1";
            this.thirdCustomControl1.Size = new System.Drawing.Size(925, 527);
            this.thirdCustomControl1.TabIndex = 24;
            // 
            // secondCustomControl1
            // 
            this.secondCustomControl1.Location = new System.Drawing.Point(148, 63);
            this.secondCustomControl1.Name = "secondCustomControl1";
            this.secondCustomControl1.Size = new System.Drawing.Size(925, 527);
            this.secondCustomControl1.TabIndex = 23;
            // 
            // firstCustomControl1
            // 
            this.firstCustomControl1.Location = new System.Drawing.Point(148, 60);
            this.firstCustomControl1.Name = "firstCustomControl1";
            this.firstCustomControl1.Size = new System.Drawing.Size(925, 527);
            this.firstCustomControl1.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1085, 590);
            this.Controls.Add(this.thirdCustomControl1);
            this.Controls.Add(this.secondCustomControl1);
            this.Controls.Add(this.firstCustomControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnMinuman;
        private System.Windows.Forms.Button btnMakanan;
        private System.Windows.Forms.PictureBox pictureBox2;
        private firstCustomControl firstCustomControl1;
        private secondCustomControl secondCustomControl1;
        private System.Windows.Forms.Button btnPesanan;
        private thirdCustomControl thirdCustomControl1;
    }
}

