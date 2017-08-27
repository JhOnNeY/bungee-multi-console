using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BungeeMultiConsole
{
    class ServerTab
    {
        public Server server { get; set; }
        public TabPage tabPage { get; set; }

        public ServerTab(TabPage tabPage, Server server)
        {
            this.server = server;
            this.tabPage = tabPage;
        }
    }
}
