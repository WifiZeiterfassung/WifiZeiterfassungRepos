namespace ProjektZeiterfassung.View
{
    partial class Mainpanel2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainpanel2));
            this.AnmeldeLabel = new System.Windows.Forms.Label();
            this.mitarbeiterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zEIT2017DataSet = new ProjektZeiterfassung.ZEIT2017DataSet();
            this.mitarbeiterTableAdapter = new ProjektZeiterfassung.ZEIT2017DataSetTableAdapters.MitarbeiterTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtBenutzerdaten = new System.Windows.Forms.TextBox();
            this.LblBenutzerdaten = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LablPin = new System.Windows.Forms.Label();
            this.TxtPin = new System.Windows.Forms.TextBox();
            this.LblPersonalnummer = new System.Windows.Forms.Label();
            this.BtnAnmelden = new System.Windows.Forms.Button();
            this.TxtPersonalnummer = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnArbeitsende = new System.Windows.Forms.Button();
            this.BtnPausenbeginn = new System.Windows.Forms.Button();
            this.BtnPausenende = new System.Windows.Forms.Button();
            this.BtnArbeitsbeginn = new System.Windows.Forms.Button();
            this.BtnBenutzerNeu = new System.Windows.Forms.Button();
            this.BtnExport = new System.Windows.Forms.Button();
            this.BtnBenutzerUpdate = new System.Windows.Forms.Button();
            this.BtnPasswortReset = new System.Windows.Forms.Button();
            this.BtnPasswortAendern = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mitarbeiterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zEIT2017DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnmeldeLabel
            // 
            this.AnmeldeLabel.AutoSize = true;
            this.AnmeldeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnmeldeLabel.Location = new System.Drawing.Point(12, 5);
            this.AnmeldeLabel.Name = "AnmeldeLabel";
            this.AnmeldeLabel.Size = new System.Drawing.Size(171, 20);
            this.AnmeldeLabel.TabIndex = 0;
            this.AnmeldeLabel.Text = "Wifi Arbeitszeitfassung";
            this.AnmeldeLabel.Click += new System.EventHandler(this.AnmeldeLabel_Click);
            // 
            // mitarbeiterBindingSource
            // 
            this.mitarbeiterBindingSource.DataMember = "Mitarbeiter";
            this.mitarbeiterBindingSource.DataSource = this.zEIT2017DataSet;
            // 
            // zEIT2017DataSet
            // 
            this.zEIT2017DataSet.DataSetName = "ZEIT2017DataSet";
            this.zEIT2017DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mitarbeiterTableAdapter
            // 
            this.mitarbeiterTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.TxtBenutzerdaten);
            this.panel1.Controls.Add(this.LblBenutzerdaten);
            this.panel1.Location = new System.Drawing.Point(340, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 55);
            this.panel1.TabIndex = 4;
            // 
            // TxtBenutzerdaten
            // 
            this.TxtBenutzerdaten.BackColor = System.Drawing.Color.PeachPuff;
            this.TxtBenutzerdaten.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBenutzerdaten.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TxtBenutzerdaten.Location = new System.Drawing.Point(8, 23);
            this.TxtBenutzerdaten.Multiline = true;
            this.TxtBenutzerdaten.Name = "TxtBenutzerdaten";
            this.TxtBenutzerdaten.ReadOnly = true;
            this.TxtBenutzerdaten.Size = new System.Drawing.Size(310, 21);
            this.TxtBenutzerdaten.TabIndex = 2;
            // 
            // LblBenutzerdaten
            // 
            this.LblBenutzerdaten.AutoSize = true;
            this.LblBenutzerdaten.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBenutzerdaten.Location = new System.Drawing.Point(5, 4);
            this.LblBenutzerdaten.Name = "LblBenutzerdaten";
            this.LblBenutzerdaten.Size = new System.Drawing.Size(79, 13);
            this.LblBenutzerdaten.TabIndex = 1;
            this.LblBenutzerdaten.Text = "Benutzerdaten:";
            this.LblBenutzerdaten.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.LablPin);
            this.panel2.Controls.Add(this.TxtPin);
            this.panel2.Controls.Add(this.LblPersonalnummer);
            this.panel2.Controls.Add(this.BtnAnmelden);
            this.panel2.Controls.Add(this.TxtPersonalnummer);
            this.panel2.Location = new System.Drawing.Point(12, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 55);
            this.panel2.TabIndex = 3;
            // 
            // LablPin
            // 
            this.LablPin.AutoSize = true;
            this.LablPin.Location = new System.Drawing.Point(106, 4);
            this.LablPin.Name = "LablPin";
            this.LablPin.Size = new System.Drawing.Size(69, 13);
            this.LablPin.TabIndex = 14;
            this.LablPin.Text = "Pin (6-stellig):";
            // 
            // TxtPin
            // 
            this.TxtPin.Location = new System.Drawing.Point(106, 23);
            this.TxtPin.MaxLength = 6;
            this.TxtPin.Name = "TxtPin";
            this.TxtPin.PasswordChar = '*';
            this.TxtPin.Size = new System.Drawing.Size(90, 20);
            this.TxtPin.TabIndex = 13;
            // 
            // LblPersonalnummer
            // 
            this.LblPersonalnummer.AutoSize = true;
            this.LblPersonalnummer.Location = new System.Drawing.Point(10, 4);
            this.LblPersonalnummer.Name = "LblPersonalnummer";
            this.LblPersonalnummer.Size = new System.Drawing.Size(63, 13);
            this.LblPersonalnummer.TabIndex = 12;
            this.LblPersonalnummer.Text = "Personalnr.:";
            // 
            // BtnAnmelden
            // 
            this.BtnAnmelden.Location = new System.Drawing.Point(202, 21);
            this.BtnAnmelden.Name = "BtnAnmelden";
            this.BtnAnmelden.Size = new System.Drawing.Size(100, 23);
            this.BtnAnmelden.TabIndex = 11;
            this.BtnAnmelden.Text = "Anmelden";
            this.BtnAnmelden.UseVisualStyleBackColor = true;
            this.BtnAnmelden.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtPersonalnummer
            // 
            this.TxtPersonalnummer.Location = new System.Drawing.Point(10, 23);
            this.TxtPersonalnummer.Name = "TxtPersonalnummer";
            this.TxtPersonalnummer.Size = new System.Drawing.Size(90, 20);
            this.TxtPersonalnummer.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.BtnArbeitsende);
            this.panel3.Controls.Add(this.BtnPausenbeginn);
            this.panel3.Controls.Add(this.BtnPausenende);
            this.panel3.Controls.Add(this.BtnArbeitsbeginn);
            this.panel3.Location = new System.Drawing.Point(12, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(659, 53);
            this.panel3.TabIndex = 5;
            // 
            // BtnArbeitsende
            // 
            this.BtnArbeitsende.Location = new System.Drawing.Point(546, 14);
            this.BtnArbeitsende.Name = "BtnArbeitsende";
            this.BtnArbeitsende.Size = new System.Drawing.Size(100, 23);
            this.BtnArbeitsende.TabIndex = 19;
            this.BtnArbeitsende.Text = "Arbeitsende";
            this.BtnArbeitsende.UseVisualStyleBackColor = true;
            // 
            // BtnPausenbeginn
            // 
            this.BtnPausenbeginn.Location = new System.Drawing.Point(191, 14);
            this.BtnPausenbeginn.Name = "BtnPausenbeginn";
            this.BtnPausenbeginn.Size = new System.Drawing.Size(100, 23);
            this.BtnPausenbeginn.TabIndex = 19;
            this.BtnPausenbeginn.Text = "Pausenbeginn";
            this.BtnPausenbeginn.UseVisualStyleBackColor = true;
            // 
            // BtnPausenende
            // 
            this.BtnPausenende.Location = new System.Drawing.Point(371, 14);
            this.BtnPausenende.Name = "BtnPausenende";
            this.BtnPausenende.Size = new System.Drawing.Size(100, 23);
            this.BtnPausenende.TabIndex = 19;
            this.BtnPausenende.Text = "Pausenende";
            this.BtnPausenende.UseVisualStyleBackColor = true;
            // 
            // BtnArbeitsbeginn
            // 
            this.BtnArbeitsbeginn.Location = new System.Drawing.Point(9, 14);
            this.BtnArbeitsbeginn.Name = "BtnArbeitsbeginn";
            this.BtnArbeitsbeginn.Size = new System.Drawing.Size(100, 23);
            this.BtnArbeitsbeginn.TabIndex = 19;
            this.BtnArbeitsbeginn.Text = "Arbeitsbeginn";
            this.BtnArbeitsbeginn.UseVisualStyleBackColor = true;
            // 
            // BtnBenutzerNeu
            // 
            this.BtnBenutzerNeu.Location = new System.Drawing.Point(235, 526);
            this.BtnBenutzerNeu.Name = "BtnBenutzerNeu";
            this.BtnBenutzerNeu.Size = new System.Drawing.Size(100, 23);
            this.BtnBenutzerNeu.TabIndex = 20;
            this.BtnBenutzerNeu.Text = "Neuer Benutzer";
            this.BtnBenutzerNeu.UseVisualStyleBackColor = true;
            this.BtnBenutzerNeu.Visible = false;
            // 
            // BtnExport
            // 
            this.BtnExport.Location = new System.Drawing.Point(560, 526);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(100, 23);
            this.BtnExport.TabIndex = 13;
            this.BtnExport.Text = "Export";
            this.BtnExport.UseVisualStyleBackColor = true;
            this.BtnExport.Click += new System.EventHandler(this.button5_Click);
            // 
            // BtnBenutzerUpdate
            // 
            this.BtnBenutzerUpdate.Location = new System.Drawing.Point(129, 526);
            this.BtnBenutzerUpdate.Name = "BtnBenutzerUpdate";
            this.BtnBenutzerUpdate.Size = new System.Drawing.Size(100, 23);
            this.BtnBenutzerUpdate.TabIndex = 21;
            this.BtnBenutzerUpdate.Text = "Benutzer-Update";
            this.BtnBenutzerUpdate.UseVisualStyleBackColor = true;
            this.BtnBenutzerUpdate.Visible = false;
            // 
            // BtnPasswortReset
            // 
            this.BtnPasswortReset.Location = new System.Drawing.Point(341, 526);
            this.BtnPasswortReset.Name = "BtnPasswortReset";
            this.BtnPasswortReset.Size = new System.Drawing.Size(100, 23);
            this.BtnPasswortReset.TabIndex = 23;
            this.BtnPasswortReset.Text = "Passwort-Reset";
            this.BtnPasswortReset.UseVisualStyleBackColor = true;
            this.BtnPasswortReset.Visible = false;
            // 
            // BtnPasswortAendern
            // 
            this.BtnPasswortAendern.Location = new System.Drawing.Point(23, 526);
            this.BtnPasswortAendern.Name = "BtnPasswortAendern";
            this.BtnPasswortAendern.Size = new System.Drawing.Size(100, 23);
            this.BtnPasswortAendern.TabIndex = 22;
            this.BtnPasswortAendern.Text = "Passwort ändern";
            this.BtnPasswortAendern.UseVisualStyleBackColor = true;
            this.BtnPasswortAendern.Visible = false;
            // 
            // Mainpanel2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.BtnPasswortReset);
            this.Controls.Add(this.BtnPasswortAendern);
            this.Controls.Add(this.BtnBenutzerUpdate);
            this.Controls.Add(this.BtnBenutzerNeu);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AnmeldeLabel);
            this.Controls.Add(this.BtnExport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mainpanel2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wifi Arbeitszeitfassung";
            ((System.ComponentModel.ISupportInitialize)(this.mitarbeiterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zEIT2017DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label AnmeldeLabel;
        private System.Windows.Forms.BindingSource mitarbeiterBindingSource;
        private ZEIT2017DataSet zEIT2017DataSet;
        private ZEIT2017DataSetTableAdapters.MitarbeiterTableAdapter mitarbeiterTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtBenutzerdaten;
        private System.Windows.Forms.Label LblBenutzerdaten;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblPersonalnummer;
        private System.Windows.Forms.Button BtnAnmelden;
        private System.Windows.Forms.TextBox TxtPersonalnummer;
        private System.Windows.Forms.Button BtnExport;
        private System.Windows.Forms.Label LablPin;
        private System.Windows.Forms.TextBox TxtPin;
        private System.Windows.Forms.Button BtnArbeitsende;
        private System.Windows.Forms.Button BtnPausenbeginn;
        private System.Windows.Forms.Button BtnPausenende;
        private System.Windows.Forms.Button BtnArbeitsbeginn;
        private System.Windows.Forms.Button BtnBenutzerNeu;
        private System.Windows.Forms.Button BtnBenutzerUpdate;
        private System.Windows.Forms.Button BtnPasswortReset;
        private System.Windows.Forms.Button BtnPasswortAendern;
    }
}