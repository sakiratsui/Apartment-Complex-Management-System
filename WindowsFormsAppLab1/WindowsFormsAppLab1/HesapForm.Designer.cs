
namespace WindowsFormsAppLab1
{
    partial class HesapForm
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
            this.hesapadlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.xmltextBox = new System.Windows.Forms.TextBox();
            this.xmlbutton = new System.Windows.Forms.Button();
            this.clockUserControl1 = new WindowsFormsAppLab1.ClockUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // hesapadlabel
            // 
            this.hesapadlabel.AutoSize = true;
            this.hesapadlabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesapadlabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.hesapadlabel.Location = new System.Drawing.Point(260, 131);
            this.hesapadlabel.Name = "hesapadlabel";
            this.hesapadlabel.Size = new System.Drawing.Size(75, 18);
            this.hesapadlabel.TabIndex = 0;
            this.hesapadlabel.Text = " deneme";
            this.hesapadlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(179, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsAppLab1.Properties.Resources.profile_1_icon;
            this.pictureBox1.Location = new System.Drawing.Point(233, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(158, 108);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // xmltextBox
            // 
            this.xmltextBox.Location = new System.Drawing.Point(158, 161);
            this.xmltextBox.Multiline = true;
            this.xmltextBox.Name = "xmltextBox";
            this.xmltextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.xmltextBox.Size = new System.Drawing.Size(200, 123);
            this.xmltextBox.TabIndex = 4;
            // 
            // xmlbutton
            // 
            this.xmlbutton.BackColor = System.Drawing.Color.Indigo;
            this.xmlbutton.FlatAppearance.BorderSize = 0;
            this.xmlbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xmlbutton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.xmlbutton.ForeColor = System.Drawing.Color.Gainsboro;
            this.xmlbutton.Location = new System.Drawing.Point(158, 291);
            this.xmlbutton.Name = "xmlbutton";
            this.xmlbutton.Size = new System.Drawing.Size(200, 23);
            this.xmlbutton.TabIndex = 5;
            this.xmlbutton.Text = "Aidat Geçmişini Gör";
            this.xmlbutton.UseVisualStyleBackColor = false;
            this.xmlbutton.Click += new System.EventHandler(this.xmlbutton_Click);
            // 
            // clockUserControl1
            // 
            this.clockUserControl1.Location = new System.Drawing.Point(120, 31);
            this.clockUserControl1.Name = "clockUserControl1";
            this.clockUserControl1.Size = new System.Drawing.Size(107, 71);
            this.clockUserControl1.TabIndex = 6;
            // 
            // HesapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(475, 348);
            this.Controls.Add(this.clockUserControl1);
            this.Controls.Add(this.xmlbutton);
            this.Controls.Add(this.xmltextBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hesapadlabel);
            this.Name = "HesapForm";
            this.Text = "Hesabım";
            this.Load += new System.EventHandler(this.HesapForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hesapadlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox xmltextBox;
        private System.Windows.Forms.Button xmlbutton;
        private ClockUserControl clockUserControl1;
    }
}