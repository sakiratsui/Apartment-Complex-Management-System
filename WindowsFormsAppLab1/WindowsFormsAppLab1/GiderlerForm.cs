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
    public partial class GiderlerForm : Form
    {
        public GiderlerForm()
        {
            InitializeComponent();
            GiderChild gcform = new GiderChild();
            gcform.MdiParent = this;
            gcform.Show();
            GiderChild2 gc2form = new GiderChild2();
            gc2form.MdiParent = this;
            gc2form.Show();
            this.LayoutMdi(MdiLayout.TileHorizontal);

        }

        private void GiderlerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
