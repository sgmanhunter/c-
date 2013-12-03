namespace ProjectGroep01.View
{
    partial class InschrijvenForm
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
            this.chklstbxInschrijven = new System.Windows.Forms.CheckedListBox();
            this.btnInschrijven = new System.Windows.Forms.Button();
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chklstbxInschrijven
            // 
            this.chklstbxInschrijven.FormattingEnabled = true;
            this.chklstbxInschrijven.Location = new System.Drawing.Point(18, 22);
            this.chklstbxInschrijven.Name = "chklstbxInschrijven";
            this.chklstbxInschrijven.Size = new System.Drawing.Size(238, 109);
            this.chklstbxInschrijven.TabIndex = 0;
            // 
            // btnInschrijven
            // 
            this.btnInschrijven.Location = new System.Drawing.Point(12, 137);
            this.btnInschrijven.Name = "btnInschrijven";
            this.btnInschrijven.Size = new System.Drawing.Size(97, 29);
            this.btnInschrijven.TabIndex = 1;
            this.btnInschrijven.Text = "Inschrijven";
            this.btnInschrijven.UseVisualStyleBackColor = true;
            this.btnInschrijven.Click += new System.EventHandler(this.btnInschrijven_Click);
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
            // InschrijvenForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 177);
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.btnInschrijven);
            this.Controls.Add(this.chklstbxInschrijven);
            this.Name = "InschrijvenForm";
            this.Text = "Inschrijven";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chklstbxInschrijven;
        private System.Windows.Forms.Button btnInschrijven;
        private System.Windows.Forms.Button btnAnnuleren;
    }
}