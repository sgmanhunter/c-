namespace ProjectGroep01.View
{
    partial class ReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.eventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cSGroep01DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cSGroep01DataSet = new ProjectGroep01.Data.Database.CSGroep01DataSet();
            this.eventsTableAdapter = new ProjectGroep01.Data.Database.CSGroep01DataSetTableAdapters.eventsTableAdapter();
            this.rpvFreeEvents = new Microsoft.Reporting.WinForms.ReportViewer();
            this.eventsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSGroep01DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSGroep01DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // eventsBindingSource
            // 
            this.eventsBindingSource.DataMember = "events";
            this.eventsBindingSource.DataSource = this.cSGroep01DataSetBindingSource;
            // 
            // cSGroep01DataSetBindingSource
            // 
            this.cSGroep01DataSetBindingSource.DataSource = this.cSGroep01DataSet;
            this.cSGroep01DataSetBindingSource.Position = 0;
            // 
            // cSGroep01DataSet
            // 
            this.cSGroep01DataSet.DataSetName = "CSGroep01DataSet";
            this.cSGroep01DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventsTableAdapter
            // 
            this.eventsTableAdapter.ClearBeforeFill = true;
            // 
            // rpvFreeEvents
            // 
            reportDataSource1.Name = "cSGroep01DataSet";
            reportDataSource1.Value = this.eventsBindingSource;
            this.rpvFreeEvents.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvFreeEvents.LocalReport.ReportEmbeddedResource = "ProjectGroep01.Reports.ReportFreeEvents.rdlc";
            this.rpvFreeEvents.Location = new System.Drawing.Point(1, 0);
            this.rpvFreeEvents.Name = "rpvFreeEvents";
            this.rpvFreeEvents.Size = new System.Drawing.Size(814, 454);
            this.rpvFreeEvents.TabIndex = 0;
            // 
            // eventsBindingSource1
            // 
            this.eventsBindingSource1.DataMember = "events";
            this.eventsBindingSource1.DataSource = this.cSGroep01DataSetBindingSource;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 452);
            this.Controls.Add(this.rpvFreeEvents);
            this.Name = "ReportForm";
            this.Text = "Rapporten";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSGroep01DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSGroep01DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Data.Database.CSGroep01DataSet cSGroep01DataSet;
        private System.Windows.Forms.BindingSource cSGroep01DataSetBindingSource;
        private System.Windows.Forms.BindingSource eventsBindingSource;
        private Data.Database.CSGroep01DataSetTableAdapters.eventsTableAdapter eventsTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rpvFreeEvents;
        private System.Windows.Forms.BindingSource eventsBindingSource1;

    }
}