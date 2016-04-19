namespace NppLogGazer.PatternTracer.View
{
    partial class FrmAbout
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
            this.txtAboutInfo = new System.Windows.Forms.TextBox();
            this.btnVisitSite = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAboutInfo
            // 
            this.txtAboutInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAboutInfo.Location = new System.Drawing.Point(12, 12);
            this.txtAboutInfo.Multiline = true;
            this.txtAboutInfo.Name = "txtAboutInfo";
            this.txtAboutInfo.ReadOnly = true;
            this.txtAboutInfo.Size = new System.Drawing.Size(273, 142);
            this.txtAboutInfo.TabIndex = 1;
            this.txtAboutInfo.Text = Properties.Resources.about_info_text;
            // 
            // btnVisitSite
            // 
            this.btnVisitSite.Location = new System.Drawing.Point(13, 226);
            this.btnVisitSite.Name = "btnVisitSite";
            this.btnVisitSite.Size = new System.Drawing.Size(75, 23);
            this.btnVisitSite.TabIndex = 0;
            this.btnVisitSite.Text = "Visit site";
            this.btnVisitSite.UseVisualStyleBackColor = true;
            this.btnVisitSite.Click += new System.EventHandler(this.btnVisitSite_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(210, 226);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 258);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnVisitSite);
            this.Controls.Add(this.txtAboutInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAbout";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAboutInfo;
        private System.Windows.Forms.Button btnVisitSite;
        private System.Windows.Forms.Button btnClose;

    }
}