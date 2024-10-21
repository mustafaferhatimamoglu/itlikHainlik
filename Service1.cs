using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace itlikHainlik
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
            System.Threading.Thread.Sleep(30000);
            System.IO.File.Delete(@"C:\aa\aa.txt");
        }

        protected override void OnStart(string[] args)
        {

        }

        protected override void OnStop()
        {
        }
    }
}
