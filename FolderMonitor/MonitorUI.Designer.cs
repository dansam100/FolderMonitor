using System;
using System.Configuration;
using System.Windows.Forms;
using FolderMonitor.FileGymnastics;

namespace FolderMonitor
{
    partial class MonitorUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonitorUI));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMoniteeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeMoniteeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopMonitoringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDestinationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.switchViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeDefaultViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutDocuMONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.DocuMon = new System.Windows.Forms.ContextMenu();
            this.RestoreProg = new System.Windows.Forms.MenuItem();
            this.minimizeProg = new System.Windows.Forms.MenuItem();
            this.helpProg = new System.Windows.Forms.MenuItem();
            this.aboutProg = new System.Windows.Forms.MenuItem();
            this.dash = new System.Windows.Forms.MenuItem();
            this.closeProg = new System.Windows.Forms.MenuItem();
            this.FormtableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl = new FolderMonitor.TabControl();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.FormtableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(911, 24);
            this.menuStrip.TabIndex = 8;
            this.menuStrip.Text = "Menu Strip";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMoniteeToolStripMenuItem,
            this.removeMoniteeToolStripMenuItem,
            this.stopMonitoringToolStripMenuItem,
            this.addDestinationToolStripMenuItem,
            this.mainStripSeparator,
            this.exitToolStripMenuItem});
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.mainToolStripMenuItem.Text = "Main";
            // 
            // addMoniteeToolStripMenuItem
            // 
            this.addMoniteeToolStripMenuItem.Name = "addMoniteeToolStripMenuItem";
            this.addMoniteeToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.addMoniteeToolStripMenuItem.Text = "Add Monitee";
            // 
            // removeMoniteeToolStripMenuItem
            // 
            this.removeMoniteeToolStripMenuItem.Name = "removeMoniteeToolStripMenuItem";
            this.removeMoniteeToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.removeMoniteeToolStripMenuItem.Text = "Remove";
            // 
            // stopMonitoringToolStripMenuItem
            // 
            this.stopMonitoringToolStripMenuItem.Name = "stopMonitoringToolStripMenuItem";
            this.stopMonitoringToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.stopMonitoringToolStripMenuItem.Text = "Stop Monitoring";
            // 
            // addDestinationToolStripMenuItem
            // 
            this.addDestinationToolStripMenuItem.Name = "addDestinationToolStripMenuItem";
            this.addDestinationToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.addDestinationToolStripMenuItem.Text = "Add Destination";
            // 
            // mainStripSeparator
            // 
            this.mainStripSeparator.Name = "mainStripSeparator";
            this.mainStripSeparator.Size = new System.Drawing.Size(158, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expandAllToolStripMenuItem,
            this.viewToolStripSeparator,
            this.switchViewToolStripMenuItem,
            this.makeDefaultViewToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // expandAllToolStripMenuItem
            // 
            this.expandAllToolStripMenuItem.Name = "expandAllToolStripMenuItem";
            this.expandAllToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.expandAllToolStripMenuItem.Text = "Expand All";
            // 
            // viewToolStripSeparator
            // 
            this.viewToolStripSeparator.Name = "viewToolStripSeparator";
            this.viewToolStripSeparator.Size = new System.Drawing.Size(170, 6);
            // 
            // switchViewToolStripMenuItem
            // 
            this.switchViewToolStripMenuItem.Name = "switchViewToolStripMenuItem";
            this.switchViewToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.switchViewToolStripMenuItem.Text = "Switch View";
            this.switchViewToolStripMenuItem.Click += new System.EventHandler(this.switchViewToolStripMenuItem_Click);
            // 
            // makeDefaultViewToolStripMenuItem
            // 
            this.makeDefaultViewToolStripMenuItem.Name = "makeDefaultViewToolStripMenuItem";
            this.makeDefaultViewToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.makeDefaultViewToolStripMenuItem.Text = "Make Default View";
            this.makeDefaultViewToolStripMenuItem.Click += new System.EventHandler(this.makeDefaultViewToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutDocuMONToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutDocuMONToolStripMenuItem
            // 
            this.aboutDocuMONToolStripMenuItem.Name = "aboutDocuMONToolStripMenuItem";
            this.aboutDocuMONToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.aboutDocuMONToolStripMenuItem.Text = "About DocuMON";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 17);
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(69, 18);
            this.statusLabel.Text = "Monitoring...";
            // 
            // statusStrip
            // 
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar,
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 604);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(911, 23);
            this.statusStrip.TabIndex = 7;
            this.statusStrip.Text = "statusStrip";
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "App is running minimized. Right-click to activate";
            this.notifyIcon.BalloonTipTitle = "DocuMon";
            this.notifyIcon.ContextMenu = this.DocuMon;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "DocuMon";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // DocuMon
            // 
            this.DocuMon.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.RestoreProg,
            this.minimizeProg,
            this.helpProg,
            this.aboutProg,
            this.dash,
            this.closeProg});
            // 
            // RestoreProg
            // 
            this.RestoreProg.DefaultItem = true;
            this.RestoreProg.Index = 0;
            this.RestoreProg.Text = "&Restore...";
            this.RestoreProg.Click += new System.EventHandler(this.RestoreProg_Click);
            // 
            // minimizeProg
            // 
            this.minimizeProg.Index = 1;
            this.minimizeProg.Text = "&Minimize";
            this.minimizeProg.Click += new System.EventHandler(this.minimizeProg_Click);
            // 
            // helpProg
            // 
            this.helpProg.Index = 2;
            this.helpProg.Text = "&Help...";
            this.helpProg.Click += new System.EventHandler(this.helpProg_Click);
            // 
            // aboutProg
            // 
            this.aboutProg.Index = 3;
            this.aboutProg.Text = "&About...";
            this.aboutProg.Click += new System.EventHandler(this.aboutProg_Click);
            // 
            // dash
            // 
            this.dash.Index = 4;
            this.dash.Text = "-";
            // 
            // closeProg
            // 
            this.closeProg.Index = 5;
            this.closeProg.Text = "&Close...";
            this.closeProg.Click += new System.EventHandler(this.closeProg_Click);
            // 
            // FormtableLayoutPanel
            // 
            this.FormtableLayoutPanel.ColumnCount = 1;
            this.FormtableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FormtableLayoutPanel.Controls.Add(this.statusStrip, 0, 1);
            this.FormtableLayoutPanel.Controls.Add(this.tabControl, 0, 0);
            this.FormtableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormtableLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.FormtableLayoutPanel.Name = "FormtableLayoutPanel";
            this.FormtableLayoutPanel.RowCount = 1;
            this.FormtableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96.33758F));
            this.FormtableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.66242F));
            this.FormtableLayoutPanel.Size = new System.Drawing.Size(911, 627);
            this.FormtableLayoutPanel.TabIndex = 9;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(905, 598);
            this.tabControl.TabIndex = 10;
            this.tabControl.Text = "TabControl";
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // MonitorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 651);
            this.Controls.Add(this.FormtableLayoutPanel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MonitorUI";
            this.Text = "DocuMON";
            this.Load += new System.EventHandler(this.MonitorUI_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MonitorUI_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.FormtableLayoutPanel.ResumeLayout(false);
            this.FormtableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        void makeDefaultViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string defaultView = this.tabControl.SelectedTab.Name;
            try
            {
                SettingsBase setBase = FolderMonitor.Properties.Settings.Default;
                setBase["DefaultView"] = defaultView;
                setBase.Save();
            }
            catch
            {
                //do nothing.
            }
            finally
            {
                if (tabControl.SelectedTab.Name.ToLower() == defaultView)
                {
                    this.makeDefaultViewToolStripMenuItem.Enabled = false;
                }
                else
                {
                    this.makeDefaultViewToolStripMenuItem.Enabled = true;
                }
            }
        }

        void switchViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl.DeselectTab(this.tabControl.SelectedTab);
        }
        
        void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            string defaultView = string.Empty;
            try
            {
                defaultView = FolderMonitor.Properties.Settings.Default["DefaultView"].ToString();
            }
            catch
            {
                //do nothing.
            }
            finally
            {
                if (tabControl.SelectedTab.Name.ToLower() == defaultView)
                {
                    this.makeDefaultViewToolStripMenuItem.Enabled = false;
                }
                else
                {
                    this.makeDefaultViewToolStripMenuItem.Enabled = true;
                }
                if (tabControl.SelectedTab.Name == this.tabControl.TreeViewPage.Name)
                {
                    this.expandAllToolStripMenuItem.Enabled = false;
                }
                Reload();
            }
        }

        void MonitorUI_Load(object sender, EventArgs e)
        {
            string defaultView = "listview";
            string treeStatus = "collapsed";
            this.Text = this.clientName;
            try
            {
                defaultView = FolderMonitor.Properties.Settings.Default["DefaultView"].ToString();
                treeStatus = FolderMonitor.Properties.Settings.Default["TreeStatus"].ToString();
                this.LoadMonitees();
            }
            catch
            {
            }
            finally
            {
                this.tabControl.SelectTab(defaultView);
                this.makeDefaultViewToolStripMenuItem.Enabled = false;
                if (defaultView == this.tabControl.TreeViewPage.Name)
                {
                    switch (treeStatus)
                    {
                        case "collapsed":
                            this.tabControl.TreeViewPage.CollapseTree();
                            break;
                        case "expanded":
                            this.tabControl.TreeViewPage.ExpandTree();
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// closes the form.
        /// </summary>
        private void CallClose()
        {
            this.notifyIcon.Dispose();
            Application.Exit();
        }

        /// <summary>
        /// calls funtion to close the form.
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        void closeProg_Click(object sender, EventArgs e)
        {
            this.Show();
            this.CallClose();
        }

        /// <summary>
        /// ensures the monitor closes for the right reasons.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MonitorUI_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (e.CloseReason == System.Windows.Forms.CloseReason.WindowsShutDown ||
                e.CloseReason == System.Windows.Forms.CloseReason.TaskManagerClosing ||
                e.CloseReason == System.Windows.Forms.CloseReason.ApplicationExitCall ||
                e.CloseReason == System.Windows.Forms.CloseReason.UserClosing)
            {
                XMLDataList.BackUpData();
                this.notifyIcon.Visible = false;
                this.CallClose();

            }
            else
            {
                //this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
                this.Hide();

            }
        }

        /// <summary>
        /// restores the form.
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        void RestoreProg_Click(object sender, EventArgs e)
        {
            this.Show();
            //this.WindowState = System.Windows.Forms.FormWindowState.Normal;
        }

        /// <summary>
        /// shows the help dialog of the program.
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        void helpProg_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// shows the about dialog
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        void aboutProg_Click(object sender, EventArgs e)
        {
            Extras.AboutBox aboutDialog = new Extras.AboutBox();
            aboutDialog.ShowDialog();
        }

        /// <summary>
        /// minimizes the program to tray.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void minimizeProg_Click(object sender, EventArgs e)
        {
            this.Hide();
            //this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {

        }

        /// <summary>
        /// toggles the mode of the program; from restored to minimized to tray positions.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
             if (this.WindowState == System.Windows.Forms.FormWindowState.Normal)
             {
                 this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
                 this.Hide();
             }
             else
             {
                 this.Show();
                 this.WindowState = System.Windows.Forms.FormWindowState.Normal;
             }
        }


        private StatusStrip statusStrip;
        private ToolStripProgressBar progressBar;
        private ToolStripStatusLabel statusLabel;
        private MenuStrip menuStrip;
        private ToolStripMenuItem mainToolStripMenuItem;
        private ToolStripMenuItem addMoniteeToolStripMenuItem;
        private ToolStripMenuItem removeMoniteeToolStripMenuItem;
        private ToolStripMenuItem stopMonitoringToolStripMenuItem;
        private ToolStripMenuItem addDestinationToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem expandAllToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem aboutDocuMONToolStripMenuItem;
        private TabControl tabControl;
        
        private ToolStripSeparator viewToolStripSeparator;
        private ToolStripMenuItem switchViewToolStripMenuItem;
        private ToolStripMenuItem makeDefaultViewToolStripMenuItem;
        private ToolStripSeparator mainStripSeparator;
        private ToolStripMenuItem exitToolStripMenuItem;
        private NotifyIcon notifyIcon;
        private MenuItem closeProg;
        private MenuItem RestoreProg;
        private MenuItem minimizeProg;
        private MenuItem helpProg;
        private MenuItem aboutProg;
        private MenuItem dash;
        private ContextMenu DocuMon;
        private TableLayoutPanel FormtableLayoutPanel;

    }
}