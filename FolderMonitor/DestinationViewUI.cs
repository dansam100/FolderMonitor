using System;
using System.Windows.Forms;
using FolderMonitor.FileGymnastics;
using FolderMonitor.Monitees;

namespace FolderMonitor
{
    internal partial class DestinationViewUI : Form
    {
        internal Monitees.Monitee monitee;
        
        public DestinationViewUI( Monitees.Monitee monitee )
        {
            InitializeComponent();
            this.monitee = monitee;
            LoadDestinations();
        }

        private void LoadDestinations()
        {
            if (monitee == null || MoniteeList.FindMonitee(monitee.Name) == null) return;
            this.Text = monitee.Name;
            foreach (string destination in monitee.Destinations)
            {
                if( destination != null )
                    destinationList.Items.Add(destination);
            }
        }

        void RemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int increment = 0;

                if ((destinationList.Items.Count > 0) && (destinationList.SelectedIndices.Count > 0))
                {
                    var selectedItems = new ListViewItem[destinationList.SelectedIndices.Count];

                    if ((MessageBox.Show(
                        "Are you sure you want to remove this entry?\nIt cannot be reversed.",
                        "Warning!",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes))
                    {

                        var iEnum = destinationList.SelectedIndices.GetEnumerator();

                        while (iEnum.MoveNext())
                        {
                            selectedItems[increment] = destinationList.Items[(Int32.Parse(iEnum.Current.ToString()))];
                            increment += 1;
                            XMLDataList.RemoveFile(destinationList.Items[(Int32.Parse(iEnum.Current.ToString()))].Text);
                        }
                        foreach (var list in selectedItems)
                        {
                            destinationList.Items.Remove(list);
                            MoniteeList.RemoveDestination(MoniteeList.FindMonitee(monitee.Name), list.Text);
                        }
                        if (destinationList.Items.Count == 0) { destinationList.Items.Clear(); }
                        MonitorListView.HasChanged = true;
                    }
                }
                else
                {
                    Exceptions.Exception("unselectedremove");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Having problems removing item\n" + ex,
                    "Error!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

    }
}