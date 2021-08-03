using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLab1
{
    public partial class AidatForm : Form
    {
        public AidatForm()
        {
            InitializeComponent();
        }

        private void site_AidatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.site_AidatBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.siteYönetimWPDBDataSet);

        }

        private void AidatForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'siteYönetimWPDBDataSet.Site_Aidat' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.site_AidatTableAdapter.Fill(this.siteYönetimWPDBDataSet.Site_Aidat);

        }

        private void aidatOdeButton_Click(object sender, EventArgs e)
        {
            AidatOdemeForm aidform = new AidatOdemeForm();
            aidform.Show();
        }
    }
}
