namespace NppLogGazer.PatternTracer.View
{
    partial class FrmResult
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
            this.tabResult = new System.Windows.Forms.TableLayoutPanel();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.flowButton = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.Icon = Properties.Resources.pattern_tracer_icon;
            this.tabResult.SuspendLayout();
            this.flowButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabResult
            // 
            this.tabResult.ColumnCount = 1;
            this.tabResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabResult.Controls.Add(this.txtResult, 0, 0);
            this.tabResult.Controls.Add(this.flowButton, 0, 1);
            this.tabResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabResult.Location = new System.Drawing.Point(0, 0);
            this.tabResult.Name = "tabResult";
            this.tabResult.RowCount = 2;
            this.tabResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabResult.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabResult.Size = new System.Drawing.Size(524, 317);
            this.tabResult.TabIndex = 0;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.Window;
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Location = new System.Drawing.Point(3, 3);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(518, 276);
            this.txtResult.TabIndex = 0;
            // 
            // flowButton
            // 
            this.flowButton.AutoSize = true;
            this.flowButton.Controls.Add(this.btnClose);
            this.flowButton.Controls.Add(this.btnCopy);
            this.flowButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowButton.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowButton.Location = new System.Drawing.Point(3, 285);
            this.flowButton.Name = "flowButton";
            this.flowButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowButton.Size = new System.Drawing.Size(518, 29);
            this.flowButton.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(440, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(359, 3);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 1;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // frmResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 317);
            this.Controls.Add(this.tabResult);
            this.Name = "frmResult";
            this.Text = "frmResult";
            this.tabResult.ResumeLayout(false);
            this.tabResult.PerformLayout();
            this.flowButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tabResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.FlowLayoutPanel flowButton;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCopy;
    }
}