namespace ProjectGroep01.View
{
    partial class UitschrijvenEventForm
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
            this.chklstbxUitschrijven = new System.Windows.Forms.CheckedListBox();
            this.btnUitschrijven = new System.Windows.Forms.Button();
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chklstbxUitschrijven
            // 
            this.chklstbxUitschrijven.FormattingEnabled = true;
            this.chklstbxUitschrijven.Location = new System.Drawing.Point(18, 22);
            this.chklstbxUitschrijven.Name = "chklstbxUitschrijven";
            this.chklstbxUitschrijven.Size = new System.Drawing.Size(238, 109);
            this.chklstbxUitschrijven.TabIndex = 0;
            // 
            // btnUitschrijven
            // 
            this.btnUitschrijven.Location = new System.Drawing.Point(18, 136);
            this.btnUitschrijven.Name = "btnUitschrijven";
            this.btnUitschrijven.Size = new System.Drawing.Size(97, 29);
            this.btnUitschrijven.TabIndex = 1;
            this.btnUitschrijven.Text = "Uitschrijven";
            this.btnUitschrijven.UseVisualStyleBackColor = true;
            this.btnUitschrijven.Click += new System.EventHandler(this.btnUitschrijven_Click);
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.Location = new System.Drawing.Point(159, 137);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(97, 29);
            this.btnAnnuleren.TabIndex = 2;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = true;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // UitschrijvenEventForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 177);
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.btnUitschrijven);
            this.Controls.Add(this.chklstbxUitschrijven);
            this.Name = "UitschrijvenEventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uitschrijven";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chklstbxUitschrijven;
        private System.Windows.Forms.Button btnUitschrijven;
        private System.Windows.Forms.Button btnAnnuleren;
    }
}