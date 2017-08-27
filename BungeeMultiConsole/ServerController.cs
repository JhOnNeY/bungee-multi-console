using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace BungeeMultiConsole
{
    class ServerController
    {
        List<string> serverFolderPaths { get; set; } // This is the mutable list to get from, of the "read from disk" directories
        private string[] ServerFolderPaths // this is what will be returned when getting a list of server folder paths
        {
            get
            {
                return this.serverFolderPaths.ToArray();
            }
            set
            {
                this.serverFolderPaths = new List<string>(value);
            }
        }

        List<Server> servers { get; set; } // This is the mutable list to get from, add to, of the current servers
        public Server[] Servers // this is what will be returned when getting a list of current servers
        {
            get
            {
                return this.servers.ToArray();
            }
            set
            {
                this.servers = new List<Server>(value);
            }
        }

        // start class methods
        public ServerController()
        {
            this.serverFolderPaths = Directory.GetDirectories(AppDomain.CurrentDomain.BaseDirectory + @"Servers\").ToList<string>();
            this.servers = new List<Server>();
            createAllServers();
        }

        private void createAllServers()
        {
            for (int i = 0; i < this.ServerFolderPaths.Length; i++)
            {
                createServer(serverFolderPaths[i]);
            }
        }

        private void createServer(string directory)
        {
            if (!serverExists(directory))
            {
                servers.Add(new Server(directory));
            }
            else
            {
                MessageBox.Show("Server Already Exsists");
            }
        }

        public bool serverExists(string directory)
        {
            if (getServerByPath(directory) != null)
            {
                return true;
            }
            return false;
        }

        public bool serverExists(Guid id)
        {
            if (getServerByID(id) != null)
            {
                return true;
            }
            return false;
        }

        public bool serverExists(Server server)
        {
            return serverExists(server.directoryPath);
        }

        // use as like so
        // Server server = getServerById(21515-1512-152);
        // if (server != null) {do stuff}
        public Server getServerByID(Guid id)
        { 
            try
            {
                return servers.Find(server => server.InstanceID == id);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        // use as like so
        // Server server = getServerByPath(/path/path/pathapth/laugh/laguh);
        // if (server != null) {do stuff}
        public Server getServerByPath(string path)
        {
            try
            {
                return servers.Find(server => server.directoryPath == path);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
    }
}
