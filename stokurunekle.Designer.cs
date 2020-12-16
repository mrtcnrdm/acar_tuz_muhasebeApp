namespace acartuz
{
    partial class stokurunekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stokurunekle));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_urunadi = new System.Windows.Forms.TextBox();
            this.textbox_urunkalite = new System.Windows.Forms.TextBox();
            this.textbox_urunadet = new System.Windows.Forms.TextBox();
            this.label_zorunlu1 = new System.Windows.Forms.Label();
            this.label_zorunlu2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textbox_urununfiyati = new System.Windows.Forms.TextBox();
            this.textbox_urununkdvsi = new System.Windows.Forms.TextBox();
            this.label_zorunlu3 = new System.Windows.Forms.Label();
            this.label_zorunlu4 = new System.Windows.Forms.Label();
            this.buton_kaydet = new custombutton.mycustombutton();
            this.buton_temizle = new custombutton.mycustombutton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(25, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(400, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(400, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Kalitesi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(400, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ürün Adet:";
            // 
            // textbox_urunadi
            // 
            this.textbox_urunadi.Location = new System.Drawing.Point(536, 187);
            this.textbox_urunadi.Name = "textbox_urunadi";
            this.textbox_urunadi.Size = new System.Drawing.Size(139, 20);
            this.textbox_urunadi.TabIndex = 5;
            // 
            // textbox_urunkalite
            // 
            this.textbox_urunkalite.Location = new System.Drawing.Point(536, 230);
            this.textbox_urunkalite.Name = "textbox_urunkalite";
            this.textbox_urunkalite.Size = new System.Drawing.Size(139, 20);
            this.textbox_urunkalite.TabIndex = 6;
            // 
            // textbox_urunadet
            // 
            this.textbox_urunadet.Location = new System.Drawing.Point(536, 274);
            this.textbox_urunadet.Name = "textbox_urunadet";
            this.textbox_urunadet.Size = new System.Drawing.Size(139, 20);
            this.textbox_urunadet.TabIndex = 7;
            this.textbox_urunadet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_urunadet_KeyPress);
            // 
            // label_zorunlu1
            // 
            this.label_zorunlu1.AutoSize = true;
            this.label_zorunlu1.ForeColor = System.Drawing.Color.Red;
            this.label_zorunlu1.Location = new System.Drawing.Point(533, 171);
            this.label_zorunlu1.Name = "label_zorunlu1";
            this.label_zorunlu1.Size = new System.Drawing.Size(71, 13);
            this.label_zorunlu1.TabIndex = 9;
            this.label_zorunlu1.Text = "*Zorunlu Alan";
            // 
            // label_zorunlu2
            // 
            this.label_zorunlu2.AutoSize = true;
            this.label_zorunlu2.ForeColor = System.Drawing.Color.Red;
            this.label_zorunlu2.Location = new System.Drawing.Point(533, 258);
            this.label_zorunlu2.Name = "label_zorunlu2";
            this.label_zorunlu2.Size = new System.Drawing.Size(71, 13);
            this.label_zorunlu2.TabIndex = 10;
            this.label_zorunlu2.Text = "*Zorunlu Alan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(400, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ürünün Fiyatı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(400, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ürünün Kdv\'si:";
            // 
            // textbox_urununfiyati
            // 
            this.textbox_urununfiyati.Location = new System.Drawing.Point(536, 313);
            this.textbox_urununfiyati.Name = "textbox_urununfiyati";
            this.textbox_urununfiyati.Size = new System.Drawing.Size(139, 20);
            this.textbox_urununfiyati.TabIndex = 15;
            this.textbox_urununfiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_urununfiyati_KeyPress);
            // 
            // textbox_urununkdvsi
            // 
            this.textbox_urununkdvsi.Location = new System.Drawing.Point(536, 353);
            this.textbox_urununkdvsi.Name = "textbox_urununkdvsi";
            this.textbox_urununkdvsi.Size = new System.Drawing.Size(139, 20);
            this.textbox_urununkdvsi.TabIndex = 16;
            this.textbox_urununkdvsi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_urununkdvsi_KeyPress);
            // 
            // label_zorunlu3
            // 
            this.label_zorunlu3.AutoSize = true;
            this.label_zorunlu3.ForeColor = System.Drawing.Color.Red;
            this.label_zorunlu3.Location = new System.Drawing.Point(537, 297);
            this.label_zorunlu3.Name = "label_zorunlu3";
            this.label_zorunlu3.Size = new System.Drawing.Size(71, 13);
            this.label_zorunlu3.TabIndex = 17;
            this.label_zorunlu3.Text = "*Zorunlu Alan";
            // 
            // label_zorunlu4
            // 
            this.label_zorunlu4.AutoSize = true;
            this.label_zorunlu4.ForeColor = System.Drawing.Color.Red;
            this.label_zorunlu4.Location = new System.Drawing.Point(537, 337);
            this.label_zorunlu4.Name = "label_zorunlu4";
            this.label_zorunlu4.Size = new System.Drawing.Size(71, 13);
            this.label_zorunlu4.TabIndex = 18;
            this.label_zorunlu4.Text = "*Zorunlu Alan";
            // 
            // buton_kaydet
            // 
            this.buton_kaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.buton_kaydet.FlatAppearance.BorderSize = 2;
            this.buton_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buton_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.buton_kaydet.ForeColor = System.Drawing.Color.White;
            this.buton_kaydet.Location = new System.Drawing.Point(457, 395);
            this.buton_kaydet.Name = "buton_kaydet";
            this.buton_kaydet.Size = new System.Drawing.Size(88, 31);
            this.buton_kaydet.TabIndex = 21;
            this.buton_kaydet.Text = "Kaydet";
            this.buton_kaydet.UseVisualStyleBackColor = false;
            this.buton_kaydet.Click += new System.EventHandler(this.buton_kaydet_Click_1);
            // 
            // buton_temizle
            // 
            this.buton_temizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.buton_temizle.FlatAppearance.BorderSize = 2;
            this.buton_temizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buton_temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.buton_temizle.ForeColor = System.Drawing.Color.White;
            this.buton_temizle.Location = new System.Drawing.Point(551, 395);
            this.buton_temizle.Name = "buton_temizle";
            this.buton_temizle.Size = new System.Drawing.Size(88, 31);
            this.buton_temizle.TabIndex = 22;
            this.buton_temizle.Text = "Temizle";
            this.buton_temizle.UseVisualStyleBackColor = false;
            this.buton_temizle.Click += new System.EventHandler(this.buton_temizle_Click);
            // 
            // stokurunekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1134, 611);
            this.Controls.Add(this.buton_temizle);
            this.Controls.Add(this.buton_kaydet);
            this.Controls.Add(this.label_zorunlu4);
            this.Controls.Add(this.label_zorunlu3);
            this.Controls.Add(this.textbox_urununkdvsi);
            this.Controls.Add(this.textbox_urununfiyati);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_zorunlu2);
            this.Controls.Add(this.label_zorunlu1);
            this.Controls.Add(this.textbox_urunadet);
            this.Controls.Add(this.textbox_urunkalite);
            this.Controls.Add(this.textbox_urunadi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "stokurunekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Ürün Ekleme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.stokurunekle_FormClosing_1);
            this.Load += new System.EventHandler(this.stokurunekle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbox_urunadi;
        private System.Windows.Forms.TextBox textbox_urunkalite;
        private System.Windows.Forms.TextBox textbox_urunadet;
        private System.Windows.Forms.Label label_zorunlu1;
        private System.Windows.Forms.Label label_zorunlu2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textbox_urununfiyati;
        private System.Windows.Forms.TextBox textbox_urununkdvsi;
        private System.Windows.Forms.Label label_zorunlu3;
        private System.Windows.Forms.Label label_zorunlu4;
        private custombutton.mycustombutton buton_kaydet;
        private custombutton.mycustombutton buton_temizle;
    }
}