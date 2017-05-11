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
            this.LblEndDatum = new System.Windows.Forms.Label();
            this.LblStartDatum = new System.Windows.Forms.Label();
            this.LblTagesDifferenz = new System.Windows.Forms.Label();
            this.TxtTagesDifferenz = new System.Windows.Forms.TextBox();
            this.LblTagesIstZeit = new System.Windows.Forms.Label();
            this.TxtTagesIstZeit = new System.Windows.Forms.TextBox();
            this.LblTagesSollZeit = new System.Windows.Forms.Label();
            this.TxtTagesSollZeit = new System.Windows.Forms.TextBox();
            this.BtnExport = new System.Windows.Forms.Button();
            this.DateTimeEndDatum = new System.Windows.Forms.DateTimePicker();
            this.DateTimeStartDatum = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TxtZeiterfassung = new System.Windows.Forms.TextBox();
            this.LblUebersichtZeiterfassung = new System.Windows.Forms.Label();
            this.BtnArbeitsbeginn = new System.Windows.Forms.Button();
            this.BtnPausenbeginn = new System.Windows.Forms.Button();
            this.BtnPausenende = new System.Windows.Forms.Button();
            this.BtnArbeitsende = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mitarbeiterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zEIT2017DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(311, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 55);
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
            this.TxtBenutzerdaten.Size = new System.Drawing.Size(341, 21);
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
            this.panel2.Size = new System.Drawing.Size(293, 55);
            this.panel2.TabIndex = 3;
            // 
            // LablPin
            // 
            this.LablPin.AutoSize = true;
            this.LablPin.Location = new System.Drawing.Point(96, 4);
            this.LablPin.Name = "LablPin";
            this.LablPin.Size = new System.Drawing.Size(69, 13);
            this.LablPin.TabIndex = 14;
            this.LablPin.Text = "Pin (6-stellig):";
            // 
            // TxtPin
            // 
            this.TxtPin.Location = new System.Drawing.Point(96, 23);
            this.TxtPin.MaxLength = 6;
            this.TxtPin.Name = "TxtPin";
            this.TxtPin.PasswordChar = '*';
            this.TxtPin.Size = new System.Drawing.Size(80, 20);
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
            this.BtnAnmelden.Location = new System.Drawing.Point(182, 21);
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
            this.TxtPersonalnummer.Size = new System.Drawing.Size(80, 20);
            this.TxtPersonalnummer.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.BtnArbeitsende);
            this.panel3.Controls.Add(this.BtnPausenbeginn);
            this.panel3.Controls.Add(this.BtnPausenende);
            this.panel3.Controls.Add(this.BtnArbeitsbeginn);
            this.panel3.Controls.Add(this.LblTagesDifferenz);
            this.panel3.Controls.Add(this.TxtTagesDifferenz);
            this.panel3.Controls.Add(this.LblTagesIstZeit);
            this.panel3.Controls.Add(this.TxtTagesIstZeit);
            this.panel3.Controls.Add(this.LblTagesSollZeit);
            this.panel3.Controls.Add(this.TxtTagesSollZeit);
            this.panel3.Controls.Add(this.BtnExport);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(12, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(659, 460);
            this.panel3.TabIndex = 5;
            // 
            // LblEndDatum
            // 
            this.LblEndDatum.AutoSize = true;
            this.LblEndDatum.Location = new System.Drawing.Point(432, 6);
            this.LblEndDatum.Name = "LblEndDatum";
            this.LblEndDatum.Size = new System.Drawing.Size(106, 13);
            this.LblEndDatum.TabIndex = 20;
            this.LblEndDatum.Text = "Enddatum Übersicht:";
            this.LblEndDatum.Click += new System.EventHandler(this.label9_Click);
            // 
            // LblStartDatum
            // 
            this.LblStartDatum.AutoSize = true;
            this.LblStartDatum.Location = new System.Drawing.Point(226, 7);
            this.LblStartDatum.Name = "LblStartDatum";
            this.LblStartDatum.Size = new System.Drawing.Size(109, 13);
            this.LblStartDatum.TabIndex = 19;
            this.LblStartDatum.Text = "Startdatum Übersicht:";
            // 
            // LblTagesDifferenz
            // 
            this.LblTagesDifferenz.AutoSize = true;
            this.LblTagesDifferenz.Location = new System.Drawing.Point(261, 413);
            this.LblTagesDifferenz.Name = "LblTagesDifferenz";
            this.LblTagesDifferenz.Size = new System.Drawing.Size(85, 13);
            this.LblTagesDifferenz.TabIndex = 18;
            this.LblTagesDifferenz.Text = "Tages-Differenz:";
            this.LblTagesDifferenz.Click += new System.EventHandler(this.label6_Click);
            // 
            // TxtTagesDifferenz
            // 
            this.TxtTagesDifferenz.Location = new System.Drawing.Point(261, 429);
            this.TxtTagesDifferenz.Name = "TxtTagesDifferenz";
            this.TxtTagesDifferenz.Size = new System.Drawing.Size(120, 20);
            this.TxtTagesDifferenz.TabIndex = 17;
            this.TxtTagesDifferenz.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // LblTagesIstZeit
            // 
            this.LblTagesIstZeit.AutoSize = true;
            this.LblTagesIstZeit.Location = new System.Drawing.Point(135, 413);
            this.LblTagesIstZeit.Name = "LblTagesIstZeit";
            this.LblTagesIstZeit.Size = new System.Drawing.Size(75, 13);
            this.LblTagesIstZeit.TabIndex = 16;
            this.LblTagesIstZeit.Text = "Tages-Ist-Zeit:";
            this.LblTagesIstZeit.Click += new System.EventHandler(this.label5_Click);
            // 
            // TxtTagesIstZeit
            // 
            this.TxtTagesIstZeit.Location = new System.Drawing.Point(135, 429);
            this.TxtTagesIstZeit.Name = "TxtTagesIstZeit";
            this.TxtTagesIstZeit.Size = new System.Drawing.Size(120, 20);
            this.TxtTagesIstZeit.TabIndex = 15;
            this.TxtTagesIstZeit.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // LblTagesSollZeit
            // 
            this.LblTagesSollZeit.AutoSize = true;
            this.LblTagesSollZeit.Location = new System.Drawing.Point(6, 413);
            this.LblTagesSollZeit.Name = "LblTagesSollZeit";
            this.LblTagesSollZeit.Size = new System.Drawing.Size(81, 13);
            this.LblTagesSollZeit.TabIndex = 14;
            this.LblTagesSollZeit.Text = "Tages-Soll-Zeit:";
            this.LblTagesSollZeit.Click += new System.EventHandler(this.label4_Click);
            // 
            // TxtTagesSollZeit
            // 
            this.TxtTagesSollZeit.Location = new System.Drawing.Point(9, 429);
            this.TxtTagesSollZeit.Name = "TxtTagesSollZeit";
            this.TxtTagesSollZeit.Size = new System.Drawing.Size(120, 20);
            this.TxtTagesSollZeit.TabIndex = 13;
            this.TxtTagesSollZeit.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // BtnExport
            // 
            this.BtnExport.Location = new System.Drawing.Point(547, 426);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(100, 23);
            this.BtnExport.TabIndex = 13;
            this.BtnExport.Text = "Export";
            this.BtnExport.UseVisualStyleBackColor = true;
            this.BtnExport.Click += new System.EventHandler(this.button5_Click);
            // 
            // DateTimeEndDatum
            // 
            this.DateTimeEndDatum.Location = new System.Drawing.Point(435, 23);
            this.DateTimeEndDatum.Name = "DateTimeEndDatum";
            this.DateTimeEndDatum.Size = new System.Drawing.Size(200, 20);
            this.DateTimeEndDatum.TabIndex = 10;
            // 
            // DateTimeStartDatum
            // 
            this.DateTimeStartDatum.Location = new System.Drawing.Point(229, 23);
            this.DateTimeStartDatum.Name = "DateTimeStartDatum";
            this.DateTimeStartDatum.Size = new System.Drawing.Size(200, 20);
            this.DateTimeStartDatum.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.TxtZeiterfassung);
            this.panel4.Controls.Add(this.LblEndDatum);
            this.panel4.Controls.Add(this.LblUebersichtZeiterfassung);
            this.panel4.Controls.Add(this.LblStartDatum);
            this.panel4.Controls.Add(this.DateTimeStartDatum);
            this.panel4.Controls.Add(this.DateTimeEndDatum);
            this.panel4.Location = new System.Drawing.Point(9, 53);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(648, 354);
            this.panel4.TabIndex = 5;
            // 
            // TxtZeiterfassung
            // 
            this.TxtZeiterfassung.BackColor = System.Drawing.Color.PeachPuff;
            this.TxtZeiterfassung.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtZeiterfassung.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TxtZeiterfassung.Location = new System.Drawing.Point(3, 50);
            this.TxtZeiterfassung.Multiline = true;
            this.TxtZeiterfassung.Name = "TxtZeiterfassung";
            this.TxtZeiterfassung.ReadOnly = true;
            this.TxtZeiterfassung.Size = new System.Drawing.Size(633, 297);
            this.TxtZeiterfassung.TabIndex = 2;
            // 
            // LblUebersichtZeiterfassung
            // 
            this.LblUebersichtZeiterfassung.AutoSize = true;
            this.LblUebersichtZeiterfassung.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUebersichtZeiterfassung.Location = new System.Drawing.Point(3, 7);
            this.LblUebersichtZeiterfassung.Name = "LblUebersichtZeiterfassung";
            this.LblUebersichtZeiterfassung.Size = new System.Drawing.Size(122, 13);
            this.LblUebersichtZeiterfassung.TabIndex = 1;
            this.LblUebersichtZeiterfassung.Text = "Übersicht Zeiterfassung:";
            this.LblUebersichtZeiterfassung.Click += new System.EventHandler(this.label2_Click);
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
            // BtnArbeitsende
            // 
            this.BtnArbeitsende.Location = new System.Drawing.Point(546, 14);
            this.BtnArbeitsende.Name = "BtnArbeitsende";
            this.BtnArbeitsende.Size = new System.Drawing.Size(100, 23);
            this.BtnArbeitsende.TabIndex = 19;
            this.BtnArbeitsende.Text = "Arbeitsende";
            this.BtnArbeitsende.UseVisualStyleBackColor = true;
            // 
            // Mainpanel2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AnmeldeLabel);
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
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox TxtZeiterfassung;
        private System.Windows.Forms.Label LblUebersichtZeiterfassung;
        private System.Windows.Forms.DateTimePicker DateTimeStartDatum;
        private System.Windows.Forms.DateTimePicker DateTimeEndDatum;
        private System.Windows.Forms.Label LblPersonalnummer;
        private System.Windows.Forms.Button BtnAnmelden;
        private System.Windows.Forms.TextBox TxtPersonalnummer;
        private System.Windows.Forms.Label LblTagesDifferenz;
        private System.Windows.Forms.TextBox TxtTagesDifferenz;
        private System.Windows.Forms.Label LblTagesIstZeit;
        private System.Windows.Forms.TextBox TxtTagesIstZeit;
        private System.Windows.Forms.Label LblTagesSollZeit;
        private System.Windows.Forms.TextBox TxtTagesSollZeit;
        private System.Windows.Forms.Button BtnExport;
        private System.Windows.Forms.Label LblEndDatum;
        private System.Windows.Forms.Label LblStartDatum;
        private System.Windows.Forms.Label LablPin;
        private System.Windows.Forms.TextBox TxtPin;
        private System.Windows.Forms.Button BtnArbeitsende;
        private System.Windows.Forms.Button BtnPausenbeginn;
        private System.Windows.Forms.Button BtnPausenende;
        private System.Windows.Forms.Button BtnArbeitsbeginn;
    }
}