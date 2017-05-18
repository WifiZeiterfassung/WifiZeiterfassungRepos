namespace ProjektZeiterfassung.View
{
    partial class Zeituebersicht
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zeituebersicht));
            this.BtnZurZeiterfassung = new System.Windows.Forms.Button();
            this.TxtAnfangsdatum = new System.Windows.Forms.TextBox();
            this.BtnSuche = new System.Windows.Forms.Button();
            this.AnfgangsdatumLabel = new System.Windows.Forms.Label();
            this.EnddatumLabel = new System.Windows.Forms.Label();
            this.TxtEnddatum = new System.Windows.Forms.TextBox();
            this.BtnExport = new System.Windows.Forms.Button();
            this.dataGridUebersicht = new System.Windows.Forms.DataGridView();
            this.zEIT2017DataSet1 = new ProjektZeiterfassung.ZEIT2017DataSet1();
            this.mitarbeiterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mitarbeiterTableAdapter = new ProjektZeiterfassung.ZEIT2017DataSet1TableAdapters.MitarbeiterTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalnummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nachnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagesSollZeitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eintrittsDatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.istAktivDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUebersicht)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zEIT2017DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitarbeiterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnZurZeiterfassung
            // 
            this.BtnZurZeiterfassung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnZurZeiterfassung.Location = new System.Drawing.Point(12, 505);
            this.BtnZurZeiterfassung.Name = "BtnZurZeiterfassung";
            this.BtnZurZeiterfassung.Padding = new System.Windows.Forms.Padding(5);
            this.BtnZurZeiterfassung.Size = new System.Drawing.Size(140, 44);
            this.BtnZurZeiterfassung.TabIndex = 7;
            this.BtnZurZeiterfassung.Text = "Zeiterfassung...";
            this.BtnZurZeiterfassung.UseVisualStyleBackColor = true;
            // 
            // TxtAnfangsdatum
            // 
            this.TxtAnfangsdatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAnfangsdatum.Location = new System.Drawing.Point(12, 36);
            this.TxtAnfangsdatum.Name = "TxtAnfangsdatum";
            this.TxtAnfangsdatum.Size = new System.Drawing.Size(181, 44);
            this.TxtAnfangsdatum.TabIndex = 10;
            this.TxtAnfangsdatum.Text = "12.05.2017";
            this.TxtAnfangsdatum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnSuche
            // 
            this.BtnSuche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSuche.Location = new System.Drawing.Point(422, 36);
            this.BtnSuche.Name = "BtnSuche";
            this.BtnSuche.Padding = new System.Windows.Forms.Padding(5);
            this.BtnSuche.Size = new System.Drawing.Size(140, 44);
            this.BtnSuche.TabIndex = 9;
            this.BtnSuche.Text = "Suche";
            this.BtnSuche.UseVisualStyleBackColor = true;
            // 
            // AnfgangsdatumLabel
            // 
            this.AnfgangsdatumLabel.AutoSize = true;
            this.AnfgangsdatumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnfgangsdatumLabel.Location = new System.Drawing.Point(8, 10);
            this.AnfgangsdatumLabel.Name = "AnfgangsdatumLabel";
            this.AnfgangsdatumLabel.Size = new System.Drawing.Size(118, 20);
            this.AnfgangsdatumLabel.TabIndex = 12;
            this.AnfgangsdatumLabel.Text = "Anfangsdatum:";
            // 
            // EnddatumLabel
            // 
            this.EnddatumLabel.AutoSize = true;
            this.EnddatumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnddatumLabel.Location = new System.Drawing.Point(212, 10);
            this.EnddatumLabel.Name = "EnddatumLabel";
            this.EnddatumLabel.Size = new System.Drawing.Size(87, 20);
            this.EnddatumLabel.TabIndex = 13;
            this.EnddatumLabel.Text = "Enddatum:";
            // 
            // TxtEnddatum
            // 
            this.TxtEnddatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEnddatum.Location = new System.Drawing.Point(216, 36);
            this.TxtEnddatum.Name = "TxtEnddatum";
            this.TxtEnddatum.Size = new System.Drawing.Size(181, 44);
            this.TxtEnddatum.TabIndex = 14;
            this.TxtEnddatum.Text = "12.05.2017";
            this.TxtEnddatum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnExport
            // 
            this.BtnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExport.Location = new System.Drawing.Point(422, 505);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Padding = new System.Windows.Forms.Padding(5);
            this.BtnExport.Size = new System.Drawing.Size(140, 44);
            this.BtnExport.TabIndex = 15;
            this.BtnExport.Text = "Export to Excel";
            this.BtnExport.UseVisualStyleBackColor = true;
            // 
            // dataGridUebersicht
            // 
            this.dataGridUebersicht.AllowUserToAddRows = false;
            this.dataGridUebersicht.AllowUserToDeleteRows = false;
            this.dataGridUebersicht.AutoGenerateColumns = false;
            this.dataGridUebersicht.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridUebersicht.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUebersicht.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.personalnummerDataGridViewTextBoxColumn,
            this.vornameDataGridViewTextBoxColumn,
            this.nachnameDataGridViewTextBoxColumn,
            this.tagesSollZeitDataGridViewTextBoxColumn,
            this.eintrittsDatumDataGridViewTextBoxColumn,
            this.istAktivDataGridViewCheckBoxColumn});
            this.dataGridUebersicht.DataSource = this.mitarbeiterBindingSource;
            this.dataGridUebersicht.Location = new System.Drawing.Point(13, 87);
            this.dataGridUebersicht.Name = "dataGridUebersicht";
            this.dataGridUebersicht.ReadOnly = true;
            this.dataGridUebersicht.Size = new System.Drawing.Size(549, 412);
            this.dataGridUebersicht.TabIndex = 16;
            // 
            // zEIT2017DataSet1
            // 
            this.zEIT2017DataSet1.DataSetName = "ZEIT2017DataSet1";
            this.zEIT2017DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mitarbeiterBindingSource
            // 
            this.mitarbeiterBindingSource.DataMember = "Mitarbeiter";
            this.mitarbeiterBindingSource.DataSource = this.zEIT2017DataSet1;
            // 
            // mitarbeiterTableAdapter
            // 
            this.mitarbeiterTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personalnummerDataGridViewTextBoxColumn
            // 
            this.personalnummerDataGridViewTextBoxColumn.DataPropertyName = "Personalnummer";
            this.personalnummerDataGridViewTextBoxColumn.HeaderText = "Personalnummer";
            this.personalnummerDataGridViewTextBoxColumn.Name = "personalnummerDataGridViewTextBoxColumn";
            this.personalnummerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vornameDataGridViewTextBoxColumn
            // 
            this.vornameDataGridViewTextBoxColumn.DataPropertyName = "Vorname";
            this.vornameDataGridViewTextBoxColumn.HeaderText = "Vorname";
            this.vornameDataGridViewTextBoxColumn.Name = "vornameDataGridViewTextBoxColumn";
            this.vornameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nachnameDataGridViewTextBoxColumn
            // 
            this.nachnameDataGridViewTextBoxColumn.DataPropertyName = "Nachname";
            this.nachnameDataGridViewTextBoxColumn.HeaderText = "Nachname";
            this.nachnameDataGridViewTextBoxColumn.Name = "nachnameDataGridViewTextBoxColumn";
            this.nachnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tagesSollZeitDataGridViewTextBoxColumn
            // 
            this.tagesSollZeitDataGridViewTextBoxColumn.DataPropertyName = "TagesSollZeit";
            this.tagesSollZeitDataGridViewTextBoxColumn.HeaderText = "TagesSollZeit";
            this.tagesSollZeitDataGridViewTextBoxColumn.Name = "tagesSollZeitDataGridViewTextBoxColumn";
            this.tagesSollZeitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eintrittsDatumDataGridViewTextBoxColumn
            // 
            this.eintrittsDatumDataGridViewTextBoxColumn.DataPropertyName = "EintrittsDatum";
            this.eintrittsDatumDataGridViewTextBoxColumn.HeaderText = "EintrittsDatum";
            this.eintrittsDatumDataGridViewTextBoxColumn.Name = "eintrittsDatumDataGridViewTextBoxColumn";
            this.eintrittsDatumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // istAktivDataGridViewCheckBoxColumn
            // 
            this.istAktivDataGridViewCheckBoxColumn.DataPropertyName = "IstAktiv";
            this.istAktivDataGridViewCheckBoxColumn.HeaderText = "IstAktiv";
            this.istAktivDataGridViewCheckBoxColumn.Name = "istAktivDataGridViewCheckBoxColumn";
            this.istAktivDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // Zeituebersicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.dataGridUebersicht);
            this.Controls.Add(this.BtnExport);
            this.Controls.Add(this.TxtEnddatum);
            this.Controls.Add(this.EnddatumLabel);
            this.Controls.Add(this.AnfgangsdatumLabel);
            this.Controls.Add(this.TxtAnfangsdatum);
            this.Controls.Add(this.BtnSuche);
            this.Controls.Add(this.BtnZurZeiterfassung);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Zeituebersicht";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zeituebersicht";
            this.Load += new System.EventHandler(this.Zeituebersicht_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUebersicht)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zEIT2017DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitarbeiterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnZurZeiterfassung;
        private System.Windows.Forms.TextBox TxtAnfangsdatum;
        private System.Windows.Forms.Button BtnSuche;
        private System.Windows.Forms.Label AnfgangsdatumLabel;
        private System.Windows.Forms.Label EnddatumLabel;
        private System.Windows.Forms.TextBox TxtEnddatum;
        private System.Windows.Forms.Button BtnExport;
        private System.Windows.Forms.DataGridView dataGridUebersicht;
        private ZEIT2017DataSet1 zEIT2017DataSet1;
        private System.Windows.Forms.BindingSource mitarbeiterBindingSource;
        private ZEIT2017DataSet1TableAdapters.MitarbeiterTableAdapter mitarbeiterTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalnummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nachnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagesSollZeitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eintrittsDatumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn istAktivDataGridViewCheckBoxColumn;
    }
}