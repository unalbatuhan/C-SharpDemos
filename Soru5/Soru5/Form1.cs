using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblSayiGir_Click(object sender, EventArgs e)
        {

        }

        private void btnBul_Click(object sender, EventArgs e)
        {

            int sayi = Convert.ToInt32(txtSayiGir.Text);
            int sayac = 0;
            for (int i=2;i<sayi;i++)
            {
                if(sayi%i==0)
                {
                    sayac++;
                }
            }
            if (sayac == 0)
                txtSonuc.Text = sayi + " . Sayı Asaldır..";
            else
                txtSonuc.Text = sayi + " . Sayı Asal Değildir..";
        }
    }
}
