
namespace WindowsFormsAppLab1
{
    partial class GiderlerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiderlerForm));
            this.siteGiderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siteYönetimWPDBDataSet = new WindowsFormsAppLab1.SiteYönetimWPDBDataSet();
            this.site_GiderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.site_GiderTableAdapter = new WindowsFormsAppLab1.SiteYönetimWPDBDataSetTableAdapters.Site_GiderTableAdapter();
            this.tableAdapterManager = new WindowsFormsAppLab1.SiteYönetimWPDBDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.siteGiderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteYönetimWPDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.site_GiderBindingSource)).BeginInit();
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
            // GiderlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(561, 376);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "GiderlerForm";
            this.Text = "Site Giderleri";
            this.Load += new System.EventHandler(this.GiderlerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.siteGiderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteYönetimWPDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.site_GiderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource siteGiderBindingSource;
        private SiteYönetimWPDBDataSet siteYönetimWPDBDataSet;
        private System.Windows.Forms.BindingSource site_GiderBindingSource;
        private SiteYönetimWPDBDataSetTableAdapters.Site_GiderTableAdapter site_GiderTableAdapter;
        private SiteYönetimWPDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}