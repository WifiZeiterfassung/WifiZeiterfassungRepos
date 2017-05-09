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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zeiterfassung));
            this.AnmeldePanel = new System.Windows.Forms.Panel();
            this.BedienungsPanel = new System.Windows.Forms.Panel();
            this.BtnZeitUebersicht = new System.Windows.Forms.Button();
            this.mitarbeiterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zEIT2017DataSet = new ProjektZeiterfassung.ZEIT2017DataSet();
            this.mitarbeiterTableAdapter = new ProjektZeiterfassung.ZEIT2017DataSetTableAdapters.MitarbeiterTableAdapter();
            this.TxtBenutzer = new System.Windows.Forms.TextBox();
            this.TxtArbeitsbeginn = new System.Windows.Forms.TextBox();
            this.BtnPausenbeginn = new System.Windows.Forms.Button();
            this.TxtPausenbeginn = new System.Windows.Forms.TextBox();
            this.BtnPausenende = new System.Windows.Forms.Button();
            this.TxtPausenende = new System.Windows.Forms.TextBox();
            this.BtnArbeitsende = new System.Windows.Forms.Button();
            this.TxtArbeitsende = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtTagesarbeitszeit = new System.Windows.Forms.TextBox();
            this.AnmeldePanel.SuspendLayout();
            this.BedienungsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mitarbeiterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zEIT2017DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // AnmeldePanel
            // 
            this.AnmeldePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AnmeldePanel.Controls.Add(this.TxtBenutzer);
            this.AnmeldePanel.Location = new System.Drawing.Point(9, 7);
            this.AnmeldePanel.Name = "AnmeldePanel";
            this.AnmeldePanel.Size = new System.Drawing.Size(600, 143);
            this.AnmeldePanel.TabIndex = 3;
            // 
            // BedienungsPanel
            // 
            this.BedienungsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BedienungsPanel.Controls.Add(this.TxtTagesarbeitszeit);
            this.BedienungsPanel.Controls.Add(this.button1);
            this.BedienungsPanel.Controls.Add(this.TxtArbeitsende);
            this.BedienungsPanel.Controls.Add(this.TxtPausenende);
            this.BedienungsPanel.Controls.Add(this.TxtPausenbeginn);
            this.BedienungsPanel.Controls.Add(this.TxtArbeitsbeginn);
            this.BedienungsPanel.Controls.Add(this.BtnArbeitsende);
            this.BedienungsPanel.Controls.Add(this.BtnPausenende);
            this.BedienungsPanel.Controls.Add(this.BtnPausenbeginn);
            this.BedienungsPanel.Controls.Add(this.BtnZeitUebersicht);
            this.BedienungsPanel.Location = new System.Drawing.Point(10, 156);
            this.BedienungsPanel.Name = "BedienungsPanel";
            this.BedienungsPanel.Size = new System.Drawing.Size(600, 202);
            this.BedienungsPanel.TabIndex = 5;
            // 
            // BtnZeitUebersicht
            // 
            this.BtnZeitUebersicht.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnZeitUebersicht.Location = new System.Drawing.Point(10, 150);
            this.BtnZeitUebersicht.Name = "BtnZeitUebersicht";
            this.BtnZeitUebersicht.Padding = new System.Windows.Forms.Padding(5);
            this.BtnZeitUebersicht.Size = new System.Drawing.Size(140, 44);
            this.BtnZeitUebersicht.TabIndex = 6;
            this.BtnZeitUebersicht.Text = "Zeitübersicht...";
            this.BtnZeitUebersicht.UseVisualStyleBackColor = true;
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
            // TxtBenutzer
            // 
            this.TxtBenutzer.BackColor = System.Drawing.Color.PeachPuff;
            this.TxtBenutzer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBenutzer.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TxtBenutzer.Location = new System.Drawing.Point(11, 15);
            this.TxtBenutzer.Multiline = true;
            this.TxtBenutzer.Name = "TxtBenutzer";
            this.TxtBenutzer.ReadOnly = true;
            this.TxtBenutzer.Size = new System.Drawing.Size(578, 96);
            this.TxtBenutzer.TabIndex = 2;
            // 
            // TxtArbeitsbeginn
            // 
            this.TxtArbeitsbeginn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtArbeitsbeginn.Location = new System.Drawing.Point(10, 79);
            this.TxtArbeitsbeginn.Name = "TxtArbeitsbeginn";
            this.TxtArbeitsbeginn.ReadOnly = true;
            this.TxtArbeitsbeginn.Size = new System.Drawing.Size(140, 44);
            this.TxtArbeitsbeginn.TabIndex = 8;
            // 
            // BtnPausenbeginn
            // 
            this.BtnPausenbeginn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPausenbeginn.Location = new System.Drawing.Point(156, 29);
            this.BtnPausenbeginn.Name = "BtnPausenbeginn";
            this.BtnPausenbeginn.Padding = new System.Windows.Forms.Padding(5);
            this.BtnPausenbeginn.Size = new System.Drawing.Size(140, 44);
            this.BtnPausenbeginn.TabIndex = 6;
            this.BtnPausenbeginn.Text = "Pausenbeginn";
            this.BtnPausenbeginn.UseVisualStyleBackColor = true;
            // 
            // TxtPausenbeginn
            // 
            this.TxtPausenbeginn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPausenbeginn.Location = new System.Drawing.Point(156, 79);
            this.TxtPausenbeginn.Name = "TxtPausenbeginn";
            this.TxtPausenbeginn.ReadOnly = true;
            this.TxtPausenbeginn.Size = new System.Drawing.Size(140, 44);
            this.TxtPausenbeginn.TabIndex = 8;
            // 
            // BtnPausenende
            // 
            this.BtnPausenende.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPausenende.Location = new System.Drawing.Point(302, 29);
            this.BtnPausenende.Name = "BtnPausenende";
            this.BtnPausenende.Padding = new System.Windows.Forms.Padding(5);
            this.BtnPausenende.Size = new System.Drawing.Size(140, 44);
            this.BtnPausenende.TabIndex = 6;
            this.BtnPausenende.Text = "Pausenende";
            this.BtnPausenende.UseVisualStyleBackColor = true;
            // 
            // TxtPausenende
            // 
            this.TxtPausenende.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPausenende.Location = new System.Drawing.Point(302, 79);
            this.TxtPausenende.Name = "TxtPausenende";
            this.TxtPausenende.ReadOnly = true;
            this.TxtPausenende.Size = new System.Drawing.Size(140, 44);
            this.TxtPausenende.TabIndex = 8;
            // 
            // BtnArbeitsende
            // 
            this.BtnArbeitsende.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnArbeitsende.Location = new System.Drawing.Point(448, 29);
            this.BtnArbeitsende.Name = "BtnArbeitsende";
            this.BtnArbeitsende.Padding = new System.Windows.Forms.Padding(5);
            this.BtnArbeitsende.Size = new System.Drawing.Size(140, 44);
            this.BtnArbeitsende.TabIndex = 6;
            this.BtnArbeitsende.Text = "Arbeitsende";
            this.BtnArbeitsende.UseVisualStyleBackColor = true;
            // 
            // TxtArbeitsende
            // 
            this.TxtArbeitsende.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtArbeitsende.Location = new System.Drawing.Point(448, 79);
            this.TxtArbeitsende.Name = "TxtArbeitsende";
            this.TxtArbeitsende.ReadOnly = true;
            this.TxtArbeitsende.Size = new System.Drawing.Size(140, 44);
            this.TxtArbeitsende.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(10, 29);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5);
            this.button1.Size = new System.Drawing.Size(140, 44);
            this.button1.TabIndex = 9;
            this.button1.Text = "Arbeitsbeginn";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TxtTagesarbeitszeit
            // 
            this.TxtTagesarbeitszeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTagesarbeitszeit.Location = new System.Drawing.Point(302, 146);
            this.TxtTagesarbeitszeit.Name = "TxtTagesarbeitszeit";
            this.TxtTagesarbeitszeit.ReadOnly = true;
            this.TxtTagesarbeitszeit.Size = new System.Drawing.Size(286, 44);
            this.TxtTagesarbeitszeit.TabIndex = 10;
            // 
            // Zeiterfassung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 364);
            this.Controls.Add(this.AnmeldePanel);
            this.Controls.Add(this.BedienungsPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Zeiterfassung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zeiterfassung";
            this.AnmeldePanel.ResumeLayout(false);
            this.AnmeldePanel.PerformLayout();
            this.BedienungsPanel.ResumeLayout(false);
            this.BedienungsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mitarbeiterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zEIT2017DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AnmeldePanel;
        private System.Windows.Forms.Panel BedienungsPanel;
        private System.Windows.Forms.Button BtnZeitUebersicht;
        private System.Windows.Forms.BindingSource mitarbeiterBindingSource;
        private ZEIT2017DataSet zEIT2017DataSet;
        private ZEIT2017DataSetTableAdapters.MitarbeiterTableAdapter mitarbeiterTableAdapter;
        private System.Windows.Forms.TextBox TxtBenutzer;
        private System.Windows.Forms.TextBox TxtArbeitsbeginn;
        private System.Windows.Forms.TextBox TxtArbeitsende;
        private System.Windows.Forms.TextBox TxtPausenende;
        private System.Windows.Forms.TextBox TxtPausenbeginn;
        private System.Windows.Forms.Button BtnArbeitsende;
        private System.Windows.Forms.Button BtnPausenende;
        private System.Windows.Forms.Button BtnPausenbeginn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtTagesarbeitszeit;
    }
}