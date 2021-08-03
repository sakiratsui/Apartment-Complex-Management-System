namespace WindowsFormsAppLab1
{
    partial class DuyuruForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DuyuruForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.site_DuyuruDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.site_DuyuruBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siteYönetimWPDBDataSet = new WindowsFormsAppLab1.SiteYönetimWPDBDataSet();
            this.duyuruekleButton = new System.Windows.Forms.Button();
            this.duyuruTextbox = new System.Windows.Forms.TextBox();
            this.site_DuyuruTableAdapter = new WindowsFormsAppLab1.SiteYönetimWPDBDataSetTableAdapters.Site_DuyuruTableAdapter();
            this.tableAdapterManager = new WindowsFormsAppLab1.SiteYönetimWPDBDataSetTableAdapters.TableAdapterManager();
            this.site_DuyuruBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.site_DuyuruBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.site_DuyuruDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.site_DuyuruBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteYönetimWPDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.site_DuyuruBindingNavigator)).BeginInit();
            this.site_DuyuruBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.site_DuyuruDataGridView);
            this.panel1.Controls.Add(this.duyuruekleButton);
            this.panel1.Controls.Add(this.duyuruTextbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 412);
            this.panel1.TabIndex = 0;
            // 
            // site_DuyuruDataGridView
            // 
            this.site_DuyuruDataGridView.AutoGenerateColumns = false;
            this.site_DuyuruDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.site_DuyuruDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.site_DuyuruDataGridView.DataSource = this.site_DuyuruBindingSource;
            this.site_DuyuruDataGridView.Location = new System.Drawing.Point(0, 28);
            this.site_DuyuruDataGridView.Name = "site_DuyuruDataGridView";
            this.site_DuyuruDataGridView.Size = new System.Drawing.Size(537, 302);
            this.site_DuyuruDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "duyuru";
            this.dataGridViewTextBoxColumn1.HeaderText = "duyuru";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 500;
            // 
            // site_DuyuruBindingSource
            // 
            this.site_DuyuruBindingSource.DataMember = "Site_Duyuru";
            this.site_DuyuruBindingSource.DataSource = this.siteYönetimWPDBDataSet;
            // 
            // siteYönetimWPDBDataSet
            // 
            this.siteYönetimWPDBDataSet.DataSetName = "SiteYönetimWPDBDataSet";
            this.siteYönetimWPDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // duyuruekleButton
            // 
            this.duyuruekleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.duyuruekleButton.FlatAppearance.BorderSize = 0;
            this.duyuruekleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.duyuruekleButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.duyuruekleButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.duyuruekleButton.Location = new System.Drawing.Point(406, 336);
            this.duyuruekleButton.Name = "duyuruekleButton";
            this.duyuruekleButton.Size = new System.Drawing.Size(131, 62);
            this.duyuruekleButton.TabIndex = 1;
            this.duyuruekleButton.Text = "Ekle";
            this.duyuruekleButton.UseVisualStyleBackColor = false;
            this.duyuruekleButton.Click += new System.EventHandler(this.duyuruekleButton_Click_1);
            // 
            // duyuruTextbox
            // 
            this.duyuruTextbox.BackColor = System.Drawing.Color.Gainsboro;
            this.duyuruTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.duyuruTextbox.Location = new System.Drawing.Point(1, 333);
            this.duyuruTextbox.Multiline = true;
            this.duyuruTextbox.Name = "duyuruTextbox";
            this.duyuruTextbox.Size = new System.Drawing.Size(400, 62);
            this.duyuruTextbox.TabIndex = 2;
            // 
            // site_DuyuruTableAdapter
            // 
            this.site_DuyuruTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Site_AidatTableAdapter = null;
            this.tableAdapterManager.Site_DuyuruTableAdapter = this.site_DuyuruTableAdapter;
            this.tableAdapterManager.Site_GiderTableAdapter = null;
            this.tableAdapterManager.Site_KullaniciTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsAppLab1.SiteYönetimWPDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // site_DuyuruBindingNavigator
            // 
            this.site_DuyuruBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.site_DuyuruBindingNavigator.BindingSource = this.site_DuyuruBindingSource;
            this.site_DuyuruBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.site_DuyuruBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.site_DuyuruBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.site_DuyuruBindingNavigatorSaveItem});
            this.site_DuyuruBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.site_DuyuruBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.site_DuyuruBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.site_DuyuruBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.site_DuyuruBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.site_DuyuruBindingNavigator.Name = "site_DuyuruBindingNavigator";
            this.site_DuyuruBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.site_DuyuruBindingNavigator.Size = new System.Drawing.Size(539, 25);
            this.site_DuyuruBindingNavigator.TabIndex = 2;
            this.site_DuyuruBindingNavigator.Text = "bindingNavigator1";
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
            // site_DuyuruBindingNavigatorSaveItem
            // 
            this.site_DuyuruBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.site_DuyuruBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("site_DuyuruBindingNavigatorSaveItem.Image")));
            this.site_DuyuruBindingNavigatorSaveItem.Name = "site_DuyuruBindingNavigatorSaveItem";
            this.site_DuyuruBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.site_DuyuruBindingNavigatorSaveItem.Text = "Veriyi Sakla";
            this.site_DuyuruBindingNavigatorSaveItem.Click += new System.EventHandler(this.site_DuyuruBindingNavigatorSaveItem_Click);
            // 
            // DuyuruForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(539, 412);
            this.Controls.Add(this.site_DuyuruBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "DuyuruForm";
            this.Text = "Duyurular";
            this.Load += new System.EventHandler(this.DuyuruForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.site_DuyuruDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.site_DuyuruBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteYönetimWPDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.site_DuyuruBindingNavigator)).EndInit();
            this.site_DuyuruBindingNavigator.ResumeLayout(false);
            this.site_DuyuruBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button duyuruekleButton;
        private System.Windows.Forms.TextBox duyuruTextbox;
        private SiteYönetimWPDBDataSet siteYönetimWPDBDataSet;
        private System.Windows.Forms.BindingSource site_DuyuruBindingSource;
        private SiteYönetimWPDBDataSetTableAdapters.Site_DuyuruTableAdapter site_DuyuruTableAdapter;
        private SiteYönetimWPDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator site_DuyuruBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton site_DuyuruBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView site_DuyuruDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}