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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MitarbeiterUpdate));
            this.zEIT2017DataSet3 = new ProjektZeiterfassung.ZEIT2017DataSet3();
            this.view_1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_1TableAdapter = new ProjektZeiterfassung.ZEIT2017DataSet3TableAdapters.View_1TableAdapter();
            this.tableAdapterManager = new ProjektZeiterfassung.ZEIT2017DataSet3TableAdapters.TableAdapterManager();
            this.view_1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.view_1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.view_1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.zEIT2017DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_1BindingNavigator)).BeginInit();
            this.view_1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_1DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // zEIT2017DataSet3
            // 
            this.zEIT2017DataSet3.DataSetName = "ZEIT2017DataSet3";
            this.zEIT2017DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_1BindingSource
            // 
            this.view_1BindingSource.DataMember = "View_1";
            this.view_1BindingSource.DataSource = this.zEIT2017DataSet3;
            // 
            // view_1TableAdapter
            // 
            this.view_1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = ProjektZeiterfassung.ZEIT2017DataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // view_1BindingNavigator
            // 
            this.view_1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.view_1BindingNavigator.BindingSource = this.view_1BindingSource;
            this.view_1BindingNavigator.CountItem = this.bindingNavigatorAddNewItem;
            this.view_1BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.view_1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.view_1BindingNavigatorSaveItem,
            this.bindingNavigatorDeleteItem});
            this.view_1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.view_1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.view_1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.view_1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.view_1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.view_1BindingNavigator.Name = "view_1BindingNavigator";
            this.view_1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.view_1BindingNavigator.Size = new System.Drawing.Size(770, 25);
            this.view_1BindingNavigator.TabIndex = 0;
            this.view_1BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Erste verschieben";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Vorherige verschieben";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Aktuelle Position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(44, 22);
            this.bindingNavigatorCountItem.Text = "von {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente.";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Nächste verschieben";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Letzte verschieben";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "von {0}";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Löschen";
            // 
            // view_1BindingNavigatorSaveItem
            // 
            this.view_1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.view_1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("view_1BindingNavigatorSaveItem.Image")));
            this.view_1BindingNavigatorSaveItem.Name = "view_1BindingNavigatorSaveItem";
            this.view_1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.view_1BindingNavigatorSaveItem.Text = "Daten speichern";
            this.view_1BindingNavigatorSaveItem.Click += new System.EventHandler(this.view_1BindingNavigatorSaveItem_Click);
            // 
            // view_1DataGridView
            // 
            this.view_1DataGridView.AutoGenerateColumns = false;
            this.view_1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1});
            this.view_1DataGridView.DataSource = this.view_1BindingSource;
            this.view_1DataGridView.Location = new System.Drawing.Point(12, 61);
            this.view_1DataGridView.Name = "view_1DataGridView";
            this.view_1DataGridView.Size = new System.Drawing.Size(746, 293);
            this.view_1DataGridView.TabIndex = 1;
            
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Personalnummer";
            this.dataGridViewTextBoxColumn1.HeaderText = "Personalnummer";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Vorname";
            this.dataGridViewTextBoxColumn5.HeaderText = "Vorname";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Nachname";
            this.dataGridViewTextBoxColumn6.HeaderText = "Nachname";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EintrittsDatum";
            this.dataGridViewTextBoxColumn2.HeaderText = "EintrittsDatum";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AustrittsDatum";
            this.dataGridViewTextBoxColumn3.HeaderText = "AustrittsDatum";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TagesSollZeit";
            this.dataGridViewTextBoxColumn4.HeaderText = "TagesSollZeit";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsAdmin";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IsAdmin";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Location = new System.Drawing.Point(13, 35);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(241, 20);
            this.TextBoxSearch.TabIndex = 2;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // MitarbeiterUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 462);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.view_1DataGridView);
            this.Controls.Add(this.view_1BindingNavigator);
            this.Name = "MitarbeiterUpdate";
            this.Text = "MitarbeiterUpdate";
            this.Load += new System.EventHandler(this.MitarbeiterUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zEIT2017DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_1BindingNavigator)).EndInit();
            this.view_1BindingNavigator.ResumeLayout(false);
            this.view_1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_1DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZEIT2017DataSet3 zEIT2017DataSet3;
        private System.Windows.Forms.BindingSource view_1BindingSource;
        private ZEIT2017DataSet3TableAdapters.View_1TableAdapter view_1TableAdapter;
        private ZEIT2017DataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator view_1BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton view_1BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView view_1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TextBox TextBoxSearch;
    }
}