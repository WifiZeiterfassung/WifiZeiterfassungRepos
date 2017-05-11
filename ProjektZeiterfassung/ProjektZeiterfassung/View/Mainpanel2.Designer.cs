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
            this.BedienungsPanel = new System.Windows.Forms.Panel();
            this.BtnBuchen = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BtnÜbersicht = new System.Windows.Forms.Button();
            this.BtnZeiterfassung = new System.Windows.Forms.Button();
            this.AnmeldeLabel = new System.Windows.Forms.Label();
            this.mitarbeiterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zEIT2017DataSet = new ProjektZeiterfassung.ZEIT2017DataSet();
            this.mitarbeiterTableAdapter = new ProjektZeiterfassung.ZEIT2017DataSetTableAdapters.MitarbeiterTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.BedienungsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mitarbeiterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zEIT2017DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // BedienungsPanel
            // 
            this.BedienungsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BedienungsPanel.Controls.Add(this.BtnBuchen);
            this.BedienungsPanel.Controls.Add(this.comboBox1);
            this.BedienungsPanel.Controls.Add(this.BtnÜbersicht);
            this.BedienungsPanel.Controls.Add(this.BtnZeiterfassung);
            this.BedienungsPanel.Location = new System.Drawing.Point(13, 177);
            this.BedienungsPanel.Name = "BedienungsPanel";
            this.BedienungsPanel.Size = new System.Drawing.Size(659, 372);
            this.BedienungsPanel.TabIndex = 5;
            // 
            // BtnBuchen
            // 
            this.BtnBuchen.Location = new System.Drawing.Point(137, 24);
            this.BtnBuchen.Name = "BtnBuchen";
            this.BtnBuchen.Size = new System.Drawing.Size(75, 23);
            this.BtnBuchen.TabIndex = 8;
            this.BtnBuchen.Text = "Buchen";
            this.BtnBuchen.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Arbeitsbeginn",
            "Pausenbeginn",
            "Pausenende",
            "Arbeitsende"});
            this.comboBox1.Location = new System.Drawing.Point(9, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // BtnÜbersicht
            // 
            this.BtnÜbersicht.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnÜbersicht.Location = new System.Drawing.Point(9, 321);
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
            this.BtnZeiterfassung.Location = new System.Drawing.Point(294, 321);
            this.BtnZeiterfassung.Name = "BtnZeiterfassung";
            this.BtnZeiterfassung.Padding = new System.Windows.Forms.Padding(5);
            this.BtnZeiterfassung.Size = new System.Drawing.Size(140, 44);
            this.BtnZeiterfassung.TabIndex = 5;
            this.BtnZeiterfassung.Text = "Zeiterfassung...";
            this.BtnZeiterfassung.UseVisualStyleBackColor = true;
            // 
            // AnmeldeLabel
            // 
            this.AnmeldeLabel.AutoSize = true;
            this.AnmeldeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnmeldeLabel.Location = new System.Drawing.Point(12, 5);
            this.AnmeldeLabel.Name = "AnmeldeLabel";
            this.AnmeldeLabel.Size = new System.Drawing.Size(171, 20);
            this.AnmeldeLabel.TabIndex = 0;
            this.AnmeldeLabel.Text = "Wifi Stundenerfassung";
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
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(311, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 55);
            this.panel1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBox1.Location = new System.Drawing.Point(8, 23);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(341, 21);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Benutzerdaten:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Location = new System.Drawing.Point(12, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 55);
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Personalnr.:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Anmelden";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(10, 23);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(80, 20);
            this.textBox4.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.textBox6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.textBox5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.dateTimePicker2);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Location = new System.Drawing.Point(13, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(659, 460);
            this.panel3.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(135, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Buchen";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(444, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Enddatum Übersicht:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(238, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Startdatum Übersicht:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Buchungsart:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tages-Differenz:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(261, 429);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(120, 20);
            this.textBox6.TabIndex = 17;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tages-Ist-Zeit:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(135, 429);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(120, 20);
            this.textBox5.TabIndex = 15;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tages-Soll-Zeit:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 429);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 20);
            this.textBox2.TabIndex = 13;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(547, 426);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "Export";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(447, 25);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(241, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.textBox3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(9, 53);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(648, 354);
            this.panel4.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.PeachPuff;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBox3.Location = new System.Drawing.Point(3, 23);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(633, 324);
            this.textBox3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Übersicht Zeiterfassung:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Arbeitsbeginn",
            "Pausenbeginn",
            "Pausenende",
            "Arbeitsende"});
            this.comboBox2.Location = new System.Drawing.Point(9, 24);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(120, 21);
            this.comboBox2.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(96, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Pin (6-stellig):";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(96, 23);
            this.textBox7.MaxLength = 6;
            this.textBox7.Name = "textBox7";
            this.textBox7.PasswordChar = '*';
            this.textBox7.Size = new System.Drawing.Size(80, 20);
            this.textBox7.TabIndex = 13;
            // 
            // Mainpanel2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.BedienungsPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AnmeldeLabel);
            this.Name = "Mainpanel2";
            this.Text = "Mainpanel2";
            this.BedienungsPanel.ResumeLayout(false);
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

        private System.Windows.Forms.Panel BedienungsPanel;
        private System.Windows.Forms.Button BtnÜbersicht;
        private System.Windows.Forms.Button BtnZeiterfassung;
        private System.Windows.Forms.Label AnmeldeLabel;
        private System.Windows.Forms.BindingSource mitarbeiterBindingSource;
        private ZEIT2017DataSet zEIT2017DataSet;
        private ZEIT2017DataSetTableAdapters.MitarbeiterTableAdapter mitarbeiterTableAdapter;
        private System.Windows.Forms.Button BtnBuchen;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox7;
    }
}