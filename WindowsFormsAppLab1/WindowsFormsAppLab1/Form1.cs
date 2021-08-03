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
    public partial class ManagementForm : Form
    {
        private Button currentbutton;  //mevcut butonun tutulduğu değişken
        private Form activeform; //mevcut form

        public ManagementForm(Login loginform)
        {
            InitializeComponent();
            adLabel.Text = loginform.usernameTextBox.Text;
        }

        private void duyuruButton_Click(object sender, EventArgs e)
        {
            if(currentbutton != null) //BUTON RENK GEÇİŞLERİ VE KONTROLLERİ
            {
                currentbutton.BackColor = Color.FromArgb(45, 45, 45);
                currentbutton.ForeColor = Color.Gainsboro;
            }
            currentbutton = (Button)sender;
            currentbutton.BackColor = Color.Purple;
            homePanel.BackColor = Color.Purple;
            currentbutton.ForeColor = Color.White;
            DuyuruForm dform = new DuyuruForm();
            openChildForm(dform, currentbutton);
            

        }

        private void genelbakisButton_Click(object sender, EventArgs e)
        {
            if (currentbutton != null) //BUTON RENK GEÇİŞLERİ VE KONTROLLERİ
            {
                currentbutton.BackColor = Color.FromArgb(45, 45, 45);
                currentbutton.ForeColor = Color.Gainsboro;
            }
            currentbutton = (Button)sender;
            currentbutton.BackColor = Color.IndianRed;
            homePanel.BackColor = Color.IndianRed;
            currentbutton.ForeColor = Color.White;
            GenelBakisForm gform = new GenelBakisForm();
            openChildForm(gform, currentbutton);

        }

        private void aidatButton_Click(object sender, EventArgs e)
        {
            if (currentbutton != null) //BUTON RENK GEÇİŞLERİ VE KONTROLLERİ
            {
                currentbutton.BackColor = Color.FromArgb(45, 45, 45);
                currentbutton.ForeColor = Color.Gainsboro;
            }
            currentbutton = (Button)sender;
            currentbutton.BackColor = Color.ForestGreen;
            homePanel.BackColor = Color.ForestGreen;
            currentbutton.ForeColor = Color.White;
            AidatForm aform = new AidatForm();
            openChildForm(aform, currentbutton);

        }

        private void giderlerButton_Click(object sender, EventArgs e)
        {
            if (currentbutton != null)  //BUTON RENK GEÇİŞLERİ VE KONTROLLERİ
            {
                currentbutton.BackColor = Color.FromArgb(45, 45, 45);
                currentbutton.ForeColor = Color.Gainsboro;
            }
            currentbutton = (Button)sender;
            currentbutton.BackColor = Color.Gray;
            homePanel.BackColor = Color.Gray;
            currentbutton.ForeColor = Color.White;
            homeLabel.Text = "Site Giderleri";
            GiderlerForm gform = new GiderlerForm();
            gform.Show();
            //mdi'ların top level'ı false olamayacağı için
            //openchildform metodu çalıştırılamaz.
        }

        private void hesapButton_Click(object sender, EventArgs e)
        {
            if (currentbutton != null)  //BUTON RENK GEÇİŞLERİ VE KONTROLLERİ
            {
                currentbutton.BackColor = Color.FromArgb(45, 45, 45);
                currentbutton.ForeColor = Color.Gainsboro;
            }
            currentbutton = (Button)sender;
            currentbutton.BackColor = Color.BlueViolet;
            homePanel.BackColor = Color.BlueViolet;
            currentbutton.ForeColor = Color.White;
            HesapForm hform = new HesapForm(this);
            openChildForm(hform, currentbutton);
        }

        private void cikisButton_Click(object sender, EventArgs e)
        {
            if (currentbutton != null)  //BUTON RENK GEÇİŞLERİ VE KONTROLLERİ
            {
                currentbutton.BackColor = Color.FromArgb(45, 45, 45);
                currentbutton.ForeColor = Color.Gainsboro;
            }
            currentbutton = (Button)sender;
            currentbutton.BackColor = Color.Tan;
            homePanel.BackColor = Color.Tan;
            currentbutton.ForeColor = Color.White;
            this.Close();
            Application.Exit();
        }

        private void openChildForm(Form childform, object btnsender)
        {
            if(activeform!= null)
            {
                activeform.Close();
            }
            currentbutton = (Button)btnsender;
            homePanel.BackColor = currentbutton.BackColor;
            currentbutton.ForeColor = Color.White;
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childform);
            this.panelDesktopPane.Tag = childform;
            childform.BringToFront();
            childform.Show();
            homeLabel.Text = childform.Text;

        }

        private void appclosebutton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
