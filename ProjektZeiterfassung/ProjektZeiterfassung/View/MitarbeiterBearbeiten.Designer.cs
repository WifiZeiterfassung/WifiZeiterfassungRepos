namespace ProjektZeiterfassung.View
{
    partial class MitarbeiterBearbeiten
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MitarbeiterBearbeiten));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePickerAustrittsdatum = new System.Windows.Forms.DateTimePicker();
            this.BtnPasswortZuruecksetzen = new System.Windows.Forms.Button();
            this.LblAustrittsdatum = new System.Windows.Forms.Label();
            this.LblNachname = new System.Windows.Forms.Label();
            this.BtnSpeichern = new System.Windows.Forms.Button();
            this.textBoxNachname = new System.Windows.Forms.TextBox();
            this.LblEintrittsdatum = new System.Windows.Forms.Label();
            this.LblVorname = new System.Windows.Forms.Label();
            this.LblPersonalnummer = new System.Windows.Forms.Label();
            this.textBoxEintrittsdatum = new System.Windows.Forms.TextBox();
            this.textBoxVorname = new System.Windows.Forms.TextBox();
            this.TxtPersonalnummer = new System.Windows.Forms.TextBox();
            this.LblMitarbeiterBerarbeiten = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.CausesValidation = false;
            this.panel2.Controls.Add(this.dateTimePickerAustrittsdatum);
            this.panel2.Controls.Add(this.BtnPasswortZuruecksetzen);
            this.panel2.Controls.Add(this.LblAustrittsdatum);
            this.panel2.Controls.Add(this.LblNachname);
            this.panel2.Controls.Add(this.BtnSpeichern);
            this.panel2.Controls.Add(this.textBoxNachname);
            this.panel2.Controls.Add(this.LblEintrittsdatum);
            this.panel2.Controls.Add(this.LblVorname);
            this.panel2.Controls.Add(this.LblPersonalnummer);
            this.panel2.Controls.Add(this.textBoxEintrittsdatum);
            this.panel2.Controls.Add(this.textBoxVorname);
            this.panel2.Controls.Add(this.TxtPersonalnummer);
            this.panel2.Location = new System.Drawing.Point(12, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 217);
            this.panel2.TabIndex = 30;
            // 
            // dateTimePickerAustrittsdatum
            // 
            this.dateTimePickerAustrittsdatum.Checked = false;
            this.dateTimePickerAustrittsdatum.Location = new System.Drawing.Point(250, 128);
            this.dateTimePickerAustrittsdatum.Name = "dateTimePickerAustrittsdatum";
            this.dateTimePickerAustrittsdatum.ShowCheckBox = true;
            this.dateTimePickerAustrittsdatum.Size = new System.Drawing.Size(220, 20);
            this.dateTimePickerAustrittsdatum.TabIndex = 6;
            // 
            // BtnPasswortZuruecksetzen
            // 
            this.BtnPasswortZuruecksetzen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnPasswortZuruecksetzen.Location = new System.Drawing.Point(10, 176);
            this.BtnPasswortZuruecksetzen.Name = "BtnPasswortZuruecksetzen";
            this.BtnPasswortZuruecksetzen.Size = new System.Drawing.Size(210, 23);
            this.BtnPasswortZuruecksetzen.TabIndex = 7;
            this.BtnPasswortZuruecksetzen.Text = "Passwort zurücksetzen";
            this.BtnPasswortZuruecksetzen.UseVisualStyleBackColor = true;
            this.BtnPasswortZuruecksetzen.Click += new System.EventHandler(this.BtnPasswortZuruecksetzen_Click);
            // 
            // LblAustrittsdatum
            // 
            this.LblAustrittsdatum.AutoSize = true;
            this.LblAustrittsdatum.Location = new System.Drawing.Point(249, 111);
            this.LblAustrittsdatum.Name = "LblAustrittsdatum";
            this.LblAustrittsdatum.Size = new System.Drawing.Size(76, 13);
            this.LblAustrittsdatum.TabIndex = 14;
            this.LblAustrittsdatum.Text = "Austrittsdatum:";
            // 
            // LblNachname
            // 
            this.LblNachname.AutoSize = true;
            this.LblNachname.Location = new System.Drawing.Point(249, 57);
            this.LblNachname.Name = "LblNachname";
            this.LblNachname.Size = new System.Drawing.Size(62, 13);
            this.LblNachname.TabIndex = 14;
            this.LblNachname.Text = "Nachname:";
            // 
            // BtnSpeichern
            // 
            this.BtnSpeichern.Location = new System.Drawing.Point(370, 176);
            this.BtnSpeichern.Name = "BtnSpeichern";
            this.BtnSpeichern.Size = new System.Drawing.Size(100, 23);
            this.BtnSpeichern.TabIndex = 8;
            this.BtnSpeichern.Text = "Speichern";
            this.BtnSpeichern.UseVisualStyleBackColor = true;
            this.BtnSpeichern.Click += new System.EventHandler(this.BtnSpeichern_Click);
            // 
            // textBoxNachname
            // 
            this.textBoxNachname.Location = new System.Drawing.Point(250, 76);
            this.textBoxNachname.MaxLength = 50;
            this.textBoxNachname.Name = "textBoxNachname";
            this.textBoxNachname.Size = new System.Drawing.Size(220, 20);
            this.textBoxNachname.TabIndex = 4;
            // 
            // LblEintrittsdatum
            // 
            this.LblEintrittsdatum.AutoSize = true;
            this.LblEintrittsdatum.Location = new System.Drawing.Point(10, 110);
            this.LblEintrittsdatum.Name = "LblEintrittsdatum";
            this.LblEintrittsdatum.Size = new System.Drawing.Size(73, 13);
            this.LblEintrittsdatum.TabIndex = 12;
            this.LblEintrittsdatum.Text = "Eintrittsdatum:";
            // 
            // LblVorname
            // 
            this.LblVorname.AutoSize = true;
            this.LblVorname.Location = new System.Drawing.Point(10, 56);
            this.LblVorname.Name = "LblVorname";
            this.LblVorname.Size = new System.Drawing.Size(52, 13);
            this.LblVorname.TabIndex = 12;
            this.LblVorname.Text = "Vorname:";
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
            // textBoxEintrittsdatum
            // 
            this.textBoxEintrittsdatum.Location = new System.Drawing.Point(10, 129);
            this.textBoxEintrittsdatum.Name = "textBoxEintrittsdatum";
            this.textBoxEintrittsdatum.ReadOnly = true;
            this.textBoxEintrittsdatum.Size = new System.Drawing.Size(210, 20);
            this.textBoxEintrittsdatum.TabIndex = 5;
            // 
            // textBoxVorname
            // 
            this.textBoxVorname.Location = new System.Drawing.Point(10, 75);
            this.textBoxVorname.MaxLength = 50;
            this.textBoxVorname.Name = "textBoxVorname";
            this.textBoxVorname.Size = new System.Drawing.Size(210, 20);
            this.textBoxVorname.TabIndex = 3;
            // 
            // TxtPersonalnummer
            // 
            this.TxtPersonalnummer.Location = new System.Drawing.Point(10, 23);
            this.TxtPersonalnummer.Name = "TxtPersonalnummer";
            this.TxtPersonalnummer.ReadOnly = true;
            this.TxtPersonalnummer.Size = new System.Drawing.Size(210, 20);
            this.TxtPersonalnummer.TabIndex = 1;
            // 
            // LblMitarbeiterBerarbeiten
            // 
            this.LblMitarbeiterBerarbeiten.AutoSize = true;
            this.LblMitarbeiterBerarbeiten.CausesValidation = false;
            this.LblMitarbeiterBerarbeiten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMitarbeiterBerarbeiten.Location = new System.Drawing.Point(12, 9);
            this.LblMitarbeiterBerarbeiten.Name = "LblMitarbeiterBerarbeiten";
            this.LblMitarbeiterBerarbeiten.Size = new System.Drawing.Size(168, 20);
            this.LblMitarbeiterBerarbeiten.TabIndex = 40;
            this.LblMitarbeiterBerarbeiten.Text = "Mitarbeiter bearbeiten:";
            // 
            // MitarbeiterBearbeiten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 256);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LblMitarbeiterBerarbeiten);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MitarbeiterBearbeiten";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wifi Arbeitszeitfassung";
            this.Load += new System.EventHandler(this.MitarbeiterBearbeiten_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblAustrittsdatum;
        private System.Windows.Forms.Label LblNachname;
        private System.Windows.Forms.Button BtnSpeichern;
        private System.Windows.Forms.TextBox textBoxNachname;
        private System.Windows.Forms.Label LblEintrittsdatum;
        private System.Windows.Forms.Label LblVorname;
        private System.Windows.Forms.Label LblPersonalnummer;
        private System.Windows.Forms.TextBox textBoxEintrittsdatum;
        private System.Windows.Forms.TextBox textBoxVorname;
        private System.Windows.Forms.TextBox TxtPersonalnummer;
        private System.Windows.Forms.Label LblMitarbeiterBerarbeiten;
        private System.Windows.Forms.Button BtnPasswortZuruecksetzen;
        private System.Windows.Forms.DateTimePicker dateTimePickerAustrittsdatum;
    }
}