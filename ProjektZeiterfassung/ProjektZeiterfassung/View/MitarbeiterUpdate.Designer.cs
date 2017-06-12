namespace ProjektZeiterfassung.View
{
    partial class MitarbeiterUpdate
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
            this.zEIT2017DataSet3 = new ProjektZeiterfassung.ZEIT2017DataSet3();
            this.mitarbeiterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mitarbeiterTableAdapter = new ProjektZeiterfassung.ZEIT2017DataSet3TableAdapters.MitarbeiterTableAdapter();
            this.mitarbeiterBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.zEIT2017DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitarbeiterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitarbeiterBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // zEIT2017DataSet3
            // 
            this.zEIT2017DataSet3.DataSetName = "ZEIT2017DataSet3";
            this.zEIT2017DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mitarbeiterBindingSource
            // 
            this.mitarbeiterBindingSource.DataMember = "Mitarbeiter";
            this.mitarbeiterBindingSource.DataSource = this.zEIT2017DataSet3;
            // 
            // mitarbeiterTableAdapter
            // 
            this.mitarbeiterTableAdapter.ClearBeforeFill = true;
            // 
            // mitarbeiterBindingSource1
            // 
            this.mitarbeiterBindingSource1.DataMember = "Mitarbeiter";
            this.mitarbeiterBindingSource1.DataSource = this.zEIT2017DataSet3;
            // 
            // MitarbeiterUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 428);
            this.Name = "MitarbeiterUpdate";
            this.Text = "MitarbeiterUpdate";
            this.ResumeLayout(false);

        }

        #endregion
        private ZEIT2017DataSet3 zEIT2017DataSet3;
        private System.Windows.Forms.BindingSource mitarbeiterBindingSource;
        private ZEIT2017DataSet3TableAdapters.MitarbeiterTableAdapter mitarbeiterTableAdapter;
        private System.Windows.Forms.BindingSource mitarbeiterBindingSource1;
    }
}