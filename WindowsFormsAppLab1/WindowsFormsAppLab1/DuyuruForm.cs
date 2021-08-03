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
    public partial class DuyuruForm : Form
    {
        public DuyuruForm()
        {
            InitializeComponent();
        }

        private void duyuruekleButton_Click(object sender, EventArgs e)
        {
            //tıklandığında duyuru db'ye eklensin
        }

        private void site_DuyuruBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.site_DuyuruBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.siteYönetimWPDBDataSet);

        }

        private void DuyuruForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'siteYönetimWPDBDataSet.Site_Duyuru' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.site_DuyuruTableAdapter.Fill(this.siteYönetimWPDBDataSet.Site_Duyuru);

        }

        private void duyuruekleButton_Click_1(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-T4FL7CL; Initial Catalog=SiteYönetimWPDB; Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Site_Duyuru (duyuru) VALUES (@dyr)", connection))
            {
                connection.Open();
                var paramadyr = cmd.Parameters.Add("@dyr", duyuruTextbox.Text);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Duyuru başarıyla eklendi!", "Başarılı");

            }
        }
    }
}
