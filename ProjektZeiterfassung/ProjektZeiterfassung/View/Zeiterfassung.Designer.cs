namespace ProjektZeiterfassung.View
{
    partial class FormZeiterfassung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormZeiterfassung));
            this.LblAdministrationsbereich = new System.Windows.Forms.Label();
            this.PanelAdministrationsbereich = new System.Windows.Forms.Panel();
            this.BtnZeittypenBearbeiten = new System.Windows.Forms.Button();
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
            this.cmbWeiterZeittypen = new System.Windows.Forms.ComboBox();
            this.zeittypenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zEIT2017DataSet3 = new ProjektZeiterfassung.ZEIT2017DataSet3();
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
            this.zeittypenTableAdapter = new ProjektZeiterfassung.ZEIT2017DataSet3TableAdapters.ZeittypenTableAdapter();
            this.PanelAdministrationsbereich.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zeittypenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zEIT2017DataSet3)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zEIT2017DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitarbeiterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LblAdministrationsbereich
            // 
            this.LblAdministrationsbereich.AutoSize = true;
            this.LblAdministrationsbereich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAdministrationsbereich.Location = new System.Drawing.Point(12, 220);
            this.LblAdministrationsbereich.Name = "LblAdministrationsbereich";
            this.LblAdministrationsbereich.Size = new System.Drawing.Size(159, 20);
            this.LblAdministrationsbereich.TabIndex = 27;
            this.LblAdministrationsbereich.Text = "Administratorbereich:";
            // 
            // PanelAdministrationsbereich
            // 
            this.PanelAdministrationsbereich.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelAdministrationsbereich.Controls.Add(this.BtnZeittypenBearbeiten);
            this.PanelAdministrationsbereich.Controls.Add(this.BtnBenutzerUpdate);
            this.PanelAdministrationsbereich.Controls.Add(this.BtnZeitkorrektur);
            this.PanelAdministrationsbereich.Controls.Add(this.BtnBenutzerNeu);
            this.PanelAdministrationsbereich.Location = new System.Drawing.Point(12, 243);
            this.PanelAdministrationsbereich.Name = "PanelAdministrationsbereich";
            this.PanelAdministrationsbereich.Size = new System.Drawing.Size(484, 70);
            this.PanelAdministrationsbereich.TabIndex = 26;
            // 
            // BtnZeittypenBearbeiten
            // 
            this.BtnZeittypenBearbeiten.Location = new System.Drawing.Point(369, 14);
            this.BtnZeittypenBearbeiten.Name = "BtnZeittypenBearbeiten";
            this.BtnZeittypenBearbeiten.Size = new System.Drawing.Size(100, 37);
            this.BtnZeittypenBearbeiten.TabIndex = 16;
            this.BtnZeittypenBearbeiten.Text = "Zeittypen bearbeiten";
            this.BtnZeittypenBearbeiten.UseVisualStyleBackColor = true;
            this.BtnZeittypenBearbeiten.Click += new System.EventHandler(this.BtnZeittypenBearbeiten_Click);
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
            this.BtnPausenbeginn.Enabled = false;
            this.BtnPausenbeginn.Location = new System.Drawing.Point(98, 17);
            this.BtnPausenbeginn.Name = "BtnPausenbeginn";
            this.BtnPausenbeginn.Size = new System.Drawing.Size(90, 23);
            this.BtnPausenbeginn.TabIndex = 10;
            this.BtnPausenbeginn.Text = "Pausenbeginn";
            this.BtnPausenbeginn.UseVisualStyleBackColor = true;
            this.BtnPausenbeginn.Click += new System.EventHandler(this.BtnPausenbeginn_Click);
            // 
            // BtnPausenende
            // 
            this.BtnPausenende.Enabled = false;
            this.BtnPausenende.Location = new System.Drawing.Point(194, 17);
            this.BtnPausenende.Name = "BtnPausenende";
            this.BtnPausenende.Size = new System.Drawing.Size(90, 23);
            this.BtnPausenende.TabIndex = 11;
            this.BtnPausenende.Text = "Pausenende";
            this.BtnPausenende.UseVisualStyleBackColor = true;
            this.BtnPausenende.Click += new System.EventHandler(this.BtnPausenende_Click);
            // 
            // BtnArbeitsbeginn
            // 
            this.BtnArbeitsbeginn.Enabled = false;
            this.BtnArbeitsbeginn.Location = new System.Drawing.Point(2, 17);
            this.BtnArbeitsbeginn.Name = "BtnArbeitsbeginn";
            this.BtnArbeitsbeginn.Size = new System.Drawing.Size(90, 23);
            this.BtnArbeitsbeginn.TabIndex = 9;
            this.BtnArbeitsbeginn.Text = "Arbeitsbeginn";
            this.BtnArbeitsbeginn.UseVisualStyleBackColor = true;
            this.BtnArbeitsbeginn.Click += new System.EventHandler(this.BtnArbeitsbeginn_Click);
            // 
            // LablPin
            // 
            this.LablPin.AutoSize = true;
            this.LablPin.Location = new System.Drawing.Point(129, 4);
            this.LablPin.Name = "LablPin";
            this.LablPin.Size = new System.Drawing.Size(91, 13);
            this.LablPin.TabIndex = 14;
            this.LablPin.Text = "Pin (max 8-stellig):";
            // 
            // BtnPasswortAendern
            // 
            this.BtnPasswortAendern.Enabled = false;
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
            this.TxtPin.MaxLength = 10;
            this.TxtPin.Name = "TxtPin";
            this.TxtPin.PasswordChar = '*';
            this.TxtPin.Size = new System.Drawing.Size(100, 20);
            this.TxtPin.TabIndex = 2;
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
            this.BtnArbeitsende.Enabled = false;
            this.BtnArbeitsende.Location = new System.Drawing.Point(290, 17);
            this.BtnArbeitsende.Name = "BtnArbeitsende";
            this.BtnArbeitsende.Size = new System.Drawing.Size(90, 23);
            this.BtnArbeitsende.TabIndex = 12;
            this.BtnArbeitsende.Text = "Arbeitsende";
            this.BtnArbeitsende.UseVisualStyleBackColor = true;
            this.BtnArbeitsende.Click += new System.EventHandler(this.BtnArbeitsende_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.cmbWeiterZeittypen);
            this.panel3.Controls.Add(this.BtnArbeitsende);
            this.panel3.Controls.Add(this.BtnPausenbeginn);
            this.panel3.Controls.Add(this.BtnPausenende);
            this.panel3.Controls.Add(this.BtnArbeitsbeginn);
            this.panel3.Location = new System.Drawing.Point(12, 154);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(484, 61);
            this.panel3.TabIndex = 25;
            // 
            // cmbWeiterZeittypen
            // 
            this.cmbWeiterZeittypen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWeiterZeittypen.FormattingEnabled = true;
            this.cmbWeiterZeittypen.Location = new System.Drawing.Point(387, 18);
            this.cmbWeiterZeittypen.Name = "cmbWeiterZeittypen";
            this.cmbWeiterZeittypen.Size = new System.Drawing.Size(90, 21);
            this.cmbWeiterZeittypen.TabIndex = 13;
            //this.cmbWeiterZeittypen.SelectedIndexChanged += new System.EventHandler(this.cmbWeiterZeittypen_SelectedIndexChanged);
            this.cmbWeiterZeittypen.SelectionChangeCommitted += new System.EventHandler(this.cmbWeiterZeittypen_SelectionChangeCommitted);
            // 
            // zeittypenBindingSource
            // 
            this.zeittypenBindingSource.DataMember = "Zeittypen";
            this.zeittypenBindingSource.DataSource = this.zEIT2017DataSet3;
            // 
            // zEIT2017DataSet3
            // 
            this.zEIT2017DataSet3.DataSetName = "ZEIT2017DataSet3";
            this.zEIT2017DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnAnmelden
            // 
            this.BtnAnmelden.Location = new System.Drawing.Point(250, 21);
            this.BtnAnmelden.Name = "BtnAnmelden";
            this.BtnAnmelden.Size = new System.Drawing.Size(100, 23);
            this.BtnAnmelden.TabIndex = 3;
            this.BtnAnmelden.Text = "Anmelden";
            this.BtnAnmelden.UseVisualStyleBackColor = true;
            this.BtnAnmelden.Click += new System.EventHandler(this.BtnAnmelden_Click);
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
            this.TxtPersonalnummer.TabIndex = 1;
            // 
            // TxtBenutzerdaten
            // 
            this.TxtBenutzerdaten.BackColor = System.Drawing.Color.PeachPuff;
            this.TxtBenutzerdaten.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBenutzerdaten.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TxtBenutzerdaten.Location = new System.Drawing.Point(8, 23);
            this.TxtBenutzerdaten.Multiline = true;
            this.TxtBenutzerdaten.Name = "TxtBenutzerdaten";
            this.TxtBenutzerdaten.ReadOnly = true;
            this.TxtBenutzerdaten.Size = new System.Drawing.Size(461, 21);
            this.TxtBenutzerdaten.TabIndex = 4;
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
            // zeittypenTableAdapter
            // 
            this.zeittypenTableAdapter.ClearBeforeFill = true;
            // 
            // FormZeiterfassung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 319);
            this.Controls.Add(this.LblAdministrationsbereich);
            this.Controls.Add(this.PanelAdministrationsbereich);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AnmeldeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormZeiterfassung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wifi Arbeitszeitfassung";
            this.Load += new System.EventHandler(this.FormZeiterfassung_Load);
            this.PanelAdministrationsbereich.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.zeittypenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zEIT2017DataSet3)).EndInit();
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

        internal System.Windows.Forms.Label LblAdministrationsbereich;
        internal System.Windows.Forms.Panel PanelAdministrationsbereich;
        internal System.Windows.Forms.Button BtnBenutzerUpdate;
        internal System.Windows.Forms.Button BtnZeitkorrektur;
        internal System.Windows.Forms.Button BtnBenutzerNeu;
        internal System.Windows.Forms.Button BtnPausenbeginn;
        internal System.Windows.Forms.Button BtnPausenende;
        internal System.Windows.Forms.Button BtnArbeitsbeginn;
        internal System.Windows.Forms.Label LablPin;
        internal System.Windows.Forms.Button BtnPasswortAendern;
        internal System.Windows.Forms.TextBox TxtPin;
        internal System.Windows.Forms.Label LblPersonalnummer;
        internal System.Windows.Forms.Button BtnArbeitsende;
        internal System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Button BtnAnmelden;
        internal System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.TextBox TxtPersonalnummer;
        internal System.Windows.Forms.TextBox TxtBenutzerdaten;
        internal System.Windows.Forms.Label LblBenutzerdaten;
        internal System.Windows.Forms.Panel panel1;
        internal ZEIT2017DataSetTableAdapters.MitarbeiterTableAdapter mitarbeiterTableAdapter;
        internal ZEIT2017DataSet zEIT2017DataSet;
        internal System.Windows.Forms.BindingSource mitarbeiterBindingSource;
        internal System.Windows.Forms.Label AnmeldeLabel;
        internal System.Windows.Forms.Button BtnZeittypenBearbeiten;
        private System.Windows.Forms.ComboBox cmbWeiterZeittypen;
        private ZEIT2017DataSet3 zEIT2017DataSet3;
        private System.Windows.Forms.BindingSource zeittypenBindingSource;
        private ZEIT2017DataSet3TableAdapters.ZeittypenTableAdapter zeittypenTableAdapter;
    }
}