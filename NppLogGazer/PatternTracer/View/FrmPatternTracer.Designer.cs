namespace NppLogGazer
{
    partial class FrmPatternTracer
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
            this.lstPattern = new System.Windows.Forms.ListBox();
            this.toolStripListMgmt = new System.Windows.Forms.ToolStrip();
            this.toolBtnAddPattern = new System.Windows.Forms.ToolStripButton();
            this.toolBtnDeletePattern = new System.Windows.Forms.ToolStripButton();
            this.toolBtnReplace = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnMoveUp = new System.Windows.Forms.ToolStripButton();
            this.toolBtnMoveDown = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnOpenPatternList = new System.Windows.Forms.ToolStripButton();
            this.toolBtnSavePatternList = new System.Windows.Forms.ToolStripButton();
            this.tabPatternTracer = new System.Windows.Forms.TableLayoutPanel();
            this.rtxtPatternInput = new System.Windows.Forms.RichTextBox();
            this.toolStripPatternInput.SuspendLayout();
            this.toolStripListMgmt.SuspendLayout();
            this.tabPatternTracer.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripPatternInput
            // 
            this.toolStripPatternInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripPatternInput.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
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
            this.toolStripPatternInput.Location = new System.Drawing.Point(0, 0);
            this.toolStripPatternInput.Name = "toolStripPatternInput";
            this.toolStripPatternInput.Size = new System.Drawing.Size(345, 25);
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
            this.toolStripBtnSearch.ToolTipText = global::NppLogGazer.Properties.Resources.tooltip_search;
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
            this.toolBtnRegExp.ToolTipText = global::NppLogGazer.Properties.Resources.tooltip_reg_exp;
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
            this.toolBtnMatchWord.ToolTipText = global::NppLogGazer.Properties.Resources.tooltip_match_word;
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
            this.toolBtnMatchCase.ToolTipText = global::NppLogGazer.Properties.Resources.tooltip_match_case;
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
            this.toolBtnWrapSearch.ToolTipText = global::NppLogGazer.Properties.Resources.tooltip_wrap_search;
            this.toolBtnWrapSearch.Visible = false;
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
            this.toolBtnClearPatternInput.ToolTipText = global::NppLogGazer.Properties.Resources.tooltip_clear_input;
            this.toolBtnClearPatternInput.Click += new System.EventHandler(this.toolBtnClearPatternInput_Click);
            // 
            // lstPattern
            // 
            this.lstPattern.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPattern.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstPattern.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPattern.FormattingEnabled = true;
            this.lstPattern.ItemHeight = 15;
            this.lstPattern.Location = new System.Drawing.Point(3, 231);
            this.lstPattern.Name = "lstPattern";
            this.lstPattern.Size = new System.Drawing.Size(339, 327);
            this.lstPattern.TabIndex = 3;
            this.lstPattern.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstPattern_DrawItem);
            this.lstPattern.SelectedIndexChanged += new System.EventHandler(this.lstPattern_SelectedIndexChanged);
            // 
            // toolStripListMgmt
            // 
            this.toolStripListMgmt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripListMgmt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripListMgmt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnAddPattern,
            this.toolBtnDeletePattern,
            this.toolBtnReplace,
            this.toolStripSeparator4,
            this.toolBtnMoveUp,
            this.toolBtnMoveDown,
            this.toolStripSeparator5,
            this.toolBtnOpenPatternList,
            this.toolBtnSavePatternList});
            this.toolStripListMgmt.Location = new System.Drawing.Point(0, 203);
            this.toolStripListMgmt.Name = "toolStripListMgmt";
            this.toolStripListMgmt.Size = new System.Drawing.Size(345, 25);
            this.toolStripListMgmt.TabIndex = 2;
            // 
            // toolBtnAddPattern
            // 
            this.toolBtnAddPattern.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnAddPattern.Image = global::NppLogGazer.Properties.Resources.add;
            this.toolBtnAddPattern.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnAddPattern.Name = "toolBtnAddPattern";
            this.toolBtnAddPattern.Size = new System.Drawing.Size(23, 22);
            this.toolBtnAddPattern.Text = "toolStripButton1";
            this.toolBtnAddPattern.ToolTipText = global::NppLogGazer.Properties.Resources.tooltip_add;
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
            this.toolBtnDeletePattern.ToolTipText = global::NppLogGazer.Properties.Resources.tooltip_delete;
            this.toolBtnDeletePattern.Click += new System.EventHandler(this.toolBtnDeletePattern_Click);
            // 
            // toolBtnReplace
            // 
            this.toolBtnReplace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnReplace.Image = global::NppLogGazer.Properties.Resources.text_replace;
            this.toolBtnReplace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnReplace.Name = "toolBtnReplace";
            this.toolBtnReplace.Size = new System.Drawing.Size(23, 22);
            this.toolBtnReplace.Text = "toolStripButton1";
            this.toolBtnReplace.ToolTipText = global::NppLogGazer.Properties.Resources.tooltip_replace;
            this.toolBtnReplace.Click += new System.EventHandler(this.toolBtnReplace_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBtnMoveUp
            // 
            this.toolBtnMoveUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnMoveUp.Image = global::NppLogGazer.Properties.Resources.arrow_up;
            this.toolBtnMoveUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnMoveUp.Name = "toolBtnMoveUp";
            this.toolBtnMoveUp.Size = new System.Drawing.Size(23, 22);
            this.toolBtnMoveUp.Text = "toolStripButton1";
            this.toolBtnMoveUp.ToolTipText = global::NppLogGazer.Properties.Resources.tooltip_move_up;
            this.toolBtnMoveUp.Click += new System.EventHandler(this.toolBtnMoveUp_Click);
            // 
            // toolBtnMoveDown
            // 
            this.toolBtnMoveDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnMoveDown.Image = global::NppLogGazer.Properties.Resources.arrow_down;
            this.toolBtnMoveDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnMoveDown.Name = "toolBtnMoveDown";
            this.toolBtnMoveDown.Size = new System.Drawing.Size(23, 22);
            this.toolBtnMoveDown.Text = "toolStripButton2";
            this.toolBtnMoveDown.ToolTipText = global::NppLogGazer.Properties.Resources.tooltip_move_down;
            this.toolBtnMoveDown.Click += new System.EventHandler(this.toolBtnMoveDown_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBtnOpenPatternList
            // 
            this.toolBtnOpenPatternList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnOpenPatternList.Image = global::NppLogGazer.Properties.Resources.folder_page_white;
            this.toolBtnOpenPatternList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnOpenPatternList.Name = "toolBtnOpenPatternList";
            this.toolBtnOpenPatternList.Size = new System.Drawing.Size(23, 22);
            this.toolBtnOpenPatternList.Text = "toolStripButton4";
            this.toolBtnOpenPatternList.ToolTipText = global::NppLogGazer.Properties.Resources.tooltip_open;
            this.toolBtnOpenPatternList.Click += new System.EventHandler(this.toolBtnOpenPatternList_Click);
            // 
            // toolBtnSavePatternList
            // 
            this.toolBtnSavePatternList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnSavePatternList.Image = global::NppLogGazer.Properties.Resources.disk;
            this.toolBtnSavePatternList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnSavePatternList.Name = "toolBtnSavePatternList";
            this.toolBtnSavePatternList.Size = new System.Drawing.Size(23, 22);
            this.toolBtnSavePatternList.Text = "toolStripButton3";
            this.toolBtnSavePatternList.ToolTipText = global::NppLogGazer.Properties.Resources.tooltip_save_as;
            this.toolBtnSavePatternList.Click += new System.EventHandler(this.toolBtnSavePatternList_Click);
            // 
            // tabPatternTracer
            // 
            this.tabPatternTracer.ColumnCount = 1;
            this.tabPatternTracer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabPatternTracer.Controls.Add(this.toolStripPatternInput, 0, 0);
            this.tabPatternTracer.Controls.Add(this.lstPattern, 0, 3);
            this.tabPatternTracer.Controls.Add(this.toolStripListMgmt, 0, 2);
            this.tabPatternTracer.Controls.Add(this.rtxtPatternInput, 0, 1);
            this.tabPatternTracer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPatternTracer.Location = new System.Drawing.Point(0, 0);
            this.tabPatternTracer.Name = "tabPatternTracer";
            this.tabPatternTracer.RowCount = 4;
            this.tabPatternTracer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabPatternTracer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tabPatternTracer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabPatternTracer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tabPatternTracer.Size = new System.Drawing.Size(345, 561);
            this.tabPatternTracer.TabIndex = 4;
            // 
            // rtxtPatternInput
            // 
            this.rtxtPatternInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtPatternInput.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtPatternInput.Location = new System.Drawing.Point(3, 28);
            this.rtxtPatternInput.Name = "rtxtPatternInput";
            this.rtxtPatternInput.Size = new System.Drawing.Size(339, 172);
            this.rtxtPatternInput.TabIndex = 4;
            this.rtxtPatternInput.Text = "";
            this.rtxtPatternInput.WordWrap = false;
            // 
            // FrmPatternTracer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 561);
            this.Controls.Add(this.tabPatternTracer);
            this.Name = "FrmPatternTracer";
            this.Text = "Pattern Tracer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPatternTracer_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.frmPatternTracer_VisibleChanged);
            this.toolStripPatternInput.ResumeLayout(false);
            this.toolStripPatternInput.PerformLayout();
            this.toolStripListMgmt.ResumeLayout(false);
            this.toolStripListMgmt.PerformLayout();
            this.tabPatternTracer.ResumeLayout(false);
            this.tabPatternTracer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripPatternInput;
        private System.Windows.Forms.ToolStripButton toolStripBtnSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolBtnRegExp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolBtnMatchWord;
        private System.Windows.Forms.ToolStripButton toolBtnMatchCase;
        private System.Windows.Forms.ToolStripButton toolBtnWrapSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolBtnClearPatternInput;
        private System.Windows.Forms.ToolStrip toolStripListMgmt;
        private System.Windows.Forms.ToolStripButton toolBtnAddPattern;
        private System.Windows.Forms.ToolStripButton toolBtnDeletePattern;
        private System.Windows.Forms.ToolStripButton toolBtnSavePatternList;
        private System.Windows.Forms.ToolStripButton toolBtnOpenPatternList;
        private System.Windows.Forms.ToolStripButton toolBtnMoveUp;
        private System.Windows.Forms.ToolStripButton toolBtnMoveDown;
        private System.Windows.Forms.ListBox lstPattern;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.TableLayoutPanel tabPatternTracer;
        private System.Windows.Forms.ToolStripButton toolBtnReplace;
        private System.Windows.Forms.RichTextBox rtxtPatternInput;

    }
}