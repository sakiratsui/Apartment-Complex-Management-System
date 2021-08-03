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
    public partial class GiderChild : Form
    {
        public GiderChild()
        {
            InitializeComponent();
            
        }

        private void GiderChild_Load(object sender, EventArgs e)
        {
            //giderlerin grafiği
            string query = "SELECT * FROM Site_Gider";
            DataTable dt = GetData(query);
            string[] x = (from p in dt.AsEnumerable()
                          orderby p.Field<string>("gider") ascending
                          select p.Field<string>("gider")).ToArray(); //veritabanı değerleri arraye çevirildi.
            int[] y = (from p in dt.AsEnumerable()
                       orderby p.Field<string>("gider") ascending
                       select p.Field<int>("ücret")).ToArray();

            chart1.Series[0].Points.DataBindXY(x, y);
            chart1.Series[0]["PieLabelStyle"] = "Disabled"; //labellar disable edildi.
            chart1.Legends[0].Enabled = true;
            chart1.ChartAreas[0].Area3DStyle.Enable3D = true;

        }
        private static DataTable GetData(string query)
        {
            string constr = "Data Source=DESKTOP-T4FL7CL; Initial Catalog=SiteYönetimWPDB; Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
