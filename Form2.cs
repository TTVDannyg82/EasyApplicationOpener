using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBT_Maker
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            const string localFile = @"C:\Program Files\Badlion Client\Badlion Client.exe";
            System.Diagnostics.Process.Start(localFile);
        }

        private void siticoneButton7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void siticoneButton8_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            const string localFile1 = @"C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE\devenv.exe";
            System.Diagnostics.Process.Start(localFile1);
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            const string localFile2 = @"C:\Users\kyegi\AppData\Local\Programs\Microsoft VS Code\code.exe";
            System.Diagnostics.Process.Start(localFile2);
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + "\\iplookup.exe");
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            const string localFile3 = @"C:\Users\kyegi\AppData\Local\Discord\app-1.0.9003\Discord.exe";
            System.Diagnostics.Process.Start(localFile3);
        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            const string localFile4 = @"C:\Program Files (x86)\Minecraft Launcher\MinecraftLauncher.exe";
            System.Diagnostics.Process.Start(localFile4);
        }

        private void siticoneButton9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://www.teamg82.tk");
        }
    }
}
