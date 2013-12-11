namespace ProjectGroep01.View
{
    partial class RapportForm
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
            this.reportViewerEvents = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewerEvents.LocalReport.ReportEmbeddedResource = "ProjectGroep01.Rapporten.ReportEvents.rdlc";
            this.reportViewerEvents.Location = new System.Drawing.Point(3, 3);
            this.reportViewerEvents.Name = "reportViewer1";
            this.reportViewerEvents.Size = new System.Drawing.Size(721, 470);
            this.reportViewerEvents.TabIndex = 0;
            // 
            // RapportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 473);
            this.Controls.Add(this.reportViewerEvents);
            this.Name = "RapportForm";
            this.Text = "RapportForm";
            this.Load += new System.EventHandler(this.RapportForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerEvents;
    }
}