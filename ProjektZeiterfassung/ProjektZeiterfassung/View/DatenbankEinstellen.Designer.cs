namespace ProjektZeiterfassung.View
{
    partial class DatenbankEinstellen
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
            this.PanelEinstellungen = new System.Windows.Forms.Panel();
            this.LabHinweis = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LabDbPassword = new System.Windows.Forms.Label();
            this.TxtUserID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDataSource = new System.Windows.Forms.TextBox();
            this.LabDbAddress = new System.Windows.Forms.Label();
            this.PanelListe = new System.Windows.Forms.Panel();
            this.BtnWeiter = new System.Windows.Forms.Button();
            this.TxtMeldung = new System.Windows.Forms.TextBox();
            this.BtnSaveDbSettings = new System.Windows.Forms.Button();
            this.PanelEinstellungen.SuspendLayout();
            this.PanelListe.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelEinstellungen
            // 
            this.PanelEinstellungen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelEinstellungen.Controls.Add(this.LabHinweis);
            this.PanelEinstellungen.Controls.Add(this.TxtPassword);
            this.PanelEinstellungen.Controls.Add(this.LabDbPassword);
            this.PanelEinstellungen.Controls.Add(this.TxtUserID);
            this.PanelEinstellungen.Controls.Add(this.label1);
            this.PanelEinstellungen.Controls.Add(this.TxtDataSource);
            this.PanelEinstellungen.Controls.Add(this.LabDbAddress);
            this.PanelEinstellungen.Location = new System.Drawing.Point(10, 13);
            this.PanelEinstellungen.Name = "PanelEinstellungen";
            this.PanelEinstellungen.Size = new System.Drawing.Size(472, 166);
            this.PanelEinstellungen.TabIndex = 1;
            // 
            // LabHinweis
            // 
            this.LabHinweis.AutoSize = true;
            this.LabHinweis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabHinweis.ForeColor = System.Drawing.Color.SeaGreen;
            this.LabHinweis.Location = new System.Drawing.Point(-1, 58);
            this.LabHinweis.Name = "LabHinweis";
            this.LabHinweis.Size = new System.Drawing.Size(470, 18);
            this.LabHinweis.TabIndex = 19;
            this.LabHinweis.Text = "Benutzer und Passwort nur bei Sql-Authentifizierung angeben!";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(187, 123);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(279, 29);
            this.TxtPassword.TabIndex = 2;
            // 
            // LabDbPassword
            // 
            this.LabDbPassword.AutoSize = true;
            this.LabDbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDbPassword.Location = new System.Drawing.Point(3, 125);
            this.LabDbPassword.Name = "LabDbPassword";
            this.LabDbPassword.Size = new System.Drawing.Size(184, 24);
            this.LabDbPassword.TabIndex = 16;
            this.LabDbPassword.Text = "Datenbankpasswort :";
            // 
            // TxtUserID
            // 
            this.TxtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserID.Location = new System.Drawing.Point(187, 87);
            this.TxtUserID.Name = "TxtUserID";
            this.TxtUserID.Size = new System.Drawing.Size(278, 29);
            this.TxtUserID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Datenbankbenutzer :";
            // 
            // TxtDataSource
            // 
            this.TxtDataSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDataSource.Location = new System.Drawing.Point(187, 17);
            this.TxtDataSource.Name = "TxtDataSource";
            this.TxtDataSource.Size = new System.Drawing.Size(279, 29);
            this.TxtDataSource.TabIndex = 0;
            // 
            // LabDbAddress
            // 
            this.LabDbAddress.AutoSize = true;
            this.LabDbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDbAddress.Location = new System.Drawing.Point(4, 19);
            this.LabDbAddress.Name = "LabDbAddress";
            this.LabDbAddress.Size = new System.Drawing.Size(177, 24);
            this.LabDbAddress.TabIndex = 10;
            this.LabDbAddress.Text = "Datenbankadresse :";
            // 
            // PanelListe
            // 
            this.PanelListe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelListe.Controls.Add(this.BtnWeiter);
            this.PanelListe.Controls.Add(this.TxtMeldung);
            this.PanelListe.Controls.Add(this.BtnSaveDbSettings);
            this.PanelListe.Location = new System.Drawing.Point(9, 191);
            this.PanelListe.Name = "PanelListe";
            this.PanelListe.Size = new System.Drawing.Size(473, 157);
            this.PanelListe.TabIndex = 1;
            // 
            // BtnWeiter
            // 
            this.BtnWeiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnWeiter.Location = new System.Drawing.Point(346, 92);
            this.BtnWeiter.Name = "BtnWeiter";
            this.BtnWeiter.Size = new System.Drawing.Size(120, 58);
            this.BtnWeiter.TabIndex = 1;
            this.BtnWeiter.Text = "Weiter...";
            this.BtnWeiter.UseVisualStyleBackColor = true;
            this.BtnWeiter.Visible = false;
            this.BtnWeiter.Click += new System.EventHandler(this.BtnWeiter_Click);
            // 
            // TxtMeldung
            // 
            this.TxtMeldung.BackColor = System.Drawing.Color.AntiqueWhite;
            this.TxtMeldung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMeldung.HideSelection = false;
            this.TxtMeldung.Location = new System.Drawing.Point(8, 3);
            this.TxtMeldung.Multiline = true;
            this.TxtMeldung.Name = "TxtMeldung";
            this.TxtMeldung.ReadOnly = true;
            this.TxtMeldung.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtMeldung.Size = new System.Drawing.Size(332, 147);
            this.TxtMeldung.TabIndex = 1;
            // 
            // BtnSaveDbSettings
            // 
            this.BtnSaveDbSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveDbSettings.Location = new System.Drawing.Point(346, 3);
            this.BtnSaveDbSettings.Name = "BtnSaveDbSettings";
            this.BtnSaveDbSettings.Size = new System.Drawing.Size(120, 58);
            this.BtnSaveDbSettings.TabIndex = 0;
            this.BtnSaveDbSettings.Text = "Speichern";
            this.BtnSaveDbSettings.UseVisualStyleBackColor = true;
            this.BtnSaveDbSettings.Click += new System.EventHandler(this.BtnSaveDbSettings_Click);
            // 
            // DatenbankEinstellen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(494, 356);
            this.Controls.Add(this.PanelListe);
            this.Controls.Add(this.PanelEinstellungen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "DatenbankEinstellen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datenbak Einstellungen";
            this.PanelEinstellungen.ResumeLayout(false);
            this.PanelEinstellungen.PerformLayout();
            this.PanelListe.ResumeLayout(false);
            this.PanelListe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelEinstellungen;
        private System.Windows.Forms.Panel PanelListe;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label LabDbPassword;
        private System.Windows.Forms.TextBox TxtUserID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDataSource;
        private System.Windows.Forms.Label LabDbAddress;
        private System.Windows.Forms.TextBox TxtMeldung;
        private System.Windows.Forms.Button BtnSaveDbSettings;
        private System.Windows.Forms.Label LabHinweis;
        private System.Windows.Forms.Button BtnWeiter;
    }
}