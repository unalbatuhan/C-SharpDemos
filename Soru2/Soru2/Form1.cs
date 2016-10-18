using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            txtSonuc.Enabled = false;
           
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtSayi1.Text);
            int y = Convert.ToInt32(txtSayi2.Text);
            txtSonuc.Text = Convert.ToString(x + y);
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtSayi1.Text);
            int y = Convert.ToInt32(txtSayi2.Text);
            txtSonuc.Text = Convert.ToString(x - y);
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtSayi1.Text);
            int y = Convert.ToInt32(txtSayi2.Text);
            txtSonuc.Text = Convert.ToString(x * y);
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtSayi1.Text);
            int y = Convert.ToInt32(txtSayi2.Text);
            txtSonuc.Text = Convert.ToString(x / y);
        }
    }
}
