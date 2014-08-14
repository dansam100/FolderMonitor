/*
 * Created by SharpDevelop.
 * User: samuel
 * Date: 30/09/2007
 * Time: 10:24 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Windows.Forms;

namespace FolderMonitor
{
    /// <summary>
    /// Class with program entry point.
    /// </summary>
    internal sealed class Program
    {
        /// <summary>
        /// Program entry point.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            
            if (args.Length > 0)
            {
                for (int i=0; i < args.Length; i++)
                {
                }
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MonitorUI());
            }
        }
        
    }
}
