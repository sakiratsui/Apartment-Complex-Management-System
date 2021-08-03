using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLab1
{
    public partial class GiderChild2 : Form
    {
        public GiderChild2()
        {
            InitializeComponent();
        }

        private void site_GiderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.site_GiderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.siteYönetimWPDBDataSet);

        }

        private void GiderChild2_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'siteYönetimWPDBDataSet.Site_Gider' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.site_GiderTableAdapter.Fill(this.siteYönetimWPDBDataSet.Site_Gider);

        }

        
    }
}
