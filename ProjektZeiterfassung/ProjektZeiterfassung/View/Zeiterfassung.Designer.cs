namespace ProjektZeiterfassung.View
{
    partial class Zeiterfassung
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnBenutzerUpdate = new System.Windows.Forms.Button();
            this.BtnZeitkorrektur = new System.Windows.Forms.Button();
            this.BtnBenutzerNeu = new System.Windows.Forms.Button();
            this.BtnPausenbeginn = new System.Windows.Forms.Button();
            this.BtnPausenende = new System.Windows.Forms.Button();
            this.BtnArbeitsbeginn = new System.Windows.Forms.Button();
            this.LablPin = new System.Windows.Forms.Label();
            this.BtnPasswortAendern = new System.Windows.Forms.Button();
            this.TxtPin = new System.Windows.Forms.TextBox();
            this.LblPersonalnummer = new System.Windows.Forms.Label();
            this.BtnArbeitsende = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnAnmelden = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtPersonalnummer = new System.Windows.Forms.TextBox();
            this.TxtBenutzerdaten = new System.Windows.Forms.TextBox();
            this.LblBenutzerdaten = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mitarbeiterTableAdapter = new ProjektZeiterfassung.ZEIT2017DataSetTableAdapters.MitarbeiterTableAdapter();
            this.zEIT2017DataSet = new ProjektZeiterfassung.ZEIT2017DataSet();
            this.mitarbeiterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AnmeldeLabel = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zEIT2017DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitarbeiterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Administratorbereich:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.BtnBenutzerUpdate);
            this.panel4.Controls.Add(this.BtnZeitkorrektur);
            this.panel4.Controls.Add(this.BtnBenutzerNeu);
            this.panel4.Location = new System.Drawing.Point(12, 243);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(484, 70);
            this.panel4.TabIndex = 26;
            // 
            // BtnBenutzerUpdate
            // 
            this.BtnBenutzerUpdate.Location = new System.Drawing.Point(8, 14);
            this.BtnBenutzerUpdate.Name = "BtnBenutzerUpdate";
            this.BtnBenutzerUpdate.Size = new System.Drawing.Size(100, 37);
            this.BtnBenutzerUpdate.TabIndex = 13;
            this.BtnBenutzerUpdate.Text = "Mitarbeiter anlegen";
            this.BtnBenutzerUpdate.UseVisualStyleBackColor = true;
            this.BtnBenutzerUpdate.Click += new System.EventHandler(this.BtnBenutzerUpdate_Click);
            // 
            // BtnZeitkorrektur
            // 
            this.BtnZeitkorrektur.Location = new System.Drawing.Point(250, 14);
            this.BtnZeitkorrektur.Name = "BtnZeitkorrektur";
            this.BtnZeitkorrektur.Size = new System.Drawing.Size(100, 37);
            this.BtnZeitkorrektur.TabIndex = 15;
            this.BtnZeitkorrektur.Text = "Zeitkorrektur";
            this.BtnZeitkorrektur.UseVisualStyleBackColor = true;
            this.BtnZeitkorrektur.Click += new System.EventHandler(this.BtnZeitkorrektur_Click);
            // 
            // BtnBenutzerNeu
            // 
            this.BtnBenutzerNeu.Location = new System.Drawing.Point(129, 14);
            this.BtnBenutzerNeu.Name = "BtnBenutzerNeu";
            this.BtnBenutzerNeu.Size = new System.Drawing.Size(100, 37);
            this.BtnBenutzerNeu.TabIndex = 14;
            this.BtnBenutzerNeu.Text = "Mitarbeiter bearbeiten";
            this.BtnBenutzerNeu.UseVisualStyleBackColor = true;
            this.BtnBenutzerNeu.Click += new System.EventHandler(this.BtnBenutzerNeu_Click);
            // 
            // BtnPausenbeginn
            // 
            this.BtnPausenbeginn.Location = new System.Drawing.Point(129, 14);
            this.BtnPausenbeginn.Name = "BtnPausenbeginn";
            this.BtnPausenbeginn.Size = new System.Drawing.Size(100, 23);
            this.BtnPausenbeginn.TabIndex = 10;
            this.BtnPausenbeginn.Text = "Pausenbeginn";
            this.BtnPausenbeginn.UseVisualStyleBackColor = true;
            // 
            // BtnPausenende
            // 
            this.BtnPausenende.Location = new System.Drawing.Point(249, 14);
            this.BtnPausenende.Name = "BtnPausenende";
            this.BtnPausenende.Size = new System.Drawing.Size(100, 23);
            this.BtnPausenende.TabIndex = 11;
            this.BtnPausenende.Text = "Pausenende";
            this.BtnPausenende.UseVisualStyleBackColor = true;
            // 
            // BtnArbeitsbeginn
            // 
            this.BtnArbeitsbeginn.Location = new System.Drawing.Point(9, 14);
            this.BtnArbeitsbeginn.Name = "BtnArbeitsbeginn";
            this.BtnArbeitsbeginn.Size = new System.Drawing.Size(100, 23);
            this.BtnArbeitsbeginn.TabIndex = 9;
            this.BtnArbeitsbeginn.Text = "Arbeitsbeginn";
            this.BtnArbeitsbeginn.UseVisualStyleBackColor = true;
            // 
            // LablPin
            // 
            this.LablPin.AutoSize = true;
            this.LablPin.Location = new System.Drawing.Point(129, 4);
            this.LablPin.Name = "LablPin";
            this.LablPin.Size = new System.Drawing.Size(69, 13);
            this.LablPin.TabIndex = 14;
            this.LablPin.Text = "Pin (6-stellig):";
            // 
            // BtnPasswortAendern
            // 
            this.BtnPasswortAendern.Location = new System.Drawing.Point(369, 21);
            this.BtnPasswortAendern.Name = "BtnPasswortAendern";
            this.BtnPasswortAendern.Size = new System.Drawing.Size(100, 23);
            this.BtnPasswortAendern.TabIndex = 8;
            this.BtnPasswortAendern.Text = "Passwort ändern";
            this.BtnPasswortAendern.UseVisualStyleBackColor = true;
            this.BtnPasswortAendern.Click += new System.EventHandler(this.BtnPasswortAendern_Click);
            // 
            // TxtPin
            // 
            this.TxtPin.Location = new System.Drawing.Point(130, 23);
            this.TxtPin.MaxLength = 6;
            this.TxtPin.Name = "TxtPin";
            this.TxtPin.PasswordChar = '*';
            this.TxtPin.Size = new System.Drawing.Size(100, 20);
            this.TxtPin.TabIndex = 6;
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
            // BtnArbeitsende
            // 
            this.BtnArbeitsende.Location = new System.Drawing.Point(369, 14);
            this.BtnArbeitsende.Name = "BtnArbeitsende";
            this.BtnArbeitsende.Size = new System.Drawing.Size(100, 23);
            this.BtnArbeitsende.TabIndex = 12;
            this.BtnArbeitsende.Text = "Arbeitsende";
            this.BtnArbeitsende.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.BtnArbeitsende);
            this.panel3.Controls.Add(this.BtnPausenbeginn);
            this.panel3.Controls.Add(this.BtnPausenende);
            this.panel3.Controls.Add(this.BtnArbeitsbeginn);
            this.panel3.Location = new System.Drawing.Point(12, 154);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(484, 53);
            this.panel3.TabIndex = 25;
            // 
            // BtnAnmelden
            // 
            this.BtnAnmelden.Location = new System.Drawing.Point(250, 21);
            this.BtnAnmelden.Name = "BtnAnmelden";
            this.BtnAnmelden.Size = new System.Drawing.Size(100, 23);
            this.BtnAnmelden.TabIndex = 7;
            this.BtnAnmelden.Text = "Anmelden";
            this.BtnAnmelden.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.LablPin);
            this.panel2.Controls.Add(this.BtnPasswortAendern);
            this.panel2.Controls.Add(this.TxtPin);
            this.panel2.Controls.Add(this.LblPersonalnummer);
            this.panel2.Controls.Add(this.BtnAnmelden);
            this.panel2.Controls.Add(this.TxtPersonalnummer);
            this.panel2.Location = new System.Drawing.Point(12, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 55);
            this.panel2.TabIndex = 23;
            // 
            // TxtPersonalnummer
            // 
            this.TxtPersonalnummer.Location = new System.Drawing.Point(10, 23);
            this.TxtPersonalnummer.Name = "TxtPersonalnummer";
            this.TxtPersonalnummer.Size = new System.Drawing.Size(100, 20);
            this.TxtPersonalnummer.TabIndex = 5;
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
            this.TxtBenutzerdaten.Size = new System.Drawing.Size(461, 21);
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
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.TxtBenutzerdaten);
            this.panel1.Controls.Add(this.LblBenutzerdaten);
            this.panel1.Location = new System.Drawing.Point(12, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 55);
            this.panel1.TabIndex = 24;
            // 
            // mitarbeiterTableAdapter
            // 
            this.mitarbeiterTableAdapter.ClearBeforeFill = true;
            // 
            // zEIT2017DataSet
            // 
            this.zEIT2017DataSet.DataSetName = "ZEIT2017DataSet";
            this.zEIT2017DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mitarbeiterBindingSource
            // 
            this.mitarbeiterBindingSource.DataMember = "Mitarbeiter";
            this.mitarbeiterBindingSource.DataSource = this.zEIT2017DataSet;
            // 
            // AnmeldeLabel
            // 
            this.AnmeldeLabel.AutoSize = true;
            this.AnmeldeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnmeldeLabel.Location = new System.Drawing.Point(12, 9);
            this.AnmeldeLabel.Name = "AnmeldeLabel";
            this.AnmeldeLabel.Size = new System.Drawing.Size(171, 20);
            this.AnmeldeLabel.TabIndex = 22;
            this.AnmeldeLabel.Text = "Wifi Arbeitszeitfassung";
            // 
            // Zeiterfassung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 321);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AnmeldeLabel);
            this.Name = "Zeiterfassung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wifi Arbeitszeitfassung";
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zEIT2017DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitarbeiterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnBenutzerUpdate;
        private System.Windows.Forms.Button BtnZeitkorrektur;
        private System.Windows.Forms.Button BtnBenutzerNeu;
        private System.Windows.Forms.Button BtnPausenbeginn;
        private System.Windows.Forms.Button BtnPausenende;
        private System.Windows.Forms.Button BtnArbeitsbeginn;
        private System.Windows.Forms.Label LablPin;
        private System.Windows.Forms.Button BtnPasswortAendern;
        private System.Windows.Forms.TextBox TxtPin;
        private System.Windows.Forms.Label LblPersonalnummer;
        private System.Windows.Forms.Button BtnArbeitsende;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnAnmelden;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtPersonalnummer;
        private System.Windows.Forms.TextBox TxtBenutzerdaten;
        private System.Windows.Forms.Label LblBenutzerdaten;
        private System.Windows.Forms.Panel panel1;
        private ZEIT2017DataSetTableAdapters.MitarbeiterTableAdapter mitarbeiterTableAdapter;
        private ZEIT2017DataSet zEIT2017DataSet;
        private System.Windows.Forms.BindingSource mitarbeiterBindingSource;
        private System.Windows.Forms.Label AnmeldeLabel;
    }
}