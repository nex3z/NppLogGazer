namespace NppLogGazer
{
    partial class frmPatternTracer
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
            this.tableLayoutPanelPatternExtractor = new System.Windows.Forms.TableLayoutPanel();
            this.splitPatternExtractor = new System.Windows.Forms.SplitContainer();
            this.toolStripContainerPatternInput = new System.Windows.Forms.ToolStripContainer();
            this.txtPatternInput = new System.Windows.Forms.TextBox();
            this.toolStripPatternInput = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainerPatternList = new System.Windows.Forms.ToolStripContainer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.toolStripListMgmt = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripListIO = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanelPatternExtractor.SuspendLayout();
            this.splitPatternExtractor.Panel1.SuspendLayout();
            this.splitPatternExtractor.Panel2.SuspendLayout();
            this.splitPatternExtractor.SuspendLayout();
            this.toolStripContainerPatternInput.ContentPanel.SuspendLayout();
            this.toolStripContainerPatternInput.TopToolStripPanel.SuspendLayout();
            this.toolStripContainerPatternInput.SuspendLayout();
            this.toolStripPatternInput.SuspendLayout();
            this.toolStripContainerPatternList.ContentPanel.SuspendLayout();
            this.toolStripContainerPatternList.TopToolStripPanel.SuspendLayout();
            this.toolStripContainerPatternList.SuspendLayout();
            this.toolStripListMgmt.SuspendLayout();
            this.toolStripListIO.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelPatternExtractor
            // 
            this.tableLayoutPanelPatternExtractor.ColumnCount = 1;
            this.tableLayoutPanelPatternExtractor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelPatternExtractor.Controls.Add(this.splitPatternExtractor, 0, 1);
            this.tableLayoutPanelPatternExtractor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPatternExtractor.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelPatternExtractor.Name = "tableLayoutPanelPatternExtractor";
            this.tableLayoutPanelPatternExtractor.RowCount = 2;
            this.tableLayoutPanelPatternExtractor.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelPatternExtractor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPatternExtractor.Size = new System.Drawing.Size(400, 449);
            this.tableLayoutPanelPatternExtractor.TabIndex = 0;
            // 
            // splitPatternExtractor
            // 
            this.splitPatternExtractor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitPatternExtractor.Location = new System.Drawing.Point(3, 3);
            this.splitPatternExtractor.Name = "splitPatternExtractor";
            this.splitPatternExtractor.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitPatternExtractor.Panel1
            // 
            this.splitPatternExtractor.Panel1.Controls.Add(this.toolStripContainerPatternInput);
            // 
            // splitPatternExtractor.Panel2
            // 
            this.splitPatternExtractor.Panel2.Controls.Add(this.toolStripContainerPatternList);
            this.splitPatternExtractor.Size = new System.Drawing.Size(394, 443);
            this.splitPatternExtractor.SplitterDistance = 188;
            this.splitPatternExtractor.TabIndex = 0;
            // 
            // toolStripContainerPatternInput
            // 
            this.toolStripContainerPatternInput.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainerPatternInput.ContentPanel
            // 
            this.toolStripContainerPatternInput.ContentPanel.Controls.Add(this.txtPatternInput);
            this.toolStripContainerPatternInput.ContentPanel.Size = new System.Drawing.Size(394, 163);
            this.toolStripContainerPatternInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainerPatternInput.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainerPatternInput.Name = "toolStripContainerPatternInput";
            this.toolStripContainerPatternInput.RightToolStripPanelVisible = false;
            this.toolStripContainerPatternInput.Size = new System.Drawing.Size(394, 188);
            this.toolStripContainerPatternInput.TabIndex = 0;
            this.toolStripContainerPatternInput.Text = "toolStripContainer1";
            // 
            // toolStripContainerPatternInput.TopToolStripPanel
            // 
            this.toolStripContainerPatternInput.TopToolStripPanel.Controls.Add(this.toolStripPatternInput);
            // 
            // txtPatternInput
            // 
            this.txtPatternInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPatternInput.Location = new System.Drawing.Point(0, 0);
            this.txtPatternInput.Multiline = true;
            this.txtPatternInput.Name = "txtPatternInput";
            this.txtPatternInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPatternInput.Size = new System.Drawing.Size(394, 163);
            this.txtPatternInput.TabIndex = 0;
            // 
            // toolStripPatternInput
            // 
            this.toolStripPatternInput.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripPatternInput.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnSearch});
            this.toolStripPatternInput.Location = new System.Drawing.Point(3, 0);
            this.toolStripPatternInput.Name = "toolStripPatternInput";
            this.toolStripPatternInput.Size = new System.Drawing.Size(35, 25);
            this.toolStripPatternInput.TabIndex = 0;
            // 
            // toolStripBtnSearch
            // 
            this.toolStripBtnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnSearch.Image = global::NppLogGazer.Properties.Resources.magnifier;
            this.toolStripBtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSearch.Name = "toolStripBtnSearch";
            this.toolStripBtnSearch.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnSearch.Text = "toolStripButton4";
            this.toolStripBtnSearch.Click += new System.EventHandler(this.toolStripBtnSearch_Click);
            // 
            // toolStripContainerPatternList
            // 
            this.toolStripContainerPatternList.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainerPatternList.ContentPanel
            // 
            this.toolStripContainerPatternList.ContentPanel.Controls.Add(this.listBox1);
            this.toolStripContainerPatternList.ContentPanel.Size = new System.Drawing.Size(394, 226);
            this.toolStripContainerPatternList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainerPatternList.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainerPatternList.Name = "toolStripContainerPatternList";
            this.toolStripContainerPatternList.RightToolStripPanelVisible = false;
            this.toolStripContainerPatternList.Size = new System.Drawing.Size(394, 251);
            this.toolStripContainerPatternList.TabIndex = 0;
            this.toolStripContainerPatternList.Text = "toolStripContainer2";
            // 
            // toolStripContainerPatternList.TopToolStripPanel
            // 
            this.toolStripContainerPatternList.TopToolStripPanel.Controls.Add(this.toolStripListMgmt);
            this.toolStripContainerPatternList.TopToolStripPanel.Controls.Add(this.toolStripListIO);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(394, 226);
            this.listBox1.TabIndex = 0;
            // 
            // toolStripListMgmt
            // 
            this.toolStripListMgmt.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripListMgmt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStripListMgmt.Location = new System.Drawing.Point(3, 0);
            this.toolStripListMgmt.Name = "toolStripListMgmt";
            this.toolStripListMgmt.Size = new System.Drawing.Size(58, 25);
            this.toolStripListMgmt.TabIndex = 0;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::NppLogGazer.Properties.Resources.add;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::NppLogGazer.Properties.Resources.delete;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripListIO
            // 
            this.toolStripListIO.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripListIO.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStripListIO.Location = new System.Drawing.Point(61, 0);
            this.toolStripListIO.Name = "toolStripListIO";
            this.toolStripListIO.Size = new System.Drawing.Size(58, 25);
            this.toolStripListIO.TabIndex = 1;
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::NppLogGazer.Properties.Resources.disk;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::NppLogGazer.Properties.Resources.folder_page_white;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // frmPatternExtractor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 449);
            this.Controls.Add(this.tableLayoutPanelPatternExtractor);
            this.Name = "frmPatternExtractor";
            this.Text = "frmMyDlg";
            this.tableLayoutPanelPatternExtractor.ResumeLayout(false);
            this.splitPatternExtractor.Panel1.ResumeLayout(false);
            this.splitPatternExtractor.Panel2.ResumeLayout(false);
            this.splitPatternExtractor.ResumeLayout(false);
            this.toolStripContainerPatternInput.ContentPanel.ResumeLayout(false);
            this.toolStripContainerPatternInput.ContentPanel.PerformLayout();
            this.toolStripContainerPatternInput.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainerPatternInput.TopToolStripPanel.PerformLayout();
            this.toolStripContainerPatternInput.ResumeLayout(false);
            this.toolStripContainerPatternInput.PerformLayout();
            this.toolStripPatternInput.ResumeLayout(false);
            this.toolStripPatternInput.PerformLayout();
            this.toolStripContainerPatternList.ContentPanel.ResumeLayout(false);
            this.toolStripContainerPatternList.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainerPatternList.TopToolStripPanel.PerformLayout();
            this.toolStripContainerPatternList.ResumeLayout(false);
            this.toolStripContainerPatternList.PerformLayout();
            this.toolStripListMgmt.ResumeLayout(false);
            this.toolStripListMgmt.PerformLayout();
            this.toolStripListIO.ResumeLayout(false);
            this.toolStripListIO.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPatternExtractor;
        private System.Windows.Forms.SplitContainer splitPatternExtractor;
        private System.Windows.Forms.ToolStripContainer toolStripContainerPatternInput;
        private System.Windows.Forms.TextBox txtPatternInput;
        private System.Windows.Forms.ToolStrip toolStripPatternInput;
        private System.Windows.Forms.ToolStripButton toolStripBtnSearch;
        private System.Windows.Forms.ToolStripContainer toolStripContainerPatternList;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStrip toolStripListMgmt;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStrip toolStripListIO;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;

    }
}