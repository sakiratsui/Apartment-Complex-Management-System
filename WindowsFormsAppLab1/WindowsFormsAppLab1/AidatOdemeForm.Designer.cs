
namespace WindowsFormsAppLab1
{
    partial class AidatOdemeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AidatOdemeForm));
            this.kartnoLabel = new System.Windows.Forms.Label();
            this.kartismiLabel = new System.Windows.Forms.Label();
            this.kartsktLabel = new System.Windows.Forms.Label();
            this.slashLabel = new System.Windows.Forms.Label();
            this.cvvLabel = new System.Windows.Forms.Label();
            this.kartnoTextbox = new System.Windows.Forms.TextBox();
            this.kartisimTextbox = new System.Windows.Forms.TextBox();
            this.cvvTextbox = new System.Windows.Forms.TextBox();
            this.kartaycomboBox = new System.Windows.Forms.ComboBox();
            this.yilcomboBox = new System.Windows.Forms.ComboBox();
            this.kartlaodeButton = new System.Windows.Forms.Button();
            this.blokLabel = new System.Windows.Forms.Label();
            this.dairenoLabel = new System.Windows.Forms.Label();
            this.blokTextbox = new System.Windows.Forms.TextBox();
            this.daireTextbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kartnoLabel
            // 
            this.kartnoLabel.AutoSize = true;
            this.kartnoLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kartnoLabel.Location = new System.Drawing.Point(27, 74);
            this.kartnoLabel.Name = "kartnoLabel";
            this.kartnoLabel.Size = new System.Drawing.Size(122, 20);
            this.kartnoLabel.TabIndex = 0;
            this.kartnoLabel.Text = "Kart Numaranız:";
            // 
            // kartismiLabel
            // 
            this.kartismiLabel.AutoSize = true;
            this.kartismiLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kartismiLabel.Location = new System.Drawing.Point(27, 105);
            this.kartismiLabel.Name = "kartismiLabel";
            this.kartismiLabel.Size = new System.Drawing.Size(164, 20);
            this.kartismiLabel.TabIndex = 1;
            this.kartismiLabel.Text = "Kartın Üzerindeki İsim:";
            // 
            // kartsktLabel
            // 
            this.kartsktLabel.AutoSize = true;
            this.kartsktLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kartsktLabel.Location = new System.Drawing.Point(27, 138);
            this.kartsktLabel.Name = "kartsktLabel";
            this.kartsktLabel.Size = new System.Drawing.Size(148, 20);
            this.kartsktLabel.TabIndex = 2;
            this.kartsktLabel.Text = "Son Kullanma Tarihi:";
            // 
            // slashLabel
            // 
            this.slashLabel.AutoSize = true;
            this.slashLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.slashLabel.Location = new System.Drawing.Point(253, 138);
            this.slashLabel.Name = "slashLabel";
            this.slashLabel.Size = new System.Drawing.Size(16, 20);
            this.slashLabel.TabIndex = 3;
            this.slashLabel.Text = "/";
            // 
            // cvvLabel
            // 
            this.cvvLabel.AutoSize = true;
            this.cvvLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cvvLabel.Location = new System.Drawing.Point(27, 173);
            this.cvvLabel.Name = "cvvLabel";
            this.cvvLabel.Size = new System.Drawing.Size(176, 20);
            this.cvvLabel.TabIndex = 4;
            this.cvvLabel.Text = "Güvenlik Kodu (CVV2):";
            // 
            // kartnoTextbox
            // 
            this.kartnoTextbox.Location = new System.Drawing.Point(155, 76);
            this.kartnoTextbox.Name = "kartnoTextbox";
            this.kartnoTextbox.Size = new System.Drawing.Size(169, 20);
            this.kartnoTextbox.TabIndex = 5;
            // 
            // kartisimTextbox
            // 
            this.kartisimTextbox.Location = new System.Drawing.Point(197, 107);
            this.kartisimTextbox.Name = "kartisimTextbox";
            this.kartisimTextbox.Size = new System.Drawing.Size(127, 20);
            this.kartisimTextbox.TabIndex = 6;
            // 
            // cvvTextbox
            // 
            this.cvvTextbox.Location = new System.Drawing.Point(209, 173);
            this.cvvTextbox.MaxLength = 3;
            this.cvvTextbox.Name = "cvvTextbox";
            this.cvvTextbox.Size = new System.Drawing.Size(60, 20);
            this.cvvTextbox.TabIndex = 7;
            // 
            // kartaycomboBox
            // 
            this.kartaycomboBox.FormattingEnabled = true;
            this.kartaycomboBox.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11"});
            this.kartaycomboBox.Location = new System.Drawing.Point(197, 140);
            this.kartaycomboBox.Name = "kartaycomboBox";
            this.kartaycomboBox.Size = new System.Drawing.Size(50, 21);
            this.kartaycomboBox.TabIndex = 8;
            // 
            // yilcomboBox
            // 
            this.yilcomboBox.FormattingEnabled = true;
            this.yilcomboBox.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.yilcomboBox.Location = new System.Drawing.Point(274, 140);
            this.yilcomboBox.Name = "yilcomboBox";
            this.yilcomboBox.Size = new System.Drawing.Size(50, 21);
            this.yilcomboBox.TabIndex = 9;
            // 
            // kartlaodeButton
            // 
            this.kartlaodeButton.FlatAppearance.BorderSize = 0;
            this.kartlaodeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.kartlaodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kartlaodeButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kartlaodeButton.Location = new System.Drawing.Point(71, 225);
            this.kartlaodeButton.Name = "kartlaodeButton";
            this.kartlaodeButton.Size = new System.Drawing.Size(253, 31);
            this.kartlaodeButton.TabIndex = 11;
            this.kartlaodeButton.Text = "Şimdi Öde (Tutar: 240₺)";
            this.kartlaodeButton.UseVisualStyleBackColor = true;
            this.kartlaodeButton.Click += new System.EventHandler(this.kartlaodeButton_Click);
            // 
            // blokLabel
            // 
            this.blokLabel.AutoSize = true;
            this.blokLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.blokLabel.Location = new System.Drawing.Point(27, 40);
            this.blokLabel.Name = "blokLabel";
            this.blokLabel.Size = new System.Drawing.Size(43, 20);
            this.blokLabel.TabIndex = 12;
            this.blokLabel.Text = "Blok:";
            // 
            // dairenoLabel
            // 
            this.dairenoLabel.AutoSize = true;
            this.dairenoLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dairenoLabel.Location = new System.Drawing.Point(151, 40);
            this.dairenoLabel.Name = "dairenoLabel";
            this.dairenoLabel.Size = new System.Drawing.Size(77, 20);
            this.dairenoLabel.TabIndex = 13;
            this.dairenoLabel.Text = "Daire No:";
            // 
            // blokTextbox
            // 
            this.blokTextbox.Location = new System.Drawing.Point(76, 42);
            this.blokTextbox.MaxLength = 3;
            this.blokTextbox.Name = "blokTextbox";
            this.blokTextbox.Size = new System.Drawing.Size(60, 20);
            this.blokTextbox.TabIndex = 14;
            // 
            // daireTextbox
            // 
            this.daireTextbox.Location = new System.Drawing.Point(234, 42);
            this.daireTextbox.MaxLength = 3;
            this.daireTextbox.Name = "daireTextbox";
            this.daireTextbox.Size = new System.Drawing.Size(60, 20);
            this.daireTextbox.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(335, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // AidatOdemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(430, 317);
            this.Controls.Add(this.daireTextbox);
            this.Controls.Add(this.blokTextbox);
            this.Controls.Add(this.dairenoLabel);
            this.Controls.Add(this.blokLabel);
            this.Controls.Add(this.kartlaodeButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.yilcomboBox);
            this.Controls.Add(this.kartaycomboBox);
            this.Controls.Add(this.cvvTextbox);
            this.Controls.Add(this.kartisimTextbox);
            this.Controls.Add(this.kartnoTextbox);
            this.Controls.Add(this.cvvLabel);
            this.Controls.Add(this.slashLabel);
            this.Controls.Add(this.kartsktLabel);
            this.Controls.Add(this.kartismiLabel);
            this.Controls.Add(this.kartnoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AidatOdemeForm";
            this.Text = "Aidat Ödeme";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kartnoLabel;
        private System.Windows.Forms.Label kartismiLabel;
        private System.Windows.Forms.Label kartsktLabel;
        private System.Windows.Forms.Label slashLabel;
        private System.Windows.Forms.Label cvvLabel;
        private System.Windows.Forms.TextBox kartnoTextbox;
        private System.Windows.Forms.TextBox kartisimTextbox;
        private System.Windows.Forms.TextBox cvvTextbox;
        private System.Windows.Forms.ComboBox kartaycomboBox;
        private System.Windows.Forms.ComboBox yilcomboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button kartlaodeButton;
        private System.Windows.Forms.Label blokLabel;
        private System.Windows.Forms.Label dairenoLabel;
        private System.Windows.Forms.TextBox blokTextbox;
        private System.Windows.Forms.TextBox daireTextbox;
    }
}