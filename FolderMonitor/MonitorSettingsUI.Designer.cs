namespace FolderMonitor
{
    partial class MonitorSettingsUI
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SettingsTabControl = new System.Windows.Forms.TabControl();
            this.GeneralPage = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GeneralPagetableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SettingsTabControl.SuspendLayout();
            this.GeneralPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.SettingsTabControl, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(716, 574);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // SettingsTabControl
            // 
            this.SettingsTabControl.Controls.Add(this.GeneralPage);
            this.SettingsTabControl.Controls.Add(this.tabPage2);
            this.SettingsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsTabControl.Location = new System.Drawing.Point(3, 3);
            this.SettingsTabControl.Name = "SettingsTabControl";
            this.SettingsTabControl.SelectedIndex = 0;
            this.SettingsTabControl.Size = new System.Drawing.Size(710, 568);
            this.SettingsTabControl.TabIndex = 0;
            // 
            // GeneralPage
            // 
            this.GeneralPage.BackColor = System.Drawing.Color.Silver;
            this.GeneralPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GeneralPage.Controls.Add(this.GeneralPagetableLayoutPanel);
            this.GeneralPage.Location = new System.Drawing.Point(4, 22);
            this.GeneralPage.Name = "GeneralPage";
            this.GeneralPage.Padding = new System.Windows.Forms.Padding(3);
            this.GeneralPage.Size = new System.Drawing.Size(702, 542);
            this.GeneralPage.TabIndex = 0;
            this.GeneralPage.Text = "General";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(550, 346);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GeneralPagetableLayoutPanel
            // 
            this.GeneralPagetableLayoutPanel.ColumnCount = 2;
            this.GeneralPagetableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GeneralPagetableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GeneralPagetableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GeneralPagetableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.GeneralPagetableLayoutPanel.Name = "GeneralPagetableLayoutPanel";
            this.GeneralPagetableLayoutPanel.RowCount = 2;
            this.GeneralPagetableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GeneralPagetableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GeneralPagetableLayoutPanel.Size = new System.Drawing.Size(692, 532);
            this.GeneralPagetableLayoutPanel.TabIndex = 0;
            // 
            // MonitorSettingsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 574);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MonitorSettingsUI";
            this.Text = "Settings";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.SettingsTabControl.ResumeLayout(false);
            this.GeneralPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl SettingsTabControl;
        private System.Windows.Forms.TabPage GeneralPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel GeneralPagetableLayoutPanel;
    }
}