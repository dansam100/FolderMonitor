using System.Reflection;
using System.Windows.Forms;
using FolderMonitor.Monitees;

namespace FolderMonitor
{
    internal partial class MonitorTreeView : TabPage
    {
        internal static bool expanded = false;
        public static bool HasChanged = false;
        
        public MonitorTreeView()
        {
            InitializeComponent();
        }

        private delegate void GenerateTreeDelegate();
        internal void Generate()
        {
            this.Invoke(new GenerateTreeDelegate(PopulateTree));
        }

        internal void PopulateTree()
        {
            Monitees.MoniteeListEntry current = MoniteeList.Head;
            System.Console.WriteLine("Beginning tree generation...");
            while (current != null)
            {
                TreeNode moniteeNode = new TreeNode(current.Data.Name);
                moniteeNode.Checked = true;
                System.Console.WriteLine("Adding {0} to the tree",current.Data.Name);
                foreach(string destination in current.Data.Destinations)
                {
                    TreeNode destNodes = new TreeNode(destination);
                    destNodes.Checked = true;
                    moniteeNode.Nodes.Add(destNodes);
                }
                moniteeNode.ToolTipText = "Click the '+' icon or double-click to expand.";
                this.tView.Nodes.Add(moniteeNode);
                current.Data.TreeNode = moniteeNode; 
                current = current.Next;
            }
        }

        internal void Clear()
        {
            this.tView.Nodes.Clear();
        }

        internal void CollapseTree()
        {
            this.tView.CollapseAll();
        }

        internal void ExpandTree()
        {
            this.tView.ExpandAll();
        }
    }
}
