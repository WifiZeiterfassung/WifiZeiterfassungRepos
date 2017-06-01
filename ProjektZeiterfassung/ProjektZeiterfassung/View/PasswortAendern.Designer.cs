namespace ProjektZeiterfassung.View
{
    partial class PasswortAendern
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswortAendern));
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextBoxPasswort = new System.Windows.Forms.RichTextBox();
            this.BtnSpeichern = new System.Windows.Forms.Button();
            this.LblVorname = new System.Windows.Forms.Label();
            this.LblPersonalnummer = new System.Windows.Forms.Label();
            this.TxtNeuesPasswort = new System.Windows.Forms.TextBox();
            this.TxtAltesPasswort = new System.Windows.Forms.TextBox();
            this.LblPasswortAendern = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNeuesPasswort1 = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.TxtNeuesPasswort1);
            this.panel2.Controls.Add(this.TextBoxPasswort);
            this.panel2.Controls.Add(this.BtnSpeichern);
            this.panel2.Controls.Add(this.LblVorname);
            this.panel2.Controls.Add(this.LblPersonalnummer);
            this.panel2.Controls.Add(this.TxtNeuesPasswort);
            this.panel2.Controls.Add(this.TxtAltesPasswort);
            this.panel2.Location = new System.Drawing.Point(12, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 135);
            this.panel2.TabIndex = 7;
            // 
            // TextBoxPasswort
            // 
            this.TextBoxPasswort.Location = new System.Drawing.Point(250, 23);
            this.TextBoxPasswort.Name = "TextBoxPasswort";
            this.TextBoxPasswort.ReadOnly = true;
            this.TextBoxPasswort.Size = new System.Drawing.Size(220, 72);
            this.TextBoxPasswort.TabIndex = 13;
            this.TextBoxPasswort.TabStop = false;
            this.TextBoxPasswort.Text = "";
            // 
            // BtnSpeichern
            // 
            this.BtnSpeichern.Location = new System.Drawing.Point(370, 101);
            this.BtnSpeichern.Name = "BtnSpeichern";
            this.BtnSpeichern.Size = new System.Drawing.Size(100, 23);
            this.BtnSpeichern.TabIndex = 4;
            this.BtnSpeichern.Text = "Speichern";
            this.BtnSpeichern.UseVisualStyleBackColor = true;
            this.BtnSpeichern.Click += new System.EventHandler(this.BtnSpeichern_Click);
            // 
            // LblVorname
            // 
            this.LblVorname.AutoSize = true;
            this.LblVorname.Location = new System.Drawing.Point(10, 46);
            this.LblVorname.Name = "LblVorname";
            this.LblVorname.Size = new System.Drawing.Size(87, 13);
            this.LblVorname.TabIndex = 12;
            this.LblVorname.Text = "Neues Passwort:";
            // 
            // LblPersonalnummer
            // 
            this.LblPersonalnummer.AutoSize = true;
            this.LblPersonalnummer.Location = new System.Drawing.Point(10, 9);
            this.LblPersonalnummer.Name = "LblPersonalnummer";
            this.LblPersonalnummer.Size = new System.Drawing.Size(79, 13);
            this.LblPersonalnummer.TabIndex = 12;
            this.LblPersonalnummer.Text = "Altes Passwort:";
            // 
            // TxtNeuesPasswort
            // 
            this.TxtNeuesPasswort.Location = new System.Drawing.Point(10, 60);
            this.TxtNeuesPasswort.MaxLength = 6;
            this.TxtNeuesPasswort.Name = "TxtNeuesPasswort";
            this.TxtNeuesPasswort.PasswordChar = '*';
            this.TxtNeuesPasswort.Size = new System.Drawing.Size(210, 20);
            this.TxtNeuesPasswort.TabIndex = 2;
            // 
            // TxtAltesPasswort
            // 
            this.TxtAltesPasswort.Location = new System.Drawing.Point(10, 23);
            this.TxtAltesPasswort.MaxLength = 6;
            this.TxtAltesPasswort.Name = "TxtAltesPasswort";
            this.TxtAltesPasswort.PasswordChar = '*';
            this.TxtAltesPasswort.Size = new System.Drawing.Size(210, 20);
            this.TxtAltesPasswort.TabIndex = 1;
            // 
            // LblPasswortAendern
            // 
            this.LblPasswortAendern.AutoSize = true;
            this.LblPasswortAendern.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPasswortAendern.Location = new System.Drawing.Point(12, 9);
            this.LblPasswortAendern.Name = "LblPasswortAendern";
            this.LblPasswortAendern.Size = new System.Drawing.Size(132, 20);
            this.LblPasswortAendern.TabIndex = 6;
            this.LblPasswortAendern.Text = "Passwort ändern:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Passwort bestätigen:";
            // 
            // TxtNeuesPasswort1
            // 
            this.TxtNeuesPasswort1.Location = new System.Drawing.Point(10, 101);
            this.TxtNeuesPasswort1.MaxLength = 6;
            this.TxtNeuesPasswort1.Name = "TxtNeuesPasswort1";
            this.TxtNeuesPasswort1.PasswordChar = '*';
            this.TxtNeuesPasswort1.Size = new System.Drawing.Size(210, 20);
            this.TxtNeuesPasswort1.TabIndex = 3;
            // 
            // PasswortAendern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 172);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LblPasswortAendern);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PasswortAendern";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wifi Arbeitszeitfassung";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnSpeichern;
        private System.Windows.Forms.Label LblVorname;
        private System.Windows.Forms.Label LblPersonalnummer;
        private System.Windows.Forms.TextBox TxtNeuesPasswort;
        private System.Windows.Forms.TextBox TxtAltesPasswort;
        private System.Windows.Forms.Label LblPasswortAendern;
        private System.Windows.Forms.RichTextBox TextBoxPasswort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNeuesPasswort1;
    }
}