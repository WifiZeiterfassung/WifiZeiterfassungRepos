﻿namespace ProjektZeiterfassung.View
{
    partial class MitarbeiterSuchen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MitarbeiterSuchen));
            this.view_1DataGridView = new System.Windows.Forms.DataGridView();
            this.view_1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxSuche = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblSuchfeld = new System.Windows.Forms.Label();
            this.LblMitarbeiterSuchen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.view_1DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_1BindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // view_1DataGridView
            // 
            this.view_1DataGridView.AllowUserToAddRows = false;
            this.view_1DataGridView.AllowUserToDeleteRows = false;
            this.view_1DataGridView.AutoGenerateColumns = false;
            this.view_1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_1DataGridView.DataSource = this.view_1BindingSource;
            this.view_1DataGridView.Location = new System.Drawing.Point(10, 62);
            this.view_1DataGridView.Name = "view_1DataGridView";
            this.view_1DataGridView.ReadOnly = true;
            this.view_1DataGridView.Size = new System.Drawing.Size(460, 148);
            this.view_1DataGridView.TabIndex = 1;
            this.view_1DataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_1DataGridView_CellDoubleClick);
            // 
            // view_1BindingSource
            // 
            this.view_1BindingSource.DataMember = "View_1";
            // 
            // textBoxSuche
            // 
            this.textBoxSuche.Location = new System.Drawing.Point(10, 23);
            this.textBoxSuche.Name = "textBoxSuche";
            this.textBoxSuche.Size = new System.Drawing.Size(460, 20);
            this.textBoxSuche.TabIndex = 1;
            this.textBoxSuche.TextChanged += new System.EventHandler(this.textBoxSuche_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.textBoxSuche);
            this.panel2.Controls.Add(this.LblSuchfeld);
            this.panel2.Controls.Add(this.view_1DataGridView);
            this.panel2.Location = new System.Drawing.Point(12, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 217);
            this.panel2.TabIndex = 41;
            // 
            // LblSuchfeld
            // 
            this.LblSuchfeld.AutoSize = true;
            this.LblSuchfeld.Location = new System.Drawing.Point(10, 4);
            this.LblSuchfeld.Name = "LblSuchfeld";
            this.LblSuchfeld.Size = new System.Drawing.Size(267, 13);
            this.LblSuchfeld.TabIndex = 12;
            this.LblSuchfeld.Text = "Suchtext: (Personalnummer, Vorname bzw. Nachname)";
            // 
            // LblMitarbeiterSuchen
            // 
            this.LblMitarbeiterSuchen.AutoSize = true;
            this.LblMitarbeiterSuchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMitarbeiterSuchen.Location = new System.Drawing.Point(12, 9);
            this.LblMitarbeiterSuchen.Name = "LblMitarbeiterSuchen";
            this.LblMitarbeiterSuchen.Size = new System.Drawing.Size(144, 20);
            this.LblMitarbeiterSuchen.TabIndex = 42;
            this.LblMitarbeiterSuchen.Text = "Mitarbeiter suchen:";
            // 
            // MitarbeiterSuchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 256);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LblMitarbeiterSuchen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MitarbeiterSuchen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wifi Arbeitszeitfassung";
            this.Load += new System.EventHandler(this.MitarbeiterSuchen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view_1DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_1BindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource view_1BindingSource;
        private System.Windows.Forms.DataGridView view_1DataGridView;
        private System.Windows.Forms.TextBox textBoxSuche;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblSuchfeld;
        private System.Windows.Forms.Label LblMitarbeiterSuchen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}