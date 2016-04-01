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
            this.tabLayoutPatternTracer = new System.Windows.Forms.TableLayoutPanel();
            this.splitPatternExtractor = new System.Windows.Forms.SplitContainer();
            this.toolStripContainerPatternInput = new System.Windows.Forms.ToolStripContainer();
            this.txtPatternInput = new System.Windows.Forms.TextBox();
            this.toolStripPatternInput = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnRegExp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnMatchWord = new System.Windows.Forms.ToolStripButton();
            this.toolBtnMatchCase = new System.Windows.Forms.ToolStripButton();
            this.toolBtnWrapSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnClearPatternInput = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainerPatternList = new System.Windows.Forms.ToolStripContainer();
            this.lstPattern = new System.Windows.Forms.ListBox();
            this.toolStripListMgmt = new System.Windows.Forms.ToolStrip();
            this.toolBtnAddPattern = new System.Windows.Forms.ToolStripButton();
            this.toolBtnDeletePattern = new System.Windows.Forms.ToolStripButton();
            this.toolStripListIO = new System.Windows.Forms.ToolStrip();
            this.toolBtnSavePatternList = new System.Windows.Forms.ToolStripButton();
            this.toolBtnOpenPatternList = new System.Windows.Forms.ToolStripButton();
            this.tabLayoutPatternTracer.SuspendLayout();
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
            // tabLayoutPatternTracer
            // 
            this.tabLayoutPatternTracer.ColumnCount = 1;
            this.tabLayoutPatternTracer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tabLayoutPatternTracer.Controls.Add(this.splitPatternExtractor, 0, 1);
            this.tabLayoutPatternTracer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLayoutPatternTracer.Location = new System.Drawing.Point(0, 0);
            this.tabLayoutPatternTracer.Name = "tabLayoutPatternTracer";
            this.tabLayoutPatternTracer.RowCount = 2;
            this.tabLayoutPatternTracer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabLayoutPatternTracer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabLayoutPatternTracer.Size = new System.Drawing.Size(400, 449);
            this.tabLayoutPatternTracer.TabIndex = 0;
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
            this.toolStripBtnSearch,
            this.toolStripSeparator1,
            this.toolBtnRegExp,
            this.toolStripSeparator2,
            this.toolBtnMatchWord,
            this.toolBtnMatchCase,
            this.toolBtnWrapSearch,
            this.toolStripSeparator3,
            this.toolBtnClearPatternInput});
            this.toolStripPatternInput.Location = new System.Drawing.Point(3, 0);
            this.toolStripPatternInput.Name = "toolStripPatternInput";
            this.toolStripPatternInput.Size = new System.Drawing.Size(168, 25);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBtnRegExp
            // 
            this.toolBtnRegExp.CheckOnClick = true;
            this.toolBtnRegExp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnRegExp.Image = global::NppLogGazer.Properties.Resources.reg_exp_icon;
            this.toolBtnRegExp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnRegExp.Name = "toolBtnRegExp";
            this.toolBtnRegExp.Size = new System.Drawing.Size(23, 22);
            this.toolBtnRegExp.Text = "toolStripButton5";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBtnMatchWord
            // 
            this.toolBtnMatchWord.CheckOnClick = true;
            this.toolBtnMatchWord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnMatchWord.Image = global::NppLogGazer.Properties.Resources.match_word_icon;
            this.toolBtnMatchWord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnMatchWord.Name = "toolBtnMatchWord";
            this.toolBtnMatchWord.Size = new System.Drawing.Size(23, 22);
            this.toolBtnMatchWord.Text = "toolStripButton6";
            // 
            // toolBtnMatchCase
            // 
            this.toolBtnMatchCase.CheckOnClick = true;
            this.toolBtnMatchCase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnMatchCase.Image = global::NppLogGazer.Properties.Resources.match_case_icon;
            this.toolBtnMatchCase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnMatchCase.Name = "toolBtnMatchCase";
            this.toolBtnMatchCase.Size = new System.Drawing.Size(23, 22);
            this.toolBtnMatchCase.Text = "toolStripButton7";
            // 
            // toolBtnWrapSearch
            // 
            this.toolBtnWrapSearch.CheckOnClick = true;
            this.toolBtnWrapSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnWrapSearch.Image = global::NppLogGazer.Properties.Resources.wrap_search_icon;
            this.toolBtnWrapSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnWrapSearch.Name = "toolBtnWrapSearch";
            this.toolBtnWrapSearch.Size = new System.Drawing.Size(23, 22);
            this.toolBtnWrapSearch.Text = "toolStripButton8";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBtnClearPatternInput
            // 
            this.toolBtnClearPatternInput.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnClearPatternInput.Image = global::NppLogGazer.Properties.Resources.delete_input;
            this.toolBtnClearPatternInput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnClearPatternInput.Name = "toolBtnClearPatternInput";
            this.toolBtnClearPatternInput.Size = new System.Drawing.Size(23, 22);
            this.toolBtnClearPatternInput.Text = "toolStripButton1";
            this.toolBtnClearPatternInput.Click += new System.EventHandler(this.toolBtnClearPatternInput_Click);
            // 
            // toolStripContainerPatternList
            // 
            this.toolStripContainerPatternList.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainerPatternList.ContentPanel
            // 
            this.toolStripContainerPatternList.ContentPanel.Controls.Add(this.lstPattern);
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
            // lstPattern
            // 
            this.lstPattern.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPattern.Font = new System.Drawing.Font("SimSun", 10F);
            this.lstPattern.FormattingEnabled = true;
            this.lstPattern.Location = new System.Drawing.Point(0, 0);
            this.lstPattern.Name = "lstPattern";
            this.lstPattern.Size = new System.Drawing.Size(394, 226);
            this.lstPattern.TabIndex = 0;
            this.lstPattern.SelectedIndexChanged += new System.EventHandler(this.lstPattern_SelectedIndexChanged);
            // 
            // toolStripListMgmt
            // 
            this.toolStripListMgmt.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripListMgmt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnAddPattern,
            this.toolBtnDeletePattern});
            this.toolStripListMgmt.Location = new System.Drawing.Point(3, 0);
            this.toolStripListMgmt.Name = "toolStripListMgmt";
            this.toolStripListMgmt.Size = new System.Drawing.Size(58, 25);
            this.toolStripListMgmt.TabIndex = 0;
            // 
            // toolBtnAddPattern
            // 
            this.toolBtnAddPattern.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnAddPattern.Image = global::NppLogGazer.Properties.Resources.add;
            this.toolBtnAddPattern.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnAddPattern.Name = "toolBtnAddPattern";
            this.toolBtnAddPattern.Size = new System.Drawing.Size(23, 22);
            this.toolBtnAddPattern.Text = "toolStripButton1";
            this.toolBtnAddPattern.Click += new System.EventHandler(this.toolBtnAddPattern_Click);
            // 
            // toolBtnDeletePattern
            // 
            this.toolBtnDeletePattern.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnDeletePattern.Image = global::NppLogGazer.Properties.Resources.delete;
            this.toolBtnDeletePattern.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnDeletePattern.Name = "toolBtnDeletePattern";
            this.toolBtnDeletePattern.Size = new System.Drawing.Size(23, 22);
            this.toolBtnDeletePattern.Text = "toolStripButton2";
            this.toolBtnDeletePattern.Click += new System.EventHandler(this.toolBtnDeletePattern_Click);
            // 
            // toolStripListIO
            // 
            this.toolStripListIO.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripListIO.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnSavePatternList,
            this.toolBtnOpenPatternList});
            this.toolStripListIO.Location = new System.Drawing.Point(61, 0);
            this.toolStripListIO.Name = "toolStripListIO";
            this.toolStripListIO.Size = new System.Drawing.Size(58, 25);
            this.toolStripListIO.TabIndex = 1;
            // 
            // toolBtnSavePatternList
            // 
            this.toolBtnSavePatternList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnSavePatternList.Image = global::NppLogGazer.Properties.Resources.disk;
            this.toolBtnSavePatternList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnSavePatternList.Name = "toolBtnSavePatternList";
            this.toolBtnSavePatternList.Size = new System.Drawing.Size(23, 22);
            this.toolBtnSavePatternList.Text = "toolStripButton3";
            this.toolBtnSavePatternList.Click += new System.EventHandler(this.toolBtnSavePatternList_Click);
            // 
            // toolBtnOpenPatternList
            // 
            this.toolBtnOpenPatternList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnOpenPatternList.Image = global::NppLogGazer.Properties.Resources.folder_page_white;
            this.toolBtnOpenPatternList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnOpenPatternList.Name = "toolBtnOpenPatternList";
            this.toolBtnOpenPatternList.Size = new System.Drawing.Size(23, 22);
            this.toolBtnOpenPatternList.Text = "toolStripButton4";
            this.toolBtnOpenPatternList.Click += new System.EventHandler(this.toolBtnOpenPatternList_Click);
            // 
            // frmPatternTracer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 449);
            this.Controls.Add(this.tabLayoutPatternTracer);
            this.Name = "frmPatternTracer";
            this.Text = "Pattern Tracer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPatternTracer_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.frmPatternTracer_VisibleChanged);
            this.tabLayoutPatternTracer.ResumeLayout(false);
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

        private System.Windows.Forms.TableLayoutPanel tabLayoutPatternTracer;
        private System.Windows.Forms.SplitContainer splitPatternExtractor;
        private System.Windows.Forms.ToolStripContainer toolStripContainerPatternInput;
        private System.Windows.Forms.TextBox txtPatternInput;
        private System.Windows.Forms.ToolStrip toolStripPatternInput;
        private System.Windows.Forms.ToolStripButton toolStripBtnSearch;
        private System.Windows.Forms.ToolStripContainer toolStripContainerPatternList;
        private System.Windows.Forms.ListBox lstPattern;
        private System.Windows.Forms.ToolStrip toolStripListMgmt;
        private System.Windows.Forms.ToolStripButton toolBtnAddPattern;
        private System.Windows.Forms.ToolStripButton toolBtnDeletePattern;
        private System.Windows.Forms.ToolStrip toolStripListIO;
        private System.Windows.Forms.ToolStripButton toolBtnSavePatternList;
        private System.Windows.Forms.ToolStripButton toolBtnOpenPatternList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolBtnRegExp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolBtnMatchWord;
        private System.Windows.Forms.ToolStripButton toolBtnMatchCase;
        private System.Windows.Forms.ToolStripButton toolBtnWrapSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolBtnClearPatternInput;

    }
}