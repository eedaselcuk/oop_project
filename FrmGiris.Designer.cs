using System;

namespace nyp2
{
    partial class FrmGrs
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
            this.cbKullanici = new System.Windows.Forms.ComboBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGrs = new System.Windows.Forms.Button();
            this.btnCik = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbKullanici
            // 
            this.cbKullanici.FormattingEnabled = true;
            this.cbKullanici.Location = new System.Drawing.Point(75, 134);
            this.cbKullanici.Name = "cbKullanici";
            this.cbKullanici.Size = new System.Drawing.Size(162, 26);
            this.cbKullanici.TabIndex = 0;
            this.cbKullanici.SelectedIndexChanged += new System.EventHandler(this.cbKullanici_SelectedIndexChanged);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(75, 211);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(162, 25);
            this.txtSifre.TabIndex = 1;
            this.txtSifre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnGrs
            // 
            this.btnGrs.BackColor = System.Drawing.Color.Red;
            this.btnGrs.ForeColor = System.Drawing.Color.White;
            this.btnGrs.Location = new System.Drawing.Point(75, 254);
            this.btnGrs.Name = "btnGrs";
            this.btnGrs.Size = new System.Drawing.Size(62, 31);
            this.btnGrs.TabIndex = 2;
            this.btnGrs.Text = "GİRİŞ";
            this.btnGrs.UseVisualStyleBackColor = false;
            this.btnGrs.Click += new System.EventHandler(this.btnGrs_Click);
            // 
            // btnCik
            // 
            this.btnCik.BackColor = System.Drawing.Color.Red;
            this.btnCik.ForeColor = System.Drawing.Color.White;
            this.btnCik.Location = new System.Drawing.Point(788, -2);
            this.btnCik.Name = "btnCik";
            this.btnCik.Size = new System.Drawing.Size(23, 25);
            this.btnCik.TabIndex = 3;
            this.btnCik.Text = "X";
            this.btnCik.UseVisualStyleBackColor = false;
            this.btnCik.Click += new System.EventHandler(this.btnCik_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(72, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(72, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre:";
            // 
            // FrmGrs
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::nyp2.Properties.Resources.back2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(810, 466);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCik);
            this.Controls.Add(this.btnGrs);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.cbKullanici);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGrs";
            this.Load += new System.EventHandler(this.FrmGrs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void cbKullanici_SelectedIndexChanged(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
            
        }

        #endregion

        private System.Windows.Forms.ComboBox cbKullanici;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGrs;
        private System.Windows.Forms.Button btnCik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

