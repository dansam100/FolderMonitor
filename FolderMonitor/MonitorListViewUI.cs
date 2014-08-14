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
using FolderMonitor.FileGymnastics;
using FolderMonitor.Monitees;

namespace FolderMonitor
{
    /// <summary>
    /// Folder Monitor program.
    /// </summary>
    internal partial class MonitorListView : TabPage
    {
        private const System.String _DefaultFolder = "c:\\doc";
        private const System.Int32 _DefaultCheckInterval = 10;
        
        public static System.Collections.ArrayList monitees = null;
        public static System.Boolean HasChanged = false;
        //public XMLDataList xmlDataList;
        public XMLData xmlData;

        /// <summary>
        /// ctor
        /// </summary>
        public MonitorListView()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }

        
        /// <summary>
        /// event: when browse button is clicked for FOLDERS.
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        void On_BrowseClick(object sender, System.EventArgs e)
        {
            FolderBrowserDialog folDlg = new FolderBrowserDialog();
            if (folDlg.ShowDialog() == DialogResult.OK)
            {
                this.FolderSelectorBox.Text = folDlg.SelectedPath;
            }
        }

        /// <summary>
        /// event: when browse button is clicked for FILES.
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        void Dest_BrowseBtn_Click(object sender, System.EventArgs e)
        {
            FolderBrowserDialog folDlg = new FolderBrowserDialog();
            if (folDlg.ShowDialog() == DialogResult.OK)
            {
                this.DestinationBox.Text = folDlg.SelectedPath;
            }
        }

        /// <summary>
        /// event: when add button is clicked.
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        void AddFolderBtn_Click(object sender, System.EventArgs e)
        {
            this.AddListItem();
        }

        /// <summary>
        /// Called when Add Folder is clicked. Adds folder to listbox.
        /// </summary>
        private void AddListItem()
        {
            if (!(this.FolderSelectorBox.Text == String.Empty))
            {

                if ((this.Lists.Items.Count == 0))
                {
                    this.AddMonitoredItem();
                    return;
                }
                if (this.CheckUniqueness())
                {
                    this.AddMonitoredItem();
                }
                if(this.CheckForCyclicDependency().Length > 0 )
                {
                    Exceptions.Exception("cyclicdependency", this.CheckForCyclicDependency());
                }
            }
            else
            {
                Exceptions.Exception("emptymoniteebox");
            }
        }

        

        /// <summary>
        /// File dialog for getting files to be monitored.
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        void BrwseFileBtn_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog fileDlg = new OpenFileDialog();
            fileDlg.InitialDirectory = System.Environment.SpecialFolder.MyDocuments.ToString();
            fileDlg.Multiselect = false;
            if (fileDlg.ShowDialog() == DialogResult.OK)
            {
                this.FolderSelectorBox.Text = fileDlg.FileName;
            }
        }
        
        /// <summary>
        /// To temporary stop or start monitoring files.
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        void StartMonitorProc_Click(object sender, System.EventArgs e)
        {
            XMLDataList.BackUpData();
        }

        /// <summary>
        /// Removes selected item from list.
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        void RemoveFolderBtn_Click(object sender, System.EventArgs e)
        {
            this.RemoveListItem();
        }

        /// <summary>
        /// Opens the destination viewer dialog; sends monitee data to display.
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        void destinationViewBtn_Click(object sender, System.EventArgs e)
        {
            if ((this.Lists.Items.Count > 0) && (this.Lists.SelectedIndices.Count > 0))
            {
                System.Collections.IEnumerator iEnum = this.Lists.SelectedIndices.GetEnumerator();
                this.Lists.SelectedItems[0].Checked = true;
                while (iEnum.MoveNext())
                {
                    Monitees.Monitee mon = MoniteeList.FindMonitee(this.Lists.Items[(Int32.Parse(iEnum.Current.ToString()))].Text);
                    DestinationViewUI destView = new DestinationViewUI(mon);
                    
                    destView.ShowDialog();
                }
            }
            else
            {
                Exceptions.Exception("selectmonitee");
            }
        }


        private void Lists_DoubleClick(object sender, EventArgs e)
        {
            destinationViewBtn_Click(sender, e);
        }


        internal void MonitorListView_OnKeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Enter:
                    if(this.Lists.SelectedIndices.Count > 0)
                    {
                        destinationViewBtn_Click(sender, e);
                    }
                    break;
            }
        }

    }
}
