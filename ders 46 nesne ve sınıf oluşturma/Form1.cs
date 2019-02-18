using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders_46_nesne_ve_sınıf_oluşturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            araba2 rb = new araba2();

            rb.renk = "kirmizi";
            rb. hiz = 180;
            rb.cesidi = "bmw";
            rb.durumu = 'i';
            rb.fiyat = 200000;

            label1.Text = rb.renk;
            label2.Text = rb.cesidi;
            label3.Text = rb.hiz.ToString();
            label4.Text = rb.durumu.ToString();
            label5.Text = rb.fiyat.ToString();
            pictureBox1.BackColor = Color.Red;
        }
    }
}
