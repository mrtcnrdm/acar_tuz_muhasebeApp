namespace acartuz
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.textbox_kullaniciSifre = new System.Windows.Forms.TextBox();
            this.label_zorunluKullaniciAdi = new System.Windows.Forms.Label();
            this.buton_girisyap = new custombutton.mycustombutton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 190);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.19932F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.80067F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1134, 196);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(669, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(669, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre:";
            // 
            // textbox_kullaniciAdi
            // 
            this.textbox_kullaniciAdi.Location = new System.Drawing.Point(831, 371);
            this.textbox_kullaniciAdi.Name = "textbox_kullaniciAdi";
            this.textbox_kullaniciAdi.Size = new System.Drawing.Size(188, 20);
            this.textbox_kullaniciAdi.TabIndex = 4;
            // 
            // textbox_kullaniciSifre
            // 
            this.textbox_kullaniciSifre.Location = new System.Drawing.Point(831, 418);
            this.textbox_kullaniciSifre.Name = "textbox_kullaniciSifre";
            this.textbox_kullaniciSifre.PasswordChar = '*';
            this.textbox_kullaniciSifre.Size = new System.Drawing.Size(188, 20);
            this.textbox_kullaniciSifre.TabIndex = 5;
            // 
            // label_zorunluKullaniciAdi
            // 
            this.label_zorunluKullaniciAdi.AutoSize = true;
            this.label_zorunluKullaniciAdi.BackColor = System.Drawing.Color.Transparent;
            this.label_zorunluKullaniciAdi.ForeColor = System.Drawing.Color.Red;
            this.label_zorunluKullaniciAdi.Location = new System.Drawing.Point(831, 352);
            this.label_zorunluKullaniciAdi.Name = "label_zorunluKullaniciAdi";
            this.label_zorunluKullaniciAdi.Size = new System.Drawing.Size(155, 13);
            this.label_zorunluKullaniciAdi.TabIndex = 7;
            this.label_zorunluKullaniciAdi.Text = "* Kullanıcı Adı veya Şifre Yanlış!";
            this.label_zorunluKullaniciAdi.Visible = false;
            // 
            // buton_girisyap
            // 
            this.buton_girisyap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.buton_girisyap.FlatAppearance.BorderSize = 2;
            this.buton_girisyap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buton_girisyap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.buton_girisyap.ForeColor = System.Drawing.Color.White;
            this.buton_girisyap.Location = new System.Drawing.Point(868, 465);
            this.buton_girisyap.Name = "buton_girisyap";
            this.buton_girisyap.Size = new System.Drawing.Size(118, 44);
            this.buton_girisyap.TabIndex = 8;
            this.buton_girisyap.Text = "Giriş Yap";
            this.buton_girisyap.UseVisualStyleBackColor = false;
            this.buton_girisyap.Click += new System.EventHandler(this.buton_girisyap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1134, 611);
            this.Controls.Add(this.buton_girisyap);
            this.Controls.Add(this.label_zorunluKullaniciAdi);
            this.Controls.Add(this.textbox_kullaniciSifre);
            this.Controls.Add(this.textbox_kullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acar Tuz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_kullaniciAdi;
        private System.Windows.Forms.TextBox textbox_kullaniciSifre;
        private System.Windows.Forms.Label label_zorunluKullaniciAdi;
        private custombutton.mycustombutton buton_girisyap;
    }
}

