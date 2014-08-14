namespace FolderMonitor
{
    partial class DestinationViewUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.destinationList = new System.Windows.Forms.ListView();
            this.Destinations = new System.Windows.Forms.ColumnHeader();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.67816F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.32184F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.destinationList, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, -1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(435, 127);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RemoveBtn);
            this.panel1.Location = new System.Drawing.Point(367, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(65, 57);
            this.panel1.TabIndex = 1;
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(3, 10);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(55, 26);
            this.RemoveBtn.TabIndex = 0;
            this.RemoveBtn.Text = "&Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(RemoveBtn_Click);
            // 
            // destinationList
            // 
            this.destinationList.BackColor = System.Drawing.SystemColors.Menu;
            this.destinationList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Destinations});
            this.destinationList.GridLines = true;
            this.destinationList.Location = new System.Drawing.Point(3, 3);
            this.destinationList.Name = "destinationList";
            this.tableLayoutPanel1.SetRowSpan(this.destinationList, 2);
            this.destinationList.CheckBoxes = true;
            this.destinationList.Size = new System.Drawing.Size(358, 121);
            this.destinationList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.destinationList.TabIndex = 0;
            this.destinationList.UseCompatibleStateImageBehavior = false;
            this.destinationList.View = System.Windows.Forms.View.Details;
            // 
            // Destinations
            // 
            this.Destinations.Text = "Destinations";
            this.Destinations.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Destinations.Width = 353;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CloseBtn);
            this.panel2.Location = new System.Drawing.Point(367, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(63, 58);
            this.panel2.TabIndex = 2;
            // 
            // CloseBtn
            // 
            this.CloseBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseBtn.Location = new System.Drawing.Point(3, 12);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(53, 26);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.Text = "&Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            // 
            // DestinationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseBtn;
            this.ClientSize = new System.Drawing.Size(436, 126);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DestinationView";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Destinations";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView destinationList;
        private System.Windows.Forms.ColumnHeader Destinations;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CloseBtn;
    }
}