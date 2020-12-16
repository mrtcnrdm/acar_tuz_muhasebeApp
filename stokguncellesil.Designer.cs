namespace acartuz
{
    partial class stokguncellesil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stokguncellesil));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_urunadi = new System.Windows.Forms.TextBox();
            this.textbox_urunkalitesi = new System.Windows.Forms.TextBox();
            this.textbox_urunadet = new System.Windows.Forms.TextBox();
            this.label_zorunlu1 = new System.Windows.Forms.Label();
            this.label_zorunlu2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textbox_urununfiyati = new System.Windows.Forms.TextBox();
            this.textbox_urununkdvsi = new System.Windows.Forms.TextBox();
            this.label_zorunlu3 = new System.Windows.Forms.Label();
            this.label_zorunlu4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buton_urunuguncelle = new custombutton.mycustombutton();
            this.buton_urunusil = new custombutton.mycustombutton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
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
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(107, -3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(688, 611);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ürün Kalitesi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(42, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ürün Adet:";
            // 
            // textbox_urunadi
            // 
            this.textbox_urunadi.Location = new System.Drawing.Point(176, 187);
            this.textbox_urunadi.Name = "textbox_urunadi";
            this.textbox_urunadi.Size = new System.Drawing.Size(100, 20);
            this.textbox_urunadi.TabIndex = 6;
            // 
            // textbox_urunkalitesi
            // 
            this.textbox_urunkalitesi.Location = new System.Drawing.Point(176, 228);
            this.textbox_urunkalitesi.Name = "textbox_urunkalitesi";
            this.textbox_urunkalitesi.Size = new System.Drawing.Size(100, 20);
            this.textbox_urunkalitesi.TabIndex = 7;
            // 
            // textbox_urunadet
            // 
            this.textbox_urunadet.Location = new System.Drawing.Point(176, 268);
            this.textbox_urunadet.Name = "textbox_urunadet";
            this.textbox_urunadet.Size = new System.Drawing.Size(100, 20);
            this.textbox_urunadet.TabIndex = 8;
            this.textbox_urunadet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_urunadet_KeyPress);
            // 
            // label_zorunlu1
            // 
            this.label_zorunlu1.AutoSize = true;
            this.label_zorunlu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_zorunlu1.ForeColor = System.Drawing.Color.Red;
            this.label_zorunlu1.Location = new System.Drawing.Point(176, 168);
            this.label_zorunlu1.Name = "label_zorunlu1";
            this.label_zorunlu1.Size = new System.Drawing.Size(87, 16);
            this.label_zorunlu1.TabIndex = 12;
            this.label_zorunlu1.Text = "*Zorunlu Alan";
            // 
            // label_zorunlu2
            // 
            this.label_zorunlu2.AutoSize = true;
            this.label_zorunlu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_zorunlu2.ForeColor = System.Drawing.Color.Red;
            this.label_zorunlu2.Location = new System.Drawing.Point(176, 255);
            this.label_zorunlu2.Name = "label_zorunlu2";
            this.label_zorunlu2.Size = new System.Drawing.Size(87, 16);
            this.label_zorunlu2.TabIndex = 13;
            this.label_zorunlu2.Text = "*Zorunlu Alan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(42, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ürünün Fiyatı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(42, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ürünün Kdv\'si:";
            // 
            // textbox_urununfiyati
            // 
            this.textbox_urununfiyati.Location = new System.Drawing.Point(176, 318);
            this.textbox_urununfiyati.Name = "textbox_urununfiyati";
            this.textbox_urununfiyati.Size = new System.Drawing.Size(100, 20);
            this.textbox_urununfiyati.TabIndex = 16;
            this.textbox_urununfiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_urununfiyati_KeyPress);
            // 
            // textbox_urununkdvsi
            // 
            this.textbox_urununkdvsi.Location = new System.Drawing.Point(176, 359);
            this.textbox_urununkdvsi.Name = "textbox_urununkdvsi";
            this.textbox_urununkdvsi.Size = new System.Drawing.Size(100, 20);
            this.textbox_urununkdvsi.TabIndex = 17;
            this.textbox_urununkdvsi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_urununkdvsi_KeyPress);
            // 
            // label_zorunlu3
            // 
            this.label_zorunlu3.AutoSize = true;
            this.label_zorunlu3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_zorunlu3.ForeColor = System.Drawing.Color.Red;
            this.label_zorunlu3.Location = new System.Drawing.Point(176, 302);
            this.label_zorunlu3.Name = "label_zorunlu3";
            this.label_zorunlu3.Size = new System.Drawing.Size(87, 16);
            this.label_zorunlu3.TabIndex = 20;
            this.label_zorunlu3.Text = "*Zorunlu Alan";
            // 
            // label_zorunlu4
            // 
            this.label_zorunlu4.AutoSize = true;
            this.label_zorunlu4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_zorunlu4.ForeColor = System.Drawing.Color.Red;
            this.label_zorunlu4.Location = new System.Drawing.Point(176, 343);
            this.label_zorunlu4.Name = "label_zorunlu4";
            this.label_zorunlu4.Size = new System.Drawing.Size(87, 16);
            this.label_zorunlu4.TabIndex = 21;
            this.label_zorunlu4.Text = "*Zorunlu Alan";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(339, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 611);
            this.panel1.TabIndex = 22;
            // 
            // buton_urunuguncelle
            // 
            this.buton_urunuguncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.buton_urunuguncelle.FlatAppearance.BorderSize = 2;
            this.buton_urunuguncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buton_urunuguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.buton_urunuguncelle.ForeColor = System.Drawing.Color.White;
            this.buton_urunuguncelle.Location = new System.Drawing.Point(64, 395);
            this.buton_urunuguncelle.Name = "buton_urunuguncelle";
            this.buton_urunuguncelle.Size = new System.Drawing.Size(104, 52);
            this.buton_urunuguncelle.TabIndex = 23;
            this.buton_urunuguncelle.Text = "Ürünü Güncelle";
            this.buton_urunuguncelle.UseVisualStyleBackColor = false;
            this.buton_urunuguncelle.Click += new System.EventHandler(this.buton_guncelle_Click);
            // 
            // buton_urunusil
            // 
            this.buton_urunusil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.buton_urunusil.FlatAppearance.BorderSize = 2;
            this.buton_urunusil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buton_urunusil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.buton_urunusil.ForeColor = System.Drawing.Color.White;
            this.buton_urunusil.Location = new System.Drawing.Point(176, 394);
            this.buton_urunusil.Name = "buton_urunusil";
            this.buton_urunusil.Size = new System.Drawing.Size(104, 52);
            this.buton_urunusil.TabIndex = 24;
            this.buton_urunusil.Text = "Ürünü Sil";
            this.buton_urunusil.UseVisualStyleBackColor = false;
            this.buton_urunusil.Click += new System.EventHandler(this.buton_temizle_Click_1);
            // 
            // stokguncellesil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1134, 611);
            this.Controls.Add(this.buton_urunusil);
            this.Controls.Add(this.buton_urunuguncelle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_zorunlu4);
            this.Controls.Add(this.label_zorunlu3);
            this.Controls.Add(this.textbox_urununkdvsi);
            this.Controls.Add(this.textbox_urununfiyati);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_zorunlu2);
            this.Controls.Add(this.label_zorunlu1);
            this.Controls.Add(this.textbox_urunadet);
            this.Controls.Add(this.textbox_urunkalitesi);
            this.Controls.Add(this.textbox_urunadi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "stokguncellesil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Güncelle-Sil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.stokguncellesil_FormClosing_1);
            this.Load += new System.EventHandler(this.stokguncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbox_urunadi;
        private System.Windows.Forms.TextBox textbox_urunkalitesi;
        private System.Windows.Forms.TextBox textbox_urunadet;
        private System.Windows.Forms.Label label_zorunlu1;
        private System.Windows.Forms.Label label_zorunlu2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textbox_urununfiyati;
        private System.Windows.Forms.TextBox textbox_urununkdvsi;
        private System.Windows.Forms.Label label_zorunlu3;
        private System.Windows.Forms.Label label_zorunlu4;
        private System.Windows.Forms.Panel panel1;
        private custombutton.mycustombutton buton_urunuguncelle;
        private custombutton.mycustombutton buton_urunusil;
    }
}