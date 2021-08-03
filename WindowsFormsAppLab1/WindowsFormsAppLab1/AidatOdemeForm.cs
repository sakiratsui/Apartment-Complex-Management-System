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
    public partial class AidatOdemeForm : Form
    {
        public AidatOdemeForm()
        {
            InitializeComponent();
        }

        private void kartlaodeButton_Click(object sender, EventArgs e)
        {
            //Textbox kontrolleri, Ödeme bilgisi tamamlandığında db'de ödendi olarak güncellenme ve close
            if (kartnoTextbox.TextLength == 11 && kartaycomboBox.SelectedItem != null && yilcomboBox.SelectedItem != null
                && cvvTextbox.TextLength == 3)
            {
                //datasette güncelleme yapılacak!!
                string connectionstring = "Data Source=DESKTOP-T4FL7CL; Initial Catalog=SiteYönetimWPDB; Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionstring))
                using (SqlCommand cmd = new SqlCommand("UPDATE Site_Aidat SET aidat = @adt WHERE blok = @blk AND daire = @dre", connection))
                {
                    connection.Open();
                    var paramadt = cmd.Parameters.Add("@adt", "Ödendi");
                    var paramblk = cmd.Parameters.Add("@blk", blokTextbox.Text);
                    var paramdre = cmd.Parameters.Add("@dre", daireTextbox.Text);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    
                }

                MessageBox.Show("Ödeme işleminiz başarıyla gerçekleştirilmiştir!", "Ödeme Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Ödeme işleminiz gerçekleştirilemedi.Lütfen bilgilerinizi eksiksiz bir şekilde doldurup tekrar deneyiniz."
                    , "Ödeme tamamlanamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
