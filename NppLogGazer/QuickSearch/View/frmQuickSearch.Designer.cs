namespace NppLogGazer
{
    partial class frmQuickSearch
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
            this.tabLayoutQuickSearch = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutSearchOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.chkMatchWord = new System.Windows.Forms.CheckBox();
            this.chkMatchCase = new System.Windows.Forms.CheckBox();
            this.chkWrapSearch = new System.Windows.Forms.CheckBox();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.flowLayoutKeywordType = new System.Windows.Forms.FlowLayoutPanel();
            this.chkRegExp = new System.Windows.Forms.CheckBox();
            this.toolStripKeywrodList = new System.Windows.Forms.ToolStrip();
            this.toolBtnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolBtnRemove = new System.Windows.Forms.ToolStripButton();
            this.toolBtnReplace = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnMoveUp = new System.Windows.Forms.ToolStripButton();
            this.toolBtnMoveDown = new System.Windows.Forms.ToolStripButton();
            this.toolBtnRemoveDuplicate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnOpen = new System.Windows.Forms.ToolStripButton();
            this.toolBtnSaveAs = new System.Windows.Forms.ToolStripButton();
            this.lstKeywords = new System.Windows.Forms.ListBox();
            this.statusKeywordList = new System.Windows.Forms.StatusStrip();
            this.statusLabelKeywordList = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTipKeywordList = new System.Windows.Forms.ToolTip(this.components);
            this.tabLayoutQuickSearch.SuspendLayout();
            this.flowLayoutSearchOptions.SuspendLayout();
            this.flowLayoutKeywordType.SuspendLayout();
            this.toolStripKeywrodList.SuspendLayout();
            this.statusKeywordList.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabLayoutQuickSearch
            // 
            this.tabLayoutQuickSearch.ColumnCount = 1;
            this.tabLayoutQuickSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabLayoutQuickSearch.Controls.Add(this.flowLayoutSearchOptions, 0, 0);
            this.tabLayoutQuickSearch.Controls.Add(this.txtKeyword, 0, 1);
            this.tabLayoutQuickSearch.Controls.Add(this.flowLayoutKeywordType, 0, 2);
            this.tabLayoutQuickSearch.Controls.Add(this.toolStripKeywrodList, 0, 3);
            this.tabLayoutQuickSearch.Controls.Add(this.lstKeywords, 0, 4);
            this.tabLayoutQuickSearch.Controls.Add(this.statusKeywordList, 0, 5);
            this.tabLayoutQuickSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLayoutQuickSearch.Location = new System.Drawing.Point(0, 0);
            this.tabLayoutQuickSearch.Name = "tabLayoutQuickSearch";
            this.tabLayoutQuickSearch.RowCount = 6;
            this.tabLayoutQuickSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabLayoutQuickSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabLayoutQuickSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabLayoutQuickSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabLayoutQuickSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabLayoutQuickSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabLayoutQuickSearch.Size = new System.Drawing.Size(371, 750);
            this.tabLayoutQuickSearch.TabIndex = 0;
            // 
            // flowLayoutSearchOptions
            // 
            this.flowLayoutSearchOptions.AutoSize = true;
            this.flowLayoutSearchOptions.Controls.Add(this.chkMatchWord);
            this.flowLayoutSearchOptions.Controls.Add(this.chkMatchCase);
            this.flowLayoutSearchOptions.Controls.Add(this.chkWrapSearch);
            this.flowLayoutSearchOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutSearchOptions.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutSearchOptions.Name = "flowLayoutSearchOptions";
            this.flowLayoutSearchOptions.Size = new System.Drawing.Size(365, 22);
            this.flowLayoutSearchOptions.TabIndex = 0;
            // 
            // chkMatchWord
            // 
            this.chkMatchWord.AutoSize = true;
            this.chkMatchWord.Location = new System.Drawing.Point(3, 3);
            this.chkMatchWord.Name = "chkMatchWord";
            this.chkMatchWord.Size = new System.Drawing.Size(84, 16);
            this.chkMatchWord.TabIndex = 0;
            this.chkMatchWord.Text = global::NppLogGazer.Properties.Resources.match_word_text;
            this.chkMatchWord.UseVisualStyleBackColor = true;
            // 
            // chkMatchCase
            // 
            this.chkMatchCase.AutoSize = true;
            this.chkMatchCase.Location = new System.Drawing.Point(93, 3);
            this.chkMatchCase.Name = "chkMatchCase";
            this.chkMatchCase.Size = new System.Drawing.Size(84, 16);
            this.chkMatchCase.TabIndex = 1;
            this.chkMatchCase.Text = global::NppLogGazer.Properties.Resources.match_case_text;
            this.chkMatchCase.UseVisualStyleBackColor = true;
            // 
            // chkWrapSearch
            // 
            this.chkWrapSearch.AutoSize = true;
            this.chkWrapSearch.Location = new System.Drawing.Point(183, 3);
            this.chkWrapSearch.Name = "chkWrapSearch";
            this.chkWrapSearch.Size = new System.Drawing.Size(90, 16);
            this.chkWrapSearch.TabIndex = 2;
            this.chkWrapSearch.Text = global::NppLogGazer.Properties.Resources.wrap_search_text;
            this.chkWrapSearch.UseVisualStyleBackColor = true;
            // 
            // txtKeyword
            // 
            this.txtKeyword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKeyword.Location = new System.Drawing.Point(3, 31);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(365, 21);
            this.txtKeyword.TabIndex = 1;
            // 
            // flowLayoutKeywordType
            // 
            this.flowLayoutKeywordType.AutoSize = true;
            this.flowLayoutKeywordType.Controls.Add(this.chkRegExp);
            this.flowLayoutKeywordType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutKeywordType.Location = new System.Drawing.Point(3, 58);
            this.flowLayoutKeywordType.Name = "flowLayoutKeywordType";
            this.flowLayoutKeywordType.Size = new System.Drawing.Size(365, 22);
            this.flowLayoutKeywordType.TabIndex = 3;
            // 
            // chkRegExp
            // 
            this.chkRegExp.AutoSize = true;
            this.chkRegExp.Location = new System.Drawing.Point(3, 3);
            this.chkRegExp.Name = "chkRegExp";
            this.chkRegExp.Size = new System.Drawing.Size(132, 16);
            this.chkRegExp.TabIndex = 2;
            this.chkRegExp.Text = global::NppLogGazer.Properties.Resources.regular_expression;
            this.chkRegExp.UseVisualStyleBackColor = true;
            // 
            // toolStripKeywrodList
            // 
            this.toolStripKeywrodList.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripKeywrodList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnAdd,
            this.toolBtnRemove,
            this.toolBtnReplace,
            this.toolStripSeparator1,
            this.toolBtnMoveUp,
            this.toolBtnMoveDown,
            this.toolBtnRemoveDuplicate,
            this.toolStripSeparator2,
            this.toolBtnOpen,
            this.toolBtnSaveAs});
            this.toolStripKeywrodList.Location = new System.Drawing.Point(0, 83);
            this.toolStripKeywrodList.Name = "toolStripKeywrodList";
            this.toolStripKeywrodList.Size = new System.Drawing.Size(371, 25);
            this.toolStripKeywrodList.TabIndex = 4;
            this.toolStripKeywrodList.Text = "toolStrip1";
            // 
            // toolBtnAdd
            // 
            this.toolBtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnAdd.Image = global::NppLogGazer.Properties.Resources.add;
            this.toolBtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnAdd.Name = "toolBtnAdd";
            this.toolBtnAdd.Size = new System.Drawing.Size(23, 22);
            this.toolBtnAdd.Text = "toolStripButton1";
            this.toolBtnAdd.ToolTipText = global::NppLogGazer.Properties.Resources.quick_search_tooltip_add;
            this.toolBtnAdd.Click += new System.EventHandler(this.toolBtnAdd_Click);
            // 
            // toolBtnRemove
            // 
            this.toolBtnRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnRemove.Image = global::NppLogGazer.Properties.Resources.delete;
            this.toolBtnRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnRemove.Name = "toolBtnRemove";
            this.toolBtnRemove.Size = new System.Drawing.Size(23, 22);
            this.toolBtnRemove.Text = "toolStripButton2";
            this.toolBtnRemove.ToolTipText = global::NppLogGazer.Properties.Resources.quick_search_tooltip_remove;
            this.toolBtnRemove.Click += new System.EventHandler(this.toolBtnRemove_Click);
            // 
            // toolBtnReplace
            // 
            this.toolBtnReplace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnReplace.Image = global::NppLogGazer.Properties.Resources.text_replace;
            this.toolBtnReplace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnReplace.Name = "toolBtnReplace";
            this.toolBtnReplace.Size = new System.Drawing.Size(23, 22);
            this.toolBtnReplace.Text = "toolStripButton1";
            this.toolBtnReplace.Click += new System.EventHandler(this.toolBtnReplace_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBtnMoveUp
            // 
            this.toolBtnMoveUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnMoveUp.Image = global::NppLogGazer.Properties.Resources.arrow_up;
            this.toolBtnMoveUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnMoveUp.Name = "toolBtnMoveUp";
            this.toolBtnMoveUp.Size = new System.Drawing.Size(23, 22);
            this.toolBtnMoveUp.Text = "toolStripButton3";
            this.toolBtnMoveUp.ToolTipText = global::NppLogGazer.Properties.Resources.quick_search_tooltip_move_up;
            this.toolBtnMoveUp.Click += new System.EventHandler(this.toolBtnMoveUp_Click);
            // 
            // toolBtnMoveDown
            // 
            this.toolBtnMoveDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnMoveDown.Image = global::NppLogGazer.Properties.Resources.arrow_down;
            this.toolBtnMoveDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnMoveDown.Name = "toolBtnMoveDown";
            this.toolBtnMoveDown.Size = new System.Drawing.Size(23, 22);
            this.toolBtnMoveDown.Text = "toolStripButton4";
            this.toolBtnMoveDown.ToolTipText = global::NppLogGazer.Properties.Resources.quick_search_tooltip_move_down;
            this.toolBtnMoveDown.Click += new System.EventHandler(this.toolBtnMoveDown_Click);
            // 
            // toolBtnRemoveDuplicate
            // 
            this.toolBtnRemoveDuplicate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnRemoveDuplicate.Image = global::NppLogGazer.Properties.Resources.remove_duplicate;
            this.toolBtnRemoveDuplicate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnRemoveDuplicate.Name = "toolBtnRemoveDuplicate";
            this.toolBtnRemoveDuplicate.Size = new System.Drawing.Size(23, 22);
            this.toolBtnRemoveDuplicate.Text = "toolStripButton5";
            this.toolBtnRemoveDuplicate.ToolTipText = global::NppLogGazer.Properties.Resources.quick_search_tooltip_delete_duplicate;
            this.toolBtnRemoveDuplicate.Click += new System.EventHandler(this.toolBtnRemoveDuplicate_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBtnOpen
            // 
            this.toolBtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnOpen.Image = global::NppLogGazer.Properties.Resources.folder_page_white;
            this.toolBtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnOpen.Name = "toolBtnOpen";
            this.toolBtnOpen.Size = new System.Drawing.Size(23, 22);
            this.toolBtnOpen.Text = "toolStripButton6";
            this.toolBtnOpen.ToolTipText = global::NppLogGazer.Properties.Resources.quick_search_tooltip_open;
            this.toolBtnOpen.Click += new System.EventHandler(this.toolBtnOpen_Click);
            // 
            // toolBtnSaveAs
            // 
            this.toolBtnSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnSaveAs.Image = global::NppLogGazer.Properties.Resources.report_disk;
            this.toolBtnSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnSaveAs.Name = "toolBtnSaveAs";
            this.toolBtnSaveAs.Size = new System.Drawing.Size(23, 22);
            this.toolBtnSaveAs.Text = "toolStripButton7";
            this.toolBtnSaveAs.ToolTipText = global::NppLogGazer.Properties.Resources.quick_search_tooltip_save_as;
            this.toolBtnSaveAs.Click += new System.EventHandler(this.toolBtnSaveAs_Click);
            // 
            // lstKeywords
            // 
            this.lstKeywords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstKeywords.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstKeywords.Font = new System.Drawing.Font("SimSun", 10F);
            this.lstKeywords.FormattingEnabled = true;
            this.lstKeywords.ItemHeight = 14;
            this.lstKeywords.Location = new System.Drawing.Point(3, 111);
            this.lstKeywords.Name = "lstKeywords";
            this.lstKeywords.Size = new System.Drawing.Size(365, 614);
            this.lstKeywords.TabIndex = 5;
            this.lstKeywords.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstKeywords_DrawItem);
            this.lstKeywords.SelectedIndexChanged += new System.EventHandler(this.lstKeywords_SelectedIndexChanged);
            this.lstKeywords.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstKeywords_MouseDown);
            this.lstKeywords.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lstKeywords_MouseMove);
            // 
            // statusKeywordList
            // 
            this.statusKeywordList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabelKeywordList});
            this.statusKeywordList.Location = new System.Drawing.Point(0, 728);
            this.statusKeywordList.Name = "statusKeywordList";
            this.statusKeywordList.Size = new System.Drawing.Size(371, 22);
            this.statusKeywordList.TabIndex = 6;
            this.statusKeywordList.Text = "statusStrip1";
            // 
            // statusLabelKeywordList
            // 
            this.statusLabelKeywordList.Name = "statusLabelKeywordList";
            this.statusLabelKeywordList.Size = new System.Drawing.Size(356, 17);
            this.statusLabelKeywordList.Spring = true;
            this.statusLabelKeywordList.Text = "status";
            this.statusLabelKeywordList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmQuickSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 750);
            this.Controls.Add(this.tabLayoutQuickSearch);
            this.Name = "frmQuickSearch";
            this.Text = "Qucik Search";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuickSearch_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.frmQuickSearch_VisibleChanged);
            this.tabLayoutQuickSearch.ResumeLayout(false);
            this.tabLayoutQuickSearch.PerformLayout();
            this.flowLayoutSearchOptions.ResumeLayout(false);
            this.flowLayoutSearchOptions.PerformLayout();
            this.flowLayoutKeywordType.ResumeLayout(false);
            this.flowLayoutKeywordType.PerformLayout();
            this.toolStripKeywrodList.ResumeLayout(false);
            this.toolStripKeywrodList.PerformLayout();
            this.statusKeywordList.ResumeLayout(false);
            this.statusKeywordList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tabLayoutQuickSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutSearchOptions;
        private System.Windows.Forms.CheckBox chkMatchWord;
        private System.Windows.Forms.CheckBox chkMatchCase;
        private System.Windows.Forms.CheckBox chkWrapSearch;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.CheckBox chkRegExp;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutKeywordType;
        private System.Windows.Forms.ToolStrip toolStripKeywrodList;
        private System.Windows.Forms.ToolStripButton toolBtnAdd;
        private System.Windows.Forms.ToolStripButton toolBtnRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolBtnMoveUp;
        private System.Windows.Forms.ToolStripButton toolBtnMoveDown;
        private System.Windows.Forms.ToolStripButton toolBtnRemoveDuplicate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolBtnOpen;
        private System.Windows.Forms.ToolStripButton toolBtnSaveAs;
        private System.Windows.Forms.ListBox lstKeywords;
        private System.Windows.Forms.StatusStrip statusKeywordList;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelKeywordList;
        private System.Windows.Forms.ToolTip toolTipKeywordList;
        private System.Windows.Forms.ToolStripButton toolBtnReplace;

    }
}