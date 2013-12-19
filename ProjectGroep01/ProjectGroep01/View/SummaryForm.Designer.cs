namespace ProjectGroep01.View
{
    partial class SummaryForm
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
            this.txtBoxEvent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxEvent
            // 
            this.txtBoxEvent.Location = new System.Drawing.Point(-4, 0);
            this.txtBoxEvent.Multiline = true;
            this.txtBoxEvent.Name = "txtBoxEvent";
            this.txtBoxEvent.Size = new System.Drawing.Size(765, 266);
            this.txtBoxEvent.TabIndex = 0;
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 267);
            this.Controls.Add(this.txtBoxEvent);
            this.Name = "OverzichtForm";
            this.Text = "Overzicht van Evenementen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxEvent;
    }
}