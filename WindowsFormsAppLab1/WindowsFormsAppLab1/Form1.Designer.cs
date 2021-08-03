namespace WindowsFormsAppLab1
{
    partial class ManagementForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementForm));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.cikisButton = new System.Windows.Forms.Button();
            this.hesapButton = new System.Windows.Forms.Button();
            this.giderlerButton = new System.Windows.Forms.Button();
            this.aidatButton = new System.Windows.Forms.Button();
            this.genelbakisButton = new System.Windows.Forms.Button();
            this.duyuruButton = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.button = new System.Windows.Forms.Button();
            this.adLabel = new System.Windows.Forms.Label();
            this.homePanel = new System.Windows.Forms.Panel();
            this.appclosebutton = new System.Windows.Forms.Button();
            this.homeLabel = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.homePanel.SuspendLayout();
            this.panelDesktopPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.menuPanel.Controls.Add(this.cikisButton);
            this.menuPanel.Controls.Add(this.hesapButton);
            this.menuPanel.Controls.Add(this.giderlerButton);
            this.menuPanel.Controls.Add(this.aidatButton);
            this.menuPanel.Controls.Add(this.genelbakisButton);
            this.menuPanel.Controls.Add(this.duyuruButton);
            this.menuPanel.Controls.Add(this.logoPanel);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(200, 494);
            this.menuPanel.TabIndex = 1;
            // 
            // cikisButton
            // 
            this.cikisButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cikisButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.cikisButton.FlatAppearance.BorderSize = 0;
            this.cikisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikisButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.cikisButton.Image = ((System.Drawing.Image)(resources.GetObject("cikisButton.Image")));
            this.cikisButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cikisButton.Location = new System.Drawing.Point(0, 420);
            this.cikisButton.Name = "cikisButton";
            this.cikisButton.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.cikisButton.Size = new System.Drawing.Size(200, 70);
            this.cikisButton.TabIndex = 6;
            this.cikisButton.Text = "  Çıkış";
            this.cikisButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cikisButton.UseVisualStyleBackColor = true;
            this.cikisButton.Click += new System.EventHandler(this.cikisButton_Click);
            // 
            // hesapButton
            // 
            this.hesapButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.hesapButton.FlatAppearance.BorderSize = 0;
            this.hesapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hesapButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesapButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.hesapButton.Image = ((System.Drawing.Image)(resources.GetObject("hesapButton.Image")));
            this.hesapButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hesapButton.Location = new System.Drawing.Point(0, 350);
            this.hesapButton.Name = "hesapButton";
            this.hesapButton.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.hesapButton.Size = new System.Drawing.Size(200, 70);
            this.hesapButton.TabIndex = 5;
            this.hesapButton.Text = "  Hesabım";
            this.hesapButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.hesapButton.UseVisualStyleBackColor = true;
            this.hesapButton.Click += new System.EventHandler(this.hesapButton_Click);
            // 
            // giderlerButton
            // 
            this.giderlerButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.giderlerButton.FlatAppearance.BorderSize = 0;
            this.giderlerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.giderlerButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giderlerButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.giderlerButton.Image = ((System.Drawing.Image)(resources.GetObject("giderlerButton.Image")));
            this.giderlerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.giderlerButton.Location = new System.Drawing.Point(0, 280);
            this.giderlerButton.Name = "giderlerButton";
            this.giderlerButton.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.giderlerButton.Size = new System.Drawing.Size(200, 70);
            this.giderlerButton.TabIndex = 4;
            this.giderlerButton.Text = "  Site Giderleri";
            this.giderlerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.giderlerButton.UseVisualStyleBackColor = true;
            this.giderlerButton.Click += new System.EventHandler(this.giderlerButton_Click);
            // 
            // aidatButton
            // 
            this.aidatButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.aidatButton.FlatAppearance.BorderSize = 0;
            this.aidatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aidatButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aidatButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.aidatButton.Image = ((System.Drawing.Image)(resources.GetObject("aidatButton.Image")));
            this.aidatButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aidatButton.Location = new System.Drawing.Point(0, 210);
            this.aidatButton.Name = "aidatButton";
            this.aidatButton.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.aidatButton.Size = new System.Drawing.Size(200, 70);
            this.aidatButton.TabIndex = 3;
            this.aidatButton.Text = "  Aidatlar";
            this.aidatButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.aidatButton.UseVisualStyleBackColor = true;
            this.aidatButton.Click += new System.EventHandler(this.aidatButton_Click);
            // 
            // genelbakisButton
            // 
            this.genelbakisButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.genelbakisButton.FlatAppearance.BorderSize = 0;
            this.genelbakisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genelbakisButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.genelbakisButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.genelbakisButton.Image = ((System.Drawing.Image)(resources.GetObject("genelbakisButton.Image")));
            this.genelbakisButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.genelbakisButton.Location = new System.Drawing.Point(0, 140);
            this.genelbakisButton.Name = "genelbakisButton";
            this.genelbakisButton.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.genelbakisButton.Size = new System.Drawing.Size(200, 70);
            this.genelbakisButton.TabIndex = 2;
            this.genelbakisButton.Text = "  Genel Bakış";
            this.genelbakisButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.genelbakisButton.UseVisualStyleBackColor = true;
            this.genelbakisButton.Click += new System.EventHandler(this.genelbakisButton_Click);
            // 
            // duyuruButton
            // 
            this.duyuruButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.duyuruButton.FlatAppearance.BorderSize = 0;
            this.duyuruButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.duyuruButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.duyuruButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.duyuruButton.Image = ((System.Drawing.Image)(resources.GetObject("duyuruButton.Image")));
            this.duyuruButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.duyuruButton.Location = new System.Drawing.Point(0, 70);
            this.duyuruButton.Name = "duyuruButton";
            this.duyuruButton.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.duyuruButton.Size = new System.Drawing.Size(200, 70);
            this.duyuruButton.TabIndex = 1;
            this.duyuruButton.Text = "  Duyurular";
            this.duyuruButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.duyuruButton.UseVisualStyleBackColor = true;
            this.duyuruButton.Click += new System.EventHandler(this.duyuruButton_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.logoPanel.Controls.Add(this.button);
            this.logoPanel.Controls.Add(this.adLabel);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(200, 70);
            this.logoPanel.TabIndex = 0;
            // 
            // button
            // 
            this.button.FlatAppearance.BorderSize = 0;
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Image = global::WindowsFormsAppLab1.Properties.Resources.iconfinder_Accept_132347;
            this.button.Location = new System.Drawing.Point(78, 12);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(36, 23);
            this.button.TabIndex = 1;
            this.button.UseVisualStyleBackColor = true;
            // 
            // adLabel
            // 
            this.adLabel.AutoSize = true;
            this.adLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.adLabel.Location = new System.Drawing.Point(64, 38);
            this.adLabel.Name = "adLabel";
            this.adLabel.Size = new System.Drawing.Size(62, 17);
            this.adLabel.TabIndex = 0;
            this.adLabel.Text = "deneme";
            this.adLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homePanel
            // 
            this.homePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.homePanel.Controls.Add(this.appclosebutton);
            this.homePanel.Controls.Add(this.homeLabel);
            this.homePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.homePanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.homePanel.Location = new System.Drawing.Point(200, 0);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(596, 70);
            this.homePanel.TabIndex = 2;
            // 
            // appclosebutton
            // 
            this.appclosebutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.appclosebutton.FlatAppearance.BorderSize = 0;
            this.appclosebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appclosebutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.appclosebutton.ForeColor = System.Drawing.Color.Gainsboro;
            this.appclosebutton.Location = new System.Drawing.Point(560, 0);
            this.appclosebutton.Name = "appclosebutton";
            this.appclosebutton.Size = new System.Drawing.Size(36, 28);
            this.appclosebutton.TabIndex = 8;
            this.appclosebutton.Text = "O";
            this.appclosebutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.appclosebutton.UseVisualStyleBackColor = true;
            this.appclosebutton.Click += new System.EventHandler(this.appclosebutton_Click);
            // 
            // homeLabel
            // 
            this.homeLabel.AutoSize = true;
            this.homeLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.homeLabel.Location = new System.Drawing.Point(255, 28);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(74, 25);
            this.homeLabel.TabIndex = 0;
            this.homeLabel.Text = "HOME";
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Controls.Add(this.pictureBox1);
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(200, 70);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(596, 424);
            this.panelDesktopPane.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsAppLab1.Properties.Resources._158_1581729_transparent_gender_png_human_resource_management_png_png;
            this.pictureBox1.Location = new System.Drawing.Point(0, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(593, 352);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.CancelButton = this.cikisButton;
            this.ClientSize = new System.Drawing.Size(796, 494);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "ManagementForm";
            this.Text = "Apartment Management";
            this.menuPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            this.panelDesktopPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button cikisButton;
        private System.Windows.Forms.Button hesapButton;
        private System.Windows.Forms.Button giderlerButton;
        private System.Windows.Forms.Button aidatButton;
        private System.Windows.Forms.Button genelbakisButton;
        private System.Windows.Forms.Button duyuruButton;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Label homeLabel;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Button appclosebutton;
        private System.Windows.Forms.Button button;
        public System.Windows.Forms.Label adLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

