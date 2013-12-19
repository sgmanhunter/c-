namespace ProjectGroep01.View
{
    partial class InscribeEventForm
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
            this.chklstbxInscribe = new System.Windows.Forms.CheckedListBox();
            this.btnInscribe = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chklstbxInscribe
            // 
            this.chklstbxInscribe.FormattingEnabled = true;
            this.chklstbxInscribe.Location = new System.Drawing.Point(18, 22);
            this.chklstbxInscribe.Name = "chklstbxInschrijven";
            this.chklstbxInscribe.Size = new System.Drawing.Size(238, 109);
            this.chklstbxInscribe.TabIndex = 0;
            // 
            // btnInscribe
            // 
            this.btnInscribe.Location = new System.Drawing.Point(12, 137);
            this.btnInscribe.Name = "btnInschrijven";
            this.btnInscribe.Size = new System.Drawing.Size(97, 29);
            this.btnInscribe.TabIndex = 1;
            this.btnInscribe.Text = "Inschrijven";
            this.btnInscribe.UseVisualStyleBackColor = true;
            this.btnInscribe.Click += new System.EventHandler(this.btnInschrijven_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(159, 137);
            this.btnCancel.Name = "btnAnnuleren";
            this.btnCancel.Size = new System.Drawing.Size(97, 29);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Annuleren";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // InscribeEventForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 177);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInscribe);
            this.Controls.Add(this.chklstbxInscribe);
            this.Name = "InschrijvenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inschrijven";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chklstbxInscribe;
        private System.Windows.Forms.Button btnInscribe;
        private System.Windows.Forms.Button btnCancel;
    }
}