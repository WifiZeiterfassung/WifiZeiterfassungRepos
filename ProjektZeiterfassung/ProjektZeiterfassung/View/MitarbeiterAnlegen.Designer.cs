﻿namespace ProjektZeiterfassung.View
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
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.checkBoxAktiv = new System.Windows.Forms.CheckBox();
            this.LblAustrittsdatum = new System.Windows.Forms.Label();
            this.LblNachname = new System.Windows.Forms.Label();
            this.BtnSpeichern = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LblEintrittsdatum = new System.Windows.Forms.Label();
            this.LblVorname = new System.Windows.Forms.Label();
            this.LblPersonalnummer = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TxtPersonalnummer = new System.Windows.Forms.TextBox();
            this.LblMitarbeiterAnlegen = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.checkBoxAktiv);
            this.panel2.Controls.Add(this.LblAustrittsdatum);
            this.panel2.Controls.Add(this.LblNachname);
            this.panel2.Controls.Add(this.BtnSpeichern);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.LblEintrittsdatum);
            this.panel2.Controls.Add(this.LblVorname);
            this.panel2.Controls.Add(this.LblPersonalnummer);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.TxtPersonalnummer);
            this.panel2.Location = new System.Drawing.Point(12, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 217);
            this.panel2.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(10, 128);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(210, 20);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // checkBoxAktiv
            // 
            this.checkBoxAktiv.AutoSize = true;
            this.checkBoxAktiv.Location = new System.Drawing.Point(10, 182);
            this.checkBoxAktiv.Name = "checkBoxAktiv";
            this.checkBoxAktiv.Size = new System.Drawing.Size(50, 17);
            this.checkBoxAktiv.TabIndex = 10;
            this.checkBoxAktiv.Text = "Aktiv";
            this.checkBoxAktiv.UseVisualStyleBackColor = true;
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
            this.BtnSpeichern.TabIndex = 11;
            this.BtnSpeichern.Text = "Speichern";
            this.BtnSpeichern.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(250, 76);
            this.textBox2.MaxLength = 6;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(220, 20);
            this.textBox2.TabIndex = 7;
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(250, 128);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(220, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 20);
            this.textBox1.TabIndex = 6;
            // 
            // TxtPersonalnummer
            // 
            this.TxtPersonalnummer.Location = new System.Drawing.Point(10, 23);
            this.TxtPersonalnummer.Name = "TxtPersonalnummer";
            this.TxtPersonalnummer.Size = new System.Drawing.Size(210, 20);
            this.TxtPersonalnummer.TabIndex = 5;
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
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.CheckBox checkBoxAktiv;
        private System.Windows.Forms.Label LblAustrittsdatum;
        private System.Windows.Forms.Label LblNachname;
        private System.Windows.Forms.Button BtnSpeichern;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label LblEintrittsdatum;
        private System.Windows.Forms.Label LblVorname;
        private System.Windows.Forms.Label LblPersonalnummer;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TxtPersonalnummer;
        private System.Windows.Forms.Label LblMitarbeiterAnlegen;
    }
}