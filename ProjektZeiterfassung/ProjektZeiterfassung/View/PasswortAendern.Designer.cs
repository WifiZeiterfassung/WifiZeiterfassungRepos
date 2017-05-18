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
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnSpeichern = new System.Windows.Forms.Button();
            this.LblVorname = new System.Windows.Forms.Label();
            this.LblPersonalnummer = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TxtPersonalnummer = new System.Windows.Forms.TextBox();
            this.LblPasswortAendern = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.BtnSpeichern);
            this.panel2.Controls.Add(this.LblVorname);
            this.panel2.Controls.Add(this.LblPersonalnummer);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.TxtPersonalnummer);
            this.panel2.Location = new System.Drawing.Point(12, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 135);
            this.panel2.TabIndex = 7;
            // 
            // BtnSpeichern
            // 
            this.BtnSpeichern.Location = new System.Drawing.Point(370, 101);
            this.BtnSpeichern.Name = "BtnSpeichern";
            this.BtnSpeichern.Size = new System.Drawing.Size(100, 23);
            this.BtnSpeichern.TabIndex = 12;
            this.BtnSpeichern.Text = "Speichern";
            this.BtnSpeichern.UseVisualStyleBackColor = true;
            // 
            // LblVorname
            // 
            this.LblVorname.AutoSize = true;
            this.LblVorname.Location = new System.Drawing.Point(10, 56);
            this.LblVorname.Name = "LblVorname";
            this.LblVorname.Size = new System.Drawing.Size(105, 13);
            this.LblVorname.TabIndex = 12;
            this.LblVorname.Text = "Passwort bestätigen:";
            // 
            // LblPersonalnummer
            // 
            this.LblPersonalnummer.AutoSize = true;
            this.LblPersonalnummer.Location = new System.Drawing.Point(10, 4);
            this.LblPersonalnummer.Name = "LblPersonalnummer";
            this.LblPersonalnummer.Size = new System.Drawing.Size(87, 13);
            this.LblPersonalnummer.TabIndex = 12;
            this.LblPersonalnummer.Text = "Neues Passwort:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 20);
            this.textBox1.TabIndex = 8;
            // 
            // TxtPersonalnummer
            // 
            this.TxtPersonalnummer.Location = new System.Drawing.Point(10, 23);
            this.TxtPersonalnummer.Name = "TxtPersonalnummer";
            this.TxtPersonalnummer.Size = new System.Drawing.Size(210, 20);
            this.TxtPersonalnummer.TabIndex = 5;
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
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(250, 23);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(220, 72);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "";
            // 
            // PasswortAendern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 172);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LblPasswortAendern);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TxtPersonalnummer;
        private System.Windows.Forms.Label LblPasswortAendern;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}