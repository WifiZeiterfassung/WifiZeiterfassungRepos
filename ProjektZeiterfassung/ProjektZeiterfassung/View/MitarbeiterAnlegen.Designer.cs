namespace ProjektZeiterfassung.View
{
    partial class MitarbeiterAnlegen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MitarbeiterAnlegen));
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnPnGen = new System.Windows.Forms.Button();
            this.dateTimePickerEintritt = new System.Windows.Forms.DateTimePicker();
            this.LblNachname = new System.Windows.Forms.Label();
            this.BtnSpeichern = new System.Windows.Forms.Button();
            this.TxtNachname = new System.Windows.Forms.TextBox();
            this.LblEintrittsdatum = new System.Windows.Forms.Label();
            this.LblVorname = new System.Windows.Forms.Label();
            this.LblPersonalnummer = new System.Windows.Forms.Label();
            this.TxtVorname = new System.Windows.Forms.TextBox();
            this.TxtPersonalnummer = new System.Windows.Forms.TextBox();
            this.LblMitarbeiterAnlegen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSollStunden = new System.Windows.Forms.TextBox();
            this.ChkIsAdmin = new System.Windows.Forms.CheckBox();
            this.TxtMeldung = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.TxtMeldung);
            this.panel2.Controls.Add(this.ChkIsAdmin);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.TxtSollStunden);
            this.panel2.Controls.Add(this.BtnPnGen);
            this.panel2.Controls.Add(this.dateTimePickerEintritt);
            this.panel2.Controls.Add(this.LblNachname);
            this.panel2.Controls.Add(this.BtnSpeichern);
            this.panel2.Controls.Add(this.TxtNachname);
            this.panel2.Controls.Add(this.LblEintrittsdatum);
            this.panel2.Controls.Add(this.LblVorname);
            this.panel2.Controls.Add(this.LblPersonalnummer);
            this.panel2.Controls.Add(this.TxtVorname);
            this.panel2.Controls.Add(this.TxtPersonalnummer);
            this.panel2.Location = new System.Drawing.Point(12, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 217);
            this.panel2.TabIndex = 7;
            // 
            // BtnPnGen
            // 
            this.BtnPnGen.Location = new System.Drawing.Point(250, 20);
            this.BtnPnGen.Name = "BtnPnGen";
            this.BtnPnGen.Size = new System.Drawing.Size(100, 23);
            this.BtnPnGen.TabIndex = 5;
            this.BtnPnGen.Text = "Generieren";
            this.BtnPnGen.UseVisualStyleBackColor = true;
            this.BtnPnGen.Click += new System.EventHandler(this.BtnPnGen_Click);
            // 
            // dateTimePickerEintritt
            // 
            this.dateTimePickerEintritt.Location = new System.Drawing.Point(10, 128);
            this.dateTimePickerEintritt.Name = "dateTimePickerEintritt";
            this.dateTimePickerEintritt.Size = new System.Drawing.Size(210, 20);
            this.dateTimePickerEintritt.TabIndex = 8;
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
            this.BtnSpeichern.TabIndex = 11;
            this.BtnSpeichern.Text = "Speichern";
            this.BtnSpeichern.UseVisualStyleBackColor = true;
            this.BtnSpeichern.Click += new System.EventHandler(this.BtnSpeichern_Click);
            // 
            // TxtNachname
            // 
            this.TxtNachname.Location = new System.Drawing.Point(250, 76);
            this.TxtNachname.Name = "TxtNachname";
            this.TxtNachname.Size = new System.Drawing.Size(220, 20);
            this.TxtNachname.TabIndex = 7;
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
            // TxtVorname
            // 
            this.TxtVorname.Location = new System.Drawing.Point(10, 75);
            this.TxtVorname.Name = "TxtVorname";
            this.TxtVorname.Size = new System.Drawing.Size(210, 20);
            this.TxtVorname.TabIndex = 6;
            // 
            // TxtPersonalnummer
            // 
            this.TxtPersonalnummer.Location = new System.Drawing.Point(10, 23);
            this.TxtPersonalnummer.Name = "TxtPersonalnummer";
            this.TxtPersonalnummer.Size = new System.Drawing.Size(210, 20);
            this.TxtPersonalnummer.TabIndex = 4;
            // 
            // LblMitarbeiterAnlegen
            // 
            this.LblMitarbeiterAnlegen.AutoSize = true;
            this.LblMitarbeiterAnlegen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMitarbeiterAnlegen.Location = new System.Drawing.Point(12, 4);
            this.LblMitarbeiterAnlegen.Name = "LblMitarbeiterAnlegen";
            this.LblMitarbeiterAnlegen.Size = new System.Drawing.Size(149, 20);
            this.LblMitarbeiterAnlegen.TabIndex = 6;
            this.LblMitarbeiterAnlegen.Text = "Mitarbeiter anlegen:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Soll Stunden:";
            // 
            // TxtSollStunden
            // 
            this.TxtSollStunden.Location = new System.Drawing.Point(248, 129);
            this.TxtSollStunden.Name = "TxtSollStunden";
            this.TxtSollStunden.Size = new System.Drawing.Size(63, 20);
            this.TxtSollStunden.TabIndex = 9;
            // 
            // ChkIsAdmin
            // 
            this.ChkIsAdmin.AutoSize = true;
            this.ChkIsAdmin.Location = new System.Drawing.Point(10, 176);
            this.ChkIsAdmin.Name = "ChkIsAdmin";
            this.ChkIsAdmin.Size = new System.Drawing.Size(100, 17);
            this.ChkIsAdmin.TabIndex = 10;
            this.ChkIsAdmin.Text = "Ist Administrator";
            this.ChkIsAdmin.UseVisualStyleBackColor = true;
            // 
            // TxtMeldung
            // 
            this.TxtMeldung.Location = new System.Drawing.Point(130, 163);
            this.TxtMeldung.MaxLength = 255;
            this.TxtMeldung.Multiline = true;
            this.TxtMeldung.Name = "TxtMeldung";
            this.TxtMeldung.ReadOnly = true;
            this.TxtMeldung.Size = new System.Drawing.Size(220, 36);
            this.TxtMeldung.TabIndex = 19;
            this.TxtMeldung.TabStop = false;
            // 
            // MitarbeiterAnlegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 256);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LblMitarbeiterAnlegen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MitarbeiterAnlegen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wifi Arbeitszeitfassung";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePickerEintritt;
        private System.Windows.Forms.Label LblNachname;
        private System.Windows.Forms.Button BtnSpeichern;
        private System.Windows.Forms.TextBox TxtNachname;
        private System.Windows.Forms.Label LblEintrittsdatum;
        private System.Windows.Forms.Label LblVorname;
        private System.Windows.Forms.Label LblPersonalnummer;
        private System.Windows.Forms.TextBox TxtVorname;
        private System.Windows.Forms.TextBox TxtPersonalnummer;
        private System.Windows.Forms.Label LblMitarbeiterAnlegen;
        private System.Windows.Forms.Button BtnPnGen;
        private System.Windows.Forms.CheckBox ChkIsAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSollStunden;
        private System.Windows.Forms.TextBox TxtMeldung;
    }
}