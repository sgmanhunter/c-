namespace ProjectGroep01.View
{
    partial class RegisterFrame
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
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtBoxFirstname = new System.Windows.Forms.TextBox();
            this.txtBoxLastname = new System.Windows.Forms.TextBox();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.txtBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.rdbtnMale = new System.Windows.Forms.RadioButton();
            this.rdbtnFemale = new System.Windows.Forms.RadioButton();
            this.pnlSex = new System.Windows.Forms.Panel();
            this.lblSex = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlSex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(12, 27);
            this.lblFirstname.Name = "lblVoornaam";
            this.lblFirstname.Size = new System.Drawing.Size(58, 13);
            this.lblFirstname.TabIndex = 0;
            this.lblFirstname.Text = "Voornaam:";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(12, 56);
            this.lblLastname.Name = "lblFamilienaam";
            this.lblLastname.Size = new System.Drawing.Size(68, 13);
            this.lblLastname.TabIndex = 1;
            this.lblLastname.Text = "Familienaam:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(12, 103);
            this.lblUsername.Name = "lblGebruikersnaam";
            this.lblUsername.Size = new System.Drawing.Size(87, 13);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Gebruikersnaam:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 129);
            this.lblPassword.Name = "lblWachtwoord";
            this.lblPassword.Size = new System.Drawing.Size(71, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Wachtwoord:";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(12, 155);
            this.lblConfirmPassword.Name = "lblWachtwoordBevestig";
            this.lblConfirmPassword.Size = new System.Drawing.Size(129, 13);
            this.lblConfirmPassword.TabIndex = 4;
            this.lblConfirmPassword.Text = "Wachtwoord bevestigen: ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 183);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email:";
            // 
            // txtBoxFirstname
            // 
            this.txtBoxFirstname.Location = new System.Drawing.Point(163, 24);
            this.txtBoxFirstname.Name = "txtBoxVoornaam";
            this.txtBoxFirstname.Size = new System.Drawing.Size(140, 20);
            this.txtBoxFirstname.TabIndex = 6;
            // 
            // txtBoxLastname
            // 
            this.txtBoxLastname.Location = new System.Drawing.Point(163, 52);
            this.txtBoxLastname.Name = "txtBoxFamilienaam";
            this.txtBoxLastname.Size = new System.Drawing.Size(140, 20);
            this.txtBoxLastname.TabIndex = 7;
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Location = new System.Drawing.Point(162, 100);
            this.txtBoxUsername.Name = "txtBoxGebruikersnaam";
            this.txtBoxUsername.Size = new System.Drawing.Size(140, 20);
            this.txtBoxUsername.TabIndex = 8;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(164, 126);
            this.txtBoxPassword.Name = "txtBoxWachtwoord";
            this.txtBoxPassword.Size = new System.Drawing.Size(140, 20);
            this.txtBoxPassword.TabIndex = 9;
            this.txtBoxPassword.UseSystemPasswordChar = true;
            // 
            // txtBoxConfirmPassword
            // 
            this.txtBoxConfirmPassword.Location = new System.Drawing.Point(163, 152);
            this.txtBoxConfirmPassword.Name = "txtBoxWachtwoordBevestig";
            this.txtBoxConfirmPassword.Size = new System.Drawing.Size(140, 20);
            this.txtBoxConfirmPassword.TabIndex = 10;
            this.txtBoxConfirmPassword.UseSystemPasswordChar = true;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(162, 180);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(140, 20);
            this.txtBoxEmail.TabIndex = 11;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(15, 246);
            this.btnRegister.Name = "btnRegistreren";
            this.btnRegister.Size = new System.Drawing.Size(139, 26);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "Registreren";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // rdbtnMale
            // 
            this.rdbtnMale.AutoSize = true;
            this.rdbtnMale.Location = new System.Drawing.Point(3, 0);
            this.rdbtnMale.Name = "rdbtnMan";
            this.rdbtnMale.Size = new System.Drawing.Size(34, 17);
            this.rdbtnMale.TabIndex = 15;
            this.rdbtnMale.TabStop = true;
            this.rdbtnMale.Text = "M";
            this.rdbtnMale.UseVisualStyleBackColor = true;
            // 
            // rdbtnFemale
            // 
            this.rdbtnFemale.AutoSize = true;
            this.rdbtnFemale.Location = new System.Drawing.Point(55, 0);
            this.rdbtnFemale.Name = "rdbtnVrouw";
            this.rdbtnFemale.Size = new System.Drawing.Size(32, 17);
            this.rdbtnFemale.TabIndex = 15;
            this.rdbtnFemale.TabStop = true;
            this.rdbtnFemale.Text = "V";
            this.rdbtnFemale.UseVisualStyleBackColor = true;
            // 
            // pnlSex
            // 
            this.pnlSex.Controls.Add(this.rdbtnMale);
            this.pnlSex.Controls.Add(this.rdbtnFemale);
            this.pnlSex.Location = new System.Drawing.Point(164, 206);
            this.pnlSex.Name = "pnlGeslacht";
            this.pnlSex.Size = new System.Drawing.Size(139, 20);
            this.pnlSex.TabIndex = 16;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(12, 213);
            this.lblSex.Name = "lblGeslacht";
            this.lblSex.Size = new System.Drawing.Size(52, 13);
            this.lblSex.TabIndex = 17;
            this.lblSex.Text = "Geslacht:";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(162, 75);
            this.dtpDateOfBirth.MaxDate = System.DateTime.Now;
            this.dtpDateOfBirth.Name = "dTPgeboortedatum";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(138, 20);
            this.dtpDateOfBirth.TabIndex = 18;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(12, 81);
            this.lblDateOfBirth.Name = "lblGeboortedatum";
            this.lblDateOfBirth.Size = new System.Drawing.Size(83, 13);
            this.lblDateOfBirth.TabIndex = 19;
            this.lblDateOfBirth.Text = "Geboortedatum:";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(163, 246);
            this.btnCancel.Name = "btnAnnuleren";
            this.btnCancel.Size = new System.Drawing.Size(139, 26);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Annuleren";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // RegisterFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 344);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.pnlSex);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.txtBoxConfirmPassword);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxUsername);
            this.Controls.Add(this.txtBoxLastname);
            this.Controls.Add(this.txtBoxFirstname);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lblFirstname);
            this.Name = "RegistreerFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registreren";
            this.pnlSex.ResumeLayout(false);
            this.pnlSex.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtBoxFirstname;
        private System.Windows.Forms.TextBox txtBoxLastname;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.TextBox txtBoxConfirmPassword;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.RadioButton rdbtnMale;
        private System.Windows.Forms.RadioButton rdbtnFemale;
        private System.Windows.Forms.Panel pnlSex;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnCancel;
    }
}