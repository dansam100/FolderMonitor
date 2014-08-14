using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FolderMonitor
{
    public partial class TabControl : System.Windows.Forms.TabControl
    {

        public TabControl()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Returns the tab you have currently selected.
        /// </summary>
        public TabControl GetTab
        {
            get
            {
                return new TabControl();
            }
        }


        internal MonitorListView ListViewPage { get{ return listViewPage; } }
        internal MonitorTreeView TreeViewPage { get{ return treeViewPage; } }

        /// <summary>
        /// Reloads a view in the tabcontrol.
        /// </summary>
        public void Reload()
        {
            if (this.SelectedTab.GetType() == typeof(MonitorListView))
            {
                if (MonitorTreeView.HasChanged)
                {
                    this.ListViewPage.Clear();
                    this.ListViewPage.Generate();
                    MonitorTreeView.HasChanged = false;
                }
            }
            else if (this.SelectedTab.GetType() == typeof(MonitorTreeView))
            {
                if (MonitorListView.HasChanged)
                {
                    this.TreeViewPage.Clear();
                    this.TreeViewPage.Generate();
                    MonitorListView.HasChanged = false;
                }
            }
        }
    }
}
