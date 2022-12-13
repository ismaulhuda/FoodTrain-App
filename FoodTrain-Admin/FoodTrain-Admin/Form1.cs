using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace FoodTrain_Admin
{
    public partial class Form1 : Form
    {
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = btnMakanan.Height;
            SidePanel.Top = btnMakanan.Top;
            firstCustomControl1.BringToFront();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnMakanan_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnMakanan.Height;
            SidePanel.Top = btnMakanan.Top;
            firstCustomControl1.BringToFront();
        }

        private void btnMinuman_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnMinuman.Height;
            SidePanel.Top = btnMinuman.Top;
            secondCustomControl1.BringToFront();
        }

        private void btnPesanan_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnPesanan.Height;
            SidePanel.Top = btnPesanan.Top;
            thirdCustomControl1.BringToFront();
        }
    }
}


