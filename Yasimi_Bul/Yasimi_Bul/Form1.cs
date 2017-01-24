using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yasimi_Bul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYasimiBul_Click(object sender, EventArgs e)
        {
            DateTime dtDogum = dtDogumTarih.Value;
            DateTime dtSimdi = DateTime.Now;
            int yas = dtSimdi.Year - dtDogum.Year;
            txtYas.Text = yas.ToString();
        }
    }
}
