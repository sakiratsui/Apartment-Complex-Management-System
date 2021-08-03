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
    public partial class GenelBakisForm : Form
    {
        public GenelBakisForm()
        {
            InitializeComponent();
        }

        private void site_KullaniciBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.site_KullaniciBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.siteYönetimWPDBDataSet);

        }

        private void GenelBakisForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'siteYönetimWPDBDataSet.Site_Kullanici' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.site_KullaniciTableAdapter.Fill(this.siteYönetimWPDBDataSet.Site_Kullanici);

        }

        private void site_KullaniciDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
