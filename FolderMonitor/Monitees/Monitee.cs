using System;
using System.Windows.Forms;
using FolderMonitor.FileGymnastics;
namespace FolderMonitor.Monitees
{
    /// <summary>
    /// Description for Monitee
    /// </summary>
    public class Monitee
    {
        private String[] destination;

        public Monitee(string monitee, string destination, XMLDataList.ItemType type)
        {
            this.Name = monitee;
            this.Type = type;
            this.destination = new String[5];
            this.destination[Index] = destination;
            Index++;
        }

        public Monitee( XMLData data)
        {
            this.Name = data.MoniteePath;
            this.destination = new String[5];
            this.destination[Index] = data.DestinationPath;
            Index++;
        }

        internal String Name { get; private set; }

        internal XMLDataList.ItemType Type { get; private set; }

        internal System.Int32 Index { get; private set; }

        internal System.Windows.Forms.ListViewItem ListItem { get; set; }

        internal System.Windows.Forms.TreeNode TreeNode { get; set; }

        internal String[] Destinations
        {
            get { return DestinationsAvailable(); }
            set {   destination[Index] = value[0]; 
                    Index++;
                if (Index == destination.Length)
                {
                    AdjustSize();
                }
            }
        }

        private String[] DestinationsAvailable()
        {
            var destAvail = new string[Index];
            for(int i=0; i < Index; i++ )
            {
                destAvail[i] = destination[i];
            }
            return destAvail;
        }

        internal void RemoveDestination(string destName)
        {
            for (int i = 0; i < Index; i++)
            {
                if (destination[i] == destName)
                {
                    if (Destinations.Length.CompareTo(1) == 0)
                    {
                        if(Confirmations.Confirm("removemonitee") == DialogResult.No)
                            return;
                    }
                    --Index;
                    destination[i] = destination[Index];
                    break;
                }
            }
            
        }

        protected void AdjustSize()
        {
            var tmp = destination;
            destination = new String[destination.Length * 2];
            for (int i = 0; i < Index; i++)
            {
                tmp[i] = destination[i];
            }
        }

    }
}
