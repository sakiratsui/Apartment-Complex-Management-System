namespace WindowsFormsAppLab1
{
    partial class GenelBakisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenelBakisForm));
            this.label1 = new System.Windows.Forms.Label();
            this.siteYönetimWPDBDataSet = new WindowsFormsAppLab1.SiteYönetimWPDBDataSet();
            this.site_KullaniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.site_KullaniciTableAdapter = new WindowsFormsAppLab1.SiteYönetimWPDBDataSetTableAdapters.Site_KullaniciTableAdapter();
            this.tableAdapterManager = new WindowsFormsAppLab1.SiteYönetimWPDBDataSetTableAdapters.TableAdapterManager();
            this.site_KullaniciBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.site_KullaniciBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.site_KullaniciDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.siteYönetimWPDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.site_KullaniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.site_KullaniciBindingNavigator)).BeginInit();
            this.site_KullaniciBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.site_KullaniciDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "tüm kullanıcıları gösteren kısım";
            // 
            // siteYönetimWPDBDataSet
            // 
            this.siteYönetimWPDBDataSet.DataSetName = "SiteYönetimWPDBDataSet";
            this.siteYönetimWPDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // site_KullaniciBindingSource
            // 
            this.site_KullaniciBindingSource.DataMember = "Site_Kullanici";
            this.site_KullaniciBindingSource.DataSource = this.siteYönetimWPDBDataSet;
            // 
            // site_KullaniciTableAdapter
            // 
            this.site_KullaniciTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Site_AidatTableAdapter = null;
            this.tableAdapterManager.Site_DuyuruTableAdapter = null;
            this.tableAdapterManager.Site_GiderTableAdapter = null;
            this.tableAdapterManager.Site_KullaniciTableAdapter = this.site_KullaniciTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsAppLab1.SiteYönetimWPDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // site_KullaniciBindingNavigator
            // 
            this.site_KullaniciBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.site_KullaniciBindingNavigator.BindingSource = this.site_KullaniciBindingSource;
            this.site_KullaniciBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.site_KullaniciBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.site_KullaniciBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.site_KullaniciBindingNavigatorSaveItem});
            this.site_KullaniciBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.site_KullaniciBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.site_KullaniciBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.site_KullaniciBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.site_KullaniciBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.site_KullaniciBindingNavigator.Name = "site_KullaniciBindingNavigator";
            this.site_KullaniciBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.site_KullaniciBindingNavigator.Size = new System.Drawing.Size(450, 25);
            this.site_KullaniciBindingNavigator.TabIndex = 1;
            this.site_KullaniciBindingNavigator.Text = "bindingNavigator1";
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
            // site_KullaniciBindingNavigatorSaveItem
            // 
            this.site_KullaniciBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.site_KullaniciBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("site_KullaniciBindingNavigatorSaveItem.Image")));
            this.site_KullaniciBindingNavigatorSaveItem.Name = "site_KullaniciBindingNavigatorSaveItem";
            this.site_KullaniciBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.site_KullaniciBindingNavigatorSaveItem.Text = "Veriyi Sakla";
            this.site_KullaniciBindingNavigatorSaveItem.Click += new System.EventHandler(this.site_KullaniciBindingNavigatorSaveItem_Click);
            // 
            // site_KullaniciDataGridView
            // 
            this.site_KullaniciDataGridView.AutoGenerateColumns = false;
            this.site_KullaniciDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.site_KullaniciDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.site_KullaniciDataGridView.DataSource = this.site_KullaniciBindingSource;
            this.site_KullaniciDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.site_KullaniciDataGridView.Location = new System.Drawing.Point(0, 25);
            this.site_KullaniciDataGridView.Name = "site_KullaniciDataGridView";
            this.site_KullaniciDataGridView.Size = new System.Drawing.Size(450, 349);
            this.site_KullaniciDataGridView.TabIndex = 2;
            this.site_KullaniciDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.site_KullaniciDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ad";
            this.dataGridViewTextBoxColumn4.HeaderText = "ad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 130;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "soyad";
            this.dataGridViewTextBoxColumn5.HeaderText = "soyad";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 130;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "blok";
            this.dataGridViewTextBoxColumn6.HeaderText = "blok";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "daire";
            this.dataGridViewTextBoxColumn7.HeaderText = "daire";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // GenelBakisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(450, 374);
            this.Controls.Add(this.site_KullaniciDataGridView);
            this.Controls.Add(this.site_KullaniciBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "GenelBakisForm";
            this.Text = "Genel Bakış";
            this.Load += new System.EventHandler(this.GenelBakisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.siteYönetimWPDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.site_KullaniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.site_KullaniciBindingNavigator)).EndInit();
            this.site_KullaniciBindingNavigator.ResumeLayout(false);
            this.site_KullaniciBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.site_KullaniciDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private SiteYönetimWPDBDataSet siteYönetimWPDBDataSet;
        private System.Windows.Forms.BindingSource site_KullaniciBindingSource;
        private SiteYönetimWPDBDataSetTableAdapters.Site_KullaniciTableAdapter site_KullaniciTableAdapter;
        private SiteYönetimWPDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator site_KullaniciBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton site_KullaniciBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView site_KullaniciDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}