
namespace WindowsFormsAppLab1
{
    partial class GiderChild2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiderChild2));
            this.siteYönetimWPDBDataSet = new WindowsFormsAppLab1.SiteYönetimWPDBDataSet();
            this.site_GiderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.site_GiderTableAdapter = new WindowsFormsAppLab1.SiteYönetimWPDBDataSetTableAdapters.Site_GiderTableAdapter();
            this.tableAdapterManager = new WindowsFormsAppLab1.SiteYönetimWPDBDataSetTableAdapters.TableAdapterManager();
            this.site_GiderBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.site_GiderBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.site_GiderDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.siteYönetimWPDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.site_GiderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.site_GiderBindingNavigator)).BeginInit();
            this.site_GiderBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.site_GiderDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // siteYönetimWPDBDataSet
            // 
            this.siteYönetimWPDBDataSet.DataSetName = "SiteYönetimWPDBDataSet";
            this.siteYönetimWPDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // site_GiderBindingSource
            // 
            this.site_GiderBindingSource.DataMember = "Site_Gider";
            this.site_GiderBindingSource.DataSource = this.siteYönetimWPDBDataSet;
            // 
            // site_GiderTableAdapter
            // 
            this.site_GiderTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Site_AidatTableAdapter = null;
            this.tableAdapterManager.Site_DuyuruTableAdapter = null;
            this.tableAdapterManager.Site_GiderTableAdapter = this.site_GiderTableAdapter;
            this.tableAdapterManager.Site_KullaniciTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsAppLab1.SiteYönetimWPDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // site_GiderBindingNavigator
            // 
            this.site_GiderBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.site_GiderBindingNavigator.BindingSource = this.site_GiderBindingSource;
            this.site_GiderBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.site_GiderBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.site_GiderBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.site_GiderBindingNavigatorSaveItem});
            this.site_GiderBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.site_GiderBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.site_GiderBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.site_GiderBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.site_GiderBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.site_GiderBindingNavigator.Name = "site_GiderBindingNavigator";
            this.site_GiderBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.site_GiderBindingNavigator.Size = new System.Drawing.Size(352, 25);
            this.site_GiderBindingNavigator.TabIndex = 0;
            this.site_GiderBindingNavigator.Text = "bindingNavigator1";
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
            // site_GiderBindingNavigatorSaveItem
            // 
            this.site_GiderBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.site_GiderBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("site_GiderBindingNavigatorSaveItem.Image")));
            this.site_GiderBindingNavigatorSaveItem.Name = "site_GiderBindingNavigatorSaveItem";
            this.site_GiderBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.site_GiderBindingNavigatorSaveItem.Text = "Veriyi Sakla";
            this.site_GiderBindingNavigatorSaveItem.Click += new System.EventHandler(this.site_GiderBindingNavigatorSaveItem_Click);
            // 
            // site_GiderDataGridView
            // 
            this.site_GiderDataGridView.AutoGenerateColumns = false;
            this.site_GiderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.site_GiderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.site_GiderDataGridView.DataSource = this.site_GiderBindingSource;
            this.site_GiderDataGridView.Location = new System.Drawing.Point(0, 28);
            this.site_GiderDataGridView.Name = "site_GiderDataGridView";
            this.site_GiderDataGridView.Size = new System.Drawing.Size(352, 264);
            this.site_GiderDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "gider";
            this.dataGridViewTextBoxColumn1.HeaderText = "gider";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ücret";
            this.dataGridViewTextBoxColumn2.HeaderText = "ücret";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // GiderChild2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(352, 291);
            this.Controls.Add(this.site_GiderDataGridView);
            this.Controls.Add(this.site_GiderBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GiderChild2";
            this.Text = "Mevcut Giderler";
            this.Load += new System.EventHandler(this.GiderChild2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.siteYönetimWPDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.site_GiderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.site_GiderBindingNavigator)).EndInit();
            this.site_GiderBindingNavigator.ResumeLayout(false);
            this.site_GiderBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.site_GiderDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SiteYönetimWPDBDataSet siteYönetimWPDBDataSet;
        private System.Windows.Forms.BindingSource site_GiderBindingSource;
        private SiteYönetimWPDBDataSetTableAdapters.Site_GiderTableAdapter site_GiderTableAdapter;
        private SiteYönetimWPDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator site_GiderBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton site_GiderBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView site_GiderDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}