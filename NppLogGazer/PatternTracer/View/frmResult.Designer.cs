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
            this.flowButton = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.tabResult = new System.Windows.Forms.TableLayoutPanel();
            this.rtxtResult = new System.Windows.Forms.RichTextBox();
            this.flowButton.SuspendLayout();
            this.tabResult.SuspendLayout();
            this.SuspendLayout();
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
            // tabResult
            // 
            this.tabResult.ColumnCount = 1;
            this.tabResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabResult.Controls.Add(this.flowButton, 0, 1);
            this.tabResult.Controls.Add(this.rtxtResult, 0, 0);
            this.tabResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabResult.Location = new System.Drawing.Point(0, 0);
            this.tabResult.Name = "tabResult";
            this.tabResult.RowCount = 2;
            this.tabResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabResult.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabResult.Size = new System.Drawing.Size(524, 317);
            this.tabResult.TabIndex = 0;
            // 
            // rtxtResult
            // 
            this.rtxtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtResult.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtResult.Location = new System.Drawing.Point(3, 3);
            this.rtxtResult.Name = "rtxtResult";
            this.rtxtResult.ReadOnly = true;
            this.rtxtResult.Size = new System.Drawing.Size(518, 276);
            this.rtxtResult.TabIndex = 2;
            this.rtxtResult.Text = "";
            this.rtxtResult.WordWrap = false;
            // 
            // FrmResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 317);
            this.Controls.Add(this.tabResult);
            this.Icon = global::NppLogGazer.Properties.Resources.pattern_tracer_icon;
            this.Name = "FrmResult";
            this.Text = "Result";
            this.flowButton.ResumeLayout(false);
            this.tabResult.ResumeLayout(false);
            this.tabResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowButton;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TableLayoutPanel tabResult;
        private System.Windows.Forms.RichTextBox rtxtResult;

    }
}