using System;
using System.IO;
using System.Diagnostics;
using System.ComponentModel;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BungeeMultiConsole
{
    public partial class BungeeMultiConsole : Form
    {

        public BungeeMultiConsole()
        {
            InitializeComponent();
        }

        private void scanDirectoryButton_Click(object sender, EventArgs e)
        {            
            
        }

        private void singleStartButton_Click(object sender, EventArgs e)
        {

            MessageBox.Show(sender.ToString());
            MessageBox.Show(e.ToString());
        }


        private void serverDirButton_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", AppDomain.CurrentDomain.BaseDirectory + @"Servers\");
        }

        private void BungeeMultiConsole_Load(object sender, EventArgs e)
        {
            // Create /server directory if none exists
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"Servers\"))
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"Servers\");
            }

            // Start instantiating classes
            try
            {
                ServerController servers = new ServerController();
                MultiTabController multiTabController = new MultiTabController(this.multiTabControl, servers);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void multiStartButton_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void testStartBtn_Click(object sender, EventArgs e)
        {
            Process myProcess = new Process();
            myProcess.StartInfo.FileName = "Notepad";
            myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            myProcess.Start();
        }

        private void testFormButton_Click(object sender, EventArgs e)
        {
            TestConsoleForm form = new TestConsoleForm();
            form.Show();
        }
    }
}