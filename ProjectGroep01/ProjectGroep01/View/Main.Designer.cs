﻿namespace ProjectGroep01.View
{
    partial class Main
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
            this.grpBoxOverzicht = new System.Windows.Forms.GroupBox();
            this.btnOverzicht = new System.Windows.Forms.Button();
            this.rdbtnOverzichtHistorie = new System.Windows.Forms.RadioButton();
            this.rdbOverzichtEventVrij = new System.Windows.Forms.RadioButton();
            this.rdbtnOverzichtEventVolzet = new System.Windows.Forms.RadioButton();
            this.grpBoxRapport = new System.Windows.Forms.GroupBox();
            this.btnRapport = new System.Windows.Forms.Button();
            this.rdbRapportStatistiek = new System.Windows.Forms.RadioButton();
            this.rdbtnRapportEventVrij = new System.Windows.Forms.RadioButton();
            this.grpBoxLogin = new System.Windows.Forms.GroupBox();
            this.btnRegistreren = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblPasswoord = new System.Windows.Forms.Label();
            this.lblGebruikersnaam = new System.Windows.Forms.Label();
            this.txtBoxWachtwoord = new System.Windows.Forms.TextBox();
            this.txtBoxGebruikersnaam = new System.Windows.Forms.TextBox();
            this.grpBoxLoggedIn = new System.Windows.Forms.GroupBox();
            this.btnAfmelden = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.rdbInschrijvenEvent = new System.Windows.Forms.RadioButton();
            this.rdbUItschrijvenEvent = new System.Windows.Forms.RadioButton();
            this.rdbtnAanmakenEvent = new System.Windows.Forms.RadioButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpBoxOverzicht.SuspendLayout();
            this.grpBoxRapport.SuspendLayout();
            this.grpBoxLogin.SuspendLayout();
            this.grpBoxLoggedIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxOverzicht
            // 
            this.grpBoxOverzicht.Controls.Add(this.btnOverzicht);
            this.grpBoxOverzicht.Controls.Add(this.rdbtnOverzichtHistorie);
            this.grpBoxOverzicht.Controls.Add(this.rdbOverzichtEventVrij);
            this.grpBoxOverzicht.Controls.Add(this.rdbtnOverzichtEventVolzet);
            this.grpBoxOverzicht.Location = new System.Drawing.Point(12, 192);
            this.grpBoxOverzicht.Name = "grpBoxOverzicht";
            this.grpBoxOverzicht.Size = new System.Drawing.Size(200, 152);
            this.grpBoxOverzicht.TabIndex = 0;
            this.grpBoxOverzicht.TabStop = false;
            this.grpBoxOverzicht.Text = "Overzicht";
            // 
            // btnOverzicht
            // 
            this.btnOverzicht.Location = new System.Drawing.Point(22, 98);
            this.btnOverzicht.Name = "btnOverzicht";
            this.btnOverzicht.Size = new System.Drawing.Size(138, 23);
            this.btnOverzicht.TabIndex = 3;
            this.btnOverzicht.Text = "Overzicht";
            this.btnOverzicht.UseVisualStyleBackColor = true;
            // 
            // rdbtnOverzichtHistorie
            // 
            this.rdbtnOverzichtHistorie.AutoSize = true;
            this.rdbtnOverzichtHistorie.Location = new System.Drawing.Point(22, 75);
            this.rdbtnOverzichtHistorie.Name = "rdbtnOverzichtHistorie";
            this.rdbtnOverzichtHistorie.Size = new System.Drawing.Size(138, 17);
            this.rdbtnOverzichtHistorie.TabIndex = 2;
            this.rdbtnOverzichtHistorie.TabStop = true;
            this.rdbtnOverzichtHistorie.Text = "Eventen in het verleden";
            this.rdbtnOverzichtHistorie.UseVisualStyleBackColor = true;
            // 
            // rdbOverzichtEventVrij
            // 
            this.rdbOverzichtEventVrij.AutoSize = true;
            this.rdbOverzichtEventVrij.Location = new System.Drawing.Point(22, 52);
            this.rdbOverzichtEventVrij.Name = "rdbOverzichtEventVrij";
            this.rdbOverzichtEventVrij.Size = new System.Drawing.Size(88, 17);
            this.rdbOverzichtEventVrij.TabIndex = 1;
            this.rdbOverzichtEventVrij.TabStop = true;
            this.rdbOverzichtEventVrij.Text = "Vrije Eventen";
            this.rdbOverzichtEventVrij.UseVisualStyleBackColor = true;
            // 
            // rdbtnOverzichtEventVolzet
            // 
            this.rdbtnOverzichtEventVolzet.AutoSize = true;
            this.rdbtnOverzichtEventVolzet.Location = new System.Drawing.Point(22, 29);
            this.rdbtnOverzichtEventVolzet.Name = "rdbtnOverzichtEventVolzet";
            this.rdbtnOverzichtEventVolzet.Size = new System.Drawing.Size(105, 17);
            this.rdbtnOverzichtEventVolzet.TabIndex = 0;
            this.rdbtnOverzichtEventVolzet.TabStop = true;
            this.rdbtnOverzichtEventVolzet.Text = "Volzette eventen";
            this.rdbtnOverzichtEventVolzet.UseVisualStyleBackColor = true;
            // 
            // grpBoxRapport
            // 
            this.grpBoxRapport.Controls.Add(this.btnRapport);
            this.grpBoxRapport.Controls.Add(this.rdbRapportStatistiek);
            this.grpBoxRapport.Controls.Add(this.rdbtnRapportEventVrij);
            this.grpBoxRapport.Location = new System.Drawing.Point(239, 192);
            this.grpBoxRapport.Name = "grpBoxRapport";
            this.grpBoxRapport.Size = new System.Drawing.Size(200, 152);
            this.grpBoxRapport.TabIndex = 2;
            this.grpBoxRapport.TabStop = false;
            this.grpBoxRapport.Text = "Rapporten";
            // 
            // btnRapport
            // 
            this.btnRapport.Location = new System.Drawing.Point(14, 98);
            this.btnRapport.Name = "btnRapport";
            this.btnRapport.Size = new System.Drawing.Size(138, 23);
            this.btnRapport.TabIndex = 3;
            this.btnRapport.Text = "Rapport";
            this.btnRapport.UseVisualStyleBackColor = true;
            // 
            // rdbRapportStatistiek
            // 
            this.rdbRapportStatistiek.AutoSize = true;
            this.rdbRapportStatistiek.Location = new System.Drawing.Point(14, 52);
            this.rdbRapportStatistiek.Name = "rdbRapportStatistiek";
            this.rdbRapportStatistiek.Size = new System.Drawing.Size(80, 17);
            this.rdbRapportStatistiek.TabIndex = 2;
            this.rdbRapportStatistiek.TabStop = true;
            this.rdbRapportStatistiek.Text = "Statistieken";
            this.rdbRapportStatistiek.UseVisualStyleBackColor = true;
            // 
            // rdbtnRapportEventVrij
            // 
            this.rdbtnRapportEventVrij.AutoSize = true;
            this.rdbtnRapportEventVrij.Location = new System.Drawing.Point(14, 29);
            this.rdbtnRapportEventVrij.Name = "rdbtnRapportEventVrij";
            this.rdbtnRapportEventVrij.Size = new System.Drawing.Size(88, 17);
            this.rdbtnRapportEventVrij.TabIndex = 1;
            this.rdbtnRapportEventVrij.TabStop = true;
            this.rdbtnRapportEventVrij.Text = "Vrije Eventen";
            this.rdbtnRapportEventVrij.UseVisualStyleBackColor = true;
            // 
            // grpBoxLogin
            // 
            this.grpBoxLogin.Controls.Add(this.btnRegistreren);
            this.grpBoxLogin.Controls.Add(this.btnLogin);
            this.grpBoxLogin.Controls.Add(this.lblPasswoord);
            this.grpBoxLogin.Controls.Add(this.lblGebruikersnaam);
            this.grpBoxLogin.Controls.Add(this.txtBoxWachtwoord);
            this.grpBoxLogin.Controls.Add(this.txtBoxGebruikersnaam);
            this.grpBoxLogin.Location = new System.Drawing.Point(19, 24);
            this.grpBoxLogin.Name = "grpBoxLogin";
            this.grpBoxLogin.Size = new System.Drawing.Size(419, 158);
            this.grpBoxLogin.TabIndex = 3;
            this.grpBoxLogin.TabStop = false;
            this.grpBoxLogin.Text = "Login";
            // 
            // btnRegistreren
            // 
            this.btnRegistreren.Location = new System.Drawing.Point(126, 106);
            this.btnRegistreren.Name = "btnRegistreren";
            this.btnRegistreren.Size = new System.Drawing.Size(149, 23);
            this.btnRegistreren.TabIndex = 5;
            this.btnRegistreren.Text = "Registreren";
            this.btnRegistreren.UseVisualStyleBackColor = true;
            this.btnRegistreren.Click += new System.EventHandler(this.btnRegistreren_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(126, 77);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(149, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblPasswoord
            // 
            this.lblPasswoord.AutoSize = true;
            this.lblPasswoord.Location = new System.Drawing.Point(33, 54);
            this.lblPasswoord.Name = "lblPasswoord";
            this.lblPasswoord.Size = new System.Drawing.Size(68, 13);
            this.lblPasswoord.TabIndex = 3;
            this.lblPasswoord.Text = "Wachtwoord";
            // 
            // lblGebruikersnaam
            // 
            this.lblGebruikersnaam.AutoSize = true;
            this.lblGebruikersnaam.Location = new System.Drawing.Point(33, 28);
            this.lblGebruikersnaam.Name = "lblGebruikersnaam";
            this.lblGebruikersnaam.Size = new System.Drawing.Size(87, 13);
            this.lblGebruikersnaam.TabIndex = 2;
            this.lblGebruikersnaam.Text = "Gebruikersnaam:";
            // 
            // txtBoxWachtwoord
            // 
            this.txtBoxWachtwoord.Location = new System.Drawing.Point(126, 51);
            this.txtBoxWachtwoord.Name = "txtBoxWachtwoord";
            this.txtBoxWachtwoord.Size = new System.Drawing.Size(150, 20);
            this.txtBoxWachtwoord.TabIndex = 1;
            this.txtBoxWachtwoord.UseSystemPasswordChar = true;
            // 
            // txtBoxGebruikersnaam
            // 
            this.txtBoxGebruikersnaam.Location = new System.Drawing.Point(126, 25);
            this.txtBoxGebruikersnaam.Name = "txtBoxGebruikersnaam";
            this.txtBoxGebruikersnaam.Size = new System.Drawing.Size(150, 20);
            this.txtBoxGebruikersnaam.TabIndex = 0;
            // 
            // grpBoxLoggedIn
            // 
            this.grpBoxLoggedIn.Controls.Add(this.btnAfmelden);
            this.grpBoxLoggedIn.Controls.Add(this.btnGo);
            this.grpBoxLoggedIn.Controls.Add(this.rdbInschrijvenEvent);
            this.grpBoxLoggedIn.Controls.Add(this.rdbUItschrijvenEvent);
            this.grpBoxLoggedIn.Controls.Add(this.rdbtnAanmakenEvent);
            this.grpBoxLoggedIn.Location = new System.Drawing.Point(20, 18);
            this.grpBoxLoggedIn.Name = "grpBoxLoggedIn";
            this.grpBoxLoggedIn.Size = new System.Drawing.Size(419, 158);
            this.grpBoxLoggedIn.TabIndex = 5;
            this.grpBoxLoggedIn.TabStop = false;
            this.grpBoxLoggedIn.Text = "Welkom";
            // 
            // btnAfmelden
            // 
            this.btnAfmelden.Location = new System.Drawing.Point(278, 127);
            this.btnAfmelden.Name = "btnAfmelden";
            this.btnAfmelden.Size = new System.Drawing.Size(135, 25);
            this.btnAfmelden.TabIndex = 4;
            this.btnAfmelden.Text = "Afmelden";
            this.btnAfmelden.UseVisualStyleBackColor = true;
            this.btnAfmelden.Click += new System.EventHandler(this.btnAfmelden_Click);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(24, 96);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(133, 25);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "Go!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // rdbInschrijvenEvent
            // 
            this.rdbInschrijvenEvent.AutoSize = true;
            this.rdbInschrijvenEvent.Location = new System.Drawing.Point(26, 50);
            this.rdbInschrijvenEvent.Name = "rdbInschrijvenEvent";
            this.rdbInschrijvenEvent.Size = new System.Drawing.Size(131, 17);
            this.rdbInschrijvenEvent.TabIndex = 2;
            this.rdbInschrijvenEvent.TabStop = true;
            this.rdbInschrijvenEvent.Text = "Inschrijven voor Event";
            this.rdbInschrijvenEvent.UseVisualStyleBackColor = true;
            // 
            // rdbUItschrijvenEvent
            // 
            this.rdbUItschrijvenEvent.AutoSize = true;
            this.rdbUItschrijvenEvent.Location = new System.Drawing.Point(26, 73);
            this.rdbUItschrijvenEvent.Name = "rdbUItschrijvenEvent";
            this.rdbUItschrijvenEvent.Size = new System.Drawing.Size(134, 17);
            this.rdbUItschrijvenEvent.TabIndex = 1;
            this.rdbUItschrijvenEvent.TabStop = true;
            this.rdbUItschrijvenEvent.Text = "Uitschrijven voor event";
            this.rdbUItschrijvenEvent.UseVisualStyleBackColor = true;
            // 
            // rdbtnAanmakenEvent
            // 
            this.rdbtnAanmakenEvent.AutoSize = true;
            this.rdbtnAanmakenEvent.Location = new System.Drawing.Point(26, 27);
            this.rdbtnAanmakenEvent.Name = "rdbtnAanmakenEvent";
            this.rdbtnAanmakenEvent.Size = new System.Drawing.Size(106, 17);
            this.rdbtnAanmakenEvent.TabIndex = 0;
            this.rdbtnAanmakenEvent.TabStop = true;
            this.rdbtnAanmakenEvent.Text = "Event aanmaken";
            this.rdbtnAanmakenEvent.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 358);
            this.Controls.Add(this.grpBoxLoggedIn);
            this.Controls.Add(this.grpBoxLogin);
            this.Controls.Add(this.grpBoxRapport);
            this.Controls.Add(this.grpBoxOverzicht);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ITEvents";
            this.grpBoxOverzicht.ResumeLayout(false);
            this.grpBoxOverzicht.PerformLayout();
            this.grpBoxRapport.ResumeLayout(false);
            this.grpBoxRapport.PerformLayout();
            this.grpBoxLogin.ResumeLayout(false);
            this.grpBoxLogin.PerformLayout();
            this.grpBoxLoggedIn.ResumeLayout(false);
            this.grpBoxLoggedIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxOverzicht;
        private System.Windows.Forms.Button btnOverzicht;
        private System.Windows.Forms.RadioButton rdbtnOverzichtHistorie;
        private System.Windows.Forms.RadioButton rdbOverzichtEventVrij;
        private System.Windows.Forms.RadioButton rdbtnOverzichtEventVolzet;
        private System.Windows.Forms.GroupBox grpBoxRapport;
        private System.Windows.Forms.Button btnRapport;
        private System.Windows.Forms.RadioButton rdbRapportStatistiek;
        private System.Windows.Forms.RadioButton rdbtnRapportEventVrij;
        private System.Windows.Forms.GroupBox grpBoxLogin;
        private System.Windows.Forms.TextBox txtBoxGebruikersnaam;
        private System.Windows.Forms.GroupBox grpBoxLoggedIn;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.RadioButton rdbInschrijvenEvent;
        private System.Windows.Forms.RadioButton rdbUItschrijvenEvent;
        private System.Windows.Forms.RadioButton rdbtnAanmakenEvent;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPasswoord;
        private System.Windows.Forms.Label lblGebruikersnaam;
        private System.Windows.Forms.TextBox txtBoxWachtwoord;
        private System.Windows.Forms.Button btnAfmelden;
        private System.Windows.Forms.Button btnRegistreren;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

