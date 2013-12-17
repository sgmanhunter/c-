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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cSGroep01DataSet = new ProjectGroep01.Data.Databank.CSGroep01DataSet();
            this.cSGroep01DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventsTableAdapter = new ProjectGroep01.Data.Databank.CSGroep01DataSetTableAdapters.eventsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cSGroep01DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSGroep01DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "csGroep01DataSet";
            reportDataSource1.Value = this.eventsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjectGroep01.Data.Databank.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 5);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(816, 451);
            this.reportViewer1.TabIndex = 0;
            // 
            // cSGroep01DataSet
            // 
            this.cSGroep01DataSet.DataSetName = "CSGroep01DataSet";
            this.cSGroep01DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cSGroep01DataSetBindingSource
            // 
            this.cSGroep01DataSetBindingSource.DataSource = this.cSGroep01DataSet;
            this.cSGroep01DataSetBindingSource.Position = 0;
            // 
            // eventsBindingSource
            // 
            this.eventsBindingSource.DataMember = "events";
            this.eventsBindingSource.DataSource = this.cSGroep01DataSetBindingSource;
            // 
            // eventsTableAdapter
            // 
            this.eventsTableAdapter.ClearBeforeFill = true;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 452);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportForm";
            this.Text = "Rapporten";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cSGroep01DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSGroep01DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Data.Databank.CSGroep01DataSet cSGroep01DataSet;
        private System.Windows.Forms.BindingSource cSGroep01DataSetBindingSource;
        private System.Windows.Forms.BindingSource eventsBindingSource;
        private Data.Databank.CSGroep01DataSetTableAdapters.eventsTableAdapter eventsTableAdapter;

    }
}