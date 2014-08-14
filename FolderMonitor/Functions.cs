using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FolderMonitor.FileGymnastics;
using FolderMonitor.Monitees;

namespace FolderMonitor
{
    
    partial class MonitorListView
    {
        Monitees.Monitee monitee;

        private delegate void PopulateListDelegate();
        internal void Generate()
        {
            this.Invoke(new PopulateListDelegate(PopulateList));
        }

        /// <summary>
        /// Uses the full list of items to populate listbox and monitee list.
        /// </summary>
        internal void PopulateList()
        {
            if (MoniteeList.Head != null)
            {
                ListViewItem.ListViewSubItem subItem1;

                /*for (int i = 0; i < monitees.Count; i++)
                {
                    string[] items = ((string)monitees[i]).Split(';');

                    System.Windows.Forms.ListViewItem listItems = new ListViewItem(items[0]);
                    listItems.Checked = true;
                    subItem1 = new ListViewItem.ListViewSubItem(listItems,
                        items[1]);
                    listItems.SubItems.Add(subItem1);
                    len++;
                    Lists.Items.Add(listItems);
                }*/

                FolderMonitor.Monitees.MoniteeListEntry current = MoniteeList.Head;
                while (current != null)
                {
                    ListViewItem listItem = new ListViewItem(current.Data.Name);
                    listItem.Checked = true;
                    
                    Console.WriteLine("Adding {0} to the listview", current.Data.Name);
                    //subItem1 = new ListViewItem.ListViewSubItem(listItems,
                    //    current.Data.Destination[0]);
                    //listItems.SubItems.Add(subItem1);
                    Lists.Items.Add(listItem);
                    current.Data.ListItem = listItem;
                    current = current.Next;
                }
                MoniteeList.AddedExtra = false;
            }
        }


        /// <summary>
        /// Checks the uniqueness of any added entry. Makes sure
        /// user does not duplicate stuff.
        /// </summary>
        /// <returns>true if item is not in list; false if item is in list.</returns>
        private bool CheckUniqueness()
        {
            System.String matcher =
                    (DelimitPath(this.FolderSelectorBox.Text));
            System.Boolean add = true;

            if (matcher.Equals(DelimitPath(this.DestinationBox.Text)))
            {
                Exceptions.Exception("srcisdest");
                return false;
            }
            for (int i = 0; i < this.Lists.Items.Count; i++)
            {
                if (matcher.Equals(DelimitPath(this.Lists.Items[i].Text)))
                {
                    if (this.CheckDuplicate(this.Lists.Items[i].Text))
                    {
                        Exceptions.Exception("duplicate");
                        return false;
                    }
                }
            }
            return add;
        }

        /// <summary>
        /// Checks all the destination folders of the monitee to ensure new instance is not a duplicate.
        /// </summary>
        /// <param name="path">destination folder of the monitee</param>
        /// <returns>true if "path" is a duplicate; false if not a duplicate</returns>
        private bool CheckDuplicate(string path)
        {
            Monitees.MoniteeListEntry current = MoniteeList.Head;
            while (current != null)
            {
                if (current.Data.Name == path)
                {
                    for (int i = 0; i < current.Data.Index; i++)
                    {
                        if (DelimitPath(current.Data.Destinations[i]).Equals(
                            DelimitPath(((this.DestinationBox.Text == "") ? _DefaultFolder : this.DestinationBox.Text))))
                        {
                            return true;
                        }
                    }
                }
                current = current.Next;
            }
            
            return false;
        }

        private string CheckForCyclicDependency()
        {
            var current = MoniteeList.Head;
            var cyclicList = new StringBuilder();

            //case1: adding a destination folder which is already a monitee.
            System.String matcher =
                    (DelimitPath(this.DestinationBox.Text));
            while( current != null)
            {
                if( DelimitPath(current.Data.Name).Equals(matcher) )
                {
                    cyclicList.Append(this.FolderSelectorBox.Text+" => ");
                    cyclicList.Append(this.DestinationBox.Text + " => ");
                    cyclicList.Append(current.Data.Destinations[0] + " => ");
                    cyclicList.Append(current.Data.Name);
                }
            }
            return cyclicList.ToString();
        }

