using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Assembly assembly = Assembly.GetExecutingAssembly();
            //Stream stream = assembly.GetManifestResourceStream("MediaPlayer.Resources.AMORPHIS - Alone.mp3");
            //StreamReader s = new StreamReader(stream);
        }

        private void btn_Oynat_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\Batuhan\\Music\\AMORPHIS - Alone.mp3";            
            pictureBox1.ImageLocation = "C:\\Users\\Batuhan\\Pictures\\docker-wallpaper-black.jpg";
        }
    }
}
