namespace ProjektZeiterfassung.View
{
    partial class Mainpanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainpanel));
            this.AnmeldePanel = new System.Windows.Forms.Panel();
            this.BtnAnmeldung = new System.Windows.Forms.Button();
            this.TxtPersonalNummer = new System.Windows.Forms.TextBox();
            this.AnmeldeLabel = new System.Windows.Forms.Label();
            this.PersonenDatenPanel = new System.Windows.Forms.Panel();
            this.TxtBenutzerdaten = new System.Windows.Forms.TextBox();
            this.BenutzDatenLabel = new System.Windows.Forms.Label();
            this.BedienungsPanel = new System.Windows.Forms.Panel();
            this.BtnÜbersicht = new System.Windows.Forms.Button();
            this.BtnZeiterfassung = new System.Windows.Forms.Button();
            this.AuswahlLabel = new System.Windows.Forms.Label();
            this.mitarbeiterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zEIT2017DataSet = new ProjektZeiterfassung.ZEIT2017DataSet();
            this.mitarbeiterTableAdapter = new ProjektZeiterfassung.ZEIT2017DataSetTableAdapters.MitarbeiterTableAdapter();
            this.AnmeldePanel.SuspendLayout();
            this.PersonenDatenPanel.SuspendLayout();
            this.BedienungsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mitarbeiterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zEIT2017DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // AnmeldePanel
            // 
            this.AnmeldePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AnmeldePanel.Controls.Add(this.BtnAnmeldung);
            this.AnmeldePanel.Controls.Add(this.TxtPersonalNummer);
            this.AnmeldePanel.Controls.Add(this.AnmeldeLabel);
            this.AnmeldePanel.Location = new System.Drawing.Point(8, 9);
            this.AnmeldePanel.Name = "AnmeldePanel";
            this.AnmeldePanel.Size = new System.Drawing.Size(258, 143);
            this.AnmeldePanel.TabIndex = 0;
            // 
            // BtnAnmeldung
            // 
            this.BtnAnmeldung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnmeldung.Location = new System.Drawing.Point(124, 52);
            this.BtnAnmeldung.Name = "BtnAnmeldung";
            this.BtnAnmeldung.Padding = new System.Windows.Forms.Padding(5);
            this.BtnAnmeldung.Size = new System.Drawing.Size(119, 44);
            this.BtnAnmeldung.TabIndex = 4;
            this.BtnAnmeldung.Text = "Anmelden";
            this.BtnAnmeldung.UseVisualStyleBackColor = true;
            // 
            // TxtPersonalNummer
            // 
            this.TxtPersonalNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPersonalNummer.Location = new System.Drawing.Point(10, 52);
            this.TxtPersonalNummer.Name = "TxtPersonalNummer";
            this.TxtPersonalNummer.Size = new System.Drawing.Size(86, 44);
            this.TxtPersonalNummer.TabIndex = 3;
            // 
            // AnmeldeLabel
            // 
            this.AnmeldeLabel.AutoSize = true;
            this.AnmeldeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnmeldeLabel.Location = new System.Drawing.Point(4, 0);
            this.AnmeldeLabel.Name = "AnmeldeLabel";
            this.AnmeldeLabel.Size = new System.Drawing.Size(239, 20);
            this.AnmeldeLabel.TabIndex = 0;
            this.AnmeldeLabel.Text = "Anmeldung mit Personalnummer";
            // 
            // PersonenDatenPanel
            // 
            this.PersonenDatenPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PersonenDatenPanel.Controls.Add(this.TxtBenutzerdaten);
            this.PersonenDatenPanel.Controls.Add(this.BenutzDatenLabel);
            this.PersonenDatenPanel.Location = new System.Drawing.Point(272, 9);
            this.PersonenDatenPanel.Name = "PersonenDatenPanel";
            this.PersonenDatenPanel.Size = new System.Drawing.Size(217, 143);
            this.PersonenDatenPanel.TabIndex = 1;
            // 
            // TxtBenutzerdaten
            // 
            this.TxtBenutzerdaten.BackColor = System.Drawing.Color.PeachPuff;
            this.TxtBenutzerdaten.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBenutzerdaten.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TxtBenutzerdaten.Location = new System.Drawing.Point(9, 28);
            this.TxtBenutzerdaten.Multiline = true;
            this.TxtBenutzerdaten.Name = "TxtBenutzerdaten";
            this.TxtBenutzerdaten.ReadOnly = true;
            this.TxtBenutzerdaten.Size = new System.Drawing.Size(199, 96);
            this.TxtBenutzerdaten.TabIndex = 2;
            // 
            // BenutzDatenLabel
            // 
            this.BenutzDatenLabel.AutoSize = true;
            this.BenutzDatenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BenutzDatenLabel.Location = new System.Drawing.Point(3, 0);
            this.BenutzDatenLabel.Name = "BenutzDatenLabel";
            this.BenutzDatenLabel.Size = new System.Drawing.Size(115, 20);
            this.BenutzDatenLabel.TabIndex = 1;
            this.BenutzDatenLabel.Text = "Benutzerdaten";
            // 
            // BedienungsPanel
            // 
            this.BedienungsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BedienungsPanel.Controls.Add(this.BtnÜbersicht);
            this.BedienungsPanel.Controls.Add(this.BtnZeiterfassung);
            this.BedienungsPanel.Controls.Add(this.AuswahlLabel);
            this.BedienungsPanel.Location = new System.Drawing.Point(9, 158);
            this.BedienungsPanel.Name = "BedienungsPanel";
            this.BedienungsPanel.Size = new System.Drawing.Size(480, 202);
            this.BedienungsPanel.TabIndex = 2;
            // 
            // BtnÜbersicht
            // 
            this.BtnÜbersicht.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnÜbersicht.Location = new System.Drawing.Point(21, 28);
            this.BtnÜbersicht.Name = "BtnÜbersicht";
            this.BtnÜbersicht.Padding = new System.Windows.Forms.Padding(5);
            this.BtnÜbersicht.Size = new System.Drawing.Size(140, 44);
            this.BtnÜbersicht.TabIndex = 6;
            this.BtnÜbersicht.Text = "Zeitübersicht...";
            this.BtnÜbersicht.UseVisualStyleBackColor = true;
            // 
            // BtnZeiterfassung
            // 
            this.BtnZeiterfassung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnZeiterfassung.Location = new System.Drawing.Point(306, 28);
            this.BtnZeiterfassung.Name = "BtnZeiterfassung";
            this.BtnZeiterfassung.Padding = new System.Windows.Forms.Padding(5);
            this.BtnZeiterfassung.Size = new System.Drawing.Size(140, 44);
            this.BtnZeiterfassung.TabIndex = 5;
            this.BtnZeiterfassung.Text = "Zeiterfassung...";
            this.BtnZeiterfassung.UseVisualStyleBackColor = true;
            // 
            // AuswahlLabel
            // 
            this.AuswahlLabel.AutoSize = true;
            this.AuswahlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuswahlLabel.Location = new System.Drawing.Point(3, 0);
            this.AuswahlLabel.Name = "AuswahlLabel";
            this.AuswahlLabel.Size = new System.Drawing.Size(69, 20);
            this.AuswahlLabel.TabIndex = 2;
            this.AuswahlLabel.Text = "Auswahl";
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
            // Mainpanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(494, 360);
            this.Controls.Add(this.BedienungsPanel);
            this.Controls.Add(this.PersonenDatenPanel);
            this.Controls.Add(this.AnmeldePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mainpanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hauptfenster Zeiterfassung";
            this.Load += new System.EventHandler(this.Mainpanel_Load);
            this.AnmeldePanel.ResumeLayout(false);
            this.AnmeldePanel.PerformLayout();
            this.PersonenDatenPanel.ResumeLayout(false);
            this.PersonenDatenPanel.PerformLayout();
            this.BedienungsPanel.ResumeLayout(false);
            this.BedienungsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mitarbeiterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zEIT2017DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AnmeldePanel;
        private System.Windows.Forms.Button BtnAnmeldung;
        private System.Windows.Forms.TextBox TxtPersonalNummer;
        private System.Windows.Forms.Label AnmeldeLabel;
        private System.Windows.Forms.Panel PersonenDatenPanel;
        private System.Windows.Forms.TextBox TxtBenutzerdaten;
        private System.Windows.Forms.Label BenutzDatenLabel;
        private System.Windows.Forms.Panel BedienungsPanel;
        private System.Windows.Forms.Button BtnÜbersicht;
        private System.Windows.Forms.Button BtnZeiterfassung;
        private System.Windows.Forms.Label AuswahlLabel;
        private ZEIT2017DataSet zEIT2017DataSet;
        private System.Windows.Forms.BindingSource mitarbeiterBindingSource;
        private ZEIT2017DataSetTableAdapters.MitarbeiterTableAdapter mitarbeiterTableAdapter;
    }
}