using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bramerto_rob_2._0
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DialogResult dg1 = MessageBox.Show("После запуска этой программы ваш компьютер может работать неправильно\nВы уверены, что хотите запустить вируc?\nЯ крайне не рекомендую вам его запускать ради интереса и не на виртуальной машине", "bramerto-rob 2.0", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dg1 == DialogResult.Yes)
            {
                DialogResult dg2 = MessageBox.Show("Вы точно уверены в запуске программы, поверьте не стоит\nНо если вам все-таки необходимо запустить эту программу, то запускайте\nОднако компьютер будет сломан", "bramerto-rob 2.0", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dg2 == DialogResult.Yes)
                {
                    DialogResult dg3 = MessageBox.Show("Ну, что ж, поехали!)","bramerto-rob 2.0", MessageBoxButtons.OK); 
                    if (dg3 == DialogResult.OK)
                    {
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);
                        Application.Run(new Cookie());
                    }
                }
                else
                {
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
