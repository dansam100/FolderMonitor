/*
 * Created by SharpDevelop.
 * User: samuel
 * Date: 30/09/2007
 * Time: 10:24 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System.Windows.Forms;

namespace FolderMonitor
{
    internal partial class MonitorListView
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        
        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            this.FolderSelectorBox = new System.Windows.Forms.TextBox();
            this.StartMonitorProc = new System.Windows.Forms.Button();
            this.RemoveFolderBtn = new System.Windows.Forms.Button();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.AddFolderBtn = new System.Windows.Forms.Button();
            this.SelectLabel = new System.Windows.Forms.Label();
            this.ListLabel = new System.Windows.Forms.Label();
            this.BtnLabel = new System.Windows.Forms.Label();
            this.DestinationBox = new System.Windows.Forms.TextBox();
            this.DestinationLabel = new System.Windows.Forms.Label();
            this.Dest_BrowseBtn = new System.Windows.Forms.Button();
            this.BrwseFileBtn = new System.Windows.Forms.Button();
            this.folderLabel = new System.Windows.Forms.Label();
            this.fileLabel = new System.Windows.Forms.Label();
            this.Lists = new System.Windows.Forms.ListView();
            this.MoniteeColumn = new System.Windows.Forms.ColumnHeader();
            this.Status = new System.Windows.Forms.ColumnHeader();
            this.tLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.BrowseDest = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonTlayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.viewDesttableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.destinationViewBtn = new System.Windows.Forms.Button();
            this.removeBtntableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.addBtntableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tLayoutPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.buttonTlayoutPanel.SuspendLayout();
            this.viewDesttableLayoutPanel.SuspendLayout();
            this.removeBtntableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel12.SuspendLayout();
            this.addBtntableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // FolderSelectorBox
            // 
            this.FolderSelectorBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FolderSelectorBox.Location = new System.Drawing.Point(3, 22);
            this.FolderSelectorBox.Name = "FolderSelectorBox";
            this.FolderSelectorBox.Size = new System.Drawing.Size(474, 20);
            this.FolderSelectorBox.TabIndex = 0;
            // 
            // StartMonitorProc
            // 
            this.StartMonitorProc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartMonitorProc.Location = new System.Drawing.Point(35, 50);
            this.StartMonitorProc.Name = "StartMonitorProc";
            this.StartMonitorProc.Size = new System.Drawing.Size(110, 62);
            this.StartMonitorProc.TabIndex = 3;
            this.StartMonitorProc.Text = "Initiate";
            this.StartMonitorProc.Click += new System.EventHandler(this.StartMonitorProc_Click);
            // 
            // RemoveFolderBtn
            // 
            this.RemoveFolderBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveFolderBtn.Location = new System.Drawing.Point(36, 40);
            this.RemoveFolderBtn.Name = "RemoveFolderBtn";
            this.RemoveFolderBtn.Size = new System.Drawing.Size(110, 30);
            this.RemoveFolderBtn.TabIndex = 4;
            this.RemoveFolderBtn.Text = "Remove..";
            this.RemoveFolderBtn.Click += new System.EventHandler(this.RemoveFolderBtn_Click);
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BrowseBtn.Location = new System.Drawing.Point(3, 3);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(25, 19);
            this.BrowseBtn.TabIndex = 5;
            this.BrowseBtn.Text = ">";
            this.BrowseBtn.Click += new System.EventHandler(this.On_BrowseClick);
            // 
            // AddFolderBtn
            // 
            this.AddFolderBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddFolderBtn.Location = new System.Drawing.Point(43, 11);
            this.AddFolderBtn.Name = "AddFolderBtn";
            this.AddFolderBtn.Size = new System.Drawing.Size(107, 30);
            this.AddFolderBtn.TabIndex = 6;
            this.AddFolderBtn.Text = "Add Monitee";
            this.AddFolderBtn.Click += new System.EventHandler(this.AddFolderBtn_Click);
            // 
            // SelectLabel
            // 
            this.SelectLabel.Location = new System.Drawing.Point(3, 0);
            this.SelectLabel.Name = "SelectLabel";
            this.SelectLabel.Size = new System.Drawing.Size(133, 19);
            this.SelectLabel.TabIndex = 7;
            this.SelectLabel.Text = "Select Folder to monitor..";
            // 
            // ListLabel
            // 
            this.ListLabel.Location = new System.Drawing.Point(0, 3);
            this.ListLabel.Name = "ListLabel";
            this.ListLabel.Size = new System.Drawing.Size(139, 17);
            this.ListLabel.TabIndex = 9;
            this.ListLabel.Text = "Folders being Monitored..";
            // 
            // BtnLabel
            // 
            this.BtnLabel.Location = new System.Drawing.Point(15, 0);
            this.BtnLabel.Name = "BtnLabel";
            this.BtnLabel.Size = new System.Drawing.Size(70, 30);
            this.BtnLabel.TabIndex = 10;
            this.BtnLabel.Text = "Click to start monitoring:";
            // 
            // DestinationBox
            // 
            this.DestinationBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DestinationBox.Location = new System.Drawing.Point(3, 31);
            this.DestinationBox.Name = "DestinationBox";
            this.DestinationBox.Size = new System.Drawing.Size(474, 20);
            this.DestinationBox.TabIndex = 11;
            // 
            // DestinationLabel
            // 
            this.DestinationLabel.Location = new System.Drawing.Point(6, 4);
            this.DestinationLabel.Name = "DestinationLabel";
            this.DestinationLabel.Size = new System.Drawing.Size(70, 18);
            this.DestinationLabel.TabIndex = 12;
            this.DestinationLabel.Text = "Destination";
            // 
            // Dest_BrowseBtn
            // 
            this.Dest_BrowseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Dest_BrowseBtn.Location = new System.Drawing.Point(3, 30);
            this.Dest_BrowseBtn.Name = "Dest_BrowseBtn";
            this.Dest_BrowseBtn.Size = new System.Drawing.Size(25, 20);
            this.Dest_BrowseBtn.TabIndex = 13;
            this.Dest_BrowseBtn.Text = ">";
            this.Dest_BrowseBtn.UseVisualStyleBackColor = true;
            this.Dest_BrowseBtn.Click += new System.EventHandler(this.Dest_BrowseBtn_Click);
            // 
            // BrwseFileBtn
            // 
            this.BrwseFileBtn.Location = new System.Drawing.Point(3, 24);
            this.BrwseFileBtn.Name = "BrwseFileBtn";
            this.BrwseFileBtn.Size = new System.Drawing.Size(25, 19);
            this.BrwseFileBtn.TabIndex = 14;
            this.BrwseFileBtn.Text = ">";
            this.BrwseFileBtn.UseVisualStyleBackColor = true;
            this.BrwseFileBtn.Click += new System.EventHandler(this.BrwseFileBtn_Click);
            // 
            // folderLabel
            // 
            this.folderLabel.AutoSize = true;
            this.folderLabel.Location = new System.Drawing.Point(33, 7);
            this.folderLabel.Name = "folderLabel";
            this.folderLabel.Size = new System.Drawing.Size(85, 13);
            this.folderLabel.TabIndex = 15;
            this.folderLabel.Text = "Browse Folders..";
            // 
            // fileLabel
            // 
            this.fileLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fileLabel.AutoSize = true;
            this.fileLabel.Location = new System.Drawing.Point(33, 26);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(72, 13);
            this.fileLabel.TabIndex = 16;
            this.fileLabel.Text = "Browse Files..";
            // 
            // Lists
            // 
            this.Lists.CheckBoxes = true;
            this.Lists.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MoniteeColumn,
            this.Status});
            this.Lists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lists.GridLines = true;
            this.Lists.Location = new System.Drawing.Point(3, 26);
            this.Lists.Name = "Lists";
            this.Lists.Size = new System.Drawing.Size(633, 344);
            this.Lists.TabIndex = 17;
            this.Lists.UseCompatibleStateImageBehavior = false;
            this.Lists.View = System.Windows.Forms.View.Details;
            this.Lists.DoubleClick += new System.EventHandler(this.Lists_DoubleClick);
            // 
            // MoniteeColumn
            // 
            this.MoniteeColumn.Text = "Monitee";
            this.MoniteeColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MoniteeColumn.Width = 342;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Status.Width = 85;
            // 
            // tLayoutPanel
            // 
            this.tLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tLayoutPanel.ColumnCount = 3;
            this.tLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.30488F));
            this.tLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.69512F));
            this.tLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tLayoutPanel.Controls.Add(this.panel3, 1, 0);
            this.tLayoutPanel.Controls.Add(this.panel8, 1, 1);
            this.tLayoutPanel.Controls.Add(this.panel6, 2, 2);
            this.tLayoutPanel.Controls.Add(this.addBtntableLayoutPanel, 2, 1);
            this.tLayoutPanel.Controls.Add(this.panel7, 2, 0);
            this.tLayoutPanel.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tLayoutPanel.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tLayoutPanel.Controls.Add(this.tableLayoutPanel7, 0, 2);
            this.tLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tLayoutPanel.Name = "tLayoutPanel";
            this.tLayoutPanel.RowCount = 1;
            this.tLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 241F));
            this.tLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tLayoutPanel.Size = new System.Drawing.Size(833, 490);
            this.tLayoutPanel.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.fileLabel);
            this.panel3.Controls.Add(this.BrwseFileBtn);
            this.panel3.Controls.Add(this.folderLabel);
            this.panel3.Controls.Add(this.BrowseBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(489, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(153, 46);
            this.panel3.TabIndex = 21;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.Dest_BrowseBtn);
            this.panel8.Controls.Add(this.BrowseDest);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(489, 55);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(153, 53);
            this.panel8.TabIndex = 27;
            // 
            // BrowseDest
            // 
            this.BrowseDest.AutoSize = true;
            this.BrowseDest.Location = new System.Drawing.Point(33, 34);
            this.BrowseDest.Name = "BrowseDest";
            this.BrowseDest.Size = new System.Drawing.Size(85, 13);
            this.BrowseDest.TabIndex = 26;
            this.BrowseDest.Text = "Browse Folders..";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(648, 114);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(182, 373);
            this.panel6.TabIndex = 24;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.buttonTlayoutPanel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(182, 373);
            this.panel5.TabIndex = 23;
            // 
            // buttonTlayoutPanel
            // 
            this.buttonTlayoutPanel.ColumnCount = 1;
            this.buttonTlayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonTlayoutPanel.Controls.Add(this.viewDesttableLayoutPanel, 0, 0);
            this.buttonTlayoutPanel.Controls.Add(this.removeBtntableLayoutPanel, 0, 1);
            this.buttonTlayoutPanel.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.buttonTlayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTlayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonTlayoutPanel.Name = "buttonTlayoutPanel";
            this.buttonTlayoutPanel.RowCount = 3;
            this.buttonTlayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.buttonTlayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.buttonTlayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.buttonTlayoutPanel.Size = new System.Drawing.Size(182, 373);
            this.buttonTlayoutPanel.TabIndex = 0;
            // 
            // viewDesttableLayoutPanel
            // 
            this.viewDesttableLayoutPanel.ColumnCount = 3;
            this.viewDesttableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.81879F));
            this.viewDesttableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.18121F));
            this.viewDesttableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.viewDesttableLayoutPanel.Controls.Add(this.destinationViewBtn, 1, 1);
            this.viewDesttableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewDesttableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.viewDesttableLayoutPanel.Name = "viewDesttableLayoutPanel";
            this.viewDesttableLayoutPanel.RowCount = 3;
            this.viewDesttableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.32927F));
            this.viewDesttableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.67073F));
            this.viewDesttableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.viewDesttableLayoutPanel.Size = new System.Drawing.Size(176, 69);
            this.viewDesttableLayoutPanel.TabIndex = 0;
            // 
            // destinationViewBtn
            // 
            this.destinationViewBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.destinationViewBtn.Location = new System.Drawing.Point(37, 15);
            this.destinationViewBtn.Name = "destinationViewBtn";
            this.destinationViewBtn.Size = new System.Drawing.Size(109, 31);
            this.destinationViewBtn.TabIndex = 24;
            this.destinationViewBtn.Text = "View Destinations";
            this.destinationViewBtn.UseVisualStyleBackColor = true;
            this.destinationViewBtn.Click += new System.EventHandler(this.destinationViewBtn_Click);
            // 
            // removeBtntableLayoutPanel
            // 
            this.removeBtntableLayoutPanel.ColumnCount = 3;
            this.removeBtntableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.removeBtntableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.77778F));
            this.removeBtntableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.removeBtntableLayoutPanel.Controls.Add(this.RemoveFolderBtn, 1, 1);
            this.removeBtntableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeBtntableLayoutPanel.Location = new System.Drawing.Point(3, 78);
            this.removeBtntableLayoutPanel.Name = "removeBtntableLayoutPanel";
            this.removeBtntableLayoutPanel.RowCount = 3;
            this.removeBtntableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.81967F));
            this.removeBtntableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.18033F));
            this.removeBtntableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.removeBtntableLayoutPanel.Size = new System.Drawing.Size(176, 119);
            this.removeBtntableLayoutPanel.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel4.Controls.Add(this.StartMonitorProc, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.panel12, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 203);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.86956F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.13044F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(176, 167);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.BtnLabel);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(35, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(110, 41);
            this.panel12.TabIndex = 29;
            // 
            // addBtntableLayoutPanel
            // 
            this.addBtntableLayoutPanel.ColumnCount = 3;
            this.addBtntableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.05634F));
            this.addBtntableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.94366F));
            this.addBtntableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.addBtntableLayoutPanel.Controls.Add(this.AddFolderBtn, 1, 1);
            this.addBtntableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addBtntableLayoutPanel.Location = new System.Drawing.Point(648, 55);
            this.addBtntableLayoutPanel.Name = "addBtntableLayoutPanel";
            this.addBtntableLayoutPanel.RowCount = 3;
            this.addBtntableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.addBtntableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.81818F));
            this.addBtntableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.addBtntableLayoutPanel.Size = new System.Drawing.Size(182, 53);
            this.addBtntableLayoutPanel.TabIndex = 30;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(648, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(182, 46);
            this.panel7.TabIndex = 31;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.FolderSelectorBox, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.SelectLabel, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.30435F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.69565F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(480, 46);
            this.tableLayoutPanel5.TabIndex = 32;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.DestinationBox, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 55);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.83019F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.16981F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(480, 53);
            this.tableLayoutPanel6.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DestinationLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 22);
            this.panel2.TabIndex = 12;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tLayoutPanel.SetColumnSpan(this.tableLayoutPanel7, 2);
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.Lists, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 114);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.388206F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.61179F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(639, 373);
            this.tableLayoutPanel7.TabIndex = 34;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ListLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(633, 17);
            this.panel4.TabIndex = 22;
            // 
            // MonitorListView
            // 
            this.ClientSize = new System.Drawing.Size(833, 490);
            this.Controls.Add(this.tLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(563, 450);
            this.Name = "MonitorListView";
            this.Text = "List View";
            this.tLayoutPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.buttonTlayoutPanel.ResumeLayout(false);
            this.viewDesttableLayoutPanel.ResumeLayout(false);
            this.removeBtntableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.addBtntableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TextBox FolderSelectorBox;
        private System.Windows.Forms.TextBox DestinationBox;
        private System.Windows.Forms.Button  StartMonitorProc;
        private System.Windows.Forms.Button  RemoveFolderBtn;
        private System.Windows.Forms.Button  BrowseBtn;
        private System.Windows.Forms.Button  AddFolderBtn;
        private System.Windows.Forms.Button Dest_BrowseBtn;
        private System.Windows.Forms.Label SelectLabel;
        private System.Windows.Forms.Label   ListLabel;
        private System.Windows.Forms.Label   BtnLabel;
        private System.Windows.Forms.Label DestinationLabel;
        private System.Windows.Forms.Button BrwseFileBtn;
        private System.Windows.Forms.Label folderLabel;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.ListView Lists;
        private System.Windows.Forms.ColumnHeader MoniteeColumn;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.TableLayoutPanel tLayoutPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label BrowseDest;
        private System.Windows.Forms.Button destinationViewBtn;
        private TableLayoutPanel buttonTlayoutPanel;
        private Panel panel12;
        private TableLayoutPanel viewDesttableLayoutPanel;
        private TableLayoutPanel addBtntableLayoutPanel;
        private TableLayoutPanel removeBtntableLayoutPanel;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel7;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel7;
        
    }
}
