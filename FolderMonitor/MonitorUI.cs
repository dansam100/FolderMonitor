using System;
using System.Reflection;
using System.Windows.Forms;
using FolderMonitor.FileGymnastics;

namespace FolderMonitor
{
    public partial class MonitorUI : Form
    {
        /*
         * I guess i will have to load the stuff from this class instead
         * and pass them to the different views to use them.
         * 
         * This way, changes can be seen from this class by some event or delegate.
         * this will be effected in the two views as necessary.
        */
        
        
        internal readonly string clientName = string.Format("DocuMON {0}", Assembly.GetExecutingAssembly().GetName().Version);
        private MethodInvoker xmlWork;
        private IAsyncResult xmlTag1, xmlTag2;

        public MonitorUI()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Subroutine that calls the load of xml data into lists.
        /// </summary>
        internal void CallXMLLoad()
        {
            Console.WriteLine("It called me...");
            XMLDataList.LoadAllMonitees();
        }

        /// <summary>
        /// Calls all subroutines that populate the list.
        /// </summary>
        internal void LoadMonitees()
        {
            Console.WriteLine("MonitorLoad..");
            
            xmlWork = this.CallXMLLoad;
            xmlTag1 = xmlWork.BeginInvoke(null, "collecting files");
            xmlWork.EndInvoke(xmlTag1);

            xmlWork = this.tabControl.ListViewPage.Generate;
            xmlTag1 = xmlWork.BeginInvoke(null, "populate list");

            MethodInvoker treeXmlWork = this.tabControl.TreeViewPage.Generate;
            xmlTag2 = treeXmlWork.BeginInvoke(null, "generate tree");

            xmlWork.EndInvoke(xmlTag2);
            xmlWork.EndInvoke(xmlTag1);
        }

        /// <summary>
        /// Reload the tab controls as necessary
        /// </summary>
        private void Reload()
        {
            this.tabControl.Reload();
        }
    }
}
