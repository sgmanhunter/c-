namespace ProjectGroep01.View
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
            this.grpBoxSummary = new System.Windows.Forms.GroupBox();
            this.btnSummary = new System.Windows.Forms.Button();
            this.rdbtnSummaryHistory = new System.Windows.Forms.RadioButton();
            this.rdbtnSummaryEventFree = new System.Windows.Forms.RadioButton();
            this.rdbtnSummaryEventFull = new System.Windows.Forms.RadioButton();
            this.grpBoxReport = new System.Windows.Forms.GroupBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.rdbtnReportStatistics = new System.Windows.Forms.RadioButton();
            this.rdbtnReportEventFree = new System.Windows.Forms.RadioButton();
            this.grpBoxLogin = new System.Windows.Forms.GroupBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.txtBoxUserName = new System.Windows.Forms.TextBox();
            this.grpBoxLoggedIn = new System.Windows.Forms.GroupBox();
            this.grpBoxOwnEvents = new System.Windows.Forms.GroupBox();
            this.btnOwnEvents = new System.Windows.Forms.Button();
            this.rdbtnReportOwnEvents = new System.Windows.Forms.RadioButton();
            this.rdbtnSummaryOwnEvents = new System.Windows.Forms.RadioButton();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.rdbtnInscribeEvent = new System.Windows.Forms.RadioButton();
            this.rdbtnWriteoutEvent = new System.Windows.Forms.RadioButton();
            this.rdbtnMakeEvent = new System.Windows.Forms.RadioButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpBoxSummary.SuspendLayout();
            this.grpBoxReport.SuspendLayout();
            this.grpBoxLogin.SuspendLayout();
            this.grpBoxLoggedIn.SuspendLayout();
            this.grpBoxOwnEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxSummary
            // 
            this.grpBoxSummary.Controls.Add(this.btnSummary);
            this.grpBoxSummary.Controls.Add(this.rdbtnSummaryHistory);
            this.grpBoxSummary.Controls.Add(this.rdbtnSummaryEventFree);
            this.grpBoxSummary.Controls.Add(this.rdbtnSummaryEventFull);
            this.grpBoxSummary.Location = new System.Drawing.Point(12, 192);
            this.grpBoxSummary.Name = "grpBoxSummary";
            this.grpBoxSummary.Size = new System.Drawing.Size(200, 152);
            this.grpBoxSummary.TabIndex = 0;
            this.grpBoxSummary.TabStop = false;
            this.grpBoxSummary.Text = "Overzicht";
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(22, 98);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(138, 23);
            this.btnSummary.TabIndex = 3;
            this.btnSummary.Text = "Overzicht";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // rdbtnSummaryHistory
            // 
            this.rdbtnSummaryHistory.AutoSize = true;
            this.rdbtnSummaryHistory.Location = new System.Drawing.Point(22, 75);
            this.rdbtnSummaryHistory.Name = "rdbtnSummaryHistory";
            this.rdbtnSummaryHistory.Size = new System.Drawing.Size(164, 17);
            this.rdbtnSummaryHistory.TabIndex = 2;
            this.rdbtnSummaryHistory.TabStop = true;
            this.rdbtnSummaryHistory.Text = "Evenementen in het verleden";
            this.rdbtnSummaryHistory.UseVisualStyleBackColor = true;
            // 
            // rdbtnSummaryEventFree
            // 
            this.rdbtnSummaryEventFree.AutoSize = true;
            this.rdbtnSummaryEventFree.Location = new System.Drawing.Point(22, 52);
            this.rdbtnSummaryEventFree.Name = "rdbtnSummaryEventFree";
            this.rdbtnSummaryEventFree.Size = new System.Drawing.Size(113, 17);
            this.rdbtnSummaryEventFree.TabIndex = 1;
            this.rdbtnSummaryEventFree.TabStop = true;
            this.rdbtnSummaryEventFree.Text = "Vrije evenementen";
            this.rdbtnSummaryEventFree.UseVisualStyleBackColor = true;
            // 
            // rdbtnSummaryEventFull
            // 
            this.rdbtnSummaryEventFull.AutoSize = true;
            this.rdbtnSummaryEventFull.Location = new System.Drawing.Point(22, 29);
            this.rdbtnSummaryEventFull.Name = "rdbtnSummaryEventFull";
            this.rdbtnSummaryEventFull.Size = new System.Drawing.Size(131, 17);
            this.rdbtnSummaryEventFull.TabIndex = 0;
            this.rdbtnSummaryEventFull.TabStop = true;
            this.rdbtnSummaryEventFull.Text = "Volzette evenementen";
            this.rdbtnSummaryEventFull.UseVisualStyleBackColor = true;
            // 
            // grpBoxReport
            // 
            this.grpBoxReport.Controls.Add(this.btnReport);
            this.grpBoxReport.Controls.Add(this.rdbtnReportStatistics);
            this.grpBoxReport.Controls.Add(this.rdbtnReportEventFree);
            this.grpBoxReport.Location = new System.Drawing.Point(239, 192);
            this.grpBoxReport.Name = "grpBoxReport";
            this.grpBoxReport.Size = new System.Drawing.Size(200, 152);
            this.grpBoxReport.TabIndex = 2;
            this.grpBoxReport.TabStop = false;
            this.grpBoxReport.Text = "Rapporten";
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(14, 98);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(138, 23);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "Rapport";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // rdbtnReportStatistics
            // 
            this.rdbtnReportStatistics.AutoSize = true;
            this.rdbtnReportStatistics.Location = new System.Drawing.Point(14, 52);
            this.rdbtnReportStatistics.Name = "rdbtnReportStatistics";
            this.rdbtnReportStatistics.Size = new System.Drawing.Size(80, 17);
            this.rdbtnReportStatistics.TabIndex = 2;
            this.rdbtnReportStatistics.TabStop = true;
            this.rdbtnReportStatistics.Text = "Statistieken";
            this.rdbtnReportStatistics.UseVisualStyleBackColor = true;
            // 
            // rdbtnReportEventFree
            // 
            this.rdbtnReportEventFree.AutoSize = true;
            this.rdbtnReportEventFree.Location = new System.Drawing.Point(14, 29);
            this.rdbtnReportEventFree.Name = "rdbtnReportEventFree";
            this.rdbtnReportEventFree.Size = new System.Drawing.Size(114, 17);
            this.rdbtnReportEventFree.TabIndex = 1;
            this.rdbtnReportEventFree.TabStop = true;
            this.rdbtnReportEventFree.Text = "Vrije Evenementen";
            this.rdbtnReportEventFree.UseVisualStyleBackColor = true;
            // 
            // grpBoxLogin
            // 
            this.grpBoxLogin.Controls.Add(this.btnRegister);
            this.grpBoxLogin.Controls.Add(this.btnLogin);
            this.grpBoxLogin.Controls.Add(this.lblPassword);
            this.grpBoxLogin.Controls.Add(this.lblUsername);
            this.grpBoxLogin.Controls.Add(this.txtBoxPassword);
            this.grpBoxLogin.Controls.Add(this.txtBoxUserName);
            this.grpBoxLogin.Location = new System.Drawing.Point(19, 24);
            this.grpBoxLogin.Name = "grpBoxLogin";
            this.grpBoxLogin.Size = new System.Drawing.Size(419, 158);
            this.grpBoxLogin.TabIndex = 3;
            this.grpBoxLogin.TabStop = false;
            this.grpBoxLogin.Text = "Login";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(126, 106);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(149, 23);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Registreren";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
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
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(33, 54);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(68, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Wachtwoord";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(33, 28);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(87, 13);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Gebruikersnaam:";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(126, 51);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(150, 20);
            this.txtBoxPassword.TabIndex = 1;
            this.txtBoxPassword.UseSystemPasswordChar = true;
            // 
            // txtBoxUserName
            // 
            this.txtBoxUserName.Location = new System.Drawing.Point(126, 25);
            this.txtBoxUserName.Name = "txtBoxUserName";
            this.txtBoxUserName.Size = new System.Drawing.Size(150, 20);
            this.txtBoxUserName.TabIndex = 0;
            // 
            // grpBoxLoggedIn
            // 
            this.grpBoxLoggedIn.Controls.Add(this.grpBoxOwnEvents);
            this.grpBoxLoggedIn.Controls.Add(this.btnLogout);
            this.grpBoxLoggedIn.Controls.Add(this.btnGo);
            this.grpBoxLoggedIn.Controls.Add(this.rdbtnInscribeEvent);
            this.grpBoxLoggedIn.Controls.Add(this.rdbtnWriteoutEvent);
            this.grpBoxLoggedIn.Controls.Add(this.rdbtnMakeEvent);
            this.grpBoxLoggedIn.Location = new System.Drawing.Point(20, 18);
            this.grpBoxLoggedIn.Name = "grpBoxLoggedIn";
            this.grpBoxLoggedIn.Size = new System.Drawing.Size(419, 158);
            this.grpBoxLoggedIn.TabIndex = 5;
            this.grpBoxLoggedIn.TabStop = false;
            this.grpBoxLoggedIn.Text = "Welkom";
            // 
            // grpBoxOwnEvents
            // 
            this.grpBoxOwnEvents.Controls.Add(this.btnOwnEvents);
            this.grpBoxOwnEvents.Controls.Add(this.rdbtnReportOwnEvents);
            this.grpBoxOwnEvents.Controls.Add(this.rdbtnSummaryOwnEvents);
            this.grpBoxOwnEvents.Location = new System.Drawing.Point(237, 25);
            this.grpBoxOwnEvents.Name = "grpBoxOwnEvents";
            this.grpBoxOwnEvents.Size = new System.Drawing.Size(165, 95);
            this.grpBoxOwnEvents.TabIndex = 5;
            this.grpBoxOwnEvents.TabStop = false;
            this.grpBoxOwnEvents.Text = "Eigen evenementen";
            // 
            // btnOwnEvents
            // 
            this.btnOwnEvents.Location = new System.Drawing.Point(16, 58);
            this.btnOwnEvents.Name = "btnOwnEvents";
            this.btnOwnEvents.Size = new System.Drawing.Size(137, 29);
            this.btnOwnEvents.TabIndex = 2;
            this.btnOwnEvents.Text = "Bekijk";
            this.btnOwnEvents.UseVisualStyleBackColor = true;
            this.btnOwnEvents.Click += new System.EventHandler(this.btnOwnEvent_Click);
            // 
            // rdbtnReportOwnEvents
            // 
            this.rdbtnReportOwnEvents.AutoSize = true;
            this.rdbtnReportOwnEvents.Location = new System.Drawing.Point(16, 42);
            this.rdbtnReportOwnEvents.Name = "rdbtnReportOwnEvents";
            this.rdbtnReportOwnEvents.Size = new System.Drawing.Size(63, 17);
            this.rdbtnReportOwnEvents.TabIndex = 1;
            this.rdbtnReportOwnEvents.TabStop = true;
            this.rdbtnReportOwnEvents.Text = "Rapport";
            this.rdbtnReportOwnEvents.UseVisualStyleBackColor = true;
            // 
            // rdbtnSummaryOwnEvents
            // 
            this.rdbtnSummaryOwnEvents.AutoSize = true;
            this.rdbtnSummaryOwnEvents.Location = new System.Drawing.Point(16, 19);
            this.rdbtnSummaryOwnEvents.Name = "rdbtnSummaryOwnEvents";
            this.rdbtnSummaryOwnEvents.Size = new System.Drawing.Size(70, 17);
            this.rdbtnSummaryOwnEvents.TabIndex = 0;
            this.rdbtnSummaryOwnEvents.TabStop = true;
            this.rdbtnSummaryOwnEvents.Text = "Overzicht";
            this.rdbtnSummaryOwnEvents.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(278, 127);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(135, 25);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Afmelden";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
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
            // rdbtnInscribeEvent
            // 
            this.rdbtnInscribeEvent.AutoSize = true;
            this.rdbtnInscribeEvent.Location = new System.Drawing.Point(26, 50);
            this.rdbtnInscribeEvent.Name = "rdbtnInscribeEvent";
            this.rdbtnInscribeEvent.Size = new System.Drawing.Size(156, 17);
            this.rdbtnInscribeEvent.TabIndex = 2;
            this.rdbtnInscribeEvent.TabStop = true;
            this.rdbtnInscribeEvent.Text = "Inschrijven voor evenement";
            this.rdbtnInscribeEvent.UseVisualStyleBackColor = true;
            // 
            // rdbtnWriteoutEvent
            // 
            this.rdbtnWriteoutEvent.AutoSize = true;
            this.rdbtnWriteoutEvent.Location = new System.Drawing.Point(26, 73);
            this.rdbtnWriteoutEvent.Name = "rdbtnWriteoutEvent";
            this.rdbtnWriteoutEvent.Size = new System.Drawing.Size(160, 17);
            this.rdbtnWriteoutEvent.TabIndex = 1;
            this.rdbtnWriteoutEvent.TabStop = true;
            this.rdbtnWriteoutEvent.Text = "Uitschrijven voor evenement";
            this.rdbtnWriteoutEvent.UseVisualStyleBackColor = true;
            // 
            // rdbtnMakeEvent
            // 
            this.rdbtnMakeEvent.AutoSize = true;
            this.rdbtnMakeEvent.Location = new System.Drawing.Point(26, 27);
            this.rdbtnMakeEvent.Name = "rdbtnMakeEvent";
            this.rdbtnMakeEvent.Size = new System.Drawing.Size(132, 17);
            this.rdbtnMakeEvent.TabIndex = 0;
            this.rdbtnMakeEvent.TabStop = true;
            this.rdbtnMakeEvent.Text = "Evenement aanmaken";
            this.rdbtnMakeEvent.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.grpBoxReport);
            this.Controls.Add(this.grpBoxSummary);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ITEvents";
            this.grpBoxSummary.ResumeLayout(false);
            this.grpBoxSummary.PerformLayout();
            this.grpBoxReport.ResumeLayout(false);
            this.grpBoxReport.PerformLayout();
            this.grpBoxLogin.ResumeLayout(false);
            this.grpBoxLogin.PerformLayout();
            this.grpBoxLoggedIn.ResumeLayout(false);
            this.grpBoxLoggedIn.PerformLayout();
            this.grpBoxOwnEvents.ResumeLayout(false);
            this.grpBoxOwnEvents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxSummary;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.RadioButton rdbtnSummaryHistory;
        private System.Windows.Forms.RadioButton rdbtnSummaryEventFree;
        private System.Windows.Forms.RadioButton rdbtnSummaryEventFull;
        private System.Windows.Forms.GroupBox grpBoxReport;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.RadioButton rdbtnReportStatistics;
        private System.Windows.Forms.RadioButton rdbtnReportEventFree;
        private System.Windows.Forms.GroupBox grpBoxLogin;
        private System.Windows.Forms.TextBox txtBoxUserName;
        private System.Windows.Forms.GroupBox grpBoxLoggedIn;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.RadioButton rdbtnInscribeEvent;
        private System.Windows.Forms.RadioButton rdbtnWriteoutEvent;
        private System.Windows.Forms.RadioButton rdbtnMakeEvent;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox grpBoxOwnEvents;
        private System.Windows.Forms.Button btnOwnEvents;
        private System.Windows.Forms.RadioButton rdbtnReportOwnEvents;
        private System.Windows.Forms.RadioButton rdbtnSummaryOwnEvents;
    }
}

