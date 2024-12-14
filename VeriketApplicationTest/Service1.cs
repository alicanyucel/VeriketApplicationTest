using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace VeriketApplicationTest
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Timer timer = new Timer();
            timer.Interval = 60000; 
            timer.Elapsed += new ElapsedEventHandler(this.OnTimer);
            timer.Start();
        }

        public void OnTimer(object sender, ElapsedEventArgs args)
        {
            string logFilePath = "C:\\Logs\\log.txt";
            string logMessage = DateTime.Now.ToString("g") + ": Log entry";
            File.AppendAllText(logFilePath, logMessage + Environment.NewLine);
        }



        protected override void OnStop()
        {
        }
    }
}
