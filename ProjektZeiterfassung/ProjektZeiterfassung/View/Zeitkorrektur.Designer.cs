namespace ProjektZeiterfassung.View
{
    partial class Zeitkorrektur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zeitkorrektur));
            this.panel3 = new System.Windows.Forms.Panel();
            this.stempelzeitenDataGridView = new System.Windows.Forms.DataGridView();
            this.stempelzeitenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zEIT2017DataSet3 = new ProjektZeiterfassung.ZEIT2017DataSet3();
            this.dateTimePickerDatumBeginn = new System.Windows.Forms.DateTimePicker();
            this.LblDatumBeginn = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePickerDatumEnde = new System.Windows.Forms.DateTimePicker();
            this.LblDatumEnde = new System.Windows.Forms.Label();
            this.TxtBenutzerdaten = new System.Windows.Forms.TextBox();
            this.LblBenutzerdaten = new System.Windows.Forms.Label();
            this.LblPersonalnummer = new System.Windows.Forms.Label();
            this.TxtPersonalnummer = new System.Windows.Forms.TextBox();
            this.AnmeldeLabel = new System.Windows.Forms.Label();
            this.stempelzeitenTableAdapter = new ProjektZeiterfassung.ZEIT2017DataSet3TableAdapters.StempelzeitenTableAdapter();
            this.tableAdapterManager = new ProjektZeiterfassung.ZEIT2017DataSet3TableAdapters.TableAdapterManager();
            this.stempelzeitenBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.stempelzeitenBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.zEIT2017DataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zEIT2017DataSet4 = new ProjektZeiterfassung.ZEIT2017DataSet4();
            this.mitarbeiterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mitarbeiterTableAdapter = new ProjektZeiterfassung.ZEIT2017DataSet4TableAdapters.MitarbeiterTableAdapter();
            this.zEIT2017DataSet3BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.zeittypenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zeittypenTableAdapter = new ProjektZeiterfassung.ZEIT2017DataSet3TableAdapters.ZeittypenTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stempelzeitenDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stempelzeitenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zEIT2017DataSet3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stempelzeitenBindingNavigator)).BeginInit();
            this.stempelzeitenBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zEIT2017DataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zEIT2017DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitarbeiterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zEIT2017DataSet3BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zeittypenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.stempelzeitenDataGridView);
            this.panel3.Location = new System.Drawing.Point(12, 139);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(484, 260);
            this.panel3.TabIndex = 25;
            // 
            // stempelzeitenDataGridView
            // 
            this.stempelzeitenDataGridView.AllowUserToDeleteRows = false;
            this.stempelzeitenDataGridView.AutoGenerateColumns = false;
            this.stempelzeitenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stempelzeitenDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.stempelzeitenDataGridView.DataSource = this.stempelzeitenBindingSource;
            this.stempelzeitenDataGridView.Location = new System.Drawing.Point(3, 3);
            this.stempelzeitenDataGridView.Name = "stempelzeitenDataGridView";
            this.stempelzeitenDataGridView.Size = new System.Drawing.Size(474, 250);
            this.stempelzeitenDataGridView.TabIndex = 0;
            // 
            // stempelzeitenBindingSource
            // 
            this.stempelzeitenBindingSource.DataMember = "Stempelzeiten";
            this.stempelzeitenBindingSource.DataSource = this.zEIT2017DataSet3;
            // 
            // zEIT2017DataSet3
            // 
            this.zEIT2017DataSet3.DataSetName = "ZEIT2017DataSet3";
            this.zEIT2017DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePickerDatumBeginn
            // 
            this.dateTimePickerDatumBeginn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDatumBeginn.Location = new System.Drawing.Point(129, 23);
            this.dateTimePickerDatumBeginn.Name = "dateTimePickerDatumBeginn";
            this.dateTimePickerDatumBeginn.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerDatumBeginn.TabIndex = 4;
            this.dateTimePickerDatumBeginn.ValueChanged += new System.EventHandler(this.dateTimePickerDatum_ValueChanged);
            // 
            // LblDatumBeginn
            // 
            this.LblDatumBeginn.AutoSize = true;
            this.LblDatumBeginn.Location = new System.Drawing.Point(129, 5);
            this.LblDatumBeginn.Name = "LblDatumBeginn";
            this.LblDatumBeginn.Size = new System.Drawing.Size(77, 13);
            this.LblDatumBeginn.TabIndex = 28;
            this.LblDatumBeginn.Text = "Datum Beginn:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dateTimePickerDatumEnde);
            this.panel2.Controls.Add(this.LblDatumEnde);
            this.panel2.Controls.Add(this.dateTimePickerDatumBeginn);
            this.panel2.Controls.Add(this.LblDatumBeginn);
            this.panel2.Controls.Add(this.TxtBenutzerdaten);
            this.panel2.Controls.Add(this.LblBenutzerdaten);
            this.panel2.Controls.Add(this.LblPersonalnummer);
            this.panel2.Controls.Add(this.TxtPersonalnummer);
            this.panel2.Location = new System.Drawing.Point(12, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 101);
            this.panel2.TabIndex = 23;
            // 
            // dateTimePickerDatumEnde
            // 
            this.dateTimePickerDatumEnde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDatumEnde.Location = new System.Drawing.Point(245, 23);
            this.dateTimePickerDatumEnde.Name = "dateTimePickerDatumEnde";
            this.dateTimePickerDatumEnde.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerDatumEnde.TabIndex = 101;
            this.dateTimePickerDatumEnde.ValueChanged += new System.EventHandler(this.dateTimePickerDatumEnde_ValueChanged);
            // 
            // LblDatumEnde
            // 
            this.LblDatumEnde.AutoSize = true;
            this.LblDatumEnde.Location = new System.Drawing.Point(245, 5);
            this.LblDatumEnde.Name = "LblDatumEnde";
            this.LblDatumEnde.Size = new System.Drawing.Size(69, 13);
            this.LblDatumEnde.TabIndex = 102;
            this.LblDatumEnde.Text = "Datum Ende:";
            // 
            // TxtBenutzerdaten
            // 
            this.TxtBenutzerdaten.BackColor = System.Drawing.Color.PeachPuff;
            this.TxtBenutzerdaten.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBenutzerdaten.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TxtBenutzerdaten.Location = new System.Drawing.Point(10, 73);
            this.TxtBenutzerdaten.Multiline = true;
            this.TxtBenutzerdaten.Name = "TxtBenutzerdaten";
            this.TxtBenutzerdaten.ReadOnly = true;
            this.TxtBenutzerdaten.Size = new System.Drawing.Size(467, 21);
            this.TxtBenutzerdaten.TabIndex = 100;
            this.TxtBenutzerdaten.TabStop = false;
            // 
            // LblBenutzerdaten
            // 
            this.LblBenutzerdaten.AutoSize = true;
            this.LblBenutzerdaten.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBenutzerdaten.Location = new System.Drawing.Point(7, 54);
            this.LblBenutzerdaten.Name = "LblBenutzerdaten";
            this.LblBenutzerdaten.Size = new System.Drawing.Size(79, 13);
            this.LblBenutzerdaten.TabIndex = 1;
            this.LblBenutzerdaten.Text = "Benutzerdaten:";
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
            // TxtPersonalnummer
            // 
            this.TxtPersonalnummer.Location = new System.Drawing.Point(10, 23);
            this.TxtPersonalnummer.Name = "TxtPersonalnummer";
            this.TxtPersonalnummer.ReadOnly = true;
            this.TxtPersonalnummer.Size = new System.Drawing.Size(100, 20);
            this.TxtPersonalnummer.TabIndex = 1;
            // 
            // AnmeldeLabel
            // 
            this.AnmeldeLabel.AutoSize = true;
            this.AnmeldeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnmeldeLabel.Location = new System.Drawing.Point(12, 9);
            this.AnmeldeLabel.Name = "AnmeldeLabel";
            this.AnmeldeLabel.Size = new System.Drawing.Size(99, 20);
            this.AnmeldeLabel.TabIndex = 22;
            this.AnmeldeLabel.Text = "Zeitkorrektur";
            // 
            // stempelzeitenTableAdapter
            // 
            this.stempelzeitenTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StempelzeitenTableAdapter = this.stempelzeitenTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProjektZeiterfassung.ZEIT2017DataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZeittypenTableAdapter = null;
            // 
            // stempelzeitenBindingNavigator
            // 
            this.stempelzeitenBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.stempelzeitenBindingNavigator.BindingSource = this.stempelzeitenBindingSource;
            this.stempelzeitenBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.stempelzeitenBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.stempelzeitenBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.stempelzeitenBindingNavigatorSaveItem});
            this.stempelzeitenBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.stempelzeitenBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.stempelzeitenBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.stempelzeitenBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.stempelzeitenBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.stempelzeitenBindingNavigator.Name = "stempelzeitenBindingNavigator";
            this.stempelzeitenBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.stempelzeitenBindingNavigator.Size = new System.Drawing.Size(504, 25);
            this.stempelzeitenBindingNavigator.TabIndex = 26;
            this.stempelzeitenBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Neu hinzufügen";
            this.bindingNavigatorAddNewItem.Visible = false;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(44, 22);
            this.bindingNavigatorCountItem.Text = "von {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente.";
            this.bindingNavigatorCountItem.Visible = false;
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Löschen";
            this.bindingNavigatorDeleteItem.Visible = false;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Erste verschieben";
            this.bindingNavigatorMoveFirstItem.Visible = false;
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Vorherige verschieben";
            this.bindingNavigatorMovePreviousItem.Visible = false;
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            this.bindingNavigatorSeparator.Visible = false;
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Aktuelle Position";
            this.bindingNavigatorPositionItem.Visible = false;
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            this.bindingNavigatorSeparator1.Visible = false;
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Nächste verschieben";
            this.bindingNavigatorMoveNextItem.Visible = false;
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Letzte verschieben";
            this.bindingNavigatorMoveLastItem.Visible = false;
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            this.bindingNavigatorSeparator2.Visible = false;
            // 
            // stempelzeitenBindingNavigatorSaveItem
            // 
            this.stempelzeitenBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stempelzeitenBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("stempelzeitenBindingNavigatorSaveItem.Image")));
            this.stempelzeitenBindingNavigatorSaveItem.Name = "stempelzeitenBindingNavigatorSaveItem";
            this.stempelzeitenBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.stempelzeitenBindingNavigatorSaveItem.Text = "Daten speichern";
            this.stempelzeitenBindingNavigatorSaveItem.Click += new System.EventHandler(this.stempelzeitenBindingNavigatorSaveItem_Click);
            // 
            // zEIT2017DataSet3BindingSource
            // 
            this.zEIT2017DataSet3BindingSource.DataSource = this.zEIT2017DataSet3;
            this.zEIT2017DataSet3BindingSource.Position = 0;
            // 
            // zEIT2017DataSet4
            // 
            this.zEIT2017DataSet4.DataSetName = "ZEIT2017DataSet4";
            this.zEIT2017DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mitarbeiterBindingSource
            // 
            this.mitarbeiterBindingSource.DataMember = "Mitarbeiter";
            this.mitarbeiterBindingSource.DataSource = this.zEIT2017DataSet4;
            // 
            // mitarbeiterTableAdapter
            // 
            this.mitarbeiterTableAdapter.ClearBeforeFill = true;
            // 
            // zEIT2017DataSet3BindingSource1
            // 
            this.zEIT2017DataSet3BindingSource1.DataSource = this.zEIT2017DataSet3;
            this.zEIT2017DataSet3BindingSource1.Position = 0;
            // 
            // zeittypenBindingSource
            // 
            this.zeittypenBindingSource.DataMember = "Zeittypen";
            this.zeittypenBindingSource.DataSource = this.zEIT2017DataSet3BindingSource1;
            // 
            // zeittypenTableAdapter
            // 
            this.zeittypenTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FK_Mitarbeiter";
            this.dataGridViewTextBoxColumn1.DataSource = this.mitarbeiterBindingSource;
            this.dataGridViewTextBoxColumn1.DisplayMember = "Nachname";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mitarbeiter";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn1.ValueMember = "ID";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Zeitpunkt";
            this.dataGridViewTextBoxColumn2.HeaderText = "Zeitpunkt";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ZeitTyp";
            this.dataGridViewTextBoxColumn3.DataSource = this.zeittypenBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Bezeichnung";
            this.dataGridViewTextBoxColumn3.HeaderText = "ZeitTyp";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "ID";
            // 
            // Zeitkorrektur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(504, 411);
            this.Controls.Add(this.stempelzeitenBindingNavigator);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.AnmeldeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Zeitkorrektur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wifi Arbeitszeitfassung";
            this.Load += new System.EventHandler(this.Zeitkorrektur_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stempelzeitenDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stempelzeitenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zEIT2017DataSet3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stempelzeitenBindingNavigator)).EndInit();
            this.stempelzeitenBindingNavigator.ResumeLayout(false);
            this.stempelzeitenBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zEIT2017DataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zEIT2017DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitarbeiterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zEIT2017DataSet3BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zeittypenBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblPersonalnummer;
        private System.Windows.Forms.TextBox TxtPersonalnummer;
        private System.Windows.Forms.TextBox TxtBenutzerdaten;
        private System.Windows.Forms.Label LblBenutzerdaten;
        private System.Windows.Forms.Label AnmeldeLabel;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatumBeginn;
        private System.Windows.Forms.Label LblDatumBeginn;
        private ZEIT2017DataSet3 zEIT2017DataSet3;
        private System.Windows.Forms.BindingSource stempelzeitenBindingSource;
        private ZEIT2017DataSet3TableAdapters.StempelzeitenTableAdapter stempelzeitenTableAdapter;
        private ZEIT2017DataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator stempelzeitenBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton stempelzeitenBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView stempelzeitenDataGridView;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatumEnde;
        private System.Windows.Forms.Label LblDatumEnde;
        private System.Windows.Forms.BindingSource zEIT2017DataSet3BindingSource;
        private ZEIT2017DataSet4 zEIT2017DataSet4;
        private System.Windows.Forms.BindingSource mitarbeiterBindingSource;
        private ZEIT2017DataSet4TableAdapters.MitarbeiterTableAdapter mitarbeiterTableAdapter;
        private System.Windows.Forms.BindingSource zEIT2017DataSet3BindingSource1;
        private System.Windows.Forms.BindingSource zeittypenBindingSource;
        private ZEIT2017DataSet3TableAdapters.ZeittypenTableAdapter zeittypenTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
    }
}