using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace BungeeMultiConsole
{
    class Server
    {
        public Guid InstanceID { get; private set; }
        public string directoryPath { get; private set; }
        public Process process { get; private set; }
        public string directoryName { get; private set; }
        public string serverName { get; private set; }
        public bool hideServer { get; set; }
        bool processIsSet { get; set; }


        public Server (string directory)
        {
            this.InstanceID = Guid.NewGuid();
            this.directoryPath = directory;
            this.directoryName = Path.GetFileName(directory);
            this.serverName = "";
        }

        public void setProcess(Process process)
        {
            if (!processIsSet)
            {
                this.process = process;
                processIsSet = true;
            }
        }

        public void setServerName(string name)
        {
            this.serverName = name;
        }
    }
}
