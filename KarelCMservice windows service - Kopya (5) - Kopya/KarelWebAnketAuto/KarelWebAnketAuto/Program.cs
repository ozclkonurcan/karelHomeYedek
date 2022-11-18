using KarelWebAnketAuto.Model;
using KarelWebAnketAuto.VM_Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace KarelWebAnketAuto
{
    internal static class Program
    {
       

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
    
         
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
            
            new Service1()
            };
            ServiceBase.Run(ServicesToRun);

        }
    }
}
