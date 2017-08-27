using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BungeeMultiConsole
{

    class MultiTabController
    {
        private ServerController ServerController;
        public TabControl tabControl { get; private set; }
        List<ServerTab> serverTabs { get; set; } // This is the mutable list to add to, of the current server tabs on the tabControl
        public ServerTab[] ServerTabs// this is what will be returned when getting the list of current server tabs
        {
            get
            {
                return this.serverTabs.ToArray();
            }
            set
            {
                this.serverTabs = new List<ServerTab>(value);
            }
        }

        public MultiTabController(TabControl tabControl, ServerController serverController)
        {
            this.serverTabs = new List<ServerTab>();
            this.tabControl = tabControl;
            ServerController = serverController;
            initializeTabControl();
        }

        private void initializeTabControl()
        {
            // Create a server tab for every server in the servercontroller.servers list
            foreach (Server server in ServerController.Servers)
            {
                if (!tabExistsForServer(server))
                {
                    createServerTab(server);
                }
            }
        }

        public void createServerTab(Server server)
        {
            TabPage newTabPage = new TabPage(server.directoryName);
            tabControl.Controls.Add(newTabPage);

            TextBox inputTextBox = new TextBox();
            TextBox readTextBox = new TextBox();
            readTextBox.Multiline = true;
            readTextBox.Height = newTabPage.Height - inputTextBox.Height;
            readTextBox.Width = newTabPage.Width;
            inputTextBox.Width = newTabPage.Width;
            System.Drawing.Point inputLocation = inputTextBox.Location;
            inputLocation.Y += (readTextBox.Height);
            inputTextBox.Location = inputLocation;
            newTabPage.Controls.Add(inputTextBox);
            newTabPage.Controls.Add(readTextBox);

            serverTabs.Add(new ServerTab(newTabPage, server));
        }
        
        public void clearTabControls()
        {
            tabControl.Controls.Clear();
        }

        public bool tabExistsForServer(Server server)
        {
            return serverTabExists(server.directoryPath);
        }
        
        public bool serverTabExists(string path)
        {
            if (getServerTabByPath(path) != null)
            {
                return true;
            }
            return false;
        }

        public bool serverTabExists(ServerTab serverTab)
        {
            return serverTabExists(serverTab.server.directoryPath);
        }


        // usage:
        // if (getServerTabByPath("/path/path/path") != null) {do stuff}
        public ServerTab getServerTabByPath(string path)
        {
            if (ServerTabs.Length > 0)
            {
                foreach (ServerTab serverTab in ServerTabs)
                {
                    if (path == serverTab.server.directoryPath)
                    {
                        return serverTab;
                    }
                }
            }
            return null;
        }
    }
}
