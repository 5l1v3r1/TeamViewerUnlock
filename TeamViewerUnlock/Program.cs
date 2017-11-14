using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamViewerUnlock
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.FileSystemWatcher watcher = new FileSystemWatcher(@"C:\Program Files (x86)\TeamViewer");
            watcher.EnableRaisingEvents = true;
            watcher.IncludeSubdirectories = true;
            //to watch only once file do 
            watcher.Filter = "TeamViewer12_Logfile.log";

            watcher.Changed += watcher_Changed;
          
           
        }

                 

        static void watcher_Changed(object sender, FileSystemEventArgs e)
        {
            // throw new NotImplementedException();
            //Console.WriteLine("File {0} changed at time: {0}", e.Name, DateTime.Now.ToLocalTime());


        }
    }
}
