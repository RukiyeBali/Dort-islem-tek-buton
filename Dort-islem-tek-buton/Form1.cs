using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dort_islem_tek_buton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHeasapla_Click(object sender, EventArgs e)

        {
            double sayi1, sayi2, toplam, fark, carpim, bolum;

            sayi1 = Convert.ToDouble(txtSayi1.Text);
            sayi2 = Convert.ToDouble(txtSayi2.Text);

            toplam = sayi1 + sayi2;
            fark = sayi1 - sayi2;
            carpim = sayi1 * sayi2;
            bolum = sayi1 / sayi2;


            lblToplam.Text = "Toplam: " + toplam;
            lblFark.Text = "Fark: " + fark;
            lblCarpim.Text = "Çarpım: " + carpim;
            lblBolum.Text = "Bölüm: " + bolum;
        }
    }
}
