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
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-T4FL7CL; Initial Catalog=SiteYönetimWPDB; Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Site_Kullanici WHERE kullaniciadi='" + usernameTextBox.Text + "' AND sifre='" + passwordTextBox.Text + "'", con); //sorgudan uyanları seçiyoruz.
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                //MessageBox.Show("giriş başarılı!", "Giriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //currentusr = usernametextbox
                ManagementForm form = new ManagementForm(this);
                form.Show();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre! Lütfen bilgilerinizi kontrol edip tekrar deneyiniz.", "Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginclosebutton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
