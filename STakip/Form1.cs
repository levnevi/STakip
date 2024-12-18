using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "Admin" && txtSifre.Text == "123")
            {
                groupBox1.Visible = false;
                groupBox2.Visible = true;
            }
            else

            {
                MessageBox.Show("Giriş Başarısız");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
    
            UrunYonetimi urunYonetimi = new UrunYonetimi();
            urunYonetimi.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KategoriYonetimi kategoriYonetimi = new KategoriYonetimi();
            kategoriYonetimi.Show();
            //gbUrunKayitFormu.Visible = true;
        }
    }
}
