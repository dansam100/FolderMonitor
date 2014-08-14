using System.Windows.Forms;

namespace FolderMonitor
{
    partial class TabControl
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
            this.components = new System.ComponentModel.Container();
            this.listViewPage = new MonitorListView();
            this.treeViewPage = new MonitorTreeView();
            this.Text = "TabControl";
            
            // 
            // listViewPage
            // 
            this.listViewPage.Location = new System.Drawing.Point(4, 22);
            this.listViewPage.MinimumSize = new System.Drawing.Size(555, 419);
            this.listViewPage.Padding = new System.Windows.Forms.Padding(3);
            this.listViewPage.Size = new System.Drawing.Size(889, 563);
            this.listViewPage.TabIndex = 0;
            this.listViewPage.Text = "List View";
            this.listViewPage.Name = "listview";
            this.listViewPage.Dock = DockStyle.Fill;
            this.listViewPage.Anchor = AnchorStyles.Top;
            this.listViewPage.UseVisualStyleBackColor = true;
            // 
            // treeViewPage
            // 
            this.treeViewPage.Location = new System.Drawing.Point(4, 22);
            this.treeViewPage.Padding = new System.Windows.Forms.Padding(3);
            this.treeViewPage.Size = new System.Drawing.Size(889, 563);
            this.treeViewPage.TabIndex = 1;
            this.treeViewPage.Dock = DockStyle.Fill;
            this.treeViewPage.Anchor = AnchorStyles.Top;
            this.treeViewPage.Text = "Tree View";
            this.treeViewPage.Name = "treeview";
            this.treeViewPage.UseVisualStyleBackColor = true;

            this.Controls.Add(this.listViewPage);
            this.Controls.Add(this.treeViewPage);
        }

        #endregion

        private MonitorTreeView treeViewPage;
        private MonitorListView listViewPage;
    }
}