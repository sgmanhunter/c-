namespace ProjectGroep01.View
{
    partial class WriteOutEventForm
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
            this.chklstbxWriteOut = new System.Windows.Forms.CheckedListBox();
            this.btnWriteOut = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chklstbxWriteOut
            // 
            this.chklstbxWriteOut.FormattingEnabled = true;
            this.chklstbxWriteOut.Location = new System.Drawing.Point(18, 22);
            this.chklstbxWriteOut.Name = "chklstbxUitschrijven";
            this.chklstbxWriteOut.Size = new System.Drawing.Size(238, 109);
            this.chklstbxWriteOut.TabIndex = 0;
            // 
            // btnWriteOut
            // 
            this.btnWriteOut.Location = new System.Drawing.Point(18, 136);
            this.btnWriteOut.Name = "btnUitschrijven";
            this.btnWriteOut.Size = new System.Drawing.Size(97, 29);
            this.btnWriteOut.TabIndex = 1;
            this.btnWriteOut.Text = "Uitschrijven";
            this.btnWriteOut.UseVisualStyleBackColor = true;
            this.btnWriteOut.Click += new System.EventHandler(this.btnWriteOut_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(159, 137);
            this.btnCancel.Name = "btnAnnuleren";
            this.btnCancel.Size = new System.Drawing.Size(97, 29);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Annuleren";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // WriteOutEventForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 177);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnWriteOut);
            this.Controls.Add(this.chklstbxWriteOut);
            this.Name = "UitschrijvenEventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uitschrijven";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chklstbxWriteOut;
        private System.Windows.Forms.Button btnWriteOut;
        private System.Windows.Forms.Button btnCancel;
    }
}