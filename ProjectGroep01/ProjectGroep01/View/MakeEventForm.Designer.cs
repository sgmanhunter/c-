namespace ProjectGroep01.View
{
    partial class MakeEventForm
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
            this.lblEventName = new System.Windows.Forms.Label();
            this.lblStreetname = new System.Windows.Forms.Label();
            this.lblHousenumber = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblNumberOfPlaces = new System.Windows.Forms.Label();
            this.txtBoxEventName = new System.Windows.Forms.TextBox();
            this.txtBoxStreetname = new System.Windows.Forms.TextBox();
            this.txtBoxHousenumber = new System.Windows.Forms.TextBox();
            this.txtBoxCity = new System.Windows.Forms.TextBox();
            this.txtBoxNumberOfPlaces = new System.Windows.Forms.TextBox();
            this.btnMake = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Location = new System.Drawing.Point(6, 31);
            this.lblEventName.Name = "lblEventNaam";
            this.lblEventName.Size = new System.Drawing.Size(38, 13);
            this.lblEventName.TabIndex = 0;
            this.lblEventName.Text = "Naam:";
            // 
            // lblStreetname
            // 
            this.lblStreetname.AutoSize = true;
            this.lblStreetname.Location = new System.Drawing.Point(6, 83);
            this.lblStreetname.Name = "lblStraatNaam";
            this.lblStreetname.Size = new System.Drawing.Size(64, 13);
            this.lblStreetname.TabIndex = 1;
            this.lblStreetname.Text = "Straatnaam:";
            // 
            // lblHousenumber
            // 
            this.lblHousenumber.AutoSize = true;
            this.lblHousenumber.Location = new System.Drawing.Point(6, 109);
            this.lblHousenumber.Name = "lblHuisnummer";
            this.lblHousenumber.Size = new System.Drawing.Size(68, 13);
            this.lblHousenumber.TabIndex = 2;
            this.lblHousenumber.Text = "Huisnummer:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(6, 135);
            this.lblCity.Name = "lblStad";
            this.lblCity.Size = new System.Drawing.Size(29, 13);
            this.lblCity.TabIndex = 3;
            this.lblCity.Text = "Stad";
            // 
            // lblNumberOfPlaces
            // 
            this.lblNumberOfPlaces.AutoSize = true;
            this.lblNumberOfPlaces.Location = new System.Drawing.Point(6, 161);
            this.lblNumberOfPlaces.Name = "lblAantalPlaatsen";
            this.lblNumberOfPlaces.Size = new System.Drawing.Size(84, 13);
            this.lblNumberOfPlaces.TabIndex = 4;
            this.lblNumberOfPlaces.Text = "Aantal Plaatsen:";
            // 
            // txtBoxEventName
            // 
            this.txtBoxEventName.Location = new System.Drawing.Point(120, 28);
            this.txtBoxEventName.Name = "txtBoxEventNaam";
            this.txtBoxEventName.Size = new System.Drawing.Size(155, 20);
            this.txtBoxEventName.TabIndex = 6;
            // 
            // txtBoxStreetname
            // 
            this.txtBoxStreetname.Location = new System.Drawing.Point(120, 80);
            this.txtBoxStreetname.Name = "txtBoxStraatNaam";
            this.txtBoxStreetname.Size = new System.Drawing.Size(155, 20);
            this.txtBoxStreetname.TabIndex = 7;
            // 
            // txtBoxHousenumber
            // 
            this.txtBoxHousenumber.Location = new System.Drawing.Point(120, 106);
            this.txtBoxHousenumber.Name = "txtBoxHuisnummer";
            this.txtBoxHousenumber.Size = new System.Drawing.Size(155, 20);
            this.txtBoxHousenumber.TabIndex = 8;
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.Location = new System.Drawing.Point(120, 132);
            this.txtBoxCity.Name = "txtBoxStad";
            this.txtBoxCity.Size = new System.Drawing.Size(155, 20);
            this.txtBoxCity.TabIndex = 9;
            // 
            // txtBoxNumberOfPlaces
            // 
            this.txtBoxNumberOfPlaces.Location = new System.Drawing.Point(120, 158);
            this.txtBoxNumberOfPlaces.Name = "txtBoxAantalPlaatsen";
            this.txtBoxNumberOfPlaces.Size = new System.Drawing.Size(155, 20);
            this.txtBoxNumberOfPlaces.TabIndex = 10;
            this.txtBoxNumberOfPlaces.Text = "30";
            this.txtBoxNumberOfPlaces.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnMake
            // 
            this.btnMake.Location = new System.Drawing.Point(9, 210);
            this.btnMake.Name = "btnAanmaken";
            this.btnMake.Size = new System.Drawing.Size(105, 21);
            this.btnMake.TabIndex = 12;
            this.btnMake.Text = "Aanmaken";
            this.btnMake.UseVisualStyleBackColor = true;
            this.btnMake.Click += new System.EventHandler(this.btnAanmaken_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(120, 210);
            this.btnCancel.Name = "btnAnnuleren";
            this.btnCancel.Size = new System.Drawing.Size(105, 21);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Annuleren";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(120, 54);
            this.dtpDate.Name = "dtpDatum";
            this.dtpDate.Size = new System.Drawing.Size(155, 20);
            this.dtpDate.TabIndex = 14;
            this.dtpDate.Value = System.DateTime.Now;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(6, 60);
            this.lblDate.Name = "lblDatum";
            this.lblDate.Size = new System.Drawing.Size(41, 13);
            this.lblDate.TabIndex = 15;
            this.lblDate.Text = "Datum:";
            // 
            // MakeEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 291);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnMake);
            this.Controls.Add(this.txtBoxNumberOfPlaces);
            this.Controls.Add(this.txtBoxCity);
            this.Controls.Add(this.txtBoxHousenumber);
            this.Controls.Add(this.txtBoxStreetname);
            this.Controls.Add(this.txtBoxEventName);
            this.Controls.Add(this.lblNumberOfPlaces);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblHousenumber);
            this.Controls.Add(this.lblStreetname);
            this.Controls.Add(this.lblEventName);
            this.Name = "AanmaakEventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maak een Event aan";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label lblStreetname;
        private System.Windows.Forms.Label lblHousenumber;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblNumberOfPlaces;
        private System.Windows.Forms.TextBox txtBoxEventName;
        private System.Windows.Forms.TextBox txtBoxStreetname;
        private System.Windows.Forms.TextBox txtBoxHousenumber;
        private System.Windows.Forms.TextBox txtBoxCity;
        private System.Windows.Forms.TextBox txtBoxNumberOfPlaces;
        private System.Windows.Forms.Button btnMake;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}