        /// <summary>
        /// Removes all the irrelevant stuff from path for comparison.
        /// </summary>
        /// <param name="path">fullname of path to be delimited.</param>
        /// <returns>the delimited full name</returns>
        internal static String DelimitPath(String path)
        {
            char[] delims = new char[] { '"', '\\', '.' };

            string[] delimName = path.Split(delims);
            string name = String.Empty;
            foreach (string s in delimName)
            {
                name += s;
            }
            Console.WriteLine(name);
            return name.ToLower();
        }

        /// <summary>
        /// works at adding a new entry into the monitee list and storages.
        /// </summary>
        public void AddMonitoredItem()
        {
            //duplicate should not be added in listview.
            string[] items = new string[]{FolderSelectorBox.Text,
                                          ((DestinationBox.Text != "") ? DestinationBox.Text:_DefaultFolder)};

            ListViewItem listItems = new ListViewItem(items[0]);
            ListViewItem.ListViewSubItem subItem1;

            listItems.Checked = true;
            subItem1 = new ListViewItem.ListViewSubItem(listItems,
                items[1]);

            //listItems.SubItems.Add(subItem1);
            
            xmlData = new XMLData( items[0], items[1], XMLDataList.Type(items[0]) );
            monitee = new FolderMonitor.Monitees.Monitee(items[0], items[1], XMLDataList.Type(items[0]));
            if (XMLDataList.InsertFile(xmlData) && MoniteeList.InsertMonitee(monitee) )
            {
                if (!Monitees.MoniteeList.AddedExtra) 
                { 
                    Lists.Items.Add(listItems);
                    Monitees.MoniteeList.AddedExtra = false;
                }

                MessageBox.Show("Folder successfully added", "Success");
                HasChanged = true;
            }
            this.FolderSelectorBox.Text = "";
            this.DestinationBox.Text = "";
        }

        /// <summary>
        /// loops through monitees and removes selected monitees from listview and storage.
        /// </summary>
        private void RemoveListItem()
        {
            try
            {
                int increment = 0;

                if ((Lists.Items.Count > 0) && (Lists.SelectedIndices.Count > 0))
                {
                    ListViewItem[] selectedItems = new ListViewItem[this.Lists.SelectedIndices.Count];

                    if ((MessageBox.Show(
                        "Are you sure you want to remove this entry?\nIt cannot be reversed.",
                        "Warning!",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes))
                    {

                        System.Collections.IEnumerator iEnum = Lists.SelectedIndices.GetEnumerator();
                        
                        while (iEnum.MoveNext())
                        {
                            selectedItems[increment] = Lists.Items[(Int32.Parse(iEnum.Current.ToString()))];
                            increment += 1;
                            XMLDataList.RemoveFile(Lists.Items[(Int32.Parse(iEnum.Current.ToString()))].Text);
                        }
                        foreach (ListViewItem list in selectedItems)
                        {
                            Lists.Items.Remove(list);
                            MoniteeList.RemoveMonitee(list.Text);
                        }
                        if (Lists.Items.Count == 0) { Lists.Items.Clear(); }
                        HasChanged = true;
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

        /// <summary>
        /// adds extra slash to full pathnames to make stuff easier.
        /// </summary>
        /// <param name="path">path to be editted.</param>
        /// <returns>the editted full pathname</returns>
        private static string AddExtraSlash(IEnumerable<char> path)
        {
            string result = "";
            foreach (char c in path)
            {
                if (c == '\\') { result += "\\\\"; }
                else { result += c; }
            }
            return result;
        }

        /// <summary>
        /// Clear the listview.
        /// </summary>
        internal void Clear()
        {
            this.Lists.Items.Clear();
        }
    }
}
