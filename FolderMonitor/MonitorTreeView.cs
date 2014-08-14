using System;
using System.Windows.Forms;

namespace FolderMonitor
{
    internal partial class MonitorTreeView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tView = new System.Windows.Forms.TreeView();
            this.removeBtn = new System.Windows.Forms.Button();
            this.tempBtn = new System.Windows.Forms.Button();
            this.showDestBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.addDestBtn = new System.Windows.Forms.Button();
            this.expandAllBtn = new System.Windows.Forms.Button();
            this.treeViewTabLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonstableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.treeViewBoxLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.treeViewTabLayoutPanel.SuspendLayout();
            this.ButtonstableLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.treeViewBoxLayoutPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tView
            // 
            this.tView.BackColor = System.Drawing.Color.Gainsboro;
            this.tView.CheckBoxes = true;
            this.tView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tView.HideSelection = false;
            this.tView.LineColor = System.Drawing.Color.Empty;
            this.tView.Location = new System.Drawing.Point(0, 0);
            this.tView.Name = "tView";
            this.tView.Size = new System.Drawing.Size(624, 598);
            this.tView.TabIndex = 0;
            this.tView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tView_AfterCheck);
            this.tView.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.tView_AfterCollapse);
            this.tView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tView_AfterSelect);
            this.tView.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.tView_AfterExpand);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(43, 22);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(115, 35);
            this.removeBtn.TabIndex = 1;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // tempBtn
            // 
            this.tempBtn.Location = new System.Drawing.Point(652, 114);
            this.tempBtn.Name = "tempBtn";
            this.tempBtn.Size = new System.Drawing.Size(173, 43);
            this.tempBtn.TabIndex = 2;
            this.tempBtn.Text = "Stop Monitoring";
            this.tempBtn.UseVisualStyleBackColor = true;
            // 
            // showDestBtn
            // 
            this.showDestBtn.Location = new System.Drawing.Point(43, 63);
            this.showDestBtn.Name = "showDestBtn";
            this.showDestBtn.Size = new System.Drawing.Size(115, 42);
            this.showDestBtn.TabIndex = 3;
            this.showDestBtn.Text = "Show Destinations";
            this.showDestBtn.UseVisualStyleBackColor = true;
            this.showDestBtn.Click += new System.EventHandler(this.showDestBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(43, 27);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(115, 36);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Add Monitee";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // addDestBtn
            // 
            this.addDestBtn.Location = new System.Drawing.Point(43, 56);
            this.addDestBtn.Name = "addDestBtn";
            this.addDestBtn.Size = new System.Drawing.Size(115, 35);
            this.addDestBtn.TabIndex = 5;
            this.addDestBtn.Text = "Add Destination";
            this.addDestBtn.UseVisualStyleBackColor = true;
            // 
            // expandAllBtn
            // 
            this.expandAllBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expandAllBtn.Location = new System.Drawing.Point(0, 0);
            this.expandAllBtn.Name = "expandAllBtn";
            this.expandAllBtn.Size = new System.Drawing.Size(34, 27);
            this.expandAllBtn.TabIndex = 6;
            this.expandAllBtn.UseVisualStyleBackColor = true;
            this.expandAllBtn.Click += new System.EventHandler(this.expandAllBtn_Click);
            // 
            // treeViewTabLayoutPanel
            // 
            this.treeViewTabLayoutPanel.ColumnCount = 2;
            this.treeViewTabLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.13873F));
            this.treeViewTabLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.86127F));
            this.treeViewTabLayoutPanel.Controls.Add(this.ButtonstableLayoutPanel, 1, 0);
            this.treeViewTabLayoutPanel.Controls.Add(this.treeViewBoxLayoutPanel, 0, 0);
            this.treeViewTabLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewTabLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.treeViewTabLayoutPanel.Name = "treeViewTabLayoutPanel";
            this.treeViewTabLayoutPanel.RowCount = 1;
            this.treeViewTabLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.treeViewTabLayoutPanel.Size = new System.Drawing.Size(901, 610);
            this.treeViewTabLayoutPanel.TabIndex = 0;
            // 
            // ButtonstableLayoutPanel
            // 
            this.ButtonstableLayoutPanel.ColumnCount = 1;
            this.ButtonstableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonstableLayoutPanel.Controls.Add(this.panel1, 0, 0);
            this.ButtonstableLayoutPanel.Controls.Add(this.panel2, 0, 1);
            this.ButtonstableLayoutPanel.Controls.Add(this.panel3, 0, 2);
            this.ButtonstableLayoutPanel.Controls.Add(this.panel4, 0, 3);
            this.ButtonstableLayoutPanel.Controls.Add(this.panel5, 0, 4);
            this.ButtonstableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonstableLayoutPanel.Location = new System.Drawing.Point(679, 3);
            this.ButtonstableLayoutPanel.Name = "ButtonstableLayoutPanel";
            this.ButtonstableLayoutPanel.RowCount = 5;
            this.ButtonstableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.74468F));
            this.ButtonstableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.25532F));
            this.ButtonstableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.ButtonstableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.ButtonstableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.ButtonstableLayoutPanel.Size = new System.Drawing.Size(219, 604);
            this.ButtonstableLayoutPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.showDestBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 128);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.addBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 101);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.addDestBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 244);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(213, 143);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.removeBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 393);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(213, 83);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 482);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(213, 119);
            this.panel5.TabIndex = 4;
            // 
            // treeViewBoxLayoutPanel
            // 
            this.treeViewBoxLayoutPanel.ColumnCount = 2;
            this.treeViewBoxLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.02985F));
            this.treeViewBoxLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.970149F));
            this.treeViewBoxLayoutPanel.Controls.Add(this.panel6, 0, 0);
            this.treeViewBoxLayoutPanel.Controls.Add(this.panel7, 1, 0);
            this.treeViewBoxLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewBoxLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.treeViewBoxLayoutPanel.Name = "treeViewBoxLayoutPanel";
            this.treeViewBoxLayoutPanel.RowCount = 2;
            this.treeViewBoxLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.629139F));
            this.treeViewBoxLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.37086F));
            this.treeViewBoxLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.treeViewBoxLayoutPanel.Size = new System.Drawing.Size(670, 604);
            this.treeViewBoxLayoutPanel.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tView);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.treeViewBoxLayoutPanel.SetRowSpan(this.panel6, 2);
            this.panel6.Size = new System.Drawing.Size(624, 598);
            this.panel6.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.expandAllBtn);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(633, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(34, 27);
            this.panel7.TabIndex = 0;
            // 
            // MonitorTreeView
            // 
            this.Controls.Add(this.treeViewTabLayoutPanel);
            this.Size = new System.Drawing.Size(901, 610);
            this.Text = "Tree View";
            this.treeViewTabLayoutPanel.ResumeLayout(false);
            this.ButtonstableLayoutPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.treeViewBoxLayoutPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        void removeBtn_Click(object sender, System.EventArgs e)
        {
            if(this.tView.SelectedNode != null )
            {
                if (MessageBox.Show(
                    "Are you sure?", "Confirmation",
                        MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.tView.SelectedNode.Remove();
                    HasChanged = true;
                }
            }
            else
            {
                MessageBox.Show("Select an item first", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void expandAllBtn_Click(object sender, System.EventArgs e)
        {
            if (MonitorTreeView.expanded)
            { 
                this.tView.CollapseAll();
                //expandAllToolStripMenuItem.Text = "Expand All";
                MonitorTreeView.expanded = false;
                this.showDestBtn.Text = //this.showDestinationsToolStripMenuItem.Text =
                    "Show Destinations";
            }
            else
            { 
                this.tView.ExpandAll();
                //this.expandAllToolStripMenuItem.Text = "Collapse All";
                expanded = true;
                this.showDestBtn.Text = //this.showDestinationsToolStripMenuItem.Text =
                    "Hide Destinations";
            }
        }

        void tView_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            if (this.tView.SelectedNode == null)
                goto done;
            bool isLeaf = (this.tView.SelectedNode.Nodes.Count == 0);
            this.showDestBtn.Text = //this.showDestinationsToolStripMenuItem.Text = 
                (!this.tView.SelectedNode.IsExpanded || isLeaf) ?
                    "Show Destinations" : "Hide Destinations";
        done: ;
        }

        void tView_AfterExpand(object sender, TreeViewEventArgs e)
        {
            if (this.tView.SelectedNode == null)
                goto done;
            bool isLeaf = (this.tView.SelectedNode.Nodes.Count == 0);
            this.showDestBtn.Text = //this.showDestinationsToolStripMenuItem.Text =
                (!this.tView.SelectedNode.IsExpanded || isLeaf) ?
                    "Show Destinations" : "Hide Destinations";
        done: ;
        }

        void tView_AfterCheck(object sender, System.Windows.Forms.TreeViewEventArgs e)
        {
            this.tView.SelectedNode = e.Node;
            this.tempBtn.Text = (this.tView.SelectedNode.Checked) ?
                "Temporarily Stop Monitoring" : "Start Monitoring";
            
        }

        void tempBtn_Click(object sender, System.EventArgs e)
        {
            if (tView.SelectedNode.Checked)
            {
                tView.SelectedNode.Checked = false;
                this.tempBtn.Text = //this.stopMonitoringToolStripMenuItem.Text = 
                    "Start Monitoring";
            }
            else
            {
                tView.SelectedNode.Checked = true;
                this.tempBtn.Text = //this.stopMonitoringToolStripMenuItem.Text = 
                    "Stop Monitoring";
            }
        }

        void tView_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
        {
            bool isLeaf = (this.tView.SelectedNode.Nodes.Count == 0);
            if (isLeaf)
            {
                this.showDestBtn.Enabled = false;
                this.addDestBtn.Enabled = false;
                //this.showDestinationsToolStripMenuItem.Enabled = false;
                //this.addDestinationToolStripMenuItem.Enabled = false;
            }
            else
            {
                this.showDestBtn.Enabled = true;
                this.addDestBtn.Enabled = true;
                //this.showDestinationsToolStripMenuItem.Enabled = true;
                //this.addDestinationToolStripMenuItem.Enabled = true;
            }
            this.tempBtn.Text = //this.stopMonitoringToolStripMenuItem.Text =
                (this.tView.SelectedNode.Checked) ?
                    "Stop Monitoring" : "Start Monitoring";

            this.showDestBtn.Text = //this.showDestinationsToolStripMenuItem.Text = 
                (!this.tView.SelectedNode.IsExpanded || isLeaf) ?
                    "Show Destinations" : "Hide Destinations";
        }
        
        void showDestBtn_Click(object sender, System.EventArgs e)
        {
            if (this.tView.SelectedNode == null)
            {
                this.expandAllBtn_Click(sender, e);
            }
            else if (this.tView.SelectedNode.IsExpanded)
            {
                this.tView.SelectedNode.Collapse();
                this.showDestBtn.Text = //this.showDestinationsToolStripMenuItem.Text = 
                    "Show Destinations";

            }
            else
            {
                this.tView.SelectedNode.Expand();
                this.showDestBtn.Text = //this.showDestinationsToolStripMenuItem.Text = 
                    "Hide Destinations";
            }
        }

        #endregion

        internal TreeView tView;
        internal Button removeBtn;
        internal Button tempBtn;
        internal Button showDestBtn;
        internal Button addBtn;
        internal Button addDestBtn;
        internal Button expandAllBtn;
        private TableLayoutPanel treeViewTabLayoutPanel;
        private TableLayoutPanel ButtonstableLayoutPanel;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private TableLayoutPanel treeViewBoxLayoutPanel;
        private Panel panel7;
        private Panel panel6;
        
    }
}

