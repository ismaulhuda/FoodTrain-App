using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodTrain_User
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = btnMakanan.Height;
            SidePanel.Top = btnMakanan.Top;
            makananCustomControl1.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMakanan_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnMakanan.Height;
            SidePanel.Top = btnMakanan.Top;
            makananCustomControl1.BringToFront();

        }

        private void btnMinuman_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnMinuman.Height;
            SidePanel.Top = btnMinuman.Top;
            minumanCustomControl1.BringToFront();
        }

        private void btnPesan_Click(object sender, EventArgs e)
        {

        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
