using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace WebApiSelfHosting
{
    public class HostingConfiguration : ServiceControl
    {
        private IDisposable _webApplication;
        
        public bool Start (HostControl hostControl)
        {
            Console.WriteLine("Starting service...");
            _webApplication = WebApp.Start<OwinConfiguration>
                ("http://localhost:8089");
            Console.WriteLine("Service has started.");
            return true;
        }
        public bool Stop (HostControl hostControl)
        {
            Console.WriteLine("Stoping service...");
            _webApplication.Dispose();
            Console.WriteLine("Service has stopped.");
            return true;
        }
    }
}
