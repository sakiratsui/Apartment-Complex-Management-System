namespace WindowsFormsAppLab1
{
    partial class AidatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AidatForm));
            this.siteYönetimWPDBDataSet = new WindowsFormsAppLab1.SiteYönetimWPDBDataSet();
            this.site_AidatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.site_AidatTableAdapter = new WindowsFormsAppLab1.SiteYönetimWPDBDataSetTableAdapters.Site_AidatTableAdapter();
            this.tableAdapterManager = new WindowsFormsAppLab1.SiteYönetimWPDBDataSetTableAdapters.TableAdapterManager();
            this.site_AidatBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.site_AidatBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.site_AidatDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aidatOdeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.siteYönetimWPDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.site_AidatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.site_AidatBindingNavigator)).BeginInit();
            this.site_AidatBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.site_AidatDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // siteYönetimWPDBDataSet
            // 
            this.siteYönetimWPDBDataSet.DataSetName = "SiteYönetimWPDBDataSet";
            this.siteYönetimWPDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // site_AidatBindingSource
            // 
            this.site_AidatBindingSource.DataMember = "Site_Aidat";
            this.site_AidatBindingSource.DataSource = this.siteYönetimWPDBDataSet;
            // 
            // site_AidatTableAdapter
            // 
            this.site_AidatTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Site_AidatTableAdapter = this.site_AidatTableAdapter;
            this.tableAdapterManager.Site_DuyuruTableAdapter = null;
            this.tableAdapterManager.Site_GiderTableAdapter = null;
            this.tableAdapterManager.Site_KullaniciTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsAppLab1.SiteYönetimWPDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // site_AidatBindingNavigator
            // 
            this.site_AidatBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.site_AidatBindingNavigator.BindingSource = this.site_AidatBindingSource;
            this.site_AidatBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.site_AidatBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.site_AidatBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.site_AidatBindingNavigatorSaveItem});
            this.site_AidatBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.site_AidatBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.site_AidatBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.site_AidatBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.site_AidatBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.site_AidatBindingNavigator.Name = "site_AidatBindingNavigator";
            this.site_AidatBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.site_AidatBindingNavigator.Size = new System.Drawing.Size(546, 25);
            this.site_AidatBindingNavigator.TabIndex = 0;
            this.site_AidatBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Yeni ekle";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Toplam öğe sayısı";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Sil";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Başa taşı";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Öne taşı";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Konum";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Geçerli konum";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Arkaya taşı";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Sona taşı";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // site_AidatBindingNavigatorSaveItem
            // 
            this.site_AidatBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.site_AidatBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("site_AidatBindingNavigatorSaveItem.Image")));
            this.site_AidatBindingNavigatorSaveItem.Name = "site_AidatBindingNavigatorSaveItem";
            this.site_AidatBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.site_AidatBindingNavigatorSaveItem.Text = "Veriyi Sakla";
            this.site_AidatBindingNavigatorSaveItem.Click += new System.EventHandler(this.site_AidatBindingNavigatorSaveItem_Click);
            // 
            // site_AidatDataGridView
            // 
            this.site_AidatDataGridView.AutoGenerateColumns = false;
            this.site_AidatDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.site_AidatDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.site_AidatDataGridView.DataSource = this.site_AidatBindingSource;
            this.site_AidatDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.site_AidatDataGridView.Location = new System.Drawing.Point(0, 25);
            this.site_AidatDataGridView.Name = "site_AidatDataGridView";
            this.site_AidatDataGridView.Size = new System.Drawing.Size(546, 350);
            this.site_AidatDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ad";
            this.dataGridViewTextBoxColumn2.HeaderText = "ad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "soyad";
            this.dataGridViewTextBoxColumn3.HeaderText = "soyad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "blok";
            this.dataGridViewTextBoxColumn4.HeaderText = "blok";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "daire";
            this.dataGridViewTextBoxColumn5.HeaderText = "daire";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "aidat";
            this.dataGridViewTextBoxColumn6.HeaderText = "aidat";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // aidatOdeButton
            // 
            this.aidatOdeButton.BackColor = System.Drawing.Color.PaleGreen;
            this.aidatOdeButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.aidatOdeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aidatOdeButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aidatOdeButton.Location = new System.Drawing.Point(0, 373);
            this.aidatOdeButton.Name = "aidatOdeButton";
            this.aidatOdeButton.Size = new System.Drawing.Size(546, 51);
            this.aidatOdeButton.TabIndex = 2;
            this.aidatOdeButton.Text = "Aidat Öde";
            this.aidatOdeButton.UseVisualStyleBackColor = false;
            this.aidatOdeButton.Click += new System.EventHandler(this.aidatOdeButton_Click);
            // 
            // AidatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(546, 424);
            this.Controls.Add(this.aidatOdeButton);
            this.Controls.Add(this.site_AidatDataGridView);
            this.Controls.Add(this.site_AidatBindingNavigator);
            this.Name = "AidatForm";
            this.Text = "Aidatlar";
            this.Load += new System.EventHandler(this.AidatForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.siteYönetimWPDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.site_AidatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.site_AidatBindingNavigator)).EndInit();
            this.site_AidatBindingNavigator.ResumeLayout(false);
            this.site_AidatBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.site_AidatDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SiteYönetimWPDBDataSet siteYönetimWPDBDataSet;
        private System.Windows.Forms.BindingSource site_AidatBindingSource;
        private SiteYönetimWPDBDataSetTableAdapters.Site_AidatTableAdapter site_AidatTableAdapter;
        private SiteYönetimWPDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator site_AidatBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton site_AidatBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView site_AidatDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button aidatOdeButton;
    }
